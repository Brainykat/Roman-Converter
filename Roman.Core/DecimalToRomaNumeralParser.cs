using Roman.Core.Expressions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Roman.Core
{
	public class DecimalToRomaNumeralParser : Expression
	{
		private List<Expression> ExpressionTree = new List<Expression>()
												  {
													  new MillionExpression(),
													  new HundredThousandExpression(),
													  //new TenThousandExpression(),
													  new ThousandExpression(),
													  new HundredExpression(),
													  new TenExpression(),
													  new OneExpression()
												  };

		public override void Interpret(RomanContext value)
		{
			foreach (Expression exp in ExpressionTree)
			{
				exp.Interpret(value);
			}
		}
	}
}
