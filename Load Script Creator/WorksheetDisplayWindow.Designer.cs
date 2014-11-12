namespace Load_Script_Creator {
    partial class WorksheetDisplayWindow {
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView_worksheetItems = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip_columnHeaderClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_rowHeaderClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_worksheetItems)).BeginInit();
            this.panel1.SuspendLayout();
            this.contextMenuStrip_columnHeaderClick.SuspendLayout();
            this.contextMenuStrip_rowHeaderClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_worksheetItems
            // 
            this.dataGridView_worksheetItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_worksheetItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_worksheetItems.Location = new System.Drawing.Point(0, 81);
            this.dataGridView_worksheetItems.Name = "dataGridView_worksheetItems";
            this.dataGridView_worksheetItems.Size = new System.Drawing.Size(763, 435);
            this.dataGridView_worksheetItems.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 81);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate Script";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip_columnHeaderClick
            // 
            this.contextMenuStrip_columnHeaderClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteColumnToolStripMenuItem});
            this.contextMenuStrip_columnHeaderClick.Name = "contextMenuStrip_columnHeaderClick";
            this.contextMenuStrip_columnHeaderClick.Size = new System.Drawing.Size(154, 26);
            // 
            // deleteColumnToolStripMenuItem
            // 
            this.deleteColumnToolStripMenuItem.Name = "deleteColumnToolStripMenuItem";
            this.deleteColumnToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.deleteColumnToolStripMenuItem.Text = "Delete Column";
            this.deleteColumnToolStripMenuItem.Click += new System.EventHandler(this.deleteColumnToolStripMenuItem_Click);
            // 
            // contextMenuStrip_rowHeaderClick
            // 
            this.contextMenuStrip_rowHeaderClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteRowToolStripMenuItem});
            this.contextMenuStrip_rowHeaderClick.Name = "contextMenuStrip_rowHeaderClick";
            this.contextMenuStrip_rowHeaderClick.Size = new System.Drawing.Size(153, 48);
            // 
            // deleteRowToolStripMenuItem
            // 
            this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteRowToolStripMenuItem.Text = "Delete Row";
            this.deleteRowToolStripMenuItem.Click += new System.EventHandler(this.deleteRowToolStripMenuItem_Click);
            // 
            // WorksheetDisplayWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 516);
            this.Controls.Add(this.dataGridView_worksheetItems);
            this.Controls.Add(this.panel1);
            this.Name = "WorksheetDisplayWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verify Fields";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_worksheetItems)).EndInit();
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip_columnHeaderClick.ResumeLayout(false);
            this.contextMenuStrip_rowHeaderClick.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_worksheetItems;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_columnHeaderClick;
        private System.Windows.Forms.ToolStripMenuItem deleteColumnToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_rowHeaderClick;
        private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;


    }
}