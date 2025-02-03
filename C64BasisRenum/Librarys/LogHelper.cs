using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C64BasisRenum.Librarys
{
    public class LogHelper
    {
        public static void WriteToLogfile(string message, string content)
        {
            string fileName = "C64BasicRenum.log";
            string dateTimeStamp = $"{DateTime.Now}";
            string output = $"{dateTimeStamp}-{message}:{content}" + Environment.NewLine;

            File.AppendAllText(fileName, output);
        }
    }
}
