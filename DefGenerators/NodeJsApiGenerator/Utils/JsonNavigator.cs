using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace NodeJsApiGenerator
{
    static class JsonNavigator
    {
        public static List<T> NotNull<T>(this List<T> list)
        {
            if (list == null)
                return new List<T>();
            return list;
        }
        public static Dictionary<string, object> AsDictionary(this object obj)
        {
            return obj as Dictionary<string, object>;
        }
        public static IList AsList(this object obj)
        {
            return obj as IList;
        }
        public static List<string> GetNames(this object obj)
        {
            return obj.AsDictionary().Keys.ToList();
        }
        public static List<object> GetValues(this object obj)
        {
            if (obj == null)
                return null;
            var dic = obj.AsDictionary();
            if (dic != null)
                return dic.Values.ToList();
            var list = obj.AsList();
            if (list != null)
                return list.Cast<object>().ToList();
            return null;
        }
        public static List<T> GetValues<T>(this object obj, string name)
        {
            return obj.AsDictionary().Values.Cast<T>().ToList();
        }
        public static List<object> GetValues(this object obj, string name)
        {
            return obj.Get(name).GetValues();
        }
        public static object Get(this object obj, string name)
        {
            return obj.AsDictionary().TryGetValue(name);
        }
        public static T Get<T>(this object obj, string name)
        {
            return (T)obj.AsDictionary().TryGetValue(name);
        }
        public static object Get(this object obj, int index)
        {
            return obj.AsList()[index];
        }
        public static T Get<T>(this object obj, int index)
        {
            return (T)obj.AsList()[index];
        }
    }

    static class ListExtensions
    {
        public static void RemoveDoubles<T>(this List<T> list, T item) where T : class
        {
            var i = 0;
            var count = 0;
            while (i < list.Count)
            {
                var item2 = list[i];
                if (item2 == item)
                {
                    count++;
                    if (count > 1)
                    {
                        list.RemoveAt(i);
                        continue;
                    }
                }
                i++;
            }
        }
        public static List<K> RemoveDoublesByKey<K, T>(this List<T> list, Func<T, K> keySelector)
            where T : class
            where K : class
        {
            var removed = new List<K>();
            var set = new HashSet<K>();
            var i = 0;
            while (i < list.Count)
            {
                var item = list[i];
                var key = keySelector(item);
                if (key != null)
                {
                    if (set.Contains(key))
                    {
                        list.RemoveAt(i);
                        removed.Add(key);
                        continue;
                    }
                    else
                    {
                        set.Add(key);
                    }
                }
                i++;
            }
            return removed;
        }

        public static IEnumerable<T> Ungroup<K, T>(this IEnumerable<IGrouping<K, T>> groups)
        {
            foreach (var group in groups)
            {
                foreach (var item in group)
                    yield return item;
            }
        }

    }
}
