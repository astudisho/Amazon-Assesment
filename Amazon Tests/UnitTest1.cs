using NUnit.Framework;
using System.Collections.Generic;

namespace Amazon_Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var list = new List<string>{ "a", "b", "a", "b", "c", "b", "a", "c", "a", "d", "e",
                "f", "e", "g", "d", "e", "h", "i", "j", "h", "k", "l", "i", "j" };

            var result = Amazon_Assesment.Amazon.Scenes(list);
            CollectionAssert.AreEqual(result, new List<int> { 9, 7, 8 });
        }

        [Test]
        public void Test2()
        {
            var list = new List<string>{ "a", "b", "c" };

            var result = Amazon_Assesment.Amazon.Scenes(list);

            CollectionAssert.AreEqual(result, new List<int> { 1, 1, 1 });
        }

        [Test]
        public void Test3()
        {
            var list = new List<string>{ "a", "b", "c", "a" };

            var result = Amazon_Assesment.Amazon.Scenes(list);

            CollectionAssert.AreEqual(result, new List<int> { 4 });
        }
    }
}