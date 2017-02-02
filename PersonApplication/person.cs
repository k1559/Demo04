using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }

        //default constructor
        
        public Person()
        {

        }

        public Person(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }

        //just one method what Person can do
        public void PersonMethod()
        {
            Console.WriteLine("This method belongs to Person!");
        }

        //return Person data as a one string, override Object class ToString()-method
        public override string ToString()
        {
            return Firstname + " " + Lastname + " " + Address + " " + Age + " " + PhoneNumber;
        }
    }
}
