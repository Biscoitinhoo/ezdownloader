using MediaToolkit;
using MediaToolkit.Model;
using System;
using System.IO;
using System.Net;
using VideoLibrary;

public class Downloader
{
    public static void DownloadImage(string url, string folder)
    {
        try
        {
            using (WebClient service = new WebClient())
            {
                WebClient webClient = new WebClient();
                ValidateAndDownloadFile(webClient, url, folder);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Ops! Something went wrong... \n" + e);
        }
    }

    public static void DownloadMP4MP3(string url, string folder)
    {
        if (Validator.DefaultFolderWasSelected(folder))
        {
            DownloadMP4MP3WDefaultFolder(url, folder);
        }
        else
        {
            DownloadMP4MP3WSpecifiedFolder(url, folder);
        }

    }

    // download images
    private static void ValidateAndDownloadFile(WebClient webClient, string url, string folder)
    {
        if (Validator.DefaultFolderWasSelected(folder))
        {
            DownloadImageWDefaultFolder(webClient, url);
        }
        else
        {
            DownloadImageWSpecifiedFolder(webClient, url, folder);
        }
    }

    private static void DownloadImageWDefaultFolder(WebClient webClient, string url)
    {
        if (Validator.IsValidDefaultFolder())
        {
            webClient.DownloadFile(new Uri(url), DefaultFolder.GetDefaultPath() + @"\" + GenerateRandomName.Generate() + ".jpeg");
            return;
        }
        else
        {
            Console.WriteLine("You still doesn't configured a default folder path. Try '" + Strings.SETPATH + "'!");
        }
    }

    private static void DownloadImageWSpecifiedFolder(WebClient webClient, string url, string folder)
    {
        webClient.DownloadFile(new Uri(url), folder + "/" + GenerateRandomName.Generate() + ".jpeg");
    }

    //download mp4 and mp3
    private static void DownloadMP4MP3WDefaultFolder(string url, string folder)
    {
        if (!DefaultFolder.DefaultPathExists())
        {
            Console.WriteLine("You still doesn't configured a default folder path. Try '" + Strings.SETPATH + "'!");
            return;
        }

        if (Validator.IsValidDefaultFolder())
        {
            var youtube = YouTube.Default;
                var video = youtube.GetVideo(url);

            /* When user copy/paste the path, Windows doesn't put the last '\'. Ex.: (C:\Users\User\Documents). 
             * So the '\' is added, */
            folder = DefaultFolder.GetDefaultPath() + @"\";

            File.WriteAllBytes(folder + video.FullName, video.GetBytes());

            var MP4Video = new MediaFile
            {
                Filename = folder + video.FullName
            };

            var MP3Audio = new MediaFile
            {
                Filename = folder + video.FullName + ".mp3"
            };

            using (var engine = new Engine())
            {
                engine.GetMetadata(MP4Video);
                engine.Convert(MP4Video, MP3Audio);
            }
        }
    }

    private static void DownloadMP4MP3WSpecifiedFolder(string url, string folder)
    {
        var youtube = YouTube.Default;
        var video = youtube.GetVideo(url);

        /* When user copy/paste the path, Windows doesn't put the last '\'. Ex.: (C:\Users\User\Documents). 
         * So the '\' is added, */
        folder += @"\";

        File.WriteAllBytes(folder + video.FullName, video.GetBytes());

        var MP4Video = new MediaFile
        {
            Filename = folder + video.FullName
        };

        var MP3Audio = new MediaFile
        {
            Filename = folder + video.FullName + ".mp3"
        };

        using (var engine = new Engine())
        {
            engine.GetMetadata(MP4Video);
            engine.Convert(MP4Video, MP3Audio);
        }
    }
}
