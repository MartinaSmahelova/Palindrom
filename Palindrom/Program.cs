using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Palindrom
{
	class Program
	{
		
		static void Main(string[] args)
		{
			//V kterémkoliv jazyce vytvořte metodu, která ověří, jestli je zadaný text palindrom tj.je možné ho číst stejně od konce i od začátku.
			//Vstupem metody bude text a výstupem boolovská hodnota.

			Console.WriteLine("Enter Word: ");
			var word = Console.ReadLine();

			Console.WriteLine($"{word} is palindrome: {IsTextPalindrome(word)}");

			// V kterémkoliv jazyce vytvořte metodu, která ověří, jestli je ze zadaného textu možné sestavit palindrom.
			// Vstupem metody bude text a výstupem boolovská hodnota. Přklad: "aabbc" vratí true, protože text je možné přeskládat na "abcba".

			Console.WriteLine("Enter Word: ");
			var word2 = Console.ReadLine();

			Console.WriteLine($"{word} is possible to create palindrome: {IsPossibleToCreatePalindromeFromText(word)}");


			Console.ReadKey();
		}

		public static bool IsTextPalindrome(string word)
		{
			string wordFromLastCharacter = "";

			for (int i = 0; i < word.Length; i++)
			{
				wordFromLastCharacter += word[(word.Length - 1) - i].ToString();
			}

			return word.Equals(wordFromLastCharacter, StringComparison.OrdinalIgnoreCase);
		}

		public static bool IsPossibleToCreatePalindromeFromText(string word)
		{
			var word1 = word.ToLower();
			var distinctWord = word1.Distinct().ToList();
			return ((distinctWord.Count * 2) - word1.Length) == 1 || ((distinctWord.Count * 2) - word1.Length) == 0;
		}
	}
}
