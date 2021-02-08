using MediaToolkit;
using MediaToolkit.Model;
using System;
using System.IO;
using System.Net;
using VideoLibrary;

public class Downloader
{
    public static void Download(string url, string folder, string name)
    {
        try
        {
            using (WebClient service = new WebClient())
            {
                WebClient webClient = new WebClient();
                ValidateAndDownloadFile(webClient, url, folder, name);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Ops! Something went wrong... \n" + e);
        }
    }

    private static void ValidateAndDownloadFile(WebClient webClient, string url, string folder, string name)
    {
        // Default path
        if (Validator.DefaultFolderWasSelected(folder))
        {
            if (Validator.IsValidDefaultFolder())
            {
                webClient.DownloadFileAsync(new Uri(url), DefaultFolder.defaultFolder + "/" + name);
                return;
            }
            else
            {
                Console.WriteLine("You still doesn't configured a default folder path. Try '--set-path'!");
            }
        }
        else
        {
            // Selected path
            DownloadMP3AndMP4Audio(url, folder, name);
        }
    }

    private static void DownloadMP3AndMP4Audio(string url, string folder, string name)
    {
        var youtube = YouTube.Default;
        //url...
        var video = youtube.GetVideo(url);
        File.WriteAllBytes(folder + video.FullName, video.GetBytes());

        var MP4Video = new MediaFile
        {
            Filename = folder + video.FullName
        };
        var MP3Audio = new MediaFile
        {
            Filename = $"{folder + video.FullName}.mp3"
        };

        using (var engine = new Engine())
        {
            engine.GetMetadata(MP4Video);
            engine.Convert(MP4Video, MP3Audio);
        }
    }
}
