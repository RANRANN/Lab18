using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region//List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //int[] array = new int[3] { 4, 5, 6 };
            //list.AddRange(array);
            //list.RemoveAt(3);
            //list.Reverse();
            //for (int i = 0; i < list.Count; i++)
            //{
            //    list[i]++;
            //}
            //foreach (int i in list) 
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadKey();
            //Dictionary<string, int> month = new Dictionary<string, int>();
            //month.Add("январь", 31);
            //month.Add("февраль", 28);
            //month.Add("март", 31);
            //month.Add("апрель", 30);
            //month.Add("май", 31);
            //month.Add("июнь", 30);
            //month.Add("июль", 31);
            //month.Add("август", 30);
            //month.Add("сентябрь", 31);
            //month.Add("октябрь", 30);
            //month.Add("ноябрь", 31);
            //month.Add("декабрь", 30);
            //Console.WriteLine(month["май"]);
            //Console.ReadKey();
            #endregion
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            Console.WriteLine(Char(str));
            Console.ReadKey();

        }
        static bool Char(string str)
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> dict = new Dictionary<char, char>()
            {
                {'(',')' },
                {'{','}' },
                {'[',']' },
            };
            foreach (char c in str)
            {
                if (c == '(' || c == '{' || c == '[')
                    stack.Push(dict[c]);
                if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0 || stack.Pop() != c)
                    {
                        return false;
                    }
                }
            }
            if (stack.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
