using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    enum Gender { Male, Female, Other }

    struct Address
    {
        string address;
        string city;
        string state;
        string zipCode;
    }

    class User
    {
        private string _firstName;
        private string _lastName;
        private Gender _gender;

        public User(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
            _gender = Gender.Other;
        }

        public string FullName
        {
            get { return _firstName + " " + _lastName; }
        }

        public Gender Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public Address Address { get; set; }
    }
}
