using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1

{ 
    class Vote
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter your age : ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a >= 18)
            {
                Console.WriteLine("Eligible to Vote");
            }
            else
            {
                Console.WriteLine("Not Eligible to Vote");
            }

        }
    }
   
}
