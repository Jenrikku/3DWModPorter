namespace _3DWPort {
    // The interface for commands.
    interface ICommand {
        // This method is called by the main class if the user types the command.
        // "args" are the arguments in array.
        void Action(string[] args);

        // Returns the command name. The string will be tracted as non-case-sensitive. The character \n isn't allowed.
        string Name();

        // Returns the help information for the command as an array. The first object will be tracted as a short description and the second as a large help.
        string[] Help();
    }
}
