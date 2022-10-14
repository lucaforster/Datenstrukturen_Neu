using NUnit.Framework;

namespace DatenstrukturenSingleLinkedListTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        /* [Test]
          public void Stack_ifpop_equals()
        {
            var myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);


            Assert.AreEqual(3, myStack.Count());
            Assert.AreEqual(myStack.Pop(), 3);
            Assert.AreEqual(myStack.Pop(), 2);
        }*/

        [Test]

        public void Linkedlist_test()
        {
            var list = new SingleLinkedList();
            list.insert(1);
            list.insert(2);
            list.insert(3);

            Assert.AreEqual(3, list.size());
        }
    }

 }