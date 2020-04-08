using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contacts = new Dictionary<string, string>();
            while(true)
            {
                var input = Console.ReadLine().Split(' ');
                string command = input[0].ToLower();
                switch (command)
                {
                    case "a":      
                        {
                            contacts.Add(input[1], input[2]);
                            break;
                        }
                    case "s": 
                        {
                            if (contacts.ContainsKey(input[1]))
                            {
                                Console.WriteLine($"{input[1]} -> {contacts[input[1]]}");
                            }
                            else
                            {
                                Console.WriteLine($"This contact does not exist.");
                            }
                            break;
                        }
                    case "end": 
                        {
                            return;
                        }
                }
            }
        }
    }
}
