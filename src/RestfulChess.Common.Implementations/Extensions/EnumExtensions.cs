﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace RestfulChess.Common.Implementations.Extensions
{
    /// <summary>
    /// General extensions for enumerations
    /// </summary>
    /// <remarks>
    /// Methods are generated by chat gpt 4 from openai
    /// </remarks>
    public static class EnumExtensions
    {
        public static T ParseIgnoreCase<T>(this Enum value, string input) where T : Enum
        {
            return (T)Enum.Parse(typeof(T), input, true);
        }

        public static bool HasFlag<T>(this Enum value, T flag) where T : Enum
        {
            return value.HasFlag(flag as Enum);
        }

        public static IEnumerable<T> GetValues<T>()
        {
            return Enum.GetValues(typeof(T)) as IEnumerable<T>;
        }

        public static string GetDescription(this Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());
            var attributes = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            return attributes != null && attributes.Length > 0 ? attributes[0].Description : value.ToString();
        }
    }
}
