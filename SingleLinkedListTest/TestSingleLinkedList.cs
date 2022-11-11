using NUnit.Framework;
using DatenstrukturenSingleLinkedList;

namespace DatenstrukturenSingleLinkedListTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SingleLinkedList_test()
        {
            var myList = new DatenstrukturenSingleLinkedList<int>();
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
            var myList = new DatenstrukturenSingleLinkedList<int>();
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
            var myList = new DatenstrukturenSingleLinkedList<int>();
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
            var myList = new DatenstrukturenSingleLinkedList<int>();
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