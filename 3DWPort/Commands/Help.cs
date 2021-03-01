using System;
using System.Collections.Generic;
using System.Text;

namespace _3DWPort.Commands {
    class Help : ICommand {
        public void Action(string[] args) {
            Console.WriteLine("List of available commands:\n");
            foreach(ICommand command in CommandManager.commandList) {
                Console.WriteLine(command.Name() + " - " + command.Help()[0]);
            }
        }

        public string Name() {
            return "help";
        }

        string[] ICommand.Help() {
            return new string[] {
                "The help command.",
                "Usage: help <command>\n" +
                "If <command> isn't given, a list of possible commands is returned. Otherwise, an extended help for the specific command will be printed."
            };
        }
    }
}
