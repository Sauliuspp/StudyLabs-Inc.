using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyLabsApp.ExtentionMethods
{
    public static class MathExtensions
    {
        //Extensions using generic type usage
        public static bool MathComparisons<T>(this T value1, T value2, string operand) where T: IComparable
        {
            switch (operand.ToLower())
            {
                case "=":
                    return Comparer<T>.Default.Compare(value1, value2) == 0;
                case "<":
                    return Comparer<T>.Default.Compare(value1, value2) < 0;
                case ">":
                    return Comparer<T>.Default.Compare(value1, value2) > 0;
                default:
                    return false;
            }

        }
    }
}
