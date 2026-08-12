using System.Text;

namespace DesafioBatch.Services;

public class CsvWriter
{
    public void WriteLine(StreamWriter writer, IEnumerable<string?> values)
    {
        var escapedValues = values.Select(Escape);

        writer.WriteLine(string.Join(",", escapedValues));
    }

    private static string Escape(string? value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return string.Empty;
        }

        if (value.Contains('"'))
        {
            value = value.Replace("\"", "\"\"");
        }

        if (value.Contains(',') ||
            value.Contains('"') ||
            value.Contains('\r') ||
            value.Contains('\n'))
        {
            value = $"\"{value}\"";
        }

        return value;
    }
}