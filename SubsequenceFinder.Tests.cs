using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace GameOfCodes
{
    partial class SubsequenceFinder
    {
        public class Tests
        {
            [Test]
            public void IsSubsequenceOf_Test()
            {
                var s = "abppplee";
                var d = new Dictionary<string, bool> {
                    {"able", true},
                    {"ale", true},
                    {"apple", true},
                    {"bale", false},
                    {"kangaroo", false}
                };

                foreach (var word in d.Keys)
                {
                    Console.WriteLine($"{word} subsequence of {s}: {word.IsSubsequenceOf(s)}");
                    Assert.That(word.IsSubsequenceOf(s), Is.EqualTo(d[word]), $"{word} is a subsequence of {s}: {word.IsSubsequenceOf(s)}");
                }
            }

            [Test]
            public void FindLongestSubsequence_Test()
            {
                var s = "abppplee";
                var d = new Dictionary<string, bool> {
                    {"able", true},
                    {"ale", true},
                    {"apple", true},
                    {"bale", false},
                    {"kangaroo", false}
                };
                var result = FindLongestSubsequence(s, d.Keys);
                Assert.That(result, Is.EqualTo("apple"));
            }
        }
    }
}