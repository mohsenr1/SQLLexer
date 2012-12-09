using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SQLLexerByMohsenr1
{
    public class Lexer : ILexer
    {
        Regex endOfLineRegex = new Regex(@"\r\n|\r|\n", RegexOptions.Compiled);             //تعریف خط جدید. این الگوی رجکس خطوط جدید را مچ می کند.
        IList<TokenDefinition> tokenDefinitions = new List<TokenDefinition>();              //یک لیست خالی از تعریف الگوهای توکن ها برایمان ایجاد می کند.

        /// <summary>
        /// این تابع الگوهای وارد شده به خود را به لیست الگوهای تعریف شده اضاف می کند.
        /// </summary>
        /// <param name="tokenDefinition"></param>
        public void AddDefinition(TokenDefinition tokenDefinition)
        {
            tokenDefinitions.Add(tokenDefinition);
        }

        /// <summary>
        /// این تابع کار اصلی لکس کردن را برایمان انجام می دهد.
        /// </summary>
        /// <param name="source">سورس ورودی . یعنی کد نوشته شده توسط کاربر برای لکس شدن</param>
        /// <returns>لیستی از توکن ها با ویژگی خودشان</returns>
        public IEnumerable<Token> Tokenize(string source)
        {
            int currentIndex = 0;                                                           //شمارنده ی ایندکس کنونی یعنی در حال خواندن کاراکتر ان ام
            int currentLine = 1;                                                            //شمارنده ی خط کنونی
            int currentColumn = 0;                                                          //شمارنده ی کاراکتر کنونی در خط یعنی ستون ان ام

            while (currentIndex < source.Length)                                            //تا زمانی که به آخر متن وارد شده نرسیده ای
            {
                TokenDefinition matchedDefinition = null;                                   //الگوی انطباقی به وجود بیاور و مقدارش را نال بگذار
                int matchLength = 0;                                                        //متغیری برای اندازه ی انطباق به وجود بیاور و آن را صفر کن

                foreach (var rule in tokenDefinitions)                                      //به ازای هر الگو در لیست الگو ها
                {
                    var match = rule.Regex.Match(source, currentIndex);                     //متغیری به نام انطباق به وجود بیاور و مقدار آن را برابر کلاس رجکس مج شده قرار برده. توضیحات بیشتر را در خواص تابع مچ در ام اس دی ان جستجو کنید.

                    if (match.Success && (match.Index - currentIndex) == 0)                 //اگر انطباق درست بود و تابع تمام کاراکتر های کلمه ی مچ شده را خوانده بود
                    {
                        matchedDefinition = rule;                                           //الگوی انطباق داده شده را برابر الگوی کنونی بگذار
                        matchLength = match.Length;                                         //طول انطباق را برابر کلمه ی ورودی قرار بده
                        break;                                                              //از حلقه ی فور ایچ بیا بیرو
                    }
                }

                if (matchedDefinition == null)                                              //اگر هیچ الگوی انطباقی پیدا نشده بود یک اکسپشن پرتاب کن
                {
                    throw new Exception(string.Format("نتوانستم این کاراکتر را به جا بیاورم '{0}' که کاراکتر {1} است و در خط {2} و مکان {3} قرار دارد.", source[currentIndex], currentIndex, currentLine, currentColumn));
                }
                else                                                                        //وگرنه بیا این کار ها را بکن
                {
                    var value = source.Substring(currentIndex, matchLength);                //در قدم اول یک متغیر به نام مقدار بساز و مقدار آن را برابر کلمه ی تطبیق داده شده قرار بده

                    if (!matchedDefinition.IsIgnored)                                       //اگر نوع انطباق الگویمان از نوع قابل درگذشتن نبود، یعنی باید لکس می شد
                                                                                            //بیا و یک نمونه از کلاس توکن به لیست توکن ها اضاف کن و از حلقه دوباره شروع کن به خواندن (خواص ییلد) 
                        yield return new Token(matchedDefinition.Type, value, new TokenPosition(currentIndex, currentLine, currentColumn));

                    var endOfLineMatch = endOfLineRegex.Match(value);                       //بعد بیا یک متغیر به اسم انطباق آخر خط درست کن و مقدارش را رجکس مچ مقدار توکن پیدا شده با الگوی تطبیق آخر خط (همانی که در بالای صفحه ایجاد کردیم) قرار بده (رجوع شود به خواص تابع مچ)
                    if (endOfLineMatch.Success)                                             //اگر انطباق موفقیت آمیز بود
                    {
                        currentLine += 1;                                                   //یکی به خط کنونی اضاف کن یعنی رفتیم به خط بعدی
                                                                                            //مقدار کاراکتر کنونی خط یعنی ستون کنونی را هم برابر طول توکن منهای ایندکس آخرین کاراکتر خط بکن
                        currentColumn = value.Length - (endOfLineMatch.Index + endOfLineMatch.Length);
                    }
                    else                                                                    //اگر هم که آخر خط نبودیم
                    {
                        currentColumn += matchLength;                                       //ایندکس کاراکتر کنونی در خط را به علاوه ی طول کلمه ی تطبیق داده شده قرار بده
                    }

                    currentIndex += matchLength;                                            //کلا در آخر هم ایندکس کنونی را به علاوه ی طول کلمه ی انطباق داده شده قرار بده
                }
            }
                                                                                            //در آخر کار هم متغیر آخر کاراکتر را به لیست توکن ها اضاف کن و کار تابع را تمام کن
            yield return new Token(Token.TokenType.End, "$", new TokenPosition(currentIndex, currentLine, currentColumn));
        }
    }
}
