using System;
using System.Collections;

public class Commands
{
    public static void Help()
    {
        Prints.HelpManual();
    }

    public static void SetURLPath()
    {
    userChoice:

        Console.WriteLine(Prints.Blank());

        Console.Write(Strings.PATH + " " + Prints.Arrow());
        string path = Console.ReadLine();

        if (!Validator.IsValidDefaultPathRequest(path))
        {
            Prints.InvalidDefaultPath();

            goto userChoice;
        }

        DefaultFolder.CreateFile(path);

        Prints.Done();
    }

    public static void SelectFileFormat(string url)
    {
    userChoice:

        Prints.DownloadMenu();
        string userInput = Console.ReadLine();

        string folder = null;

        if (IsValidDownloadOption(userInput))
        {
            if (userInput == Strings.DOWNLOAD_VIDEO_AUDIO) DownloadMP4MP3File(url, folder);
            if (userInput == Strings.DOWNLOAD_IMAGE) DownloadImageFile(url, folder);
        }
        else
        {
            Console.WriteLine("Invalid download option.");
            goto userChoice;
        }

    }

    private static bool IsValidDownloadOption(string command)
    {
        bool IsValidDownloadOption = false;
        ArrayList options = new ArrayList
        {
            "1",
            "2",
        };
        foreach (string option in options)
        {
            if (command.Equals(option)) IsValidDownloadOption = true;
        }
        return IsValidDownloadOption;
    }
    // Download files...
    private static void DownloadMP4MP3File(string url, string folder)
    {
        Console.Write("folder " + Prints.Arrow());
        folder = Console.ReadLine();

        Downloader.DownloadMP4MP3(url, folder);
    }
    private static void DownloadImageFile(string url, string folder)
    {
        Console.Write("folder " + Prints.Arrow());
        folder = Console.ReadLine();

        Downloader.DownloadImage(url, folder);
    }
}