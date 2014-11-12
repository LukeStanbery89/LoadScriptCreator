namespace Load_Script_Creator {
    partial class MainWindow {
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_importWorksheet = new System.Windows.Forms.Button();
            this.button_browse = new System.Windows.Forms.Button();
            this.textBox_filePath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_server = new System.Windows.Forms.TextBox();
            this.textBox_evtUid = new System.Windows.Forms.TextBox();
            this.textBox_dbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(572, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 190);
            this.panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_importWorksheet);
            this.groupBox2.Controls.Add(this.button_browse);
            this.groupBox2.Controls.Add(this.textBox_filePath);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(194, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 190);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select an Excel Worksheet";
            // 
            // button_importWorksheet
            // 
            this.button_importWorksheet.BackColor = System.Drawing.Color.PaleGreen;
            this.button_importWorksheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_importWorksheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_importWorksheet.Location = new System.Drawing.Point(82, 81);
            this.button_importWorksheet.Name = "button_importWorksheet";
            this.button_importWorksheet.Size = new System.Drawing.Size(224, 69);
            this.button_importWorksheet.TabIndex = 2;
            this.button_importWorksheet.Text = "Import Excel Worksheet";
            this.button_importWorksheet.UseVisualStyleBackColor = false;
            this.button_importWorksheet.Click += new System.EventHandler(this.button_importWorksheet_Click);
            // 
            // button_browse
            // 
            this.button_browse.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_browse.Location = new System.Drawing.Point(337, 24);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(33, 23);
            this.button_browse.TabIndex = 1;
            this.button_browse.Text = "...";
            this.button_browse.UseVisualStyleBackColor = false;
            this.button_browse.Click += new System.EventHandler(this.button_browse_Click);
            // 
            // textBox_filePath
            // 
            this.textBox_filePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_filePath.Location = new System.Drawing.Point(6, 26);
            this.textBox_filePath.Name = "textBox_filePath";
            this.textBox_filePath.ReadOnly = true;
            this.textBox_filePath.Size = new System.Drawing.Size(325, 20);
            this.textBox_filePath.TabIndex = 1000;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_server);
            this.groupBox1.Controls.Add(this.textBox_evtUid);
            this.groupBox1.Controls.Add(this.textBox_dbName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database Info";
            // 
            // textBox_server
            // 
            this.textBox_server.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_server.Location = new System.Drawing.Point(68, 78);
            this.textBox_server.MaxLength = 8;
            this.textBox_server.Name = "textBox_server";
            this.textBox_server.Size = new System.Drawing.Size(120, 20);
            this.textBox_server.TabIndex = 5;
            this.textBox_server.Leave += new System.EventHandler(this.textBox_server_Leave);
            // 
            // textBox_evtUid
            // 
            this.textBox_evtUid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_evtUid.Location = new System.Drawing.Point(68, 52);
            this.textBox_evtUid.MaxLength = 5;
            this.textBox_evtUid.Name = "textBox_evtUid";
            this.textBox_evtUid.Size = new System.Drawing.Size(120, 20);
            this.textBox_evtUid.TabIndex = 4;
            this.textBox_evtUid.Leave += new System.EventHandler(this.textBox_evtUid_Leave);
            // 
            // textBox_dbName
            // 
            this.textBox_dbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_dbName.Location = new System.Drawing.Point(68, 26);
            this.textBox_dbName.MaxLength = 10;
            this.textBox_dbName.Name = "textBox_dbName";
            this.textBox_dbName.Size = new System.Drawing.Size(120, 20);
            this.textBox_dbName.TabIndex = 3;
            this.textBox_dbName.Leave += new System.EventHandler(this.textBox_dbName_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Server: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Evt_uid: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 214);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Load Script Creator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_server;
        private System.Windows.Forms.TextBox textBox_evtUid;
        private System.Windows.Forms.TextBox textBox_dbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.TextBox textBox_filePath;
        private System.Windows.Forms.Button button_importWorksheet;
    }
}

