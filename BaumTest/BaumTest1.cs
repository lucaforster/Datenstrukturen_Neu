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

        [Test]
        public void Baum_DeleteLeaf_RightNodeisdeleted()
        {
            var tree = new BinaererBaum();

            tree.addNode(5);
            tree.addNode(3);
            tree.addNode(7);
            tree.addNode(6);
            tree.addNode(4);

            Assert.AreEqual(tree.ToString(), "34567");

            tree.deleteNode(4);

            Assert.AreEqual(tree.ToString(), "3567");
        }

        [Test]
        public void Baum_DeleteRoot_NoRoot()
        {
            var tree = new BinaererBaum();

            tree.addNode(5);

            Assert.AreEqual(tree.ToString(), "5");

            tree.deleteNode(5);

            Assert.AreEqual(tree.ToString(), "");
        }

        [Test]
        public void Baum_DeleteNodeInTheMiddle_RightNodeisdeleted()
        {
            var tree = new BinaererBaum();

            tree.addNode(5);
            tree.addNode(3);
            tree.addNode(7);
            tree.addNode(6);
            tree.addNode(4);

            Assert.AreEqual(tree.ToString(), "34567");

            tree.deleteNode(3);

            Assert.AreEqual(tree.ToString(), "4567");
        }

        [Test]
        public void Baum_DeleteNodeInTheMiddle_LeftNodeisdeleted()
        {
            var tree = new BinaererBaum();

            tree.addNode(6);
            tree.addNode(3);
            tree.addNode(7);
            tree.addNode(2);

            Assert.AreEqual(tree.ToString(), "2367");

            tree.deleteNode(3);

            Assert.AreEqual(tree.ToString(), "267");
        }

        [Test]
        public void Baum_DeleteNodeInTheMiddle_Nodeisdeleted()
        {
            var tree = new BinaererBaum();

            tree.addNode(6);
            tree.addNode(3);
            tree.addNode(8);
            tree.addNode(2);
            tree.addNode(9);
            tree.addNode(7);

            Assert.AreEqual(tree.ToString(), "236789");

            tree.deleteNode(8);

            Assert.AreEqual(tree.ToString(), "23679");
        }
    }
}