using System;
using VolumeControl;

namespace VolumeMuteControl
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            VolumeControl.VolumeControl.RunCommand(VolumeCommand.Mute);
        }
    }
}
