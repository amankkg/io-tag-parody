using System;
using Utilities;
using WithIO = System.ObsoleteAttribute;

namespace Services
{
    [WithIO(Messages.TypeHasIo)]
    public static class ConsoleService
    {
        [WithIO(Messages.FunctionIsImpure, true)]
        public static string Read() => Console.ReadLine();

        [WithIO(Messages.FunctionIsImpure, true)]
        public static void Write(string line) => Console.WriteLine(line);
    }
}
