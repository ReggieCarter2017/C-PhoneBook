using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Contact
    {
        public string id { get; set; }
        public string name { get; set; }
        public string  phoneNumber { get; set; }
        public string email { get; set; }
        public string adress { get; set; }

     
        public Contact() : this("None", "None", "None", "None", "None") { }

        public Contact(string id, string name, string phoneNumber, string email, string adress)
        {
            this.id = id;
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.adress = adress;
        }
    }
}
