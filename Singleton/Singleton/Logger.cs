using System;

public sealed class Logger
{
    private static readonly Logger _instance = new Logger();

    public static Logger Instance => _instance;

    private Logger() { }

    public void Log(string message)
    {
        Console.WriteLine($"[Log] {message}");
    }
}