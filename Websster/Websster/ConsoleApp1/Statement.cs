using System;

namespace ConsoleApp1
{
    /**
     * 产生表达式
     * **/
    public class Statement
    {
        public string[] MakeStatement()
        {
            Random random = new Random();
            int numSize = numSize = random.Next(3, 12);
            int oprSize = numSize - 1;

            String[] numbers = new RandomNum().Make(numSize);
            String[] operators = new RandomOpt().Make(oprSize);

            return new Merge().Mix(numbers, operators); ;
        }
    }
}