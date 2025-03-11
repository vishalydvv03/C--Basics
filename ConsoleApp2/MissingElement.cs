using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class MissingElement
    {
        public static int FindMissing(int[] arr)
        {
            int n = arr.Length + 1;
            int sumOfN = (n * (n + 1)) / 2;

            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }

            return sumOfN - sum;
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 4, 5, 6 };
            Console.WriteLine(MissingElement.FindMissing(arr));

            int[] nums = {1, 2, 3 };
        }

        
    }
}
