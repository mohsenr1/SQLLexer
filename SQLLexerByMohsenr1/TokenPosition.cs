using System;

namespace SQLLexerByMohsenr1
{
    public class TokenPosition
    {
        /// <summary>
        /// کانستراکتور کلاس موقعیت توکن
        /// </summary>
        /// <param name="index">ایندکس</param>
        /// <param name="line">خط</param>
        /// <param name="column">ستون (کاراکتر چندم در خط)</param>
        public TokenPosition(int index, int line, int column)
        {
            Index = index;
            Line = line;
            Column = column;
        }

        public int Column { get; private set; }
        public int Index { get; private set; }
        public int Line { get; private set; }
    }
}
