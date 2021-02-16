using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("renseignez votre age : \n");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age > 18)
            {
                Console.WriteLine($"vous avez {age} an vous etes donc majeur");
            }

            else 
            {
                Console.WriteLine($"vous avez {age} an vous etes donc mineur");
            }
        }
        }
    }

