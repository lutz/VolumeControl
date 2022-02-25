using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace VolumeControl
{
    internal static class VolumeControl
    {
        public static void RunCommand(VolumeCommand command)
        {
            switch (command)
            {
                case VolumeCommand.Up:
                    Up();
                    break;
                case VolumeCommand.Down:
                    Down();
                    break;
                case VolumeCommand.Mute:
                    Mute();
                    break;
            }
        }

        private static void Down() => keybd_event((byte)Keys.VolumeDown, 0, 0, 0);

        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        private static void Mute() => keybd_event((byte)Keys.VolumeMute, 0, 0, 0);

        private static void Up() => keybd_event((byte)Keys.VolumeUp, 0, 0, 0);
    }
}
