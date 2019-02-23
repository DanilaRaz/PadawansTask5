using System;

namespace PadawansTask5
{
    public static class ArrayHelper
    {
        public static string CheckIfSymmetric(int[] source)
        {
            if (source == null)
            {
                throw new ArgumentNullException();
            }
            if (source.Length == 0)
            {
                throw new ArgumentException();
            }
            bool result=true;
            for (int i = 0; i < source.Length / 2; i++)
            {
                if (source[i] == source[source.Length - i-1])
                {
                    result = true;
                }
                else
                {
                    result=false;
                    break;
                }
            }
            if (result == true)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }
    }
}
