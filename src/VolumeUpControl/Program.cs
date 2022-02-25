using System;
using VolumeControl;

namespace VolumeUpControl
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            VolumeControl.VolumeControl.RunCommand(VolumeCommand.Up);
        }
    }
}
