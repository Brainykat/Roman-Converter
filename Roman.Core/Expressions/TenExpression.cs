using System;
using System.Collections.Generic;
using System.Text;

namespace Roman.Core.Expressions
{
	class TenExpression : TerminalExpression
	{
		public override string One() { return "X"; }
		public override string Four() { return "XL"; }
		public override string Five() { return "L"; }
		public override string Nine() { return "XC"; }
		public override int Multiplier() { return 10; }
	}
}
