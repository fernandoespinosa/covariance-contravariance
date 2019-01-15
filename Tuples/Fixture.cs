
using System;
using NUnit.Framework;

namespace GameOfCodes.Tuples
{

    public class Tuples
    {

        [Test]
        public void Tuples_Test()
        {
            (string a, string b) namedLetters = ("a", "b");
            Console.WriteLine(namedLetters);
            Console.WriteLine(namedLetters.a);
            Console.WriteLine(namedLetters.b);
            Assert.Pass();
        }
    }
}