using NUnit.Framework;
using DatenstrukturenSingleLinkedList;

namespace DatenstrukturenSingleLinkedListTest
{
    public class TestSingleLinkedList
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SingleLinkedList_test()
        {
            var myList = new SingleLinkedList<int>();
            myList.insert_AtTheEnd(1);
            myList.insert_AtTheEnd(2);
            myList.insert_AtTheEnd(3);



            Assert.AreEqual(3, myList.size());

            myList.delete_last();
            Assert.AreEqual(2, myList.size());
        }
        [Test]
        public void insertSort_UnorderdNummbers_CorrectOrder()
        {
            var myList = new SingleLinkedList<int>();
            myList.insert_AtTheEnd(1);
            myList.insert_AtTheEnd(6);
            myList.insert_AtTheEnd(2);
            myList.insert_AtTheEnd(4);
            myList.insert_AtTheEnd(3);
            myList.insert_AtTheEnd(5);

            Assert.That(myList.ToString, Is.EqualTo("1\n6\n2\n4\n3\n5\n"));

            myList.insertionSort();

            Assert.That(myList.ToString, Is.EqualTo("1\n2\n3\n4\n5\n6\n"));
        }

        [Test]

        public void insertSort_SomeNummberDouble_CorrectOrderAndNoError()
        {
            var myList = new SingleLinkedList<int>();
            myList.insert_AtTheEnd(1);
            myList.insert_AtTheEnd(6);
            myList.insert_AtTheEnd(2);
            myList.insert_AtTheEnd(4);
            myList.insert_AtTheEnd(3);
            myList.insert_AtTheEnd(4);
            myList.insert_AtTheEnd(5);

            Assert.That(myList.ToString, Is.EqualTo("1\n6\n2\n4\n3\n4\n5\n"));

            myList.insertionSort();

            Assert.That(myList.ToString, Is.EqualTo("1\n2\n3\n4\n4\n5\n6\n"));
        }
        [Test]
        public void insertionSortinverse_SomeNummberDouble_CorrectOrderOfNumbersAndNoError()
        {
            var myList = new SingleLinkedList<int>();
            myList.insert_AtTheEnd(1);
            myList.insert_AtTheEnd(6);
            myList.insert_AtTheEnd(2);
            myList.insert_AtTheEnd(6);
            myList.insert_AtTheEnd(3);
            myList.insert_AtTheEnd(4);
            myList.insert_AtTheEnd(5);

            Assert.That(myList.ToString, Is.EqualTo("1\n6\n2\n6\n3\n4\n5\n"));

            myList.insertionSortinverse();

            Assert.That(myList.ToString, Is.EqualTo("6\n6\n5\n4\n3\n2\n1\n"));
        }

        [Test]
        public void BubbleSort_UnorderdNummbers_CorrectOrderOfNumbers()
        {
            var myList = new SingleLinkedList<int>();
            myList.SetSortStrategy(new BubbleSort());
            myList.insert_AtTheEnd(1);
            myList.insert_AtTheEnd(6);
            myList.insert_AtTheEnd(2);
            myList.insert_AtTheEnd(4);
            myList.insert_AtTheEnd(3);
            myList.insert_AtTheEnd(5);

            Assert.That(myList.ToString, Is.EqualTo("| 1 | 6 | 2 | 4 | 3 | 5 |"));

            myList.Sort();

            Assert.That(myList.ToString, Is.EqualTo("| 1 | 2 | 3 | 4 | 5 | 6 |"));
        }

        [Test]
        public void RverseBubbleSort_UnorderdNummbers_CorrectOrderOfNumbers()
        {
            var myList = new SingleLinkedList<int>();
            myList.SetSortStrategy(new BubbleSort());
            myList.insert_AtTheEnd(1);
            myList.insert_AtTheEnd(6);
            myList.insert_AtTheEnd(2);
            myList.insert_AtTheEnd(4);
            myList.insert_AtTheEnd(3);
            myList.insert_AtTheEnd(5);

            Assert.That(myList.ToString, Is.EqualTo("| 1 | 6 | 2 | 4 | 3 | 5 |"));

            myList.SortDesc();

            Assert.That(myList.ToString, Is.EqualTo("| 6 | 5 | 4 | 3 | 2 | 1 |"));
        }

        [Test]
        public void RverseBubbleSort_SomeNummberDouble_CorrectOrderOfNumbers()
        {
            var myList = new SingleLinkedList<int>();
            myList.SetSortStrategy(new BubbleSort());
            myList.insert_AtTheEnd(1);
            myList.insert_AtTheEnd(6);
            myList.insert_AtTheEnd(3);
            myList.insert_AtTheEnd(4);
            myList.insert_AtTheEnd(3);
            myList.insert_AtTheEnd(5);

            Assert.That(myList.ToString, Is.EqualTo("| 1 | 6 | 3 | 4 | 3 | 5 |"));

            myList.SortDesc();

            Assert.That(myList.ToString, Is.EqualTo("| 6 | 5 | 4 | 3 | 3 | 1 |"));
        }
    }
}
   
