
namespace MachineApp
{
    partial class Search
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
            this.btn_search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolCategory_txt = new System.Windows.Forms.TextBox();
            this.toolName_txt = new System.Windows.Forms.TextBox();
            this.toolID_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(202, 202);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tool Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tool Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tool ID";
            // 
            // toolCategory_txt
            // 
            this.toolCategory_txt.Location = new System.Drawing.Point(137, 72);
            this.toolCategory_txt.Name = "toolCategory_txt";
            this.toolCategory_txt.Size = new System.Drawing.Size(140, 20);
            this.toolCategory_txt.TabIndex = 5;
            // 
            // toolName_txt
            // 
            this.toolName_txt.Location = new System.Drawing.Point(137, 104);
            this.toolName_txt.Name = "toolName_txt";
            this.toolName_txt.Size = new System.Drawing.Size(140, 20);
            this.toolName_txt.TabIndex = 6;
            // 
            // toolID_txt
            // 
            this.toolID_txt.Location = new System.Drawing.Point(137, 140);
            this.toolID_txt.Name = "toolID_txt";
            this.toolID_txt.Size = new System.Drawing.Size(140, 20);
            this.toolID_txt.TabIndex = 7;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 270);
            this.Controls.Add(this.toolID_txt);
            this.Controls.Add(this.toolName_txt);
            this.Controls.Add(this.toolCategory_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_search);
            this.Name = "Search";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox toolCategory_txt;
        private System.Windows.Forms.TextBox toolName_txt;
        private System.Windows.Forms.TextBox toolID_txt;
    }
}

