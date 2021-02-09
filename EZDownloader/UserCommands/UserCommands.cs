using System;
using System.Collections;

public class UserCommands
{
    public static void ReturnUserCommandInformation(string command)
    {
        if (command.Trim().Equals(Strings.HELP))
        {
            Commands.Help();
            return;
        }
        if (command.Trim().Equals(Strings.SETPATH))
        {
            Commands.SetURLPath();
            return;
        }
        // download command...
        if (command.Trim().StartsWith("http") || command.Trim().StartsWith("https"))
        {
            Commands.SelectFileFormat(command);
            return;
        }
        // else...
        Console.WriteLine("What you mean with '" + command + "'? If you've doubts, try '--help'.");
        return;
    }
}