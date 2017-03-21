using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Randomness
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd1 = new Random();
            //Thread.Sleep(15);
            //Random rnd2 = new Random();
            //Thread.Sleep(15);
            //Random rnd3 = new Random();
            //Thread.Sleep(15);
            //Random rnd4 = new Random();
            //Thread.Sleep(15);
            //Random rnd5 = new Random();
            //Thread.Sleep(15);


            int r1 = rnd1.Next(1000);
            int r2 = rnd1.Next(1000);
            int r3 = rnd1.Next(1000);
            int r4 = rnd1.Next(1000);
            int r5 = rnd1.Next(1000);

            Console.WriteLine(string.Format("val1: {0}, val2: {1}, val3: {2}, val4: {3}, val5: {4}", r1, r2, r3, r4, r5));

            int r6 = rnd1.Next(1000);
            Console.WriteLine("r6 = " + r6);


            Console.ReadLine();

        }
    }
}
