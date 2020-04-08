using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mine
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();
            resources.Add("Gold", 0);
            resources.Add("Silver", 0);
            resources.Add("Copper", 0);
            while (true)
            {
                Console.Write("Enter type of metal: ");
                string comm = Console.ReadLine().ToLower();
                if (comm == "stop" || comm == "copper" || comm == "silver" || comm == "gold")
                {
                    if (comm != "stop") 
                    {
                        int amount = 0;
                        Console.Write($"Enter amount {comm}: ");
                        try
                        {
                            amount = int.Parse(Console.ReadLine());
                        }
                        catch (FormatException e) { Console.WriteLine("You must type a number."); }
                        switch (comm)
                        {                            
                            case "copper":
                                {
                                    resources["Copper"] += amount;
                                    Console.WriteLine($"{amount} copper added.");
                                    break;
                                }
                            case "silver":
                                {
                                    resources["Silver"] += amount;
                                    Console.WriteLine($"{amount} silver added.");
                                    break;
                                }
                            case "gold":
                                {
                                    resources["Gold"] += amount;
                                    Console.WriteLine($"{amount} gold added.");
                                    break;
                                }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Gold -> {resources["Gold"]}");     
                        Console.WriteLine($"Silver -> {resources["Silver"]}"); 
                        Console.WriteLine($"Copper -> {resources["Copper"]}"); 
                        break;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
