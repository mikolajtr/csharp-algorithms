using System;
using System.Collections.Generic;
using Algorithms.Implementations;
using NUnit.Framework;

namespace Algorithms.Tests
{
    public class SortAlgorithmsTests : BaseTestClass
    {
        private SortAlgorithms sorting;

        [SetUp]
        public void SetUp()
        {
            sorting = new SortAlgorithms();
        }

        [TestCase(new[] {32}, new[] {32})]
        [TestCase(new[] {4, 2, 1, 3}, new[] {1, 2, 3, 4})]
        [TestCase(new[] {4.21, 2, 8.33, 1, 3}, new[] {1, 2, 3, 4.21, 8.33})]
        public void TestBubbleSort<T>(ICollection<T> unsorted, ICollection<T> expected) where T: IComparable
        {
            var result = sorting.BubbleSort<T>(unsorted);

            AssertIfSequencesEqual(expected, result);
        }
    }
}
