Namespace XtraPivotGrid_SortedFilterItems
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim fieldInfo1 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo2 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo3 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo4 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo5 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo6 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo7 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo8 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo9 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo10 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo11 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo12 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim excelWorksheetSettings1 As New DevExpress.DataAccess.Excel.ExcelWorksheetSettings()
			Dim excelSourceOptions1 As New DevExpress.DataAccess.Excel.ExcelSourceOptions(excelWorksheetSettings1)
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.rbCaptionLength = New System.Windows.Forms.RadioButton()
			Me.rbAlphabeticalSort = New System.Windows.Forms.RadioButton()
			Me.excelDataSource1 = New DevExpress.DataAccess.Excel.ExcelDataSource()
			Me.fieldProductName1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldSalesPerson1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldExtendedPrice1 = New DevExpress.XtraPivotGrid.PivotGridField()
			DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.pivotGridControl1.DataSource = Me.excelDataSource1
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldProductName1, Me.fieldSalesPerson1, Me.fieldExtendedPrice1})
			Me.pivotGridControl1.Location = New System.Drawing.Point(12, 85)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.Size = New System.Drawing.Size(528, 464)
			Me.pivotGridControl1.TabIndex = 0
			' 
			' groupBox1
			' 
			Me.groupBox1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.groupBox1.Controls.Add(Me.rbCaptionLength)
			Me.groupBox1.Controls.Add(Me.rbAlphabeticalSort)
			Me.groupBox1.Location = New System.Drawing.Point(13, 13)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(527, 66)
			Me.groupBox1.TabIndex = 1
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Sort Filter Items"
			' 
			' rbCaptionLength
			' 
			Me.rbCaptionLength.AutoSize = True
			Me.rbCaptionLength.Location = New System.Drawing.Point(7, 43)
			Me.rbCaptionLength.Name = "rbCaptionLength"
			Me.rbCaptionLength.Size = New System.Drawing.Size(113, 17)
			Me.rbCaptionLength.TabIndex = 1
			Me.rbCaptionLength.TabStop = True
			Me.rbCaptionLength.Text = "By Caption Length"
			Me.rbCaptionLength.UseVisualStyleBackColor = True
			' 
			' rbAlphabeticalSort
			' 
			Me.rbAlphabeticalSort.AutoSize = True
			Me.rbAlphabeticalSort.Checked = True
			Me.rbAlphabeticalSort.Location = New System.Drawing.Point(7, 20)
			Me.rbAlphabeticalSort.Name = "rbAlphabeticalSort"
			Me.rbAlphabeticalSort.Size = New System.Drawing.Size(91, 17)
			Me.rbAlphabeticalSort.TabIndex = 0
			Me.rbAlphabeticalSort.TabStop = True
			Me.rbAlphabeticalSort.Text = "Alphabetically"
			Me.rbAlphabeticalSort.UseVisualStyleBackColor = True
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.rbAlphabeticalSort.CheckedChanged += new System.EventHandler(this.rbAlphabeticalSort_CheckedChanged);
			' 
			' excelDataSource1
			' 
			Me.excelDataSource1.Name = "excelDataSource1"
			Me.excelDataSource1.ResultSchemaSerializable = resources.GetString("excelDataSource1.ResultSchemaSerializable")
			fieldInfo1.Name = "CategoryName"
			fieldInfo1.Type = GetType(String)
			fieldInfo2.Name = "Country"
			fieldInfo2.Type = GetType(String)
			fieldInfo3.Name = "FirstName"
			fieldInfo3.Type = GetType(String)
			fieldInfo4.Name = "LastName"
			fieldInfo4.Type = GetType(String)
			fieldInfo5.Name = "ProductName"
			fieldInfo5.Type = GetType(String)
			fieldInfo6.Name = "Sales Person"
			fieldInfo6.Type = GetType(String)
			fieldInfo7.Name = "OrderDate"
			fieldInfo7.Type = GetType(Date)
			fieldInfo8.Name = "OrderID"
			fieldInfo8.Type = GetType(Double)
			fieldInfo9.Name = "Quantity"
			fieldInfo9.Type = GetType(Double)
			fieldInfo10.Name = "Discount"
			fieldInfo10.Type = GetType(Double)
			fieldInfo11.Name = "Extended Price"
			fieldInfo11.Type = GetType(Double)
			fieldInfo12.Name = "UnitPrice"
			fieldInfo12.Type = GetType(Double)
			Me.excelDataSource1.Schema.AddRange(New DevExpress.DataAccess.Excel.FieldInfo() { fieldInfo1, fieldInfo2, fieldInfo3, fieldInfo4, fieldInfo5, fieldInfo6, fieldInfo7, fieldInfo8, fieldInfo9, fieldInfo10, fieldInfo11, fieldInfo12})
			excelWorksheetSettings1.CellRange = Nothing
			excelWorksheetSettings1.WorksheetName = "Data"
			excelSourceOptions1.ImportSettings = excelWorksheetSettings1
			Me.excelDataSource1.SourceOptions = excelSourceOptions1
			' 
			' fieldProductName1
			' 
			Me.fieldProductName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldProductName1.AreaIndex = 0
			Me.fieldProductName1.Caption = "Product Name"
			Me.fieldProductName1.FieldName = "ProductName"
			Me.fieldProductName1.Name = "fieldProductName1"
			' 
			' fieldSalesPerson1
			' 
			Me.fieldSalesPerson1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldSalesPerson1.AreaIndex = 0
			Me.fieldSalesPerson1.Caption = "Sales Person"
			Me.fieldSalesPerson1.FieldName = "Sales Person"
			Me.fieldSalesPerson1.Name = "fieldSalesPerson1"
			' 
			' fieldExtendedPrice1
			' 
			Me.fieldExtendedPrice1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldExtendedPrice1.AreaIndex = 0
			Me.fieldExtendedPrice1.Caption = "Extended Price"
			Me.fieldExtendedPrice1.FieldName = "Extended Price"
			Me.fieldExtendedPrice1.Name = "fieldExtendedPrice1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(552, 561)
			Me.Controls.Add(Me.groupBox1)
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Name = "Form1"
			Me.Text = "Ordered Items in a Filter DropDown List"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.Form1_Load);
			DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private rbCaptionLength As System.Windows.Forms.RadioButton
		Private WithEvents rbAlphabeticalSort As System.Windows.Forms.RadioButton
		Private excelDataSource1 As DevExpress.DataAccess.Excel.ExcelDataSource
		Private fieldProductName1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldSalesPerson1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldExtendedPrice1 As DevExpress.XtraPivotGrid.PivotGridField
	End Class
End Namespace

