using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyLabsApp.ExtentionMethods
{
    public static class MathExtensions
    {   
        public static bool IsGreaterThan<T>(this T value1, T value2) where T : IComparable
        {
            return Comparer<T>.Default.Compare(value1, value2) > 0;
        }
    }
}
