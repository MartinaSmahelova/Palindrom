using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Palindrom
{
	class Program
	{
		//V kterémkoliv jazyce vytvořte metodu, která ověří, jestli je zadaný text palindrom tj.je možné ho číst stejně od konce i od začátku.
		//Vstupem metody bude text a výstupem boolovská hodnota.

		//V kterémkoliv jazyce vytvořte metodu, která ověří, jestli je ze zadaného textu možné sestavit palindrom.
		//Vstupem metody bude text a výstupem boolovská hodnota.Přklad: "aabbc" vratí true, protože text je možné přeskládat na "abcba".

		static void Main(string[] args)
		{
			string word;

			Console.WriteLine("Enter Word: ");
			word = Console.ReadLine();

			Console.WriteLine($"{word} is palidrome: {IsTextPalindrome(word)}");

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
	}
}
