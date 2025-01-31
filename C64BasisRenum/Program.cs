using C64BasisRenum.Forms;
using C64BasisRenum.Librarys;
using C64BasisRenum.Models;
using System.Linq;
using System.Text.RegularExpressions;

namespace C64BasisRenum
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //string basicInputFile = FileHelper.GetFileName();
            string basicInputFile = @"C:\Users\RSH\OneDrive\Development\C64\Sorter\BASIC Files\TestSort02.bas";

            string basicFileContent = File.ReadAllText(basicInputFile);

            BasicLines basicLines = BasicHelper.Code2BasicLines(basicFileContent);

            CodeViewer codeViewer = new CodeViewer(basicLines);
            codeViewer.ShowDialog();
        }
        
    }

}