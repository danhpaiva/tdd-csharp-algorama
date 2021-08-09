using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Exercises.Domain;

namespace Exercises.Test
{
    [TestClass]
    public class HelloWorldTest
    {
        [TestMethod]
        public void SayHello_Test()
        {
            string message = HelloWorld.SayHello();
            Assert.AreEqual("Hello World!", message);
            Console.WriteLine(message);
        }
    }
}
