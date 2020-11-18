using System;
using System.Collections.Generic;
using System.Text;

namespace Zork
{
    internal class ConsoleOutputService : IOutputService
    {
        public void Writeline(string value)
        {
            Console.WriteLine(value);
        }

        public void Writeline(object value)
        {
            Writeline(value.ToString());
        }
    }
}
