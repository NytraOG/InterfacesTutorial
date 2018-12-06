using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using  DemoLibrary;

namespace InterfaceTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PhysicalProductModel> shoppingCart = AddSampleData();
            CustomerModel customer = GetCustomer();

            foreach (var item in shoppingCart)
            {
                item.ShipItem(customer);
            }
        }

        private static CustomerModel GetCustomer()
        {
            return new CustomerModel
            {
                FirstName = "Bob",
                LastName = "Blubber",
                City = "Hamburg",
                EmailAddress = "Bob@Blubber.com",
                PhoneNumber = "555-1658"
            };
        }

        private static List<PhysicalProductModel> AddSampleData()
        {
            List<PhysicalProductModel> output = new List<PhysicalProductModel>();

            output.Add(new PhysicalProductModel{Title = "13 sparkling Marbles"});
            output.Add(new PhysicalProductModel{Title = "a whole horse"});
            output.Add(new PhysicalProductModel{Title = "30 Textmarkers"});

            return output;
        }
    }
}
