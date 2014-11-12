using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Load_Script_Creator {
    public partial class MainWindow : Form {
        // Globals
        private string incompleteFieldColor = "#FF8080";
        private string filePath;

        public MainWindow() {
            InitializeComponent();
        }

        // Click exit button
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        /// <summary>
        /// Turns an incomplete textbox red. This is used to indicate to the user that they need to key data into this field.
        /// </summary>
        private void UpdateIncompleteTextFieldBackColor(TextBox tb, string color) {


            if (tb.Text != "") {
                tb.BackColor = SystemColors.Window;
            } else {
                tb.BackColor = ColorTranslator.FromHtml(color);
            }
        }

        // Event for leaving the DB name box
        private void textBox_dbName_Leave(object sender, EventArgs e) {
            textBox_dbName.Text = textBox_dbName.Text.ToLower();
            UpdateIncompleteTextFieldBackColor(textBox_dbName, incompleteFieldColor);
        }

        // Event for leaving the Server name box
        private void textBox_server_Leave(object sender, EventArgs e) {
            textBox_server.Text = textBox_server.Text.ToLower();
            UpdateIncompleteTextFieldBackColor(textBox_server, incompleteFieldColor);
        }

        // Event for leaving the evt_uid box
        private void textBox_evtUid_Leave(object sender, EventArgs e) {
            UpdateIncompleteTextFieldBackColor(textBox_evtUid, incompleteFieldColor);
        }

        // Click the browse button to select an Excel workbook
        private void button_browse_Click(object sender, EventArgs e) {
            using (OpenFileDialog ofd = new OpenFileDialog()) {
                ofd.Title = "Open Excel Worksheet";
                ofd.Filter = "Excel Files|*.xls;*.xlsx|All Files|*.*";
                if (ofd.ShowDialog() == DialogResult.OK) {
                    textBox_filePath.Text = filePath = ofd.FileName;
                }
            }
        }

        // User clicks the Gengerate Script button
        private void button_importWorksheet_Click(object sender, EventArgs e) {
            if (textBox_dbName.Text != "" && textBox_evtUid.Text != "" && textBox_server.Text != "") {
                // TODO: Write code to import Excel worksheet data
                if (filePath == "" || filePath == null) {
                    MessageBox.Show("Please select an Excel worksheet.", "No Excel Worksheet Selected!");
                } else {
                    using (WorksheetDisplayWindow f2 = new WorksheetDisplayWindow(filePath)) {
                        f2.ShowDialog();
                    }
                }
            } else {
                MessageBox.Show("Please fill out all fields before proceeding.", "Missing required fields!");
                // Update control back colors
                if (textBox_server.Text == "") {
                    textBox_server.BackColor = ColorTranslator.FromHtml(incompleteFieldColor);
                }
                if (textBox_evtUid.Text == "") {
                    textBox_evtUid.BackColor = ColorTranslator.FromHtml(incompleteFieldColor);
                }
                if (textBox_dbName.Text == "") {
                    textBox_dbName.BackColor = ColorTranslator.FromHtml(incompleteFieldColor);
                }
            }


        }
    }
}
