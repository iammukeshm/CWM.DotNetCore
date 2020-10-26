using CWM.DotNetCore.Results;
using System;

namespace CWM.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = Result.Failure("You are not authorized to access this resource");
            Console.WriteLine("Hello World!");
        }
    }
}
