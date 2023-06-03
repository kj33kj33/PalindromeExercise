using System;
namespace PalindromeExercise
{
	public class WordSmith
	{
		public bool IsAPalindrome(string word)
		{
			string reversed = String.Empty;
			for(int i = word.Length -1; i >= 0; i--)
			{
				reversed += word[i];
			}
			if(word.ToLower() == reversed.ToLower())
			{
				return true;
			}
			return false;
		}
	}
}

