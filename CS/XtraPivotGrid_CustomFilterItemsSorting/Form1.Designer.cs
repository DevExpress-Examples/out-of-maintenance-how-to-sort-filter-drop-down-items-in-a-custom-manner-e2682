namespace XtraPivotGrid_ExampleTemplate {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductSales = new DevExpress.XtraPivotGrid.PivotGridField();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCaptionLength = new System.Windows.Forms.RadioButton();
            this.rbAlphabeticalSort = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldYear,
            this.fieldProductName,
            this.fieldProductSales});
            this.pivotGridControl1.Location = new System.Drawing.Point(12, 85);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(520, 464);
            this.pivotGridControl1.TabIndex = 0;
            this.pivotGridControl1.CustomFilterPopupItems += new DevExpress.XtraPivotGrid.PivotCustomFilterPopupItemsEventHandler(this.pivotGridControl1_CustomFilterPopupItems);
            // 
            // fieldYear
            // 
            this.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldYear.AreaIndex = 0;
            this.fieldYear.Caption = "Year";
            this.fieldYear.FieldName = "ShippedDate";
            this.fieldYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldYear.Name = "fieldYear";
            this.fieldYear.UnboundFieldName = "fieldYear";
            // 
            // fieldProductName
            // 
            this.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProductName.AreaIndex = 0;
            this.fieldProductName.Caption = "Product Name";
            this.fieldProductName.FieldName = "ProductName";
            this.fieldProductName.Name = "fieldProductName";
            // 
            // fieldProductSales
            // 
            this.fieldProductSales.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldProductSales.AreaIndex = 0;
            this.fieldProductSales.Caption = "Sales";
            this.fieldProductSales.FieldName = "ProductSales";
            this.fieldProductSales.Name = "fieldProductSales";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rbCaptionLength);
            this.groupBox1.Controls.Add(this.rbAlphabeticalSort);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 66);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort Filter Items";
            // 
            // rbCaptionLength
            // 
            this.rbCaptionLength.AutoSize = true;
            this.rbCaptionLength.Location = new System.Drawing.Point(7, 43);
            this.rbCaptionLength.Name = "rbCaptionLength";
            this.rbCaptionLength.Size = new System.Drawing.Size(112, 17);
            this.rbCaptionLength.TabIndex = 1;
            this.rbCaptionLength.TabStop = true;
            this.rbCaptionLength.Text = "By Caption Length";
            this.rbCaptionLength.UseVisualStyleBackColor = true;
            // 
            // rbAlphabeticalSort
            // 
            this.rbAlphabeticalSort.AutoSize = true;
            this.rbAlphabeticalSort.Checked = true;
            this.rbAlphabeticalSort.Location = new System.Drawing.Point(7, 20);
            this.rbAlphabeticalSort.Name = "rbAlphabeticalSort";
            this.rbAlphabeticalSort.Size = new System.Drawing.Size(90, 17);
            this.rbAlphabeticalSort.TabIndex = 0;
            this.rbAlphabeticalSort.TabStop = true;
            this.rbAlphabeticalSort.Text = "Alphabetically";
            this.rbAlphabeticalSort.UseVisualStyleBackColor = true;
            this.rbAlphabeticalSort.CheckedChanged += new System.EventHandler(this.rbAlphabeticalSort_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldYear;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductSales;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCaptionLength;
        private System.Windows.Forms.RadioButton rbAlphabeticalSort;
    }
}

