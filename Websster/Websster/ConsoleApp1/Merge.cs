using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Merge
    {
        public String[] Mix(String[] numbers, String[] operators)
        {
            //合并
            int indexForNum = 0;
            int indexForOpr = 0;
            int numSize = numbers.Length;
            int oprSize = operators.Length;

            String[] temp = new string[numSize + oprSize];

            for (int i = 0; i < numSize + oprSize; i++)
            {
                temp[i] = 0 == i % 2 ? numbers[indexForNum++] : operators[indexForOpr++];
            }
            return temp;
        }
    }
}
