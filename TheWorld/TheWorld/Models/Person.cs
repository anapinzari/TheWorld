using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorld.Models
{
    class Person
    {
        private string _firstName;
        private string _lastName;
        private string _id;
        private string _phoneNumber;

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (value == null || value.Length == 0) throw new Exception("First name cannot be empty.");
                _firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (value == null || value.Length == 0) throw new Exception("Last name cannot be empty.");
                _lastName = value;
            }
        }
        public string Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value == null || value.Length == 0) throw new Exception("Id cannot be empty.");
                _id = value;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                if (value == null || value.Length == 0) throw new Exception("Phone number cannot be empty.");
                _phoneNumber = value;
            }
        }
        public int Age { get; set; }
        public bool IsFemale { get; set; }

        public Person(string firstName, string lastName, string id, string phoneNumber, int age, bool isFemale)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            PhoneNumber = phoneNumber;
            Age = age;
            IsFemale = isFemale;
        }
    }
}
