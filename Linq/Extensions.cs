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
}
