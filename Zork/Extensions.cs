using System;

namespace Zork
{
    public static class Extensions
    {
        public static Commands ToCommand(this string commandString) => Enum.TryParse(commandString, true, out Commands result) ? result : Commands.UNKNOWN;
    }
}
