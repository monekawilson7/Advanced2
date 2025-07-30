using System;

namespace Advanced2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /*      String[] fristLine = Console.ReadLine().Split();
                  int n = int.Parse(fristLine[0]);
                  int q = int.Parse(fristLine[1]);

                  int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                  for (int i = 0; i < q; i++) { 
                  int x = int.Parse(Console.ReadLine());
                      int count = 0;
                      foreach (int num in arr) {
                          if (num > x)
                          {
                              count++;
                          }
                      }
                      Console.WriteLine(count);*/
            #endregion
            #region Q2
            int n = int.Parse(Console.ReadLine());
            String[] input = Console.ReadLine().Split();
            int[] arr = Array.ConvertAll(input, int.Parse);
            bool isPalindrome = true;
            for (int i = 0; i < n / 2; i++)
            {
                if (arr[i] != arr[n - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }
            Console.WriteLine(isPalindrome ? "Yes" : "No");
            #endregion
        }
    }
    }