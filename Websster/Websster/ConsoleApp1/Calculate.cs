using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Calculate
    {
        public static double Evalve(String[] s)
        {
            //变量
            Judge   judge = new Judge();
            double  temp = 0;
            double  length = s.Length;
            Stack<string> ops = new Stack<string>();
            Stack<double> vals = new Stack<double>();
            //运算过程
            for (int i = 0; i < length; i++)
            {
                if (judge.isNum(s[i]))
                {
                    vals.Push(double.Parse(s[i]));
                }
                else if (s[i].Equals("*"))
                {
                    vals.Push(double.Parse(s[i + 1]));
                    vals.Push(vals.Pop() * vals.Pop());
                    i++;
                }
                else if (s[i].Equals("/"))
                {
                    vals.Push(double.Parse(s[i + 1]));
                    //跟乘号不同，因为除号的顺序不能随意改变
                    //所以后出栈的数值作为除数
                    double t = vals.Pop();
                    vals.Push((vals.Pop() / t));
                    i++;
                }
                else
                {
                    if (judge.isAddorSub(s[i]))
                    {
                        ops.Push(s[i]);
                    }
                    if (judge.isNum(s[i]))
                    {
                        vals.Push(double.Parse(s[i]));
                    }
                }
            }
                //符号栈要先出完
            while (ops.Count > 0)
            {
                string op = ops.Pop();
                if (op.Equals("-"))
                {
                    temp += -vals.Pop();
                }
                else if (op.Equals("+"))
                {
                    temp += vals.Pop();
                }
            }
            //符号栈为空时 数栈里面还有一个数
            temp += vals.Pop();
            return temp;
    }
    }
}