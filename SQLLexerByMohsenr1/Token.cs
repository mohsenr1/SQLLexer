using System;

namespace SQLLexerByMohsenr1
{
    public class Token
    {
        /// <summary>
        /// کانستراکتو کلاس توکن ها
        /// </summary>
        /// <param name="type">ورودی نوع</param>
        /// <param name="value">ورودی مقدار</param>
        /// <param name="position">ورودی موقعیت در متن</param>
        public Token(TokenType type, string value, TokenPosition position)
        {
            Type = type;
            Value = value;
            Position = position;
        }

        public TokenPosition Position { get; set; }

        private TokenType _type;
        public TokenType Type
        {
            get { return _type; }
            set { _type = value; }

        }

        public string Value { get; set; }

        /// <summary>
        /// انواع تایپ توکن ها
        /// </summary>
        public enum TokenType
        {
            Keyword,
            Literal,
            String,
            Variable,
            Digit,
            Operator,
            Parenthese,
            EQ,
            GT,
            LT,
            Comment,
            WhiteSpace,
            Semicolon,
            Colon,
            Dot,
            End
        }

        /// <summary>
        /// آورراید کردن تابع تو استرینگ برای نوشتن توکن در تکست باکس
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("توکن:  نوع: \"{0}\", مقدار: \"{1}\" | موقعیت:  شماره: \"{2}\", خط: \"{3}\", کاراکتر: \"{4}\" ", Type, Value, Position.Index, Position.Line, Position.Column);
        }
    }
}
