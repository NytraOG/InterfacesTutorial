using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLib.Interfaces;

namespace DemoLib.Models
{
    public class DemoClass : Interface1, Interface2 
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Age { get; set; }

        public void SayHi()
        {
            Console.WriteLine("Hi");
        }

    }
}
