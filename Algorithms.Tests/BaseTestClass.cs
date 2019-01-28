using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Algorithms.Tests
{
    public class BaseTestClass
    {
        public void AssertIfSequencesEqual<T>(ICollection<T> firstSequence, ICollection<T> secondSequence) where T : IComparable
        {
            if (firstSequence.Count() != secondSequence.Count())
            {
                throw new AssertionException("Sequences are not equal");
            }

            foreach (var tup in firstSequence.Zip(secondSequence, (first, second) => (first, second)))
            {
                Assert.AreEqual(tup.Item1, tup.Item2);
            }
        }
    }
}
