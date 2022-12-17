using System.Diagnostics;

namespace ZrzutEkranu.Utility
{
    internal static class StartProcess
    {
        public static void Screenclip()
        {
            var process = new Process();
            var startInfo = new ProcessStartInfo
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = "/C explorer ms-screenclip:"
            };

            process.StartInfo = startInfo;
            process.Start();
        }
    }
}