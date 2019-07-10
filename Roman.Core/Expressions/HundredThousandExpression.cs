using System;
using System.Collections.Generic;
using System.Text;

namespace Roman.Core.Expressions
{
	class HundredThousandExpression : TerminalExpression
	{
		public override string One() { return "c"; }
		public override string Four() { return "cd"; }
		public override string Five() { return "d"; }
		public override string Nine() { return "cm"; }
		public override int Multiplier() { return 100000; }
	}
}
