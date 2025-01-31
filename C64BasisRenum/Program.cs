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
            // Enable visual styles for the application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new CodeViewer());
        }
        
    }

}