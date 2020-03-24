using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_26_2020_pt2
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = Console.ReadLine().Replace(" ", "");

            string[] array1 = new string[test.Count()];
            int x = 0;
            foreach (var item in test)
            {
                array1[x] = item.ToString();
                x++;
            }

            string str = Console.ReadLine().Replace(" ", "");

            string[] array2 = new string[str.Count()];
            int z = 0;
            foreach (var item in str)
            {
                array2[z] = item.ToString();
                z++;
            }

            Console.WriteLine(compare(array1, array2));
            Console.WriteLine(unique(array1, array2, false));
            Console.WriteLine(unique(array1, array2, true));
            Console.ReadLine();
        }

        public static string compare(string[] array1, string[] array2)
        {
            string same = "";
            for (int i = 0; i < array1.Length; i++)
            {
                if (array2.Contains(array1[i]))
                {
                    same += array1[i] + " ";
                }
            }
            return same;
        }

        public static string unique(string[] array1, string[] array2, bool ForArray1)
        {
            string same = "";
            if (ForArray1)
            {
                for (int i = 0; i < array2.Length; i++)
                {
                    if (!array1.Contains(array2[i]))
                    {
                        same += array2[i] + " ";
                    }
                }
            }
            else
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    if (!array2.Contains(array1[i]))
                    {
                        same += array1[i] + " ";
                    }
                }
            }
            return same;
        }
    }
}
