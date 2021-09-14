using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public int? StringLenghts(string[] strings)
        {
            int result = 0;

            if (strings == null)
            {
                return null;
            }

            foreach (var str in strings)
            {
                result += str.Length;
            }

            return result;
        }
    }
}
