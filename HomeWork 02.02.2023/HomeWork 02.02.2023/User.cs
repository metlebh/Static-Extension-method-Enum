using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_02._02._2023
{
    class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public RegistrationMonth RegistrationMonth { get; set; }
        public string PIN { 
            get 
            {
                return pin;
            }
            set 
            {
                if (value.PinCheck())
                {
                    pin = value;
                }
                else
                {
                     throw new Exception("Try Again");
                }
            } 
        }
        private string pin;


        public User(string name, string surname, string pin, RegistrationMonth registrationMonth)
        {
            Name = name;
            Surname = surname;
            PIN = pin;
            RegistrationMonth = registrationMonth;
            
        }

        public string GetDetails()
        {
            return $" Name: {Name} \n Surname: {Surname} \n Pin: {PIN} \n Registration Month: {RegistrationMonth}\n";

        }
        public string Pin
        {
            get
            {
                return PIN;
            }
            set
            {
                if (value.PinCheck()==true)
                {
                    value = Pin;
                }
            }
        }
    }
}
