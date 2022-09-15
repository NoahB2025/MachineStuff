
namespace MachineApp
{
	partial class SignInForm
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_User = new System.Windows.Forms.TextBox();
			this.txt_Pass = new System.Windows.Forms.TextBox();
			this.btn_SignIn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(187, 91);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(188, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Sign in to edit";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(248, 182);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Username";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(248, 225);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Password";
			// 
			// txt_User
			// 
			this.txt_User.Location = new System.Drawing.Point(338, 182);
			this.txt_User.Name = "txt_User";
			this.txt_User.Size = new System.Drawing.Size(169, 22);
			this.txt_User.TabIndex = 3;
			// 
			// txt_Pass
			// 
			this.txt_Pass.Location = new System.Drawing.Point(338, 225);
			this.txt_Pass.Name = "txt_Pass";
			this.txt_Pass.Size = new System.Drawing.Size(169, 22);
			this.txt_Pass.TabIndex = 4;
			// 
			// btn_SignIn
			// 
			this.btn_SignIn.Location = new System.Drawing.Point(356, 284);
			this.btn_SignIn.Name = "btn_SignIn";
			this.btn_SignIn.Size = new System.Drawing.Size(75, 28);
			this.btn_SignIn.TabIndex = 5;
			this.btn_SignIn.Text = "Sign In";
			this.btn_SignIn.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btn_SignIn);
			this.Controls.Add(this.txt_Pass);
			this.Controls.Add(this.txt_User);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_User;
		private System.Windows.Forms.TextBox txt_Pass;
		private System.Windows.Forms.Button btn_SignIn;
	}
}

