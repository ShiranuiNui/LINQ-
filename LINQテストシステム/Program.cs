using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQテストシステム
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
            foreach(int x in Number)
            {
                Database.Input = x;
            }

            List<int> ArrayList = Database.Output;
            var Linq = Number.Where(n => n <5).Select(r => r);
            foreach(int x in Linq)
            {
                Console.WriteLine(x);
            }
        }
    }
    static class Database
    {
        private static System.Collections.Generic.List<int> ArrayList = new List<int>();
        public static int Input
        {
            set
            {
                ArrayList.Add(value);
            }
        }
        public static List<int> Output
        {
            get
            {
                return ArrayList;
            }
            
        }

    }
}
