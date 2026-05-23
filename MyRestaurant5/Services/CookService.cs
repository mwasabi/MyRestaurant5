using MyRestaurant5.Models;

namespace MyRestaurant5.Services
{
    public class CookService
    {
        public async Task<string> PrepareFoodAsync(
            CustomerRequest request,
            int cookId)
        {
            await Task.Delay(3000);

            return $"Cook #{cookId} prepared food for {request.CustomerName}";
        }
    }
}