namespace Roman.Core
{
	public class RomanContext
	{
		private int _input;
		private string _output;

		public RomanContext(int input)
		{
			this._input = input;
		}

		public int Input
		{
			get { return _input; }
			set { _input = value; }
		}

		public string Output
		{
			get { return _output; }
			set { _output = value; }
		}
	}
}