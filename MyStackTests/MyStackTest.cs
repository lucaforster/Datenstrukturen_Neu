using MyStack;
using NUnit.Framework;

namespace DatenstrukturenSingleLinkedList
{
    public class MyStackTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Push_ThreeElements_StackOrderOK()
        {
            MyStacks<int> stack = new MyStacks<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Assert.AreEqual(stack.ToString(), "| 1 | 2 | 3 |");
        }

        [Test]
        public void PushAndPop_PushThreeTimesPoPonce_TwoElementsInStackLastOneRemoved()
        {
            MyStacks<int> stack = new MyStacks<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            var last = stack.Pop();
            Assert.AreEqual(last.data, 3);
            Assert.AreEqual(stack.ToString(), "| 1 | 2 |");
        }
    }
}