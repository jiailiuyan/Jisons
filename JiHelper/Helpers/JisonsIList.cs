﻿/* 迹I柳燕
 * 
 * FileName:   JisonsIList.cs
 * Version:    1.0
 * Date:       2014.03.18
 * Author:     Ji
 * 
 *========================================
 * @namespace  Jisons 
 * @class      JisonsIList
 * @extends    
 * 
 *             对于 IList 的Linq扩展查询
 * 
 *========================================
 * Hi,小喵喵...
 * Copyright © 迹I柳燕
 * 
 * 转载请保留...
 * 
 */

using System.Collections.Generic;
using System.Linq;

namespace Jisons
{
    public static class JisonsIList
    {
        /// <summary> 执行删除所有子项，且忽略锁定检查 </summary>
        /// <typeparam name="T">遍历的子类型</typeparam>
        /// <param name="items">欲清空的列表,继承IList</param>
        public static void DeleteAllItems<T>(this IList<T> items)
        {
            if (items != null)
            {
                var count = items.Count();
                if (count > 0)
                {
                    for (int i = count - 1; i >= 0; i--)
                    {
                        items.RemoveAt(i);
                    }
                }
            }
        }

    }
}