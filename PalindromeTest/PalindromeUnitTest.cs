using NUnit.Framework;
using DatenstrukturenSingleLinkedList;

namespace DatenstrukturenSingleLinkedList
{
    public class Tests
    {
        [Test]
        public void IsPalindrome_WithPalindrome_ReturnsTrue()
        {
            // Arrange
            string palindrome = "radar";

            // Act
            bool result = IsPalindrome(palindrome);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_WithNonPalindrome_ReturnsFalse()
        {
            // Arrange
            string nonPalindrome = "hello";

            // Act
            bool result = IsPalindrome(nonPalindrome);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
//Test