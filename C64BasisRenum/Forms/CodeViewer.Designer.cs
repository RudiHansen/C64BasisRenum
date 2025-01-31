namespace C64BasisRenum.Forms
{
    partial class CodeViewer
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
            dataGridView1 = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            renumberCodeButton = new Button();
            setSubLinesButton = new Button();
            loadBasicButton = new Button();
            saveCodeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 103);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(993, 344);
            dataGridView1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(999, 450);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(saveCodeButton);
            groupBox1.Controls.Add(renumberCodeButton);
            groupBox1.Controls.Add(setSubLinesButton);
            groupBox1.Controls.Add(loadBasicButton);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(993, 94);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // renumberCodeButton
            // 
            renumberCodeButton.Location = new Point(173, 9);
            renumberCodeButton.Name = "renumberCodeButton";
            renumberCodeButton.Size = new Size(128, 23);
            renumberCodeButton.TabIndex = 4;
            renumberCodeButton.Text = "Renumber code";
            renumberCodeButton.UseVisualStyleBackColor = true;
            renumberCodeButton.Click += renumberCodeButton_Click;
            // 
            // setSubLinesButton
            // 
            setSubLinesButton.Location = new Point(0, 38);
            setSubLinesButton.Name = "setSubLinesButton";
            setSubLinesButton.Size = new Size(128, 23);
            setSubLinesButton.TabIndex = 3;
            setSubLinesButton.Text = "Set sub line numbers";
            setSubLinesButton.UseVisualStyleBackColor = true;
            setSubLinesButton.Click += setSubLinesButton_Click;
            // 
            // loadBasicButton
            // 
            loadBasicButton.Location = new Point(0, 9);
            loadBasicButton.Name = "loadBasicButton";
            loadBasicButton.Size = new Size(128, 23);
            loadBasicButton.TabIndex = 2;
            loadBasicButton.Text = "Load Basic Program";
            loadBasicButton.UseVisualStyleBackColor = true;
            loadBasicButton.Click += loadBasicButton_Click;
            // 
            // saveCodeButton
            // 
            saveCodeButton.Location = new Point(403, 9);
            saveCodeButton.Name = "saveCodeButton";
            saveCodeButton.Size = new Size(128, 23);
            saveCodeButton.TabIndex = 5;
            saveCodeButton.Text = "Save Code";
            saveCodeButton.UseVisualStyleBackColor = true;
            saveCodeButton.Click += saveCodeButton_Click;
            // 
            // CodeViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "CodeViewer";
            Text = "CodeViewer";
            FormClosing += CodeViewer_FormClosing;
            Load += CodeViewer_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private Button loadBasicButton;
        private Button setSubLinesButton;
        private Button renumberCodeButton;
        private Button saveCodeButton;
    }
}