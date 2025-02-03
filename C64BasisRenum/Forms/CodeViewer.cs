using C64BasisRenum.Librarys;
using C64BasisRenum.Models;
using System.Text;
using System.Text.RegularExpressions;
using System.Data;

namespace C64BasisRenum.Forms
{
    public partial class CodeViewer : Form
    {
        private BasicLines basicLines = new();
        private DataTable dataTable = new();
        private BindingSource bindingSource = new();
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

            PopulateDataTable();
        }
        private void PopulateDataTable()
        {
            dataTable.Rows.Clear();
            dataTable.Columns.Clear();

            if (dataTable.Columns.Count == 0)
            {
                // Define table structure
                dataTable.Columns.Add("LineNumber", typeof(int));
                dataTable.Columns.Add("LineText", typeof(string));
                dataTable.Columns.Add("GoLineNumber", typeof(int));
                dataTable.Columns.Add("NewLineNumber", typeof(int));
                dataTable.Columns.Add("NewGoLineNumber", typeof(int));
                dataTable.Columns.Add("SubRoutine", typeof(bool));
                // Hidden column to store original BasicLine reference
                dataTable.Columns.Add("OriginalObject", typeof(BasicLine));
            }

            // Mark all rows as "unchanged" to prevent potential issues
            dataTable.AcceptChanges();

            // Load your data
            foreach (var basicLine in basicLines.Lines)
            {
                dataTable.Rows.Add(basicLine.LineNumber, basicLine.LineText, basicLine.GoLineNumber, basicLine.NewLineNumber, basicLine.NewGoLineNumber, basicLine.SubRoutine, basicLine);
            }

            // Bind to BindingSource
            bindingSource.DataSource = dataTable;
            advancedDataGridView1.DataSource = bindingSource;
        }

