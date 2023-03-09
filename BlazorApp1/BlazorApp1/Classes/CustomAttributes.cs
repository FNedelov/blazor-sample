using BlazorApp1.Configuration;

namespace BlazorApp1.Classes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class DataTypeAttribute : Attribute
    { 
        public DataTypeAttribute(DataType dataType) 
        {
            DataType= dataType;
        }
        public DataType DataType { get; set; }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class FormatAttribute : Attribute
    {
        public FormatAttribute(string format)
        {
            Format = format;
        }
        public string Format { get; set; }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class AlignmentAttribute : Attribute
    {
        public AlignmentAttribute(Alignment alignment)
        {
            Alignment = alignment;
        }
        public Alignment Alignment { get; set; }
    }
}