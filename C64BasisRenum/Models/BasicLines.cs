namespace C64BasisRenum.Models
{
    public class BasicLine
    {
        public int LineNumber { get; set; }
        public string LineText { get; set; }
        public int? GoLineNumber { get; set; }
        public int? NewLineNumber { get; set; }
        public int? NewGoLineNumber { get; set; }
        public bool SubRoutine { get; set; }

        public BasicLine()
        {
            LineNumber = 0;
            LineText = "";
            GoLineNumber = null;
            NewLineNumber = null;
            NewGoLineNumber = null;
            SubRoutine = false;
        }
    }
    public class BasicLines
    {
        public List<BasicLine> Lines { get; set; }
        public BasicLines()
        {
            Lines = new List<BasicLine>();
        }

    }
}
