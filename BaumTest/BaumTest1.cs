using Baum;
using NUnit.Framework;

namespace BaumTest1
{
    public class BaumTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Baum_AddNodes_AllNodesAreAdded()
        {
            var tree = new BinaererBaum();

            tree.addNode(5);
            tree.addNode(3);
            tree.addNode(7);
            tree.addNode(6);
            tree.addNode(4);

            Assert.AreEqual(tree.ToString(), "34567");
        }

    }
}