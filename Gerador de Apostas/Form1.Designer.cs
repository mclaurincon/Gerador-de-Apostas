namespace Gerador_de_Apostas
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			button1 = new Button();
			label4 = new Label();
			textBox3 = new TextBox();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Coral;
			label1.BorderStyle = BorderStyle.Fixed3D;
			label1.Font = new Font("Maiandra GD", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(29, 32);
			label1.Name = "label1";
			label1.Size = new Size(72, 21);
			label1.TabIndex = 0;
			label1.Text = "Primeiro";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Coral;
			label2.BorderStyle = BorderStyle.Fixed3D;
			label2.Font = new Font("Maiandra GD", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(167, 32);
			label2.Name = "label2";
			label2.Size = new Size(60, 21);
			label2.TabIndex = 1;
			label2.Text = "Último";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = SystemColors.Control;
			label3.BorderStyle = BorderStyle.FixedSingle;
			label3.Font = new Font("Maiandra GD", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label3.ForeColor = Color.Aqua;
			label3.Location = new Point(106, 193);
			label3.Name = "label3";
			label3.Size = new Size(79, 21);
			label3.TabIndex = 2;
			label3.Text = "Resultado";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// textBox1
			// 
			textBox1.Font = new Font("Maiandra GD", 12F, FontStyle.Regular, GraphicsUnit.Point);
			textBox1.Location = new Point(29, 56);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(100, 27);
			textBox1.TabIndex = 3;
			// 
			// textBox2
			// 
			textBox2.Font = new Font("Maiandra GD", 12F, FontStyle.Regular, GraphicsUnit.Point);
			textBox2.Location = new Point(167, 56);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(100, 27);
			textBox2.TabIndex = 4;
			// 
			// button1
			// 
			button1.BackColor = Color.Coral;
			button1.Font = new Font("Maiandra GD", 12F, FontStyle.Regular, GraphicsUnit.Point);
			button1.Location = new Point(106, 247);
			button1.Name = "button1";
			button1.Size = new Size(76, 37);
			button1.TabIndex = 5;
			button1.Text = "Gerar";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.Coral;
			label4.BorderStyle = BorderStyle.FixedSingle;
			label4.Font = new Font("Maiandra GD", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(106, 101);
			label4.Name = "label4";
			label4.Size = new Size(93, 21);
			label4.TabIndex = 6;
			label4.Text = "Quantidade";
			// 
			// textBox3
			// 
			textBox3.Font = new Font("Maiandra GD", 12F, FontStyle.Regular, GraphicsUnit.Point);
			textBox3.Location = new Point(106, 125);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(100, 27);
			textBox3.TabIndex = 7;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(311, 311);
			Controls.Add(textBox3);
			Controls.Add(label4);
			Controls.Add(button1);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			MaximumSize = new Size(327, 350);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private TextBox textBox1;
		private TextBox textBox2;
		private Button button1;
		private Label label4;
		private TextBox textBox3;
	}
}