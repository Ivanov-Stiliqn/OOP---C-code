using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01_CustomLINQExtensionMethods
{
    public static class ExtensionMethods
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            var results=new List<T>();

            foreach (var element in collection)
            {
                if (!predicate(element))
                {
                    results.Add(element);
                }
            }

            return results;
        }



        public static TSelector MyMax<TSource, TSelector>(
            this IEnumerable<TSource> collection,
            Func<TSource, TSelector> criterion) where TSelector : IComparable<TSelector>
        {
            TSelector max = criterion(collection.First());

            foreach (var item in collection.Where(item => max.CompareTo(criterion(item)) < 0))
            {
                max = criterion(item);
            }

            return max;
        }


    }
}
