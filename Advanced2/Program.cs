using System;

namespace Advanced2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            String[] fristLine = Console.ReadLine().Split();
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
                Console.WriteLine(count);
            }
            #endregion
            #region Q2
            #endregion
        }
    }
}
