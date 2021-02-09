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
        string manualTitle = "                      Here is your 'help' manual!";
        string download = "   {https://youtube/url}      -------    for start download.";
        string url = "      1 - Video/Audio         -------    select for download video and audio.";
        string type = "      2 - Image               -------    select for download an image.";
        string folder = "      folder                  -------    the folder path.";

        string setPath = "     --set-path               -------    for start a new default folder path location.";
        string path = "        path                  -------    the name of the default path.";

        string hint = "        hint                  -------    use '.' for use default properties.";
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

    public static void Done()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(Strings.DONE);
        Console.ResetColor();
    }

    public static void InvalidDefaultPath()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(Strings.INVALID_DEFAULT_PATH);
        Console.ResetColor();
    }

    public static void DownloadMenu()
    {

        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("Select what you want to download:");
        Console.ResetColor();
        Console.WriteLine("1 - Video/Audio");
        Console.WriteLine("2 - Image");
        Console.Write(Prints.Arrow());

    }

}