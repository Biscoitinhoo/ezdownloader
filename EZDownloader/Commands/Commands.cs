using System;

public class Commands
{
    public static void Help()
    {
        Prints.HelpManual();
    }
    public static void DownloadFile()
    {
        Console.WriteLine(Prints.Blank());

        Console.Write(Strings.URL + " " + Prints.Arrow());
        string url = Console.ReadLine();

        Console.Write(Strings.FOLDER + " " + Prints.Arrow());
        string folder = Console.ReadLine();

        Console.Write(Strings.NAME + " " + Prints.Arrow());
        string name = Console.ReadLine();

        Downloader.Download(url, folder, name);
        // TODO: verify extension and download videos?
    }
    public static void SetURLPath()
    {
        Console.WriteLine(Prints.Blank());

        Console.Write(Strings.PATH + " " + Prints.Arrow());
        string path = Console.ReadLine();

        while (!Validator.IsValidDefaultPathRequest(path))
        {
            // TODO: error messages class;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Prints.InvalidDefaultPath());
            Console.ResetColor();

            Console.Write(Strings.PATH + " " + Prints.Arrow());
            path = Console.ReadLine();
        }

        DefaultFolder.defaultFolder = path;

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(Prints.Done());
        Console.ResetColor();
    }
    public static void SelectFileFormat()
    {
        // TODO: refactor to Strings class
        Console.WriteLine("Select extension options:");
        Console.WriteLine("1 - .mp4");
        Console.WriteLine("2 - .mp3");
        Console.WriteLine("3 - .png");
        Console.WriteLine("4 - .jpeg");
    }
}