using System.Collections;

namespace NthFibonacci
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n1st solution - recursive brute force\n");
            Console.WriteLine(GetNthFibRec(6));
            Console.WriteLine("\n2nd solution - recursive with memorization || caching\n");
            Console.WriteLine(GetNthFibRecWithMemorize(6));
            Console.WriteLine("\nthird solution - iterative with caching the last two fibs\n");
            Console.WriteLine(GetNthFibIter(6));
        }
        static int GetNthFibRec(int n)
        {
            //Recursive Solution 
            //Time Complexity O(2^n) Space Complexity O(n)(draw the functions call stack to illustrate it)

            if (n <= 1)
            {
                return 0;
            }
            else if (n == 2)
            {
                return 1;
            }
            else
            {
                return GetNthFibRec(n - 1) + GetNthFibRec(n - 2);
            }
        }
        static int GetNthFibRecWithMemorize(int n)
        {        
            //Recursive Solution With Caching (hashtable)
            //Time Complexitty O(n) Space Complexity O(n) (a hastable and the function's call stack due to recursion)

            Hashtable cacheFibs = new Hashtable();
            cacheFibs.Add(1, 0);
            cacheFibs.Add(2, 1);
            if (cacheFibs.ContainsKey(n))
            {
                return Convert.ToInt32(cacheFibs[n]);
            }
            else
            {

                cacheFibs[n] = GetNthFibRecWithMemorize(n - 1) + GetNthFibRecWithMemorize(n - 2);
                return Convert.ToInt32(cacheFibs[n]);
            }
        }
        static int GetNthFibIter(int n)
        {
            //Iterative Solution
            //Time Complexity O(n) Space Complexity O(1)

            if (n == 1)
            {
                return 0;
            }
            else if (n == 2)
            {
                return 1;
            }
            else
            {
                int counter = 3;
                int[] lastTwoFibs = { 0, 1 };
                while (counter < n)
                {
                    int next = lastTwoFibs[0] + lastTwoFibs[1];
                    lastTwoFibs[0] = lastTwoFibs[1];
                    lastTwoFibs[1] = next;
                    counter++;
                }
                return lastTwoFibs[0] + lastTwoFibs[1];
            }
        }
    }
}