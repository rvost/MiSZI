using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab01.Task2
{
    class SimpleCodeTable:ICodeTable
    {
        private Dictionary<char, string> _codes = new Dictionary<char, string>()
        {
            ['М'] = "001",
            ['А'] = "010",
            ['Ш'] = "011",
            ['И'] = "100",
            ['Н'] = "101",
        };

        public string this[char letter]
        {
            get
            {
                if (_codes.ContainsKey(letter))
                    return _codes[letter];
                else
                    throw new ArgumentOutOfRangeException(nameof(letter), $"Буква {letter} отсутствует в кодовой таблице");
            }
        }

        public char this[string code]
        {
            get
            {
                if (_codes.Values.Contains(code))
                    return _codes.First(x => x.Value == code).Key;
                else
                    throw new ArgumentOutOfRangeException(nameof(code), $"Код {code} отсутствует в кодовой таблице");
            }
        }

        public int CodeLength => 3;
    }
}
