namespace Load_Script_Creator {
    partial class WorksheetSelectionBox {
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_worksheetSelection = new System.Windows.Forms.ComboBox();
            this.button_submitWorksheetSelection = new System.Windows.Forms.Button();
            this.button_cancelWorksheetSelection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Which worksheet would you like to import?";
            // 
            // comboBox_worksheetSelection
            // 
            this.comboBox_worksheetSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_worksheetSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_worksheetSelection.FormattingEnabled = true;
            this.comboBox_worksheetSelection.Location = new System.Drawing.Point(15, 38);
            this.comboBox_worksheetSelection.Name = "comboBox_worksheetSelection";
            this.comboBox_worksheetSelection.Size = new System.Drawing.Size(206, 21);
            this.comboBox_worksheetSelection.Sorted = true;
            this.comboBox_worksheetSelection.TabIndex = 1;
            // 
            // button_submitWorksheetSelection
            // 
            this.button_submitWorksheetSelection.BackColor = System.Drawing.Color.PaleGreen;
            this.button_submitWorksheetSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_submitWorksheetSelection.Location = new System.Drawing.Point(146, 76);
            this.button_submitWorksheetSelection.Name = "button_submitWorksheetSelection";
            this.button_submitWorksheetSelection.Size = new System.Drawing.Size(75, 23);
            this.button_submitWorksheetSelection.TabIndex = 2;
            this.button_submitWorksheetSelection.Text = "Submit";
            this.button_submitWorksheetSelection.UseVisualStyleBackColor = false;
            this.button_submitWorksheetSelection.Click += new System.EventHandler(this.button_submitWorksheetSelection_Click);
            // 
            // button_cancelWorksheetSelection
            // 
            this.button_cancelWorksheetSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_cancelWorksheetSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancelWorksheetSelection.Location = new System.Drawing.Point(15, 76);
            this.button_cancelWorksheetSelection.Name = "button_cancelWorksheetSelection";
            this.button_cancelWorksheetSelection.Size = new System.Drawing.Size(75, 23);
            this.button_cancelWorksheetSelection.TabIndex = 3;
            this.button_cancelWorksheetSelection.Text = "Cancel";
            this.button_cancelWorksheetSelection.UseVisualStyleBackColor = false;
            this.button_cancelWorksheetSelection.Click += new System.EventHandler(this.button_cancelWorksheetSelection_Click);
            // 
            // WorksheetSelectionBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 113);
            this.Controls.Add(this.button_cancelWorksheetSelection);
            this.Controls.Add(this.button_submitWorksheetSelection);
            this.Controls.Add(this.comboBox_worksheetSelection);
            this.Controls.Add(this.label1);
            this.Name = "WorksheetSelectionBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorksheetSelectionBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_worksheetSelection;
        private System.Windows.Forms.Button button_submitWorksheetSelection;
        private System.Windows.Forms.Button button_cancelWorksheetSelection;
    }
}