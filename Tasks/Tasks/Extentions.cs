using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    static class Extentions
    {
        public static IEnumerable<T> Paginate<T>(this IEnumerable<T> source, int page, int pageSize)
        {
            if(source == null)
                throw new ArgumentNullException(nameof(source));
            if (page < 1)
                throw new ArgumentOutOfRangeException(nameof(page), "Page number must be >= 1.");
            if (pageSize < 1)
                throw new ArgumentOutOfRangeException(nameof(pageSize), "Page size must be >= 1.");

            int startIndex = (page - 1) * pageSize;
            int index = 0;
            int currentSize = 0;

            foreach(T item in source)
            {
                if(index >= startIndex && currentSize <= pageSize)
                {
                    if (currentSize == pageSize)
                        yield break;

                    currentSize++;
                    yield return item;
                }
                index++;
            }

        }

        public static string ToJson<T>(this T obj)
        {
            if(obj == null)
                throw new ArgumentNullException(nameof(obj));
            return JsonSerializer.Serialize(obj);
        }
    }
}
