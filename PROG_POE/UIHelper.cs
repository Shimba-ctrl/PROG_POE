using System;
using System.Threading;

public class UIHelper
{
    public static void ShowLogo()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;

        // the cyber logo
        Console.WriteLine(@"
╔══════════════════════════════════════════════════════╗
║           CYBERSECURITY AWARENESS BOT                ║
╠══════════════════════════════════════════════════════╣
║   Protecting Users From Online Threats               ║
╚══════════════════════════════════════════════════════╝
");

        Console.ResetColor();
    }

    public static void TypeText(string message)
    {
        // creates typing effect for better user experience
        foreach (char c in message)
        {
            Console.Write(c);
            Thread.Sleep(15);
        }
        Console.WriteLine();
    }
}