using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using System.IO;

namespace FizzBuzz.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void rangeOf3Test()
        {
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            Program program = new Program();
            program.FizzBuzz(3);

            string output = stringWriter.ToString();

            Assert.AreEqual("1 2 Fizz ", output);
        }

        [TestMethod()]
        public void rangeOf15Test()
        {
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            Program program = new Program();
            program.FizzBuzz(15);

            string output = stringWriter.ToString();

            Assert.AreEqual("1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz ", output);
        }
    }
}