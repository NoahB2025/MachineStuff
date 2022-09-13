
namespace MachineApp
{
	partial class ItemRemovedSuccessfully
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
			this.btn_CloseRemoveSuccessWindow = new MetroFramework.Controls.MetroButton();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.SuspendLayout();
			// 
			// btn_CloseRemoveSuccessWindow
			// 
			this.btn_CloseRemoveSuccessWindow.Location = new System.Drawing.Point(362, 240);
			this.btn_CloseRemoveSuccessWindow.Name = "btn_CloseRemoveSuccessWindow";
			this.btn_CloseRemoveSuccessWindow.Size = new System.Drawing.Size(75, 23);
			this.btn_CloseRemoveSuccessWindow.TabIndex = 1;
			this.btn_CloseRemoveSuccessWindow.Text = "Close";
			this.btn_CloseRemoveSuccessWindow.UseSelectable = true;
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(314, 161);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(176, 20);
			this.metroLabel1.TabIndex = 2;
			this.metroLabel1.Text = "item successfully removed.";
			// 
			// ItemRemovedSuccessfully
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.btn_CloseRemoveSuccessWindow);
			this.Name = "ItemRemovedSuccessfully";
			this.Text = "ItemRemovedSuccessfully";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private MetroFramework.Controls.MetroButton btn_CloseRemoveSuccessWindow;
		private MetroFramework.Controls.MetroLabel metroLabel1;
	}
}