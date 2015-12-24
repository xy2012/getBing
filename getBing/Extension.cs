using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace getBing
{
    public static class Extension
    {
        private static bool IsChinese(this char c)
        {
            if (c < '\u4E00') return false;
            if (c <= '\u9FA5') return true;
            if (c < '\uF900') return false;
            if (c <= '\uFA2D') return true;
            return false;
        }

        public static bool ContainsChinese(this string input)
        {
            return input.Any(c => c.IsChinese());
        }
/*
        //The longest common prefix
        public static int LongestCommonPrefix(this string s1, string s2)
        {
            if (s2 == null) return 0;
            int i = 0;
            for (; i < s1.Length && i < s2.Length; i++)
            {
                if (char.ToUpper(s1[i]) != char.ToUpper(s2[i])) return i;
            }
            return i;
        }

        public static void UnfoldInflections(this LE lexiconEntry)
        {
            if (lexiconEntry == null
                || lexiconEntry.Headword == null
                || lexiconEntry.Inflections == null
                || lexiconEntry.Inflections.Count == 0)
            {
                return;
            }

            string headword = lexiconEntry.Headword.Value;

            foreach (INF inflection in lexiconEntry.Inflections)
            {
                inflection.Value = Unfold(headword, inflection.Value);
            }
        }

        private static string Unfold(string original, string cut)
        {
            if (cut[0] == '~')
            {
                return original + cut.Substring(1);
            }
            else if (cut.Length >= 2 && Char.IsDigit(cut[0]) && cut[1] == '~')
            {
                int indent = int.Parse(cut[0].ToString());
                return original.Substring(0, original.Length - indent) + cut.Substring(2);
            }
            else
            {
                return cut;
            }
        }
    }

    public class EventHandlerHelper
    {
        public static void ClearAllEvents(object objectHasEvents, string eventName)
        {
            if (objectHasEvents == null)
            {
                return;
            }
            try
            {
                EventInfo[] events = objectHasEvents.GetType().GetEvents(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                if (events == null || events.Length < 1)
                {
                    return;
                }
                for (int i = 0; i < events.Length; i++)
                {
                    EventInfo ei = events[i];
                    if (ei.Name == eventName)
                    {
                        FieldInfo fi = ei.DeclaringType.GetField(eventName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                        if (fi != null)
                        {
                            fi.SetValue(objectHasEvents, null);
                        }
                        break;
                    }
                }
            }
            catch
            { }
        }
        */
    }
}
