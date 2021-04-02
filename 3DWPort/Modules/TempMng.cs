using System;
using System.IO;

namespace _3DWPort.Modules {
    class TempMng {
        public static string Dir;

        public static void InitTempPath() {
            const String chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            char[] stringChars = new char[6];
            Random random = new Random();

            for(int i = 0; i < stringChars.Length; i++) {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            Dir = Path.Join(Path.GetTempPath(), "JkKU", new string(stringChars));

            Directory.CreateDirectory(Dir);
        }

        public static void DeleteTempPath() {
            Directory.Delete(Dir, true);
        }
    }
}
