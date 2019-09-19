using System;

namespace ConsoleApp1
{
    class MainClass
    {
        static void Main(string[] args)
        {
            //产生表达式
            string[] statement = new Statement().MakeStatement();
            //输出表达式
            for (int i = 0; i < statement.Length; i++)
            {
                Console.Write(statement[i]);
            }
            //计算表达式值
            Console.WriteLine(" = " +  Calculate.Evalve(statement));

            Console.Read();
        }
    }
}
