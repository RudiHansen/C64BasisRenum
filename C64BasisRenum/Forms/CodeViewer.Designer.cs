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
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            subNoStepUpDown = new NumericUpDown();
            subNoStepLabel = new Label();
            subNoStartUpDown = new NumericUpDown();
            subNoStartLabel = new Label();
            lineNoStepUpDown = new NumericUpDown();
            lineNoStepLabel = new Label();
            lineNoStartUpDown = new NumericUpDown();
            lineNoStartLabel = new Label();
            saveCodeButton = new Button();
            renumberCodeButton = new Button();
            setSubLinesButton = new Button();
            loadBasicButton = new Button();
            advancedDataGridView1 = new Zuby.ADGV.AdvancedDataGridView();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)subNoStepUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)subNoStartUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lineNoStepUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lineNoStartUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)advancedDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(advancedDataGridView1, 0, 1);
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
            groupBox1.Controls.Add(subNoStepUpDown);
            groupBox1.Controls.Add(subNoStepLabel);
            groupBox1.Controls.Add(subNoStartUpDown);
            groupBox1.Controls.Add(subNoStartLabel);
            groupBox1.Controls.Add(lineNoStepUpDown);
            groupBox1.Controls.Add(lineNoStepLabel);
            groupBox1.Controls.Add(lineNoStartUpDown);
            groupBox1.Controls.Add(lineNoStartLabel);
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
            // subNoStepUpDown
            // 
            subNoStepUpDown.Location = new Point(910, 36);
            subNoStepUpDown.Name = "subNoStepUpDown";
            subNoStepUpDown.Size = new Size(80, 23);
            subNoStepUpDown.TabIndex = 13;
            // 
            // subNoStepLabel
            // 
            subNoStepLabel.AutoSize = true;
            subNoStepLabel.Location = new Point(835, 38);
            subNoStepLabel.Name = "subNoStepLabel";
            subNoStepLabel.Size = new Size(66, 15);
            subNoStepLabel.TabIndex = 12;
            subNoStepLabel.Text = "Subno step";
            // 
            // subNoStartUpDown
            // 
            subNoStartUpDown.Location = new Point(910, 11);
            subNoStartUpDown.Name = "subNoStartUpDown";
            subNoStartUpDown.Size = new Size(80, 23);
            subNoStartUpDown.TabIndex = 11;
            // 
            // subNoStartLabel
            // 
            subNoStartLabel.AutoSize = true;
            subNoStartLabel.Location = new Point(835, 13);
            subNoStartLabel.Name = "subNoStartLabel";
            subNoStartLabel.Size = new Size(67, 15);
            subNoStartLabel.TabIndex = 10;
            subNoStartLabel.Text = "Subno start";
            // 
            // lineNoStepUpDown
            // 
            lineNoStepUpDown.Location = new Point(733, 36);
            lineNoStepUpDown.Name = "lineNoStepUpDown";
            lineNoStepUpDown.Size = new Size(80, 23);
            lineNoStepUpDown.TabIndex = 9;
            // 
            // lineNoStepLabel
            // 
            lineNoStepLabel.AutoSize = true;
            lineNoStepLabel.Location = new Point(658, 38);
            lineNoStepLabel.Name = "lineNoStepLabel";
            lineNoStepLabel.Size = new Size(68, 15);
            lineNoStepLabel.TabIndex = 8;
            lineNoStepLabel.Text = "Lineno step";
            // 
            // lineNoStartUpDown
            // 
            lineNoStartUpDown.Location = new Point(733, 11);
            lineNoStartUpDown.Name = "lineNoStartUpDown";
            lineNoStartUpDown.Size = new Size(80, 23);
            lineNoStartUpDown.TabIndex = 7;
            // 
            // lineNoStartLabel
            // 
            lineNoStartLabel.AutoSize = true;
            lineNoStartLabel.Location = new Point(658, 13);
            lineNoStartLabel.Name = "lineNoStartLabel";
            lineNoStartLabel.Size = new Size(69, 15);
            lineNoStartLabel.TabIndex = 6;
            lineNoStartLabel.Text = "Lineno start";
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
            // advancedDataGridView1
            // 
            advancedDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            advancedDataGridView1.Dock = DockStyle.Fill;
            advancedDataGridView1.FilterAndSortEnabled = true;
            advancedDataGridView1.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            advancedDataGridView1.Location = new Point(3, 103);
            advancedDataGridView1.MaxFilterButtonImageHeight = 23;
            advancedDataGridView1.Name = "advancedDataGridView1";
            advancedDataGridView1.RightToLeft = RightToLeft.No;
            advancedDataGridView1.Size = new Size(993, 344);
            advancedDataGridView1.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            advancedDataGridView1.TabIndex = 2;
            advancedDataGridView1.FilterStringChanged += advancedDataGridView1_FilterStringChanged;
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
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)subNoStepUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)subNoStartUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)lineNoStepUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)lineNoStartUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)advancedDataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private Button loadBasicButton;
        private Button setSubLinesButton;
        private Button renumberCodeButton;
        private Button saveCodeButton;
        private Zuby.ADGV.AdvancedDataGridView advancedDataGridView1;
        private Label lineNoStartLabel;
        private NumericUpDown subNoStepUpDown;
        private Label subNoStepLabel;
        private NumericUpDown subNoStartUpDown;
        private Label subNoStartLabel;
        private NumericUpDown lineNoStepUpDown;
        private Label lineNoStepLabel;
        private NumericUpDown lineNoStartUpDown;
    }
}