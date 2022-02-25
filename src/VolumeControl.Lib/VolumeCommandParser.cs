using System;

namespace VolumeControl
{
    public static class VolumeCommandParser
    {
        private const string ARGUMENT_VOLUME_DOWN = "down";

        private const string ARGUMENT_VOLUME_MUTE = "mute";

        private const string ARGUMENT_VOLUME_UP = "up";

        public static VolumeCommand Parse(string command)
        {
            if (command.Equals(ARGUMENT_VOLUME_UP, StringComparison.Ordinal)) return VolumeCommand.Up;
            if (command.Equals(ARGUMENT_VOLUME_DOWN, StringComparison.Ordinal)) return VolumeCommand.Down;
            if (command.Equals(ARGUMENT_VOLUME_MUTE, StringComparison.Ordinal)) return VolumeCommand.Mute;

            return VolumeCommand.None;
        }
    }
}
