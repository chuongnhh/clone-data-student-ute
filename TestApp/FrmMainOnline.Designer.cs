namespace TestApp
{
    partial class FrmMainOnline
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.labelCountItem = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.labelMessage = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelEndIndex = new System.Windows.Forms.Label();
            this.labelStartIndex = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxStudentID3 = new System.Windows.Forms.ComboBox();
            this.comboBoxStudentID2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxStudentID1 = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.labelCountItem,
            this.toolStripLabel1,
            this.toolStripLabel4,
            this.labelMessage,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 267);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(733, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(36, 22);
            this.toolStripLabel3.Text = "items";
            // 
            // labelCountItem
            // 
            this.labelCountItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.labelCountItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountItem.Name = "labelCountItem";
            this.labelCountItem.Size = new System.Drawing.Size(14, 22);
            this.labelCountItem.Text = "0";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(36, 22);
            this.toolStripLabel1.Text = "Total:";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel4.Text = "Message:";
            // 
            // labelMessage
            // 
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(72, 22);
            this.labelMessage.Text = "No message";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.buttonReset);
            this.panel1.Controls.Add(this.labelEndIndex);
            this.panel1.Controls.Add(this.labelStartIndex);
            this.panel1.Controls.Add(this.buttonStart);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxStudentID3);
            this.panel1.Controls.Add(this.comboBoxStudentID2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxStudentID1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 119);
            this.panel1.TabIndex = 5;
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonReset.Location = new System.Drawing.Point(628, 57);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 24;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.reset_Click);
            // 
            // labelEndIndex
            // 
            this.labelEndIndex.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelEndIndex.AutoSize = true;
            this.labelEndIndex.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndIndex.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelEndIndex.Location = new System.Drawing.Point(544, 36);
            this.labelEndIndex.Name = "labelEndIndex";
            this.labelEndIndex.Size = new System.Drawing.Size(64, 17);
            this.labelEndIndex.TabIndex = 23;
            this.labelEndIndex.Text = "14110013";
            // 
            // labelStartIndex
            // 
            this.labelStartIndex.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelStartIndex.AutoSize = true;
            this.labelStartIndex.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartIndex.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelStartIndex.Location = new System.Drawing.Point(625, 36);
            this.labelStartIndex.Name = "labelStartIndex";
            this.labelStartIndex.Size = new System.Drawing.Size(64, 17);
            this.labelStartIndex.TabIndex = 22;
            this.labelStartIndex.Text = "14110013";
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonStart.Location = new System.Drawing.Point(547, 57);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 20;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.start_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(322, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mã ngành";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(122, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mã hệ đào tạo";
            // 
            // comboBoxStudentID3
            // 
            this.comboBoxStudentID3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxStudentID3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStudentID3.FormattingEnabled = true;
            this.comboBoxStudentID3.Location = new System.Drawing.Point(326, 58);
            this.comboBoxStudentID3.Name = "comboBoxStudentID3";
            this.comboBoxStudentID3.Size = new System.Drawing.Size(215, 21);
            this.comboBoxStudentID3.TabIndex = 15;
            this.comboBoxStudentID3.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudentID3_SelectedIndexChanged);
            // 
            // comboBoxStudentID2
            // 
            this.comboBoxStudentID2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxStudentID2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStudentID2.FormattingEnabled = true;
            this.comboBoxStudentID2.Location = new System.Drawing.Point(125, 58);
            this.comboBoxStudentID2.Name = "comboBoxStudentID2";
            this.comboBoxStudentID2.Size = new System.Drawing.Size(195, 21);
            this.comboBoxStudentID2.TabIndex = 16;
            this.comboBoxStudentID2.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudentID2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Khóa tuyển sinh";
            // 
            // comboBoxStudentID1
            // 
            this.comboBoxStudentID1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxStudentID1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStudentID1.FormattingEnabled = true;
            this.comboBoxStudentID1.Location = new System.Drawing.Point(12, 58);
            this.comboBoxStudentID1.Name = "comboBoxStudentID1";
            this.comboBoxStudentID1.Size = new System.Drawing.Size(107, 21);
            this.comboBoxStudentID1.TabIndex = 12;
            this.comboBoxStudentID1.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudentID1_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 119);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.webBrowser1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(733, 148);
            this.splitContainer1.SplitterDistance = 88;
            this.splitContainer1.TabIndex = 7;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(733, 88);
            this.webBrowser1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(733, 56);
            this.dataGridView1.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(733, 292);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ha ha: Student info";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel labelCountItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel labelMessage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxStudentID3;
        private System.Windows.Forms.ComboBox comboBoxStudentID2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxStudentID1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelEndIndex;
        private System.Windows.Forms.Label labelStartIndex;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

