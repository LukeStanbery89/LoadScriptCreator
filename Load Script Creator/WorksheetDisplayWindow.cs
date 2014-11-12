using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.Office.Interop.Excel;

namespace Load_Script_Creator {
    public partial class WorksheetDisplayWindow : Form {
        private string filePath;
        List<string> worksheetNameList = new List<string>();
        Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
        Microsoft.Office.Interop.Excel.Workbook wkb = null;

        public WorksheetDisplayWindow(string p) {
            InitializeComponent();
            filePath = p;

            // Read worksheet names from Excel file
            wkb = app.Workbooks.Open(p);

            foreach (Worksheet w in wkb.Worksheets) {
                try {
                    //Console.WriteLine(w.Name);
                    worksheetNameList.Add(w.Name);
                } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            }

            // Close Excel
            wkb.Close();

            using (WorksheetSelectionBox wsb = new WorksheetSelectionBox(worksheetNameList)) {
                wsb.ShowDialog();
                if (wsb.DialogResult == DialogResult.OK) {
                    string worksheetName = wsb.selection;
                    //Console.WriteLine("Worksheet name is " + worksheetName);

                    String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                        filePath + ";Extended Properties='Excel 12.0 XML;HDR=YES;';";

                    using (OleDbConnection con = new OleDbConnection(constr)) {
                        OleDbCommand oconn = new OleDbCommand("SELECT * FROM [" + worksheetName + "$]", con);
                        con.Open();

                        OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
                        System.Data.DataTable data = new System.Data.DataTable();
                        sda.Fill(data);
                        dataGridView_worksheetItems.DataSource = data;
                    }

                    foreach (DataGridViewColumn column in dataGridView_worksheetItems.Columns) {
                        column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                    dataGridView_worksheetItems.SelectionMode = DataGridViewSelectionMode.CellSelect;
                }
            }
        }

        // Destructor
        ~WorksheetDisplayWindow() {
            if (wkb != null) {
                wkb.Close();
            }
        }

        private void dataGridView_worksheetItems_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.ColumnIndex == 0 && e.RowIndex != 0) {
                dataGridView_worksheetItems.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;
                if(e.Button == MouseButtons.Right)
                // TODO: Show context menu
                contextMenuStrip_columnHeaderClick.Show();
            }
            if (e.ColumnIndex != 0 && e.RowIndex == 0) {
                dataGridView_worksheetItems.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
                // TODO: Show context menu
                contextMenuStrip_rowHeaderClick.Show();
            } else {
                dataGridView_worksheetItems.SelectionMode = DataGridViewSelectionMode.CellSelect;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            // TODO: Make this button do something
        }

        private void deleteColumnToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("WOW!");
        }

        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Holy cow!");
        }
    }
}
