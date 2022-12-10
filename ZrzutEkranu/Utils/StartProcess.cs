using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZrzutEkranu.Utils
{
    internal static class StartProcess
    {
        public static void Screenclip()
        {
            var process = new System.Diagnostics.Process();
            var startInfo = new System.Diagnostics.ProcessStartInfo
            {
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = "/C explorer ms-screenclip:"
            };

            process.StartInfo = startInfo;
            process.Start();
        }
    }
}
