
using System.Collections;

namespace MyRestaurant5.Models
{
    public class TableRequests : IEnumerable<CustomerRequest>
    {
        private List<CustomerRequest> requests =
            new List<CustomerRequest>();

        public void Add(CustomerRequest request)
        {
            requests.Add(request);
        }

        public void Clear()
        {
            requests.Clear();
        }

        public IEnumerator<CustomerRequest> GetEnumerator()
        {
            return requests.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public List<CustomerRequest> GetAll()
        {
            return requests;
        }
    }
}
