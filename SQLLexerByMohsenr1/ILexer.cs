using System;
using System.Collections.Generic;

namespace SQLLexerByMohsenr1
{
    /// <summary>
    /// تعریف توابع در این اینترفیس برای پیاده سازی بعدی
    /// شاید به نظر لازم نرسد اما از پیچیدگی کد ها کم می کند.
    /// </summary>
    public interface ILexer
    {
        /// <summary>
        /// تعریف این تابع که کارش افزودن تعریف توکن ها به مخزن الگوهاست.
        /// </summary>
        /// <param name="tokenDefinition"></param>
        void AddDefinition(TokenDefinition tokenDefinition);

        /// <summary>
        /// این تابع، تابع اصلی لکسر ما خواهد بود.
        /// </summary>
        /// <param name="source">ورودی کد نوشته شده برای لکس شدن</param>
        /// <returns>خروجی یک لیست آی نامیریبل از کلاس توکن خواهد بود. یعنی لیستی از توکن ها</returns>
        IEnumerable<Token> Tokenize(string source);
    }
}
