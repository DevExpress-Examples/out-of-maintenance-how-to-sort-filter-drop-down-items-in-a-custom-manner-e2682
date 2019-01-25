Namespace XtraPivotGrid_ExampleTemplate
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
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.fieldYear = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldProductSales = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.rbCaptionLength = New System.Windows.Forms.RadioButton()
			Me.rbAlphabeticalSort = New System.Windows.Forms.RadioButton()
			DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldYear, Me.fieldProductName, Me.fieldProductSales})
			Me.pivotGridControl1.Location = New System.Drawing.Point(12, 85)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.Size = New System.Drawing.Size(520, 464)
			Me.pivotGridControl1.TabIndex = 0
			' 
			' fieldYear
			' 
			Me.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldYear.AreaIndex = 0
			Me.fieldYear.Caption = "Year"
			Me.fieldYear.FieldName = "ShippedDate"
			Me.fieldYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
			Me.fieldYear.Name = "fieldYear"
			Me.fieldYear.UnboundFieldName = "fieldYear"
			' 
			' fieldProductName
			' 
			Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldProductName.AreaIndex = 0
			Me.fieldProductName.Caption = "Product Name"
			Me.fieldProductName.FieldName = "ProductName"
			Me.fieldProductName.Name = "fieldProductName"
			' 
			' fieldProductSales
			' 
			Me.fieldProductSales.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldProductSales.AreaIndex = 0
			Me.fieldProductSales.Caption = "Sales"
			Me.fieldProductSales.FieldName = "ProductSales"
			Me.fieldProductSales.Name = "fieldProductSales"
			' 
			' groupBox1
			' 
			Me.groupBox1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.groupBox1.Controls.Add(Me.rbCaptionLength)
			Me.groupBox1.Controls.Add(Me.rbAlphabeticalSort)
			Me.groupBox1.Location = New System.Drawing.Point(13, 13)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(519, 66)
			Me.groupBox1.TabIndex = 1
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Sort Filter Items"
			' 
			' rbCaptionLength
			' 
			Me.rbCaptionLength.AutoSize = True
			Me.rbCaptionLength.Location = New System.Drawing.Point(7, 43)
			Me.rbCaptionLength.Name = "rbCaptionLength"
			Me.rbCaptionLength.Size = New System.Drawing.Size(112, 17)
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
			Me.rbAlphabeticalSort.Size = New System.Drawing.Size(90, 17)
			Me.rbAlphabeticalSort.TabIndex = 0
			Me.rbAlphabeticalSort.TabStop = True
			Me.rbAlphabeticalSort.Text = "Alphabetically"
			Me.rbAlphabeticalSort.UseVisualStyleBackColor = True
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.rbAlphabeticalSort.CheckedChanged += new System.EventHandler(this.rbAlphabeticalSort_CheckedChanged);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(544, 561)
			Me.Controls.Add(Me.groupBox1)
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.Form1_Load);
			DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private fieldYear As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldProductName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldProductSales As DevExpress.XtraPivotGrid.PivotGridField
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private rbCaptionLength As System.Windows.Forms.RadioButton
		Private WithEvents rbAlphabeticalSort As System.Windows.Forms.RadioButton
	End Class
End Namespace

