using System;

namespace _3DWPort.Commands {
    class Unpack : ICommand {
        public void Action(string[] args) {
            throw new NotImplementedException();
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
