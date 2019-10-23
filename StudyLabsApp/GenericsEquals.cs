using StudyLabsApp;
using System;
using System.Collections.Generic;

public class GenericsEquals
{
    public static bool AreEqual<T>(T Value1, T Value2) where T: IComparable
	{

        return Comparer<T>.Default.Compare(Value1, Value2) == 0;

	}

}
