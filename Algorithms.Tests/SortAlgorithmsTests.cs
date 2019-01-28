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

        [Test]
        public void TestBubbleSortForOneInt()
        {
            var data = new[] { 32 };
            var result = sorting.BubbleSort(data);

            AssertIfSequencesEqual(data, result);
        }
    }
}
