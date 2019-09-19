
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Judge
    {
        public bool isAddorSub(string v)
        {
            return v.Equals("+") || v.Equals("-");
        }

        public bool isNum(string v)
        {
            foreach (char o in v.ToCharArray())
            {
                if (o > '9' || o < '0')
                {
                    return false;
                }
            }
            return true;
        }
    }
}

