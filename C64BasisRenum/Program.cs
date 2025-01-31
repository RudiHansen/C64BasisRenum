using C64BasisRenum.Forms;
using C64BasisRenum.Librarys;
using C64BasisRenum.Models;
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

            BasicLines basicLines = new BasicLines();

            foreach (var line in basicFileContent.Split("\r\n"))
            {
                Console.WriteLine(line);
                var result = ParseBasicLine(line);
                BasicLine basicLine = new BasicLine();

                basicLine.LineNumber = result.LineNumber;
                basicLine.LineText = result.RestOfLine;
                basicLine.GoLineNumber = result.GotoGosubNumber;
                basicLine.NewLineNumber = 0;
                basicLine.NewGoLineNumber = 0;
                basicLines.Lines.Add(basicLine);
            }
            CodeViewer codeViewer = new CodeViewer(basicLines);
            codeViewer.ShowDialog();
        }
        static (int LineNumber, string RestOfLine, int? GotoGosubNumber) ParseBasicLine(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return (0, "", null);
            }

            // Matcher linjenummer + resten af linjen (uden at fjerne "gosub 8000" fra "RestOfLine")
            var match = Regex.Match(input, @"^(?<LineNumber>\d+)\s*(?<RestOfLine>.*)", RegexOptions.IgnoreCase);

            if (match.Success)
            {
                int lineNumber = int.Parse(match.Groups["LineNumber"].Value);
                string restOfLine = match.Groups["RestOfLine"].Value;  // Bevarer formatet 100%

                // Finder "goto" eller "gosub" som det sidste nummer i linjen
                var gotoMatch = Regex.Match(restOfLine, @"(?:goto|gosub|then)\s+(?<GotoGosub>\d+)", RegexOptions.IgnoreCase);
                int? gotoGosubNumber = gotoMatch.Success ? int.Parse(gotoMatch.Groups["GotoGosub"].Value) : (int?)null;

                return (lineNumber, restOfLine, gotoGosubNumber);
            }

            throw new ArgumentException("Invalid input format.");
        }
    }

}