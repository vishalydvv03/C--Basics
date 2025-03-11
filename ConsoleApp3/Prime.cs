﻿namespace ConsoleApp3
{
    class Prime
    {
        public static bool IsPrime(int n)
        {
            if (n == 2)
            {
                return true;
            }

            for(int i=2; i*i<=n; i++)
            {
                if(n%i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
