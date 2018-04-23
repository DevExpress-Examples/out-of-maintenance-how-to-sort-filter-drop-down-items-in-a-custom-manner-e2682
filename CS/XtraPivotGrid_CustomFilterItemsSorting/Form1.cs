using System;
using System.Collections;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraPivotGrid.Data;

namespace XtraPivotGrid_ExampleTemplate {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            DataSet1TableAdapters.ProductReportsTableAdapter tableAdapter =
                new DataSet1TableAdapters.ProductReportsTableAdapter();
            pivotGridControl1.DataSource = tableAdapter.GetData();
            pivotGridControl1.BestFit();
        }
        private void pivotGridControl1_CustomFilterPopupItems(object sender, 
            PivotCustomFilterPopupItemsEventArgs e) {
            if(rbCaptionLength.Checked)
                ArrayList.Adapter((IList)e.Items).Sort(new FilterItemsComparer());
        }
        private void rbAlphabeticalSort_CheckedChanged(object sender, EventArgs e) {
            fieldProductName.ShowFilterPopup();
        }
    }
    public class FilterItemsComparer : IComparer {
        int IComparer.Compare(object x, object y) {
            if (!(x is PivotGridFilterItem) || !(y is PivotGridFilterItem)) return 0;
            PivotGridFilterItem item1 = (PivotGridFilterItem)x;
            PivotGridFilterItem item2 = (PivotGridFilterItem)y;
            if (item1.ToString().Length == item2.ToString().Length) return 0;
            if (item1.ToString().Length > item2.ToString().Length) return 1;
            return -1;
        }
    }
}