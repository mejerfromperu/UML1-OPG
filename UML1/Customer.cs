using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML1
{
    public class Customer
    {
        // Kunde Klasse
        // Instance Fields

        private int _customerNumber;
        private string _name;
        private string _phoneNumber;


        // Properties

        public int CustomerNumber
        {
            get { return _customerNumber; }
            set { _customerNumber = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }


         // Constructor

        public Customer()
        {
            _customerNumber = 0;
            _name = "";
            _phoneNumber = "";
        }

        public Customer(int number, string name, string phoneNumber)
        {
            _customerNumber = number;
            _name = name;
            _phoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return $"{{{nameof(CustomerNumber)}={CustomerNumber.ToString()}, {nameof(Name)}={Name}, {nameof(PhoneNumber)}={PhoneNumber}}}";
        }
    }

}
