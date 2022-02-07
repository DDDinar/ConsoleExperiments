using System;
using Cocona;

namespace ConsoleExperiments
{
    class Program
    {
        static void Main(string[] args)
        {
            CoconaApp.Run<Program>(args);
        }

        public void Hello(bool toUpperCase, string name)
        {
            Console.WriteLine($"Hello {(toUpperCase ? name.ToUpper() : name)}");
        }
    }
}
