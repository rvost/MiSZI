using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01.Task2
{
    class Decoder<TTable> where TTable : ICodeTable, new()
    {
        private TTable _table = new TTable();

        public string Decode(string code)
        {
            StringBuilder message = new StringBuilder();
            for (int pos = 0; pos < code.Length; pos += _table.CodeLength)
                message.Append(_table[code.Substring(pos, _table.CodeLength)]);
            return message.ToString();
        }
    }
}
