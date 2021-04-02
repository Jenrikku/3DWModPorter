using _3DWPort.Modules;
using System;
using System.Text;

namespace _3DWPort {
    class Program {
        static void Main(string[] args) {
            // Enables Shift-JIS encoding
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Encoding.GetEncoding("Shift-JIS");

            CmdMng.RegisterArray(new ICommand[] {
                new Commands.Help(),
                new Commands.Unpack()
            });

            TempMng.InitTempPath();

            Console.Write("3DW Mod Porter 0.1 by JkKU\n\n");

            if(args.Length > 0) {
                string[] subargs = new string[] { "" };
                if(args.Length >= 1) {
                    subargs = new string[args.Length - 1];

                    for(byte i = 2; args.Length >= i; i++) {
                        subargs[i - 2] = args[i - 1];
                    }
                }

                CmdMng.Execute(args[0], subargs);
            } else {
                Console.Write(
                    "Usage: 3DWPort [command] [args]\n" +
                    "Try typing 'help'.");
            }

            //TempMng.DeleteTempPath();
        }
    }
}
