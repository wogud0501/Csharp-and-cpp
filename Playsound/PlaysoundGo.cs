using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices; // 네임 스페이스 추가

namespace Playsound
{
    public class PlaysoundGo
    {
    }
    public enum PlaySoundFlags : int
    {
        SND_SYNC = 0x0000,
        SND_ASYNC = 0x0001,
        SND_NODEFAULT = 0x0002,
        SND_LOOP = 0x0008,
        SND_NOSTOP = 0x0010,
        SND_NOWAIT = 0x00002000,
        SND_FILENAME = 0x00020000,
        SND_RESOURCE = 0x00040004

    }
    [DllImport("winmm.DLL", EntryPoint = "Playsound", SetLastError = true)]
    public static extern bool PlaySoundStart(string szSound,
        System.IntPtr hMod, PlaySoundFlags flags);
}
