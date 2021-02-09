class Validator
{
    // Default path validations;
    public static bool IsValidDefaultFolder()
    {
        return DefaultFolder.GetDefaultPath().Length > 0;
    }
    public static bool DefaultFolderWasSelected(string folder)
    {
        return folder.Trim().Equals(".");
    }
    public static bool IsValidDefaultPathRequest(string path)
    {
        return path.Trim().Length != 0;
    }
}