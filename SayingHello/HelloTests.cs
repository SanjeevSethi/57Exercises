using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SayingHello
{
    [TestFixture]
    public class HelloTests
    {
        [Test]
        public void WhenAskedYourNameYourNameIsReturned()
        {
            var app = new HelloWorld();
            string name = "sanj";
            Assert.AreEqual(name, app.AskName(name));
        }

        [Test]
        public void GivenYourNameReturnAGreetingWithNameConcatanated()
        {
            var app = new HelloWorld();
            string name = "Sanj";
            string greeting = "Hello, Sanj, nice to meet you!";
            Assert.AreEqual(greeting, app.CreateGreeting(name));
        }
    }
}
