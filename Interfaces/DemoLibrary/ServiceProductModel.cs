using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    class ServiceProductModel : IProductModel
    {
        public string Title { get; set; }
        public bool HasBeenShipped { get; private set; }

        public void ShipItem(CustomerModel customer)
        {
            if (!HasBeenShipped)
            {
                Console.WriteLine($"The Service {Title} has been told to visit {customer.FirstName} {customer.LastName} in {customer.City}");
                HasBeenShipped = true;
            }
        }
    }
}
