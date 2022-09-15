
namespace MachineApp
{
    partial class InventoryForm
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
            this.components = new System.ComponentModel.Container();
            this.InventoryList = new System.Windows.Forms.ListBox();
            this.btnSignin = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbCategorize = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSignout = new System.Windows.Forms.Button();
            this.btnCheckedout = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hafsayDataSet = new MachineApp.hafsayDataSet();
            this.toolTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolTblTableAdapter = new MachineApp.hafsayDataSetTableAdapters.toolTblTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imperialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metricDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_displayAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hafsayDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // InventoryList
            // 
            this.InventoryList.FormattingEnabled = true;
            this.InventoryList.ItemHeight = 16;
            this.InventoryList.Location = new System.Drawing.Point(66, 123);
            this.InventoryList.Name = "InventoryList";
            this.InventoryList.Size = new System.Drawing.Size(953, 292);
            this.InventoryList.TabIndex = 1;
            // 
            // btnSignin
            // 
            this.btnSignin.Location = new System.Drawing.Point(66, 439);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(107, 34);
            this.btnSignin.TabIndex = 2;
            this.btnSignin.Text = "Sign in";
            this.btnSignin.UseVisualStyleBackColor = true;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(751, 43);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 34);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // cbCategorize
            // 
            this.cbCategorize.FormattingEnabled = true;
            this.cbCategorize.Items.AddRange(new object[] {
            "Tool Name",
            "Category"});
            this.cbCategorize.Location = new System.Drawing.Point(886, 49);
            this.cbCategorize.Name = "cbCategorize";
            this.cbCategorize.Size = new System.Drawing.Size(133, 24);
            this.cbCategorize.TabIndex = 4;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(912, 439);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(107, 34);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(613, 439);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(107, 34);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(361, 439);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 34);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(491, 439);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(107, 34);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSignout
            // 
            this.btnSignout.Location = new System.Drawing.Point(66, 439);
            this.btnSignout.Name = "btnSignout";
            this.btnSignout.Size = new System.Drawing.Size(107, 34);
            this.btnSignout.TabIndex = 9;
            this.btnSignout.Text = "Sign out";
            this.btnSignout.UseVisualStyleBackColor = true;
            this.btnSignout.Click += new System.EventHandler(this.btnSignout_Click);
            // 
            // btnCheckedout
            // 
            this.btnCheckedout.Location = new System.Drawing.Point(627, 43);
            this.btnCheckedout.Name = "btnCheckedout";
            this.btnCheckedout.Size = new System.Drawing.Size(107, 34);
            this.btnCheckedout.TabIndex = 10;
            this.btnCheckedout.Text = "Checked-out";
            this.btnCheckedout.UseVisualStyleBackColor = true;
            this.btnCheckedout.Click += new System.EventHandler(this.btnCheckedout_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.imperialDataGridViewTextBoxColumn,
            this.metricDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.categoryIdDataGridViewTextBoxColumn,
            this.programIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.toolTblBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(74, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(945, 181);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // hafsayDataSet
            // 
            this.hafsayDataSet.DataSetName = "hafsayDataSet";
            this.hafsayDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolTblBindingSource
            // 
            this.toolTblBindingSource.DataMember = "toolTbl";
            this.toolTblBindingSource.DataSource = this.hafsayDataSet;
            // 
            // toolTblTableAdapter
            // 
            this.toolTblTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // imperialDataGridViewTextBoxColumn
            // 
            this.imperialDataGridViewTextBoxColumn.DataPropertyName = "imperial";
            this.imperialDataGridViewTextBoxColumn.HeaderText = "imperial";
            this.imperialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imperialDataGridViewTextBoxColumn.Name = "imperialDataGridViewTextBoxColumn";
            this.imperialDataGridViewTextBoxColumn.Width = 125;
            // 
            // metricDataGridViewTextBoxColumn
            // 
            this.metricDataGridViewTextBoxColumn.DataPropertyName = "metric";
            this.metricDataGridViewTextBoxColumn.HeaderText = "metric";
            this.metricDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.metricDataGridViewTextBoxColumn.Name = "metricDataGridViewTextBoxColumn";
            this.metricDataGridViewTextBoxColumn.Width = 125;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "qty";
            this.qtyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            this.categoryIdDataGridViewTextBoxColumn.DataPropertyName = "categoryId";
            this.categoryIdDataGridViewTextBoxColumn.HeaderText = "categoryId";
            this.categoryIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            this.categoryIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // programIdDataGridViewTextBoxColumn
            // 
            this.programIdDataGridViewTextBoxColumn.DataPropertyName = "programId";
            this.programIdDataGridViewTextBoxColumn.HeaderText = "programId";
            this.programIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.programIdDataGridViewTextBoxColumn.Name = "programIdDataGridViewTextBoxColumn";
            this.programIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // btn_displayAll
            // 
            this.btn_displayAll.Location = new System.Drawing.Point(254, 148);
            this.btn_displayAll.Name = "btn_displayAll";
            this.btn_displayAll.Size = new System.Drawing.Size(301, 23);
            this.btn_displayAll.TabIndex = 12;
            this.btn_displayAll.Text = "Display Inventory Data";
            this.btn_displayAll.UseVisualStyleBackColor = true;
            this.btn_displayAll.Click += new System.EventHandler(this.btn_displayAll_Click);
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 512);
            this.Controls.Add(this.btn_displayAll);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCheckedout);
            this.Controls.Add(this.btnSignout);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cbCategorize);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSignin);
            this.Controls.Add(this.InventoryList);
            this.Name = "InventoryForm";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hafsayDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTblBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox InventoryList;
        private System.Windows.Forms.Button btnSignin;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbCategorize;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSignout;
        private System.Windows.Forms.Button btnCheckedout;
        private System.Windows.Forms.DataGridView dataGridView1;
        private hafsayDataSet hafsayDataSet;
        private System.Windows.Forms.BindingSource toolTblBindingSource;
        private hafsayDataSetTableAdapters.toolTblTableAdapter toolTblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imperialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metricDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn programIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_displayAll;
    }
}

