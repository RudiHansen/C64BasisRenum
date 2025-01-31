namespace C64BasisRenum.Librarys
{
    public class FileHelper
    {
        public static string GetFileName()
        {
            // Enable visual styles for the application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Open the file with the Basic program to renumber
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "BASIC Files (*.bas)|*.bas|All Files (*.*)|*.*";
                openFileDialog.Title = "Select a BASIC Program File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    return filePath;
                }
            }
            return "";
        }
    }
}
