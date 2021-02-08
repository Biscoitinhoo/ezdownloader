class Validator
{
    // Default path validations;
    public static bool IsValidDefaultFolder()
    {
        return DefaultFolder.defaultFolder != null;
    }
    public static bool DefaultFolderWasSelected(string folder)
    {
        return folder.Equals(".");
    }
    public static bool IsValidDefaultPathRequest(string path)
    {
        return path.Trim().Length != 0;
    }
}