using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML1
{
    public class CustomerList
    {
        private List<Customer> _customers;

        public List<Customer> Catalog
        {
            get { return _customers; }
            set { _customers = value; }
        }

        public CustomerList()
        {
            _customers = new List<Customer>();
        }

        // Metoder

        public void AddCustomer(Customer customer)
        {
            _customers.Add(customer);
        }

        public Customer Remove(Customer customer)
        {
            if (_customers.Contains(customer))
            {
                _customers.Remove(customer);
                return customer;
            }
            else
            {
                Console.WriteLine("Error: Customer number not found!");
                return null;
            }
        }

        public List<Customer> GetAllCustomers()
        {
            return _customers;
        }



        // Min Edit Metode

        public void EditCustomer(int customerNumberrrrr, string newName, string newPhoneNumber)
        {
            Customer customerToEdit = _customers.Find(c => c.CustomerNumber == customerNumberrrrr);

            if (customerToEdit != null)
            {
                customerToEdit.Name = newName;
                customerToEdit.PhoneNumber = newPhoneNumber;
            }
            else
            {
                Console.WriteLine("Error: Customer number not found!");
            }
        }

        public List<Customer> GetFromName(string name)
        {
            List<Customer> Results = new List<Customer>();

            for (int i = 0; i < _customers.Count; i++)
            {
                if (_customers[i].Name == name)
                {
                    Results.Add(_customers[i]);
                }
            }

            return Results;
        }

        public override string ToString()
        {
            return $"{{{nameof(Catalog)}={Catalog}}}";
        }
    }
}
