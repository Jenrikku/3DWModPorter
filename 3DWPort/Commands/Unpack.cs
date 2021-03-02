using System;

namespace _3DWPort.Commands {
    class Unpack : ICommand {
        public void Action(string[] args) {
            //Hack.io.YAZ0.YAZ0
        }

        public string Name() {
            return "unpack";
        }

        public string[] Help() {
            return new string[] {
                "Unpacks a szs.",
                "This is sample text.\nAnd yet another sample text."
            };
        }
    }
}
