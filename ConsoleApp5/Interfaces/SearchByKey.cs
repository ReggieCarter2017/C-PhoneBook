using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Interfaces
{
    internal interface SearchByKey
    {
        public Contact SearchByKey(String c, List<Contact> contacts);
    }
}
