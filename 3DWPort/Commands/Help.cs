using System;
using System.Collections.Generic;
using System.Text;

namespace _3DWPort.Commands {
    class Help : ICommand {
        public void Action(string[] args) {
            if(args[0].Equals("")) {
                Console.WriteLine("List of available commands:\n");
                foreach(ICommand command in CommandManager.commandList) {
                    Console.WriteLine(command.Name() + " - " + command.Help()[0]);
                }
            } else {
                ICommand command = CommandManager.Get(args[0]);

                if(command == null) {
                    Console.WriteLine("No command with this name was found.");
                    return;
                }

                Console.WriteLine(args[0] + " - " + command.Help()[0] + "\n");
                Console.WriteLine(command.Help()[1]);
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
