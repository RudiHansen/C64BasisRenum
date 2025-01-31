namespace C64BasisRenum.Models
{
    public class BasicLine
    {
        public int LineNumber { get; set; }
        public string LineText { get; set; }
        public int? GoLineNumber { get; set; }
        public int? NewLineNumber { get; set; }
        public int? NewGoLineNumber { get; set; }

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
