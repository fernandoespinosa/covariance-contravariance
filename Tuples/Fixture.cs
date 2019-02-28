
using System;
using System.IO;
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

        [Test]
        public void Foo_Test()
        {
            FileInfo fileInfo = new FileInfo("~/Spikes/game-of-codes/SubsequenceFinder.Tests.cs");
            Console.WriteLine($"Full Name: {fileInfo.FullName}");
            Console.WriteLine(fileInfo.Exists);
            Console.Write(File.Exists("~/Spikes/game-of-codes/SubsequenceFinder.Tests.cs"));
            Assert.Pass();
        }
    }
}