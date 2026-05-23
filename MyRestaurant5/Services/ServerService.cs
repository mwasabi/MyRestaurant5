using MyRestaurant5.Models;

namespace MyRestaurant5.Services
{
    public class ServerService
    {
        public async Task<string> ServeFoodAsync(
            CustomerRequest request)
        {
            await Task.Delay(2000);

            return $"Server served {request.CustomerName}";
        }
    }
}