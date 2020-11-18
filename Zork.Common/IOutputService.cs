using System;
using System.Collections.Generic;
using System.Text;

namespace Zork
{
    public interface IOutputService
    {
        void Writeline(string value);

        void Writeline(object value);
    }
}
