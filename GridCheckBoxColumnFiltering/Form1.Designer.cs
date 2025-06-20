namespace SfDataGrid_Demo_4_8
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
            this.sfDataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.AllowFiltering = new System.Windows.Forms.CheckBox();
            this.textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sfDataGrid1
            // 
            this.sfDataGrid.AccessibleName = "Table";
            this.sfDataGrid.Location = new System.Drawing.Point(71, 60);
            this.sfDataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sfDataGrid.Name = "sfDataGrid1";
            this.sfDataGrid.PreviewRowHeight = 35;
            this.sfDataGrid.Size = new System.Drawing.Size(773, 551);
            this.sfDataGrid.TabIndex = 0;
            this.sfDataGrid.Text = "sfDataGrid1";
            // 
            // groupBox1
            // 
            this.groupBox.Controls.Add(this.AllowFiltering);
            this.groupBox.Controls.Add(this.textBox);
            this.groupBox.Location = new System.Drawing.Point(899, 100);
            this.groupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox.Name = "groupBox1";
            this.groupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox.Size = new System.Drawing.Size(342, 189);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Search";
            // 
            // AllowFiltering
            // 
            this.AllowFiltering.AutoSize = true;
            this.AllowFiltering.Location = new System.Drawing.Point(21, 96);
            this.AllowFiltering.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AllowFiltering.Name = "AllowFiltering";
            this.AllowFiltering.Size = new System.Drawing.Size(128, 24);
            this.AllowFiltering.TabIndex = 1;
            this.AllowFiltering.Text = "AllowFiltering";
            this.AllowFiltering.UseVisualStyleBackColor = true;
            this.AllowFiltering.CheckStateChanged += OnCheckStateChanged;
            // 
            // textBox1
            // 
            this.textBox.Location = new System.Drawing.Point(21, 42);
            this.textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox.Name = "textBox1";
            this.textBox.Size = new System.Drawing.Size(112, 26);
            this.textBox.TabIndex = 0;
            this.textBox.TextChanged += OnTextChanged;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1653, 789);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.sfDataGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "SearchingandFiltering";
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.CheckBox AllowFiltering;
    }
}

