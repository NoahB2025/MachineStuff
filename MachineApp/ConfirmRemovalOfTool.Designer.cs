
namespace MachineApp
{
	partial class ConfirmRemovalOfTool
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
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.btn_YesRemoveTool = new MetroFramework.Controls.MetroButton();
			this.btn_NoDontRemoveTool = new MetroFramework.Controls.MetroButton();
			this.SuspendLayout();
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(204, 161);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(312, 20);
			this.metroLabel1.TabIndex = 0;
			this.metroLabel1.Text = "Are you sure you would like to remove this item?";
			// 
			// btn_YesRemoveTool
			// 
			this.btn_YesRemoveTool.Location = new System.Drawing.Point(257, 240);
			this.btn_YesRemoveTool.Name = "btn_YesRemoveTool";
			this.btn_YesRemoveTool.Size = new System.Drawing.Size(75, 23);
			this.btn_YesRemoveTool.TabIndex = 1;
			this.btn_YesRemoveTool.Text = "Yes";
			this.btn_YesRemoveTool.UseSelectable = true;
			// 
			// btn_NoDontRemoveTool
			// 
			this.btn_NoDontRemoveTool.Location = new System.Drawing.Point(396, 240);
			this.btn_NoDontRemoveTool.Name = "btn_NoDontRemoveTool";
			this.btn_NoDontRemoveTool.Size = new System.Drawing.Size(75, 23);
			this.btn_NoDontRemoveTool.TabIndex = 2;
			this.btn_NoDontRemoveTool.Text = "No";
			this.btn_NoDontRemoveTool.UseSelectable = true;
			// 
			// ConfirmRemovalOfTool
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btn_NoDontRemoveTool);
			this.Controls.Add(this.btn_YesRemoveTool);
			this.Controls.Add(this.metroLabel1);
			this.Name = "ConfirmRemovalOfTool";
			this.Text = "ConfirmRemovalOfTool";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroButton btn_YesRemoveTool;
		private MetroFramework.Controls.MetroButton btn_NoDontRemoveTool;
	}
}