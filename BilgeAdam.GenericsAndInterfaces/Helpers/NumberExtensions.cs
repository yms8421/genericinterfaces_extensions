using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.GenericsAndInterfaces.Helpers
{
    public static class NumberExtensions
    {
        public static double GetDoubled(this int number)
        {
            return Math.Pow(number, 2);
        }
    }

    public static class ObjectExtensions
    {
        public static string GetPassword(this Random random, int lenght)
        {
            var result = string.Empty;
            var charset = "ABCDEFGHIJKLMNOPRSTUVYZabcdefghijklmnoprstuvyz0123456789!*?+%&/()#._-[]{}";
            for (int i = 0; i < lenght; i++)
            {
                result += charset[random.Next(0, charset.Length)];
            }

            return result;
        }

        public static void AddOrUpdate<K, V>(this Dictionary<K, V> dictionary, K key, V value)
        {
            if (dictionary.ContainsKey(key))
            {
                dictionary[key] = value;
            }
            else
            {
                dictionary.Add(key, value);
            }
        }
    }
}
