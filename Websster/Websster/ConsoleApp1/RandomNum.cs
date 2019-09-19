using System;

namespace ConsoleApp1
{
    public class RandomNum
    {
        public String[] Make(int size)
        {
            Random random = new Random();
            String[] result = new string[size];
            for (int i = 0; i < size; i++)
            {
                result[i] = random.Next(10, 50).ToString();
            }
            return result;
        }
    }
}