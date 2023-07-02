using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SheepTask
{
    internal class Program
    {
        public static string CountSheep(int n)
        {
            StringBuilder sb = new StringBuilder("");

            for(int i = 0; i <= n; i++)
            {
                if(i == 0)
                {
                    continue;
                }
                sb.Append(i.ToString());
                sb.Append(" sheep...");
            }

            string result = sb.ToString();
            Console.WriteLine(result);
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number of sheeps");
            int n = int.Parse(Console.ReadLine());
            string result = CountSheep(n);
    
        }
    }
}