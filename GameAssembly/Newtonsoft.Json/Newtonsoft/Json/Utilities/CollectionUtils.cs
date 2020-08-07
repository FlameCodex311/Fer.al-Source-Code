/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Shims;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001801CDDD0-0x00000001801CDE00
	internal static class CollectionUtils // TypeDefIndex: 8040
	{
		// Methods
		public static bool IsNullOrEmpty<T>(ICollection<T> collection);
		public static bool IsDictionaryType(Type type); // 0x0000000180C18180-0x0000000180C182E0
		public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType); // 0x0000000180C18660-0x0000000180C18770
		public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType, Type constructorArgumentType); // 0x0000000180C18400-0x0000000180C18660
		private static IList<int> GetDimensions(IList values, int dimensionsCount); // 0x0000000180C17E00-0x0000000180C18180
		private static void CopyFromJaggedToMultidimensionalArray(IList values, Array multidimensionalArray, int[] indices); // 0x0000000180C17BB0-0x0000000180C17E00
		private static object JaggedArrayGetValue(IList values, int[] indices); // 0x0000000180C182E0-0x0000000180C18400
		public static Array ToMultidimensionalArray(IList values, Type type, int rank); // 0x0000000180C18770-0x0000000180C18940
	
		// Extension methods
		public static void AddRange<T>(this IList<T> initial, IEnumerable<T> collection);
		public static void AddRange<T>(this IList<T> initial, IEnumerable collection);
		public static int IndexOf<T>(this IEnumerable<T> collection, Func<T, bool> predicate);
		public static bool Contains<T>(this List<T> list, T value, IEqualityComparer comparer);
		public static int IndexOfReference<T>(this List<T> list, T item);
	}
}
