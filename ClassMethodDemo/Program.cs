using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClassMethodDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            CustomerManager manager = new CustomerManager();

            customer.id = 1;
            customer.name = "Ayşe";
            customer.sName = "Dağ";
            customer.age = 25;
            customer.gender = "Female";
            customer.job = "Engineer";

            Customer customer2 = new Customer();
            customer2.id = 2;
            customer2.name = "Elif";
            customer2.sName = "Akça";
            customer2.age = 30;
            customer2.gender = "Female";
            customer2.job = "Doctor";

            List<Customer> _customer = new List<Customer>()

            {
                customer, customer2
            };

            Console.WriteLine("In order to start the app press 'Enter' !");
            Console.WriteLine("Keep pressing 'Enter' after each action takes place");
            Console.ReadLine();
            Console.WriteLine("Customer Addition");
            Console.ReadLine();
            manager.addCustomer(customer);
            Console.ReadLine();
            Console.WriteLine("customer Removing");
            Console.ReadLine();
            manager.deleteCustomer(customer2);
            Console.ReadLine();
            Console.WriteLine("Listing Customers");
            Console.ReadLine();
            manager.listOfAll(_customer);



        }


    }
}
