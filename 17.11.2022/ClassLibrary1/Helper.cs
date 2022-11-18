using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Helper
    {
        private Random rnd = new Random();
        public int RetRand()
        {
            return rnd.Next(0, 10000);
        }

        public string RetString()
        {
            return "String";
        }
    }
}
