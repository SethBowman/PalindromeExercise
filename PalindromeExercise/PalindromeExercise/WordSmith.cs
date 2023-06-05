using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
	public class WordSmith
	{
		public bool IsAPalindrome(string word)
		{
			var reversed = "";

			for(int i = word.Length - 1; i >= 0; i--)
			{
				reversed += word[i];
			}

			//var wordCharArr = word.ToCharArray();
			//Array.Reverse(wordCharArr);
			//var reversed = new string(wordCharArr);

			if(word.ToLower() == reversed.ToLower())
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
