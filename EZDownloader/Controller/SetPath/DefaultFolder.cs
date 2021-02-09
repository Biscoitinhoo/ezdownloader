using System.IO;

class DefaultFolder
{
    // Path for store default user path content.
    private static readonly string defaultUserPath = Directory.GetCurrentDirectory() + @"\DefaultPath";

    public static void CreateFile(string path)
    {
        // Create directory for store default user path (If it doesn't exists, no problem).
        Directory.CreateDirectory(defaultUserPath);
        // First, clean all the .txt content.
        File.WriteAllText(defaultUserPath + @"\DefaultPath.txt", Prints.Blank());
        // After that, add the user path.
        File.AppendAllText(defaultUserPath + @"\DefaultPath.txt", path);
    }
    public static string GetDefaultPath()
    {
        return File.ReadAllText(defaultUserPath + @"\DefaultPath.txt");
    }
    public static bool DefaultPathExists()
    {
        return File.Exists(defaultUserPath + @"\DefaultPath.txt");
    }
}