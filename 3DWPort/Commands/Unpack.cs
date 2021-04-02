using _3DWPort.Modules;
using Hack.io.YAZ0;
using System;
using System.IO;
using SZS;

namespace _3DWPort.Commands {
    /// <summary>
    /// Decompresses a szs to the temp directory. %temp%\JkKU\|random|
    /// </summary>
    class Unpack : ICommand {
        public void Action(string[] args) {
            if(args.Length < 1) {
                CmdMng.Execute("help", new string[] { "unpack" });
                return;
            }

            if(args.Length > -1) {
                var filesInside = SARC.UnpackRamN(YAZ0.Decompress(File.ReadAllBytes(args[0]))).Files;

                foreach(String key in filesInside.Keys) {
                    File.WriteAllBytes(Path.Join(TempMng.Dir, key), filesInside[key]);
                }   
            }
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