        private void SyncDataTableToBasicLines()
        {
            TimeCodeExecution timeCodeExecution = new();
            timeCodeExecution.Start("SyncDataTableToBasicLines");
            basicLines.Lines.Clear(); // Clear old data

            foreach (DataRow row in dataTable.Rows)
            {
                var basicLine = new BasicLine
                {
                    LineNumber = row.Field<int>("LineNumber"),
                    LineText = row.Field<string>("LineText"),
                    GoLineNumber = row.Field<int?>("GoLineNumber"),
                    NewLineNumber = row.Field<int?>("NewLineNumber"),
                    NewGoLineNumber = row.Field<int?>("NewGoLineNumber"),
                    SubRoutine = row.Field<bool>("SubRoutine")
                };

                basicLines.Lines.Add(basicLine);
            }
            timeCodeExecution.Stop();
        }
        private void SyncDataTableToBasicLines2()
        {
            TimeCodeExecution timeCodeExecution = new();
            timeCodeExecution.Start("SyncDataTableToBasicLines2");
            // Track processed items
            HashSet<BasicLine> updatedLines = new HashSet<BasicLine>();

            foreach (DataRow row in dataTable.Rows)
            {
                // Retrieve the original BasicLine object stored in the row
                if (row.RowState == DataRowState.Deleted)
                    continue; // Skip deleted rows

                BasicLine? basicLine = row["OriginalObject"] as BasicLine;

                if (basicLine != null)
                {
                    // ✅ Update existing BasicLine object
                    basicLine.LineNumber = row.Field<int>("LineNumber");
                    basicLine.LineText = row.Field<string>("LineText");
                    basicLine.GoLineNumber = row.Field<int?>("GoLineNumber");
                    basicLine.NewLineNumber = row.Field<int?>("NewLineNumber");
                    basicLine.NewGoLineNumber = row.Field<int?>("NewGoLineNumber");
                    basicLine.SubRoutine = row.Field<bool>("SubRoutine");

                    updatedLines.Add(basicLine);
                }
                else
                {
                    // ✅ Add new BasicLine if it doesn’t exist
                    var newLine = new BasicLine
                    {
                        LineNumber = row.Field<int>("LineNumber"),
                        LineText = row.Field<string>("LineText"),
                        GoLineNumber = row.Field<int?>("GoLineNumber"),
                        NewLineNumber = row.Field<int?>("NewLineNumber"),
                        NewGoLineNumber = row.Field<int?>("NewGoLineNumber"),
                        SubRoutine = row.Field<bool>("SubRoutine")
                    };

                    basicLines.Lines.Add(newLine);
                    row["OriginalObject"] = newLine; // Store reference for future updates
                    updatedLines.Add(newLine);
                }
            }

            // ✅ Remove deleted lines
            basicLines.Lines.RemoveAll(line => !updatedLines.Contains(line));
            timeCodeExecution.Stop();
        }
        private void SetupDataGridView()
        {
            advancedDataGridView1.AutoGenerateColumns = false;

            // Set the font for the entire DataGridView
            advancedDataGridView1.DefaultCellStyle.Font = new Font("Consolas", 10);

            // Remove horizontal lines
            advancedDataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;

            // Define columns manually
            DataGridViewTextBoxColumn lineNumberColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LineNumber",
                HeaderText = "Line",
                Name = "LineNumberColumn",
                Width = 60,
                DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Red }
            };
            advancedDataGridView1.Columns.Add(lineNumberColumn);

            DataGridViewTextBoxColumn newLineNumberColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NewLineNumber",
                HeaderText = "New",
                Name = "NewLineNumberColumn",
                Width = 60,
                DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Blue }
            };
            advancedDataGridView1.Columns.Add(newLineNumberColumn);

            DataGridViewCheckBoxColumn newSubColumn = new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "SubRoutine",
                HeaderText = "Sub",
                Name = "SubRoutine",
                Width = 30
            };
            advancedDataGridView1.Columns.Add(newSubColumn);

            DataGridViewTextBoxColumn lineTextColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LineText",
                HeaderText = "Code",
                Name = "LineTextColumn",
                Width = 680
            };
            advancedDataGridView1.Columns.Add(lineTextColumn);

            DataGridViewTextBoxColumn goLineNumberColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "GoLineNumber",
                HeaderText = "Goto line",
                Name = "GoLineNumberColumn",
                Width = 60
            };
            advancedDataGridView1.Columns.Add(goLineNumberColumn);

            DataGridViewTextBoxColumn newGoLineNumberColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NewGoLineNumber",
                HeaderText = "New",
                Name = "NewGoLineNumberColumn",
                Width = 60
            };
            advancedDataGridView1.Columns.Add(newGoLineNumberColumn);
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
            advancedDataGridView1.EndEdit();
            SyncDataTableToBasicLines();

            int subLine = 1000;

            foreach (var item in basicLines.Lines.Where(x => x.SubRoutine == true))
            {
                item.NewLineNumber = subLine;
                subLine += 1000;
            }

            PopulateDataTable();
        }
        private void renumberCodeButton_Click(object sender, EventArgs e)
        {
            // Ensure any pending changes in the DataGridView are committed
            advancedDataGridView1.EndEdit();
            SyncDataTableToBasicLines();

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
            PopulateDataTable();
        }
        private void saveCodeButton_Click(object sender, EventArgs e)
        {
            SyncDataTableToBasicLines();

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
                        // Finder "goto", "gosub" eller "then" efterfulgt af et nummer
                        MatchCollection matches = Regex.Matches(item.LineText, @"\b(?:goto|gosub|then)\s+(?<GotoGosub>\d+)", RegexOptions.IgnoreCase);

                        foreach (Match match in matches)
                        {
                            if (match.Success)
                            {
                                int gotoGosubNumber = int.Parse(match.Groups["GotoGosub"].Value); // Henter nummeret
                                var newGoLineNumber = basicLines.Lines.FirstOrDefault(x => x.LineNumber == gotoGosubNumber)?.NewLineNumber; // Henter det nye nummer
                                item.LineText = item.LineText.Replace(gotoGosubNumber.ToString(), item.NewGoLineNumber.ToString()); // Erstatter det gamle nummer med det nye
                            }
                        }
                        sb.AppendLine($"{item.NewLineNumber}{item.LineText}");
                    }
                    else
                    {
                        sb.AppendLine($"{item.NewLineNumber}{item.LineText}");
                    }
                }
            }
            File.WriteAllText(basicOutputFile, sb.ToString());
        }
        private void advancedDataGridView1_FilterStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.FilterEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(advancedDataGridView1.FilterString))
            {
                try
                {
                    // Use DataView's RowFilter (Automatically handles filtering)
                    (bindingSource.DataSource as DataTable).DefaultView.RowFilter = advancedDataGridView1.FilterString;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error applying filter: " + ex.Message);
                }
            }
            else
            {
                // Clear filter if no condition is set
                (bindingSource.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
        }
    }
}
