using System;
using System.Security.Cryptography.X509Certificates;

namespace SheepTask
{
    internal class Program
    {
        public static string CountSheep(int n)
        {
            string result = " ";
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