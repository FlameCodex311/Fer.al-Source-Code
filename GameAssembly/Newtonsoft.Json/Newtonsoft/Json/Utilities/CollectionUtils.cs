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

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001800B4050-0x00000001800B4080
	internal static class CollectionUtils // TypeDefIndex: 7874
	{
		// Methods
		public static bool IsNullOrEmpty<T>(ICollection<T> collection);
		public static bool IsDictionaryType(Type type); // 0x000000018057F960-0x000000018057FAD0
		public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType); // 0x000000018057FE70-0x000000018057FF90
		public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType, Type constructorArgumentType); // 0x000000018057FC00-0x000000018057FE70
		private static IList<int> GetDimensions(IList values, int dimensionsCount); // 0x000000018057F5E0-0x000000018057F960
		private static void CopyFromJaggedToMultidimensionalArray(IList values, Array multidimensionalArray, int[] indices); // 0x000000018057F380-0x000000018057F5E0
		private static object JaggedArrayGetValue(IList values, int[] indices); // 0x000000018057FAD0-0x000000018057FC00
		public static Array ToMultidimensionalArray(IList values, Type type, int rank); // 0x000000018057FF90-0x0000000180580160
	
		// Extension methods
		public static void AddRange<T>(this IList<T> initial, IEnumerable<T> collection);
		public static void AddRange<T>(this IList<T> initial, IEnumerable collection);
		public static int IndexOf<T>(this IEnumerable<T> collection, Func<T, bool> predicate);
		public static bool Contains<T>(this List<T> list, T value, IEqualityComparer comparer);
		public static int IndexOfReference<T>(this List<T> list, T item);
	}
}
