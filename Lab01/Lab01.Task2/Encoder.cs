using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01.Task2
{
    class Encoder<TTable> where TTable : ICodeTable, new()
    {
        private TTable _table = new TTable();

        public string Encode(string message)
        {
            var code = new StringBuilder();
            foreach (var letter in message)
                code.Append(_table[letter]);
            return code.ToString();
        }
    }
}
