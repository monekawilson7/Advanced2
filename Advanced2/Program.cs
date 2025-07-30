using System;
using System.Collections.Generic;

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
            /* int n = int.Parse(Console.ReadLine());
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
             Console.WriteLine(isPalindrome ? "Yes" : "No");*/
            #endregion
            #region Q3
            /*      Queue<int> q = new Queue<int>();

                  q.Enqueue(10);
                  q.Enqueue(20);
                  q.Enqueue(30);
                  q.Enqueue(40);
                  q.Enqueue(50);
                  Console.WriteLine("Origional");
                  foreach (var item in q) {
                      Console.WriteLine(item);
                  }
                  ReverseQueue(q);
                  Console.WriteLine("/n Reversed Queue: ");
                  foreach (var item in q) {
                      Console.WriteLine(item);
                  }*/
            #endregion
            #region Q4
            /*            String input = "[()]{()}";
                        if (IsBalanced(input))
                            Console.WriteLine("Balanced");
                        else
                            Console.WriteLine("Not Balanced");*/
            #endregion
            #region Q5
            int[] arr = { 11, 5, 2, 11, 2, 7, 1, 11 };
            int [] result = RemoveDuplicates(arr);
            foreach (int i in result) {
                Console.WriteLine(i);
            }
            #endregion
        }

        #region Q3
        static void ReverseQueue<T>(Queue<T> queue) { 
        Stack<T> stack = new Stack<T>();
            while (queue.Count > 0) {
                stack.Push(queue.Dequeue());
            }
            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
        }
        #endregion
        #region Q4
        static bool IsBalanced(string input) { 
        Stack<char> stack = new Stack<char>();
            foreach (char c in input) {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}') {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    char top = stack.Pop();
                    if (c == ')' && top != '(' ||
                        c == ']' && top != '[' ||
                        c == '}' && top != '{' 
                        ) { 
                    return false;
                    }
                }
            }
            return stack.Count == 0;
        }
        #endregion
        #region Q5
        static int[] RemoveDuplicates(int[] arr) { 
        HashSet<int> uniqueElements = new HashSet<int>();
            foreach (int i in arr) { 
            uniqueElements.Add(i);
            }
            return new List<int>(uniqueElements).ToArray();
        }
        #endregion
    }
}