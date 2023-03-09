namespace BlazorApp1.Configuration
{
    public class ColumnDefinition
    {
        public ColumnDefinition()
        {
            DataType = DataType.NotSet;
            Alignment = Alignment.NotSet;
            SortDirection = SortDirection.NotSet;
        }
        public string DataField { get; set; }
        public string Caption { get; set; }
        public DataType DataType { get; set; }
        public string Format { get; set; }
        public Alignment Alignment { get; set; }
        public SortDirection SortDirection { get; set; }
    }
}
