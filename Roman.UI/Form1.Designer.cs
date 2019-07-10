namespace Roman.UI
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tbNumberInput = new System.Windows.Forms.TextBox();
			this.btnToRoman = new System.Windows.Forms.Button();
			this.tbRomanOutput = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbRomanInput = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbNumberOutput = new System.Windows.Forms.TextBox();
			this.btnRomanToNumber = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.tbRomanOutput);
			this.groupBox1.Controls.Add(this.btnToRoman);
			this.groupBox1.Controls.Add(this.tbNumberInput);
			this.groupBox1.Location = new System.Drawing.Point(7, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1440, 447);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Number To Roman";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnRomanToNumber);
			this.groupBox2.Controls.Add(this.tbNumberOutput);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.tbRomanInput);
			this.groupBox2.Location = new System.Drawing.Point(7, 473);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1440, 452);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Roman To Number";
			// 
			// tbNumberInput
			// 
			this.tbNumberInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbNumberInput.Location = new System.Drawing.Point(33, 84);
			this.tbNumberInput.Name = "tbNumberInput";
			this.tbNumberInput.Size = new System.Drawing.Size(606, 80);
			this.tbNumberInput.TabIndex = 0;
			this.tbNumberInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbNumberInput_KeyPress);
			// 
			// btnToRoman
			// 
			this.btnToRoman.Location = new System.Drawing.Point(394, 182);
			this.btnToRoman.Name = "btnToRoman";
			this.btnToRoman.Size = new System.Drawing.Size(245, 92);
			this.btnToRoman.TabIndex = 1;
			this.btnToRoman.Text = "Convert";
			this.btnToRoman.UseVisualStyleBackColor = true;
			this.btnToRoman.Click += new System.EventHandler(this.BtnToRoman_Click);
			// 
			// tbRomanOutput
			// 
			this.tbRomanOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbRomanOutput.Location = new System.Drawing.Point(225, 294);
			this.tbRomanOutput.Multiline = true;
			this.tbRomanOutput.Name = "tbRomanOutput";
			this.tbRomanOutput.ReadOnly = true;
			this.tbRomanOutput.Size = new System.Drawing.Size(1190, 134);
			this.tbRomanOutput.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(26, 349);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(122, 37);
			this.label1.TabIndex = 3;
			this.label1.Text = "Results";
			// 
			// tbRomanInput
			// 
			this.tbRomanInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbRomanInput.Location = new System.Drawing.Point(33, 84);
			this.tbRomanInput.Name = "tbRomanInput";
			this.tbRomanInput.Size = new System.Drawing.Size(1382, 80);
			this.tbRomanInput.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(26, 329);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(122, 37);
			this.label2.TabIndex = 4;
			this.label2.Text = "Results";
			// 
			// tbNumberOutput
			// 
			this.tbNumberOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbNumberOutput.Location = new System.Drawing.Point(225, 329);
			this.tbNumberOutput.Multiline = true;
			this.tbNumberOutput.Name = "tbNumberOutput";
			this.tbNumberOutput.ReadOnly = true;
			this.tbNumberOutput.Size = new System.Drawing.Size(1209, 94);
			this.tbNumberOutput.TabIndex = 5;
			// 
			// btnRomanToNumber
			// 
			this.btnRomanToNumber.Location = new System.Drawing.Point(394, 207);
			this.btnRomanToNumber.Name = "btnRomanToNumber";
			this.btnRomanToNumber.Size = new System.Drawing.Size(245, 92);
			this.btnRomanToNumber.TabIndex = 6;
			this.btnRomanToNumber.Text = "Convert";
			this.btnRomanToNumber.UseVisualStyleBackColor = true;
			this.btnRomanToNumber.Click += new System.EventHandler(this.BtnRomanToNumber_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1467, 945);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Roman Convertor ";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbRomanOutput;
		private System.Windows.Forms.Button btnToRoman;
		private System.Windows.Forms.TextBox tbNumberInput;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnRomanToNumber;
		private System.Windows.Forms.TextBox tbNumberOutput;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbRomanInput;
	}
}

