using C64BasisRenum.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C64BasisRenum.Forms
{
    public partial class CodeViewer : Form
    {
        private BindingList<BasicLine> BasicLinesBinding = new();
        public CodeViewer(BasicLines basicLines)
        {
            InitializeComponent();

            BasicLinesBinding = new BindingList<BasicLine>(basicLines.Lines);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = BasicLinesBinding;

            // Set the font for the entire DataGridView
            dataGridView1.DefaultCellStyle.Font = new Font("Consolas", 10);

            // Remove horizontal lines
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;

            // Define columns manually
            DataGridViewTextBoxColumn lineNumberColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LineNumber",
                HeaderText = "Line",
                Name = "LineNumberColumn",
                Width = 60,
                DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Red }
            };
            dataGridView1.Columns.Add(lineNumberColumn);

            DataGridViewTextBoxColumn newLineNumberColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NewLineNumber",
                HeaderText = "New",
                Name = "NewLineNumberColumn",
                Width = 60,
                DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Blue }
            };
            dataGridView1.Columns.Add(newLineNumberColumn);

            DataGridViewTextBoxColumn lineTextColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LineText",
                HeaderText = "Code",
                Name = "LineTextColumn",
                Width = 680
            };
            dataGridView1.Columns.Add(lineTextColumn);

            DataGridViewTextBoxColumn goLineNumberColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "GoLineNumber",
                HeaderText = "Goto line",
                Name = "GoLineNumberColumn",
                Width = 60
            };
            dataGridView1.Columns.Add(goLineNumberColumn);

            DataGridViewTextBoxColumn newGoLineNumberColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NewGoLineNumber",
                HeaderText = "New",
                Name = "NewGoLineNumberColumn",
                Width = 60
            };
            dataGridView1.Columns.Add(newGoLineNumberColumn);
        }
    }
}
