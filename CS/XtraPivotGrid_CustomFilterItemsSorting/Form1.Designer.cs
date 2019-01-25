namespace XtraPivotGrid_SortedFilterItems {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo1 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo2 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo3 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo4 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo5 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo6 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo7 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo8 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo9 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo10 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo11 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo12 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.ExcelWorksheetSettings excelWorksheetSettings1 = new DevExpress.DataAccess.Excel.ExcelWorksheetSettings();
            DevExpress.DataAccess.Excel.ExcelSourceOptions excelSourceOptions1 = new DevExpress.DataAccess.Excel.ExcelSourceOptions(excelWorksheetSettings1);
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCaptionLength = new System.Windows.Forms.RadioButton();
            this.rbAlphabeticalSort = new System.Windows.Forms.RadioButton();
            this.excelDataSource1 = new DevExpress.DataAccess.Excel.ExcelDataSource();
            this.fieldProductName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSalesPerson1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldExtendedPrice1 = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pivotGridControl1.DataSource = this.excelDataSource1;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldProductName1,
            this.fieldSalesPerson1,
            this.fieldExtendedPrice1});
            this.pivotGridControl1.Location = new System.Drawing.Point(12, 85);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(528, 464);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rbCaptionLength);
            this.groupBox1.Controls.Add(this.rbAlphabeticalSort);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 66);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort Filter Items";
            // 
            // rbCaptionLength
            // 
            this.rbCaptionLength.AutoSize = true;
            this.rbCaptionLength.Location = new System.Drawing.Point(7, 43);
            this.rbCaptionLength.Name = "rbCaptionLength";
            this.rbCaptionLength.Size = new System.Drawing.Size(113, 17);
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
            this.rbAlphabeticalSort.Size = new System.Drawing.Size(91, 17);
            this.rbAlphabeticalSort.TabIndex = 0;
            this.rbAlphabeticalSort.TabStop = true;
            this.rbAlphabeticalSort.Text = "Alphabetically";
            this.rbAlphabeticalSort.UseVisualStyleBackColor = true;
            this.rbAlphabeticalSort.CheckedChanged += new System.EventHandler(this.rbAlphabeticalSort_CheckedChanged);
            // 
            // excelDataSource1
            // 
            this.excelDataSource1.Name = "excelDataSource1";
            this.excelDataSource1.ResultSchemaSerializable = resources.GetString("excelDataSource1.ResultSchemaSerializable");
            fieldInfo1.Name = "CategoryName";
            fieldInfo1.Type = typeof(string);
            fieldInfo2.Name = "Country";
            fieldInfo2.Type = typeof(string);
            fieldInfo3.Name = "FirstName";
            fieldInfo3.Type = typeof(string);
            fieldInfo4.Name = "LastName";
            fieldInfo4.Type = typeof(string);
            fieldInfo5.Name = "ProductName";
            fieldInfo5.Type = typeof(string);
            fieldInfo6.Name = "Sales Person";
            fieldInfo6.Type = typeof(string);
            fieldInfo7.Name = "OrderDate";
            fieldInfo7.Type = typeof(System.DateTime);
            fieldInfo8.Name = "OrderID";
            fieldInfo8.Type = typeof(double);
            fieldInfo9.Name = "Quantity";
            fieldInfo9.Type = typeof(double);
            fieldInfo10.Name = "Discount";
            fieldInfo10.Type = typeof(double);
            fieldInfo11.Name = "Extended Price";
            fieldInfo11.Type = typeof(double);
            fieldInfo12.Name = "UnitPrice";
            fieldInfo12.Type = typeof(double);
            this.excelDataSource1.Schema.AddRange(new DevExpress.DataAccess.Excel.FieldInfo[] {
            fieldInfo1,
            fieldInfo2,
            fieldInfo3,
            fieldInfo4,
            fieldInfo5,
            fieldInfo6,
            fieldInfo7,
            fieldInfo8,
            fieldInfo9,
            fieldInfo10,
            fieldInfo11,
            fieldInfo12});
            excelWorksheetSettings1.CellRange = null;
            excelWorksheetSettings1.WorksheetName = "Data";
            excelSourceOptions1.ImportSettings = excelWorksheetSettings1;
            this.excelDataSource1.SourceOptions = excelSourceOptions1;
            // 
            // fieldProductName1
            // 
            this.fieldProductName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProductName1.AreaIndex = 0;
            this.fieldProductName1.Caption = "Product Name";
            this.fieldProductName1.FieldName = "ProductName";
            this.fieldProductName1.Name = "fieldProductName1";
            // 
            // fieldSalesPerson1
            // 
            this.fieldSalesPerson1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldSalesPerson1.AreaIndex = 0;
            this.fieldSalesPerson1.Caption = "Sales Person";
            this.fieldSalesPerson1.FieldName = "Sales Person";
            this.fieldSalesPerson1.Name = "fieldSalesPerson1";
            // 
            // fieldExtendedPrice1
            // 
            this.fieldExtendedPrice1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldExtendedPrice1.AreaIndex = 0;
            this.fieldExtendedPrice1.Caption = "Extended Price";
            this.fieldExtendedPrice1.FieldName = "Extended Price";
            this.fieldExtendedPrice1.Name = "fieldExtendedPrice1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "Form1";
            this.Text = "Ordered Items in a Filter DropDown List";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCaptionLength;
        private System.Windows.Forms.RadioButton rbAlphabeticalSort;
        private DevExpress.DataAccess.Excel.ExcelDataSource excelDataSource1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSalesPerson1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldExtendedPrice1;
    }
}

