using System;
using System.Text.RegularExpressions;

namespace SQLLexerByMohsenr1
{
    public class TokenDefinition
    {
        /// <summary>
        /// کانستراکتور تابع تعریف توکن
        /// اگر پارامتر سوم وجود نداشت، بیا همین کلاس را با کانستراکتور بعدی 3 پارامتره با پارامتر سوم فالس صدا بزن
        /// </summary>
        /// <param name="type"></param>
        /// <param name="regex"></param>
        public TokenDefinition(Token.TokenType type,Regex regex):this(type, regex, false)
        {
        }

        /// <summary>
        /// کانستراکتور تابع تعریف توکن ها
        /// </summary>
        /// <param name="type">نوع</param>
        /// <param name="regex">الگوی تطابق</param>
        /// <param name="isIgnored">قابل درگذشتن هست یا نه. یعنی می توان از این مچ شده صرف نظر کرد یا نه</param>
        public TokenDefinition(Token.TokenType type,Regex regex,bool isIgnored)
        {
            Type = type;
            Regex = regex;
            IsIgnored = isIgnored;
        }

        public bool IsIgnored { get; private set; }
        public Regex Regex { get; private set; }
        public Token.TokenType Type { get; private set; }
    }
}
