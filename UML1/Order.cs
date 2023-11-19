using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML1
{
    public class Order
    {

        private Customer _customer;
        private Pizza _pizza;


        public Customer customer { get { return _customer; } set {  _customer = value; } }


        public Pizza pizza { get { return _pizza; } set { _pizza = value; } }


        // Constructer

        public Order()
        {
            _customer = null;
            _pizza = null;
        }
        public Order(Customer customer, Pizza pizza)
        {
            _customer = customer;
            _pizza = pizza;
        }

        public override string ToString()
        {
            return $"{{{nameof(customer)}={customer}, {nameof(pizza)}={pizza}}}";
        }
    }
}
