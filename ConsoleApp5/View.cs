using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class View
    {
        public int getNum()
        {
            int.TryParse(Console.ReadLine(), out int c);
            if (c != null) return c;
            return 0;
        }

        public string getLine()
        {
            string c = Console.ReadLine();
            if (c != null) return c;
            return null;
        }
    }
}
