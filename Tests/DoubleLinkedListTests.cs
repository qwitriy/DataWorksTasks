using System.Linq;
using DataWorksTasks;
using NUnit.Framework;

namespace Tests
{
    public class DoubleLinkedListTests
    {
        [Test]
        public void AddFirstTest()
        {
            var list = new DoubleLinkedList<int>();
            list.AddFirst(1);
            Assert.AreEqual(1,list.First());
            list.AddFirst(2);
            Assert.AreEqual(2,list.First());
        }
        
        [Test]
        public void AddLastTest()
        {
            var list = new DoubleLinkedList<int>();
            list.AddFirst(1);
            list.AddLast(2);
            Assert.AreEqual(2,list.Last());
        }

        [Test]
        public void ReverseTest()
        {
            var list = new DoubleLinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.Reverse();
            var a = list.ToArray();
            var expected = new[] {3, 2, 1};
            CollectionAssert.AreEqual(expected, a);
        }
    }
}