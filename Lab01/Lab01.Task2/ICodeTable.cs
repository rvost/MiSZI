using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01.Task2
{
    interface ICodeTable
    {
        int CodeLength { get; }

        string this[char letter] { get; }
        char this[string code] { get; }
    }
}
