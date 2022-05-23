using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    public class CustomerManager : Customer
    {
        List<Customer> _customer = new List<Customer>();
        public void addCustomer(Customer customer)
        {
            _customer.Add(customer);
            Console.WriteLine(customer.name + " " + customer.sName + " added!");
        }

        public void deleteCustomer(Customer customer)
        {
            _customer.Remove(customer);
            Console.WriteLine(customer.name + " " + customer.sName + " removed!");
        }

        public void updatecustomer(Customer customer)
        {
            Console.WriteLine("Enter the customer name: ");
            string _name = Console.ReadLine();
            Console.WriteLine("Enter the customer surname: ");
            string surname = Console.ReadLine();
            customer.name = _name;
            customer.sName = surname;
            Console.WriteLine(customer.name + " " + customer.sName + " updated!");
        }

        public void listOfAll(List<Customer> customer)
        {
            foreach (var item in customer)
            {
                Console.WriteLine($"id = {item.id} , name = {item.name} , surname = {item.sName}");
            }
        }

    }
}

