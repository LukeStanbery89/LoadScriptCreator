using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Load_Script_Creator {
    public partial class WorksheetSelectionBox : Form {
        private string _selection;

        public string selection {
            get {
                return _selection;
            }
        }

        public WorksheetSelectionBox(List<string> worksheetNames) {
            InitializeComponent();

            comboBox_worksheetSelection.DataSource = worksheetNames;
        }

        private void button_cancelWorksheetSelection_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void button_submitWorksheetSelection_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            _selection = comboBox_worksheetSelection.Text;
        }
    }
}
