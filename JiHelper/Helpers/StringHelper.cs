﻿/* 迹I柳燕
 * 
 * FileName:   StringHelper.cs
 * Version:    1.0
 * Date:       2014.03.18
 * Author:     Ji
 * 
 *========================================
 * @namespace  Jisons 
 * @class      StringHelper
 * @extends    
 * 
 *             对于String的扩展方法
 * 
 *========================================
 * Hi,小喵喵...
 * Copyright © 迹I柳燕
 * 
 * 转载请保留...
 * 
 */

using System;
using System.Linq;
using System.Text;

namespace Jisons
{
    public static class StringHelper
    {

        #region 字符编码转换

        /// <summary> string 转换到 byte[] </summary>
        /// <param name="body"> 将要转换的 string </param>
        /// <returns> 返回转换后的 byte[] </returns>
        public static byte[] ConvertToASCII(this string str)
        {
            return new ASCIIEncoding().GetBytes(str);
        }

        #endregion

        /// <summary> 替换最后一个匹配字符串 </summary>
        /// <param name="str"> 原字符串 </param>
        /// <param name="oldStr"> 即将被替换的字符串 </param>
        /// <param name="newStr"> 即将替换的字符串, null => string.Empty </param>
        /// <param name="comparisonType"> 字符串检查类型 </param>
        /// <returns> 返回替换后的字符串 </returns>
        public static string ReplaceLast(this string str, string oldStr, string newStr, StringComparison comparisonType = StringComparison.CurrentCultureIgnoreCase)
        {
            newStr = newStr ?? string.Empty;
            if (!string.IsNullOrWhiteSpace(str))
            {
                int index = str.LastIndexOf(oldStr, comparisonType);
                if (index != -1)
                {
                    string reStr = new string(str.Take(index).ToArray()) + newStr;
                    return reStr;
                }
            }
            return str;
        }

        //全角转半角
        //string str = "ａｂｃｄｅｆｇｈｉｊｋｌｍｎｏｐｑｒｓｔｕｖｗｘｙｚＡＢＣＤＥＦＧＨＩＪＫＬＭＮＯＰＱＲＳＴＵＶＷＸＹＺ～！＠＃＄％︿＆＊（）＿－＋｜＼｛｝［］：＂；＇＜＞，．？／０１２３４５６７８９";
        //string str2 = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ~!@#$%^&*()_-+|\\{}[]:\";'<>,.?/0123456789";

    }
}