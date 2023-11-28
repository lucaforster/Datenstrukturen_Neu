using System;
using System.Collections.Generic;
using DatenstrukturenSingleLinkedList

namespace DatenstrukturenSingleLinkedList
{
	public class Palindrome
	{
		static void Main()
		{
			Console.WriteLine(IsPalindrome("radar")); // True
			Console.WriteLine(IsPalindrome("hello")); // False
		}

		static bool IsPalindrome(string s)
		{
			s = s.Replace("", "").ToLower();    //Entfernt die Abstaende und kleinbuchstaben

			Stack<char> stack = new Stack<char>(); // Stack initiallisation

			foreach (char c in s)  // Push für jeden character in den Stack
			{
				stack.Push(c);
			}

			string reversed = "";   //String wiederaufbauen in dem man die Elemente aus dem Stack Popt
			while (stack.Count > 0)
			{
				reversed += stack.Pop();
			}

			return s.Equals(reversed); //Prüft ob der Originale Wert gleich mit dem Umgedrehten Wert ist

		}
	}

}
// Test

