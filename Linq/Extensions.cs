using System;
using System.Collections.Generic;
using System.Text;

namespace Linq;

internal static class Extensions
{
    public static IEnumerable<T> CustomWhere<T>(this IEnumerable<T> source, Func<T, bool> predicate)
    {
        foreach (var item in source)
        {
            if(predicate(item)) 
                yield return item;
        }
    }

    public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
    {
        foreach (var item in source)
        {
            action?.Invoke(item);
        }
    }
    //public static void ForEach(this int[] source, Action<int> action)
    //{
    //    foreach (var item in source)
    //    {
    //        action?.Invoke(item);
    //    }
    //}
}
