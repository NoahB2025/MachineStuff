
namespace CheckoutPage
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
			this.label1 = new System.Windows.Forms.Label();
			this.btn_Back = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_ToolID = new System.Windows.Forms.TextBox();
			this.txt_Name = new System.Windows.Forms.TextBox();
			this.txt_Instructor = new System.Windows.Forms.TextBox();
			this.txt_Date = new System.Windows.Forms.TextBox();
			this.btn_CheckOut = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(79, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(210, 46);
			this.label1.TabIndex = 0;
			this.label1.Text = "Check out\r\n";
			// 
			// btn_Back
			// 
			this.btn_Back.Location = new System.Drawing.Point(3, 2);
			this.btn_Back.Name = "btn_Back";
			this.btn_Back.Size = new System.Drawing.Size(75, 26);
			this.btn_Back.TabIndex = 1;
			this.btn_Back.Text = "Back";
			this.btn_Back.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(152, 160);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "Tool ID";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(163, 197);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 25);
			this.label3.TabIndex = 3;
			this.label3.Text = "Name";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(136, 236);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(92, 25);
			this.label4.TabIndex = 4;
			this.label4.Text = "Instructor";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(173, 277);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 25);
			this.label5.TabIndex = 5;
			this.label5.Text = "Date";
			// 
			// txt_ToolID
			// 
			this.txt_ToolID.Location = new System.Drawing.Point(233, 160);
			this.txt_ToolID.Name = "txt_ToolID";
			this.txt_ToolID.Size = new System.Drawing.Size(62, 22);
			this.txt_ToolID.TabIndex = 6;
			// 
			// txt_Name
			// 
			this.txt_Name.Location = new System.Drawing.Point(233, 200);
			this.txt_Name.Name = "txt_Name";
			this.txt_Name.Size = new System.Drawing.Size(273, 22);
			this.txt_Name.TabIndex = 7;
			// 
			// txt_Instructor
			// 
			this.txt_Instructor.Location = new System.Drawing.Point(234, 240);
			this.txt_Instructor.Name = "txt_Instructor";
			this.txt_Instructor.Size = new System.Drawing.Size(273, 22);
			this.txt_Instructor.TabIndex = 8;
			// 
			// txt_Date
			// 
			this.txt_Date.Location = new System.Drawing.Point(232, 281);
			this.txt_Date.Name = "txt_Date";
			this.txt_Date.Size = new System.Drawing.Size(100, 22);
			this.txt_Date.TabIndex = 9;
			// 
			// btn_CheckOut
			// 
			this.btn_CheckOut.Location = new System.Drawing.Point(662, 412);
			this.btn_CheckOut.Name = "btn_CheckOut";
			this.btn_CheckOut.Size = new System.Drawing.Size(126, 26);
			this.btn_CheckOut.TabIndex = 10;
			this.btn_CheckOut.Text = "Check out";
			this.btn_CheckOut.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Maroon;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btn_CheckOut);
			this.Controls.Add(this.txt_Date);
			this.Controls.Add(this.txt_Instructor);
			this.Controls.Add(this.txt_Name);
			this.Controls.Add(this.txt_ToolID);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btn_Back);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_Back;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txt_ToolID;
		private System.Windows.Forms.TextBox txt_Name;
		private System.Windows.Forms.TextBox txt_Instructor;
		private System.Windows.Forms.TextBox txt_Date;
		private System.Windows.Forms.Button btn_CheckOut;
	}
}

