using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_26_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] input = new string[text.Count()];
            int f = 0;
            foreach (var item in text)
            {
                input[f] = item.ToString();
                f++;
            }

            string word = "";
            for (int i = 3; i < text.Count(); i++)
            {
                word += input[i];
            }

            string word2 = "";
            for (int i = 0; i < text.Count() - 3; i++)
            {
                word2 += input[i];
            }

            int n = 3;
            string word3 = "";

            for (int i = n; i < text.Count() - 3; i++)
            {
                word3 += input[i];
            }

            Console.WriteLine(word);
            Console.WriteLine(word2);
            Console.WriteLine(word3);
            Console.Read();
        }
    }
}
