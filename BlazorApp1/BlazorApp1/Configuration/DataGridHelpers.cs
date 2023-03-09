using BlazorApp1.Classes;
using System.ComponentModel;
using System.Reflection;

namespace BlazorApp1.Configuration
{
    public static class DataGridHelpers
    {
        public static List<ColumnDefinition> GetColumnDefinitions<T>()
        {
            var columnsDefinition = new List<ColumnDefinition>();
            PropertyInfo[] properties = typeof(T).GetProperties();
            var captionDict = GetAttributeDict<T, DisplayNameAttribute>();
            var dataTypeDict = GetAttributeDict<T, DataTypeAttribute>();
            var formatDict = GetAttributeDict<T, FormatAttribute>();
            var alignmentDict = GetAttributeDict<T, AlignmentAttribute>();

            for (int i = 0; i < properties.Length; i++)
            {
                columnsDefinition.Add(new ColumnDefinition
                {
                    DataField = properties[i].Name,
                    Caption = captionDict[properties[i].Name]?.DisplayName ?? string.Empty,
                    DataType = dataTypeDict[properties[i].Name]?.DataType ?? DataType.NotSet,
                    Format = formatDict[properties[i].Name]?.Format ?? string.Empty,
                    Alignment = alignmentDict[properties[i].Name]?.Alignment ?? Alignment.NotSet
                });
            }

            return columnsDefinition;
        }

        private static Dictionary<string, U?> GetAttributeDict<T, U>()
        {
            return typeof(T).GetProperties().ToDictionary(p => p.Name, p => p.GetCustomAttributes(typeof(U), false).Select(a => (U)a).FirstOrDefault());
        }
    }
}
