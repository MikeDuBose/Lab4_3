using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Primer
{
    public class Priming
    {
        static int counter = 0;
        static int[] primeNums = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109 };
        public static int CalcPrime(int a)
        {
            return primeNums[a - 1];
        }

        public static bool isPrime(int n)
        {

            // Corner case 
            if (n <= 1)
                return false;

            // Check from 2 to n-1 
            for (int i = 2; i < n; i++)
                if (n % i == 0)
                    return false;

            return true;
        }

        public static int printPrime(int n)
        {
            List<int> pn = new List<int>();
            ArrayList primeNumeros = new ArrayList();
            for (int i = 2; i <= 50; i++)
            {
                if (isPrime(i))
                {
                    //primeNumeros.Add(i);
                    pn.Add(i);
                    counter++;
                    //Console.WriteLine("Counter size is " + counter);
                    
                }
            }
            return pn[n-1];
        }

    }
}
