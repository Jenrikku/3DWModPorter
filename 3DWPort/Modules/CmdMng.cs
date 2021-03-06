﻿using System.Collections.Generic;

namespace _3DWPort.Modules {
    class CmdMng {
        public static readonly List<ICommand> commandList = new List<ICommand>();

        public static void Register(ICommand command) {
            commandList.Add(command);
        }

        public static void RegisterArray(ICommand[] commands) {
            commandList.AddRange(commands);
        }

        public static void UnLoad(ICommand command) {
            commandList.Remove(command);
        }

        public static void Execute(string commandName, string[] args) {
            foreach(ICommand command in commandList) {
                if(command.Name().ToLower().Equals(commandName.ToLower())) command.Action(args);
            }
        }

        public static ICommand Get(string commandName) {
            foreach(ICommand command in commandList) {
                if(command.Name().ToLower().Equals(commandName.ToLower())) return command;
            }

            return null;
        }
    }
}
