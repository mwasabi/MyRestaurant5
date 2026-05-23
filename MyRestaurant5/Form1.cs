using MyRestaurant5.Models;
using MyRestaurant5.Services;
using System.Threading;
using System.Linq;

namespace MyRestaurant5
{
    public partial class Form1 : Form
    {
        private TableRequests tableRequests =
    new TableRequests();

        private CookService cookService =
            new CookService();

        private ServerService serverService =
            new ServerService();
        private SemaphoreSlim cooksSemaphore =
    new SemaphoreSlim(2);

        private object serverLock = new object();
        public Form1()
        {
            InitializeComponent();

        }
        private async Task ProcessCustomerAsync(
    CustomerRequest request)
        {
            await cooksSemaphore.WaitAsync();

            try
            {
                int cookId =
                    Thread.CurrentThread.ManagedThreadId;

                txtResults.AppendText(
                    $"Cook started preparing for " +
                    $"{request.CustomerName}" +
                    Environment.NewLine);

                string prepared =
                    await cookService.PrepareFoodAsync(
                        request,
                        cookId);

                txtResults.AppendText(
                    prepared +
                    Environment.NewLine);

                lock (serverLock)
                {
                    txtResults.AppendText(
                        $"Server serving " +
                        $"{request.CustomerName}" +
                        Environment.NewLine);
                }

                string served =
                    await serverService
                    .ServeFoodAsync(request);

                txtResults.AppendText(
                    served +
                    Environment.NewLine);

                txtResults.AppendText(
                    $"{request.CustomerName} ordered " +
                    $"{request.Tea} tea, " +
                    $"{request.Egg} egg, " +
                    $"{request.Chicken} chicken" +
                    Environment.NewLine +
                    Environment.NewLine);
            }
            finally
            {
                cooksSemaphore.Release();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReceiveRequest_Click(object sender, EventArgs e)
        {
            CustomerRequest request = new CustomerRequest
            {
                CustomerName = txtCustomerName.Text,
                Tea = (int)numTea.Value,
                Egg = (int)numEgg.Value,
                Chicken = (int)numChicken.Value
            };

            tableRequests.Add(request);

            lstRequests.Items.Add(
                $"{request.CustomerName} added");
        }

        private async void btnSendToCook_Click(
     object sender,
     EventArgs e)
        {
            List<Task> tasks = new List<Task>();

            var sortedRequests =
                tableRequests
                .GetAll()
                .OrderBy(x => x.CustomerName)
                .ToList();

            foreach (var request in sortedRequests)
            {
                Task task = ProcessCustomerAsync(request);

                tasks.Add(task);
            }

            await Task.WhenAll(tasks);

            txtResults.AppendText(
                "All customers served!" +
                Environment.NewLine);
        }
    }
}
