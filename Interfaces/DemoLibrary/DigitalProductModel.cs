using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class DigitalProductModel : IProductModel
    {
        public string Title { get; set; }

        public bool HasBeenShipped { get; private set; }

        public int TotalDownloadsLeft { get; private set; } = 5;

        public void ShipItem(CustomerModel customer)
        {
            if (!HasBeenShipped)
            {
                Console.WriteLine($"Simulating emailing {Title} to {customer.EmailAddress}.");
                TotalDownloadsLeft--;
                if (TotalDownloadsLeft < 1)
                {
                    HasBeenShipped = true;
                    TotalDownloadsLeft = 0;
                }
            }

        }
    }
}
