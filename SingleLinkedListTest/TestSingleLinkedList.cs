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
            var myList = new SingleLinkedList();
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
            var myList = new SingleLinkedList();
            myList.insert_AtTheEnd(1);
            myList.insert_AtTheEnd(6);
            myList.insert_AtTheEnd(2);
            myList.insert_AtTheEnd(4);
            myList.insert_AtTheEnd(3);
            myList.insert_AtTheEnd(5);
            myList.SetSortStrategy(new Sortstartegyfactory());

            Assert.That(myList.ToString(), Is.EqualTo("| 1 | 6 | 2 | 4 | 3 | 5 |"));

            myList.Sort();

            Assert.That(myList.ToString(), Is.EqualTo("| 1 | 2 | 3 | 4 | 5 | 6 |"));
        }

        [Test]

        public void insertSort_SomeNummberDouble_CorrectOrderAndNoError()
        {
            var myList = new SingleLinkedList();
            myList.insert_AtTheEnd(1);
            myList.insert_AtTheEnd(6);
            myList.insert_AtTheEnd(2);
            myList.insert_AtTheEnd(4);
            myList.insert_AtTheEnd(3);
            myList.insert_AtTheEnd(4);
            myList.insert_AtTheEnd(5);
            myList.SetSortStrategy(new InsertionSort());

            Assert.That(myList.ToString(), Is.EqualTo("| 1 | 6 | 2 | 4 | 3 | 4 | 5 |"));

            myList.Sort();

            Assert.That(myList.ToString(), Is.EqualTo("| 1 | 2 | 3 | 4 | 4 | 5 | 6 |"));
        }
        [Test]
        public void insertionSortinverse_SomeNummberDouble_CorrectOrderOfNumbersAndNoError()
        {
            var myList = new SingleLinkedList();
            myList.insert_AtTheEnd(1);
            myList.insert_AtTheEnd(6);
            myList.insert_AtTheEnd(2);
            myList.insert_AtTheEnd(6);
            myList.insert_AtTheEnd(3);
            myList.insert_AtTheEnd(4);
            myList.insert_AtTheEnd(5);
            myList.SetSortStrategy(new ReverseInsertionSort());

            Assert.That(myList.ToString(), Is.EqualTo("| 1 | 6 | 2 | 6 | 3 | 4 | 5 |"));

            myList.Sort();

            Assert.That(myList.ToString(), Is.EqualTo("| 6 | 6 | 5 | 4 | 3 | 2 | 1 |"));
        }

        [Test]
        public void BubbleSort_UnorderdNummbers_CorrectOrderOfNumbers()
        {
            var myList = new SingleLinkedList();
            myList.SetSortStrategy(new BubbleSort());
            myList.insert_AtTheEnd(1);
            myList.insert_AtTheEnd(6);
            myList.insert_AtTheEnd(2);
            myList.insert_AtTheEnd(4);
            myList.insert_AtTheEnd(3);
            myList.insert_AtTheEnd(5);

            Assert.That(myList.ToString(), Is.EqualTo("| 1 | 6 | 2 | 4 | 3 | 5 |"));

            myList.Sort();

            Assert.That(myList.ToString(), Is.EqualTo("| 1 | 2 | 3 | 4 | 5 | 6 |"));
        }

        [Test]
        public void RverseBubbleSort_UnorderdNummbers_CorrectOrderOfNumbers()
        {
            var myList = new SingleLinkedList();
            myList.SetSortStrategy(new BubbleSort());
            myList.insert_AtTheEnd(1);
            myList.insert_AtTheEnd(6);
            myList.insert_AtTheEnd(2);
            myList.insert_AtTheEnd(4);
            myList.insert_AtTheEnd(3);
            myList.insert_AtTheEnd(5);

            Assert.That(myList.ToString(), Is.EqualTo("| 1 | 6 | 2 | 4 | 3 | 5 |"));

            myList.SortDesc();

            Assert.That(myList.ToString(), Is.EqualTo("| 6 | 5 | 4 | 3 | 2 | 1 |"));
        }

        [Test]
        public void RverseBubbleSort_SomeNummberDouble_CorrectOrderOfNumbers()
        {
            var myList = new SingleLinkedList();
            myList.SetSortStrategy(new BubbleSort());
            myList.insert_AtTheEnd(1);
            myList.insert_AtTheEnd(6);
            myList.insert_AtTheEnd(3);
            myList.insert_AtTheEnd(4);
            myList.insert_AtTheEnd(3);
            myList.insert_AtTheEnd(5);

            Assert.That(myList.ToString(), Is.EqualTo("| 1 | 6 | 3 | 4 | 3 | 5 |"));

            myList.SortDesc();

            Assert.That(myList.ToString(), Is.EqualTo("| 6 | 5 | 4 | 3 | 3 | 1 |"));
        }
    }
}
   
