using C64BasisRenum.Models;
using System.Text.RegularExpressions;

namespace C64BasisRenum.Librarys
{
    public class BasicHelper
    {
        public static BasicLines Code2BasicLines(string basicFileContent)
        {
            BasicLines basicLines = new BasicLines();

            foreach (var line in basicFileContent.Split("\r\n"))
            {
                var result = ParseBasicLine(line);
                BasicLine basicLine = new BasicLine();

                basicLine.LineNumber = result.LineNumber;
                basicLine.LineText = result.RestOfLine;
                if (basicLine.LineText.StartsWith(" rem sub", StringComparison.OrdinalIgnoreCase))
                {
                    basicLine.SubRoutine = true;
                }
                basicLine.GoLineNumber = result.GotoGosubNumber;
                basicLine.NewLineNumber = 0;
                basicLine.NewGoLineNumber = 0;
                basicLines.Lines.Add(basicLine);
            }
            return basicLines;
        }
        private static (int LineNumber, string RestOfLine, int? GotoGosubNumber) ParseBasicLine(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return (0, "", null);
            }

            // Matcher linjenummer + resten af linjen (uden at fjerne "gosub 8000" fra "RestOfLine")
            var match = Regex.Match(input, @"^(?<LineNumber>\d+)(?<RestOfLine>.*)", RegexOptions.IgnoreCase);

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
