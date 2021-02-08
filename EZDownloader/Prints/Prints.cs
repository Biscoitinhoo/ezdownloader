using System;


public class Prints
{
    public static string Blank()
    {
        return "";
    }

    public static string WelcomeMessage()
    {
        return Strings.WELCOME_MESSAGE;
    }

    public static string WelcomeMessageHelp()
    {
        return Strings.WELCOME_MESSAGE_HELP;
    }

    public static string Arrow()
    {
        return Strings.ARROW;
    }

    public static void HelpManual()
    {
        string manualTitle = "             Here is your 'help' manual!";
        string download = "   --download      -------    for start download.";
        string url = "       url         -------    the url you want to download.";
        string type = "       type        -------    file type (png, mp3, etc...).";
        string folder = "      folder       -------    the folder path.";
        string name = "       name        -------    the name of the file (Ex.: filename.png).";
        string hint = "       hint        -------    use '.' for use default properties.";

        string setPath = "   --set-path      -------    for start a new default folder path location.";
        string path = "       path        -------    the name of the default path.";

        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine(manualTitle);
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(download);
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine(url);
        Console.WriteLine(type);
        Console.WriteLine(folder);
        Console.WriteLine(name);

        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(setPath);
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(path);
        Console.ResetColor();

        Console.WriteLine(Prints.Blank());

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(hint);
        Console.ResetColor();
    }

    public static string Done()
    {
        return Strings.DONE;
    }

    public static string InvalidDefaultPath()
    {
        return Strings.INVALID_DEFAULT_PATH;
    }

}