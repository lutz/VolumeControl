using System;

namespace VolumeControl
{
    internal static class VolumeCommandParser
    {
        private const string ARGUMENT_VOLUME_DOWN = "-";

        private const string ARGUMENT_VOLUME_MUTE = "0";

        private const string ARGUMENT_VOLUME_UP = "+";

        public static VolumeCommand Parse(string command)
        {
            if (command.Equals(ARGUMENT_VOLUME_UP, StringComparison.Ordinal)) return VolumeCommand.Up;
            if (command.Equals(ARGUMENT_VOLUME_DOWN, StringComparison.Ordinal)) return VolumeCommand.Down;
            if (command.Equals(ARGUMENT_VOLUME_MUTE, StringComparison.Ordinal)) return VolumeCommand.Mute;

            return VolumeCommand.None;
        }
    }
}
