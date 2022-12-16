using NUnit.Framework;

namespace DatenstrukturenSingleLinkedList
{
    public class QueueTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Enqueue_ThreeElements_QueueOrderOK()
        {
            Queues queue = new Queues();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Assert.AreEqual(queue.ToString(), "| 1 | 2 | 3 |");
        }

        [Test]
        public void EnqueueAndDequeue_EnqueueThreeTimesPoPonce_TwoElementsInStackLastOneRemoved()
        {
            Queues queue = new Queues();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            var last = queue.Dequeue();
            Assert.AreEqual(last.data, 1);
            Assert.AreEqual(queue.ToString(), "| 2 | 3 |");
        }
    }
}