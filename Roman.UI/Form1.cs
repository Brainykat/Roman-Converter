using System;
using System.Windows.Forms;

namespace Roman.UI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void TbNumberInput_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void BtnToRoman_Click(object sender, EventArgs e)
		{
			if (System.Text.RegularExpressions.Regex.IsMatch(tbNumberInput.Text, "[^0-9]"))
			{
				ShowMessage("Please enter only numbers.");
				tbNumberInput.Text = "0";
			}
			else
			{
				tbRomanOutput.Text = Domain.Roman.To(Int32.Parse(tbNumberInput.Text));
			}
		}
		private void ShowMessage(string message)
		{
			MessageBox.Show(message);
		}

		private void BtnRomanToNumber_Click(object sender, EventArgs e)
		{
			var result = Domain.Roman.From(tbRomanInput.Text.Trim().ToUpper());
			tbNumberOutput.Text = result.ToString();
			if (result == 0) ShowMessage("Invalid Input");
		}
	}
}
