using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (!File.Exists(args[0]))
            {
                return;
            }

            using (StreamReader sr = new StreamReader(args[0]))
            {
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }
        }
    }
}
