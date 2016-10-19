using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayingHello
{
    public class HelloWorld
    {

        public HelloWorld()
        {

        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello")

        }

        public string AskName(string name)
        {
            var name = Console.ReadLine("What is your name? ")
            return name;
        }

        public string CreateGreeting(string name)
        {
            return string.Format("Hello, {0}, nice to meet you!", name);
        }

    }
}
