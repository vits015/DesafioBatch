namespace DesafioBatch.Services;

public static class DateUtils
{
    public static string FormatDate(string? date)
    {
        if (string.IsNullOrWhiteSpace(date))
        {
            return string.Empty;
        }

        if (DateTime.TryParse(date, out var parsedDate))
        {
            return parsedDate.ToString("yyyy-MM-dd");
        }

        return date;
    }
}