using NUnit.Framework;

namespace Rekursion
{
    public class RekursionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Sum_FixNumber_ReturnCorrectSum()
        {
            MySum ms = new MySum();
            var ret = ms.Sumvalues_Iterative(50);
            Assert.AreEqual(ret, ms.Sumvalues_Rekursive(50));
        }
        private class MySum
        {
            public int Sumvalues_Iterative(int number)
            {
                var ret = 0;
                for (int i = 1; i <= number; i++)
                    ret += i;
                return ret;
            }
            public int Sumvalues_Rekursive(int number)
            {
                if (number == 1)
                {
                    return 1;
                }
                return number + Sumvalues_Rekursive(number - 1);
            }
        }
        
    }
}