using System;

namespace VolumeControl
{
    static class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                return;
            }

            var volumeCommand = VolumeCommandParser.Parse(args[0]);
            VolumeControl.RunCommand(volumeCommand);
        }
    }
}
