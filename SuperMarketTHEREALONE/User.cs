using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketTHEREALONE
{
    internal class User
    {
        public int ID { get; set; }

        public string Name{ get; set; }

        public string Surname{ get; set; }
        public string Email{ get; set; }

        public string Password { get; set; }

        public int Age { get; set; }

        public string Address { get; set; }

        public int PhoneNumber { get; set; }

        public User (int ID,string Name,string Surname,string Email,string Password,int Age,string Address,int PhoneNumber)
        {
            this.ID = ID;
            this.Name = Name;
            this.Surname = Surname;
            this.Email = Email;
            this.Password = Password;
            this.Age = Age;
            this.Address = Address;                                              //Tada
            this.PhoneNumber = PhoneNumber;
        }
        public User() { }
    }

}
