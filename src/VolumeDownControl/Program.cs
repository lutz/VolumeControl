using System;
using VolumeControl;

namespace VolumeDownControl
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            VolumeControl.VolumeControl.RunCommand(VolumeCommand.Down);
        }
    }
}
