using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace refractor4_demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var customer = new Customer("John", "Liquid", "123 Main St", "Chiang Mai", "Muang", 50000);
            System.Console.WriteLine(customer.GetFirstName() + " " + customer.GetLastName());

            var smithAddress =new Address("11/3 Main Road", "London", "Chelsea", 30210);
            var smith = new Customer("Alan", "Smith", smithAddress);
            System.Console.WriteLine(smith.GetFirstName() + " " + smith.GetLastName());
            System.Console.WriteLine(smithAddress.ToString());
        }
    }
}
