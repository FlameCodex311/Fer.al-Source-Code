/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Utils
{
	public static class ListTools // TypeDefIndex: 7046
	{
		// Methods
		public static bool OffsetAtIndex<T>(IList<T> list, int index, bool offsetDown, bool offsetNow = true /* Metadata: 0x0076676C */);
		public static List<T> ShallowCopy<T>(List<T> list);
		public static bool CopyTo<T>(IList<T> fromList, IList<T> toList);
		public static bool CopyTo<T>(IList<T> fromList, IList<T> toList, int fromListStartIndex);
		public static bool CopyTo<T>(IList<T> fromList, IList<T> toList, int fromListStartIndex, int count);
		public static T[] ToArray<T>(IList<T> list);
		public static List<T> Combine<T>(IList<T> list1, IList<T> list2);
		public static bool IsNullOrEmpty<T>(IList<T> list);
		public static List<object> ConvertToObjeclist<T>(IList<T> list);
		public static void Concat<T>(IList<T> list1, IList<T> list2);
		public static bool AddIfUnique<T>(IList<T> list, T item);
		public static int Count<T>(IList<T> list, Predicate<T> predicate);
		public static void TryClear<T>(IList<T> list);
		private static bool yplRrFsYWTJmQhZSqjsEjWYhFLE<T>(IList<T> param_0000f241, T param_0000f242);
		public static int AddAndCreateList<T>(ref IList<T> list, T item);
	}
}
