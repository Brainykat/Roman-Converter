using Xunit;

namespace Roman.Simple.Tests
{
	public class IntToRomanTests
	{

		[Theory]
		[InlineData("I",1)]
		[InlineData("IV", 4)]
		[InlineData("IX", 9)]
		[InlineData("X", 10)]
		[InlineData("XLIX", 49)]
		[InlineData("L", 50)]
		[InlineData("C", 100)]
		[InlineData("CMXCIX", 999)]
		[InlineData("M", 1000)]

		public void Convert_Returns_Expected(string expected, int input)
		{
			Assert.Equal(expected, IntToRoman.Convert(input));
		}
	}
}
