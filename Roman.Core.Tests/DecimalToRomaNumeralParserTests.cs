using Xunit;

namespace Roman.Core.Tests
{
	public class DecimalToRomaNumeralParserTests
	{
		[Theory]
		[InlineData("I", 1)]
		[InlineData("IV", 4)]
		[InlineData("IX", 9)]
		[InlineData("X", 10)]
		[InlineData("XLIX", 49)]
		[InlineData("L", 50)]
		[InlineData("C", 100)]
		[InlineData("CMXCIX", 999)]
		[InlineData("M", 1000)]

		public void Interpret_Returns_Expected(string expected, int input)
		{
			RomanContext ctx = new RomanContext(input);
			var parser = new DecimalToRomaNumeralParser();
			parser.Interpret(ctx);
			Assert.Equal(expected, ctx.Output);
		}
	}
}
