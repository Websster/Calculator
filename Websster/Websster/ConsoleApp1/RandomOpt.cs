using System;

namespace ConsoleApp1
{
    public class RandomOpt
    {
        public string[] Make(int size)
        {
            Random random = new Random();
            String[] result = new string[size];
            for (int i = 0; i < size; i++)
            {
                result[i] = "+-/*"[random.Next(0, 5) % 4].ToString();
            }
            return result;
        }
     }
}
