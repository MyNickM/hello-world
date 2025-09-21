static class LogLine
{
    public static string Message(string logLine)
    {
        int message_index = logLine.IndexOf(' ');
        logLine = logLine.Substring(message_index + 1);
        return logLine.Trim();
    }

    public static string LogLevel(string logLine)
    {
        int logstart = logLine.IndexOf('[');
        int logend = logLine.IndexOf(']');
        return logLine.Substring(logstart + 1, logend - 1).ToLower();
    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)}" + $" ({LogLevel(logLine)})";
    }
}
