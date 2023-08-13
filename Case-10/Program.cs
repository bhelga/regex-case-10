using System;
using System.Text.RegularExpressions;

namespace Case_10
{
	public class RegexValidator
	{
		// Regular expression to match the provided acceptance criteria
		private static readonly Regex regex = new Regex(
			@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[!""#$%&'()*+,-./:;<=>?@\[\\\]^_`{|}~])\S{1,}$",
			RegexOptions.Compiled
		);

		// Method to validate the string based on the provided maximum length
		public static bool ValidateString(string input, int maxLength)
		{
			// Validate the length constraint
			if (input.Length > maxLength) return false;

			// Validate the rest of the criteria with the regular expression
			return regex.IsMatch(input);
		}

		public static void Main(string[] args)
		{
			Console.WriteLine(ValidateString("A1!", 5)); // False (too short input)
			Console.WriteLine(ValidateString("Aa1!Aa1!Aa1!Aa1!Aa1!", 10)); // False (too long input)
			Console.WriteLine(ValidateString("Aa1!", 4)); // True (matching input length)
			Console.WriteLine(ValidateString("aa1!", 5)); // False (missing uppercase)
			Console.WriteLine(ValidateString("AA1!", 5)); // False (missing lowercase)
			Console.WriteLine(ValidateString("AaA!", 5)); // False (missing digit)
			Console.WriteLine(ValidateString("Aa11", 5)); // False (missing special character)
			Console.WriteLine(ValidateString(" Aa1!", 5)); // False (leading whitespace)
			Console.WriteLine(ValidateString("Aa1! ", 5)); // False (trailing whitespace)
			Console.WriteLine(ValidateString("Aa 1!", 5)); // False (whitespace within the string)
		}
	}
	}
}