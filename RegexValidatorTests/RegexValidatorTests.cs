using Case_10;

namespace RegexValidatorTests
{
	public class RegexValidatorTests
	{
		[Fact]
		public void TooShortInput_ReturnsFalse()
		{
			Assert.False(RegexValidator.ValidateString("A1!", 5));
		}

		[Fact]
		public void TooLongInput_ReturnsFalse()
		{
			Assert.False(RegexValidator.ValidateString("Aa1!Aa1!Aa1!Aa1!Aa1!", 10));
		}

		[Fact]
		public void MatchingInputLength_ReturnsTrue()
		{
			Assert.True(RegexValidator.ValidateString("Aa1!", 4));
		}

		[Fact]
		public void MissingUppercase_ReturnsFalse()
		{
			Assert.False(RegexValidator.ValidateString("aa1!", 5));
		}

		[Fact]
		public void MissingLowercase_ReturnsFalse()
		{
			Assert.False(RegexValidator.ValidateString("AA1!", 5));
		}

		[Fact]
		public void MissingDigit_ReturnsFalse()
		{
			Assert.False(RegexValidator.ValidateString("AaA!", 5));
		}

		[Fact]
		public void MissingSpecialCharacter_ReturnsFalse()
		{
			Assert.False(RegexValidator.ValidateString("Aa11", 5));
		}

		[Fact]
		public void LeadingWhitespace_ReturnsFalse()
		{
			Assert.False(RegexValidator.ValidateString(" Aa1!", 5));
		}

		[Fact]
		public void TrailingWhitespace_ReturnsFalse()
		{
			Assert.False(RegexValidator.ValidateString("Aa1! ", 5));
		}

		[Fact]
		public void WhitespaceWithinString_ReturnsFalse()
		{
			Assert.False(RegexValidator.ValidateString("Aa 1!", 5));
		}
	}
}