using C64BasisRenum.Librarys;
using C64BasisRenum.Models;
using System.ComponentModel;
using System.Text;

namespace C64BasisRenum.Forms
{
    public partial class CodeViewer : Form
    {
        private BasicLines basicLines = new();
        private BindingList<BasicLine> BasicLinesBinding = new();
        private string basicInputFile = "";
        public CodeViewer()
        {
            InitializeComponent();
            SetupForm();
            SetupDataGridView();
        }

        private void CodeViewer_Load(object sender, EventArgs e)
        {



        }

        private void loadBasicButton_Click(object sender, EventArgs e)
        {
            //basicInputFile = FileHelper.GetFileName();
            basicInputFile = @"C:\Users\RSH\OneDrive\Development\C64\Sorter\BASIC Files\TestSort02.bas";
            string basicFileContent = File.ReadAllText(basicInputFile);

            basicLines = BasicHelper.Code2BasicLines(basicFileContent);

            BasicLinesBinding = new BindingList<BasicLine>(basicLines.Lines);
            dataGridView1.DataSource = BasicLinesBinding;
        }
        private void SetupDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;

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

            DataGridViewCheckBoxColumn newSubColumn = new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "SubRoutine",
                HeaderText = "Sub",
                Name = "SubRoutine",
                Width = 30
            };
            dataGridView1.Columns.Add(newSubColumn);

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
        private void SetupForm()
        {
            this.Text = "Code Viewer";
            this.Size = new Size(1030, 950);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.TopMost = false;
            this.Activate();
        }

        private void CodeViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            var size = this.Size;
        }

        private void setSubLinesButton_Click(object sender, EventArgs e)
        {
            // Ensure any pending changes in the DataGridView are committed
            dataGridView1.EndEdit();

            int subLine = 1000;

            foreach (var item in basicLines.Lines.Where(x => x.SubRoutine == true))
            {
                item.NewLineNumber = subLine;
                subLine += 1000;
            }
            // Reload data in DataGridView
            BasicLinesBinding.ResetBindings();
        }

        private void renumberCodeButton_Click(object sender, EventArgs e)
        {
            // Ensure any pending changes in the DataGridView are committed
            dataGridView1.EndEdit();

            // Renumber code
            int subLine = 10;
            foreach (var item in basicLines.Lines)
            {
                // If line number is 0 then its a blank line and should keep 0
                if (item.LineNumber == 0)
                {
                    item.NewLineNumber = 0;
                    continue;
                }

                if (item.NewLineNumber == 0 || item.NewLineNumber is null)
                {
                    item.NewLineNumber = subLine;
                    subLine += 10;
                }
                else
                {
                    subLine = (int)item.NewLineNumber;
                    subLine += 10;
                }
            }

            // Generate new line numbers for "goto" and "gosub"
            foreach (var item in basicLines.Lines)
            {
                if (item.GoLineNumber is null)
                {
                    item.NewGoLineNumber = null;
                }
                else
                {
                    var newGoLineNumber = basicLines.Lines.FirstOrDefault(x => x.LineNumber == item.GoLineNumber)?.NewLineNumber;
                    item.NewGoLineNumber = newGoLineNumber;
                }
            }

            // Reload data in DataGridView
            BasicLinesBinding.ResetBindings();

        }

        private void saveCodeButton_Click(object sender, EventArgs e)
        {
            string basicOutputFile = basicInputFile.Replace(".bas", "_renum.bas");
            StringBuilder sb = new StringBuilder();

            foreach (var item in basicLines.Lines)
            {
                if (item.NewLineNumber == 0)
                {
                    sb.AppendLine();
                }
                else
                {
                    if (item.NewGoLineNumber is not null)
                    {


                        sb.AppendLine($"{item.NewLineNumber} {item.LineText.Replace(item.GoLineNumber.ToString(), item.NewGoLineNumber.ToString())}");
                    }
                    else
                    {
                        sb.AppendLine($"{item.NewLineNumber} {item.LineText}");
                    }
                }
            }
            File.WriteAllText(basicOutputFile, sb.ToString());
        }
    }
}
