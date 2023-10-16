using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Sieve_Of_Eratosthenes
{
    internal class Program
    {
        static List<int> SieveOfEratosthenes(int n)
        {
            List<int> primes = new List<int>();
            bool[] isPrime = new bool[n + 1];

            for (int i = 2; i <= n; i++)
            {
                isPrime[i] = true;
            }

            for (int p = 2; p * p <= n; p++)
            {
                if (isPrime[p])
                {
                    for (int i = p * p; i <= n; i += p)
                    {
                        isPrime[i] = false;
                    }
                }
            }

            for (int i = 2; i <= n; i++)
            {
                if (isPrime[i])
                {
                    primes.Add(i);
                }
            }

            return primes;
        }
        static void Main(string[] args)
        {
            int n = 30;
            List<int> primes = SieveOfEratosthenes(n);

            Console.WriteLine("Prime numbers from range [2, 30]:");
            foreach (int prime in primes)
            {
                Console.WriteLine(prime);
                Console.ReadLine();
            }
        }
    }
}
