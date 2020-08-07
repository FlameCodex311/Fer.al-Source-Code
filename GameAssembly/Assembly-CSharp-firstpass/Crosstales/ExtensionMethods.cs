/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace Crosstales
{
	public static class ExtensionMethods // TypeDefIndex: 9705
	{
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass5_0 // TypeDefIndex: 9706
		{
			// Fields
			public string str; // 0x10
	
			// Constructors
			public <>c__DisplayClass5_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <CTContainsAny>b__0(string searchTerm); // 0x000000018108D480-0x000000018108D510
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass6_0 // TypeDefIndex: 9707
		{
			// Fields
			public string str; // 0x10
	
			// Constructors
			public <>c__DisplayClass6_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <CTContainsAll>b__0(string searchTerm); // 0x000000018108D480-0x000000018108D510
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__21<T> // TypeDefIndex: 9708
		{
			// Fields
			public static readonly <>c__21<T> <>9;
			public static Func<T, string> <>9__21_0;
	
			// Constructors
			static <>c__21();
			public <>c__21();
	
			// Methods
			internal string <CTToString>b__21_0(T element);
		}
	
		// Methods
		public static Transform CTDeepSearch(Transform parent, string name); // 0x000000018107B050-0x000000018107B330
	
		// Extension methods
		public static string CTToTitleCase(this string str); // 0x000000018107C940-0x000000018107CA20
		public static string CTReverse(this string str); // 0x000000018107C8B0-0x000000018107C940
		public static string CTReplace(this string str, string oldString, string newString, StringComparison comp = StringComparison.OrdinalIgnoreCase /* Metadata: 0x0077A2EA */); // 0x000000018107C760-0x000000018107C8B0
		public static bool CTEquals(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase /* Metadata: 0x0077A2EE */); // 0x000000018107C3B0-0x000000018107C440
		public static bool CTContains(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase /* Metadata: 0x0077A2F2 */); // 0x000000018107AFC0-0x000000018107B050
		public static bool CTContainsAny(this string str, string searchTerms, char splitChar = ' ' /* Metadata: 0x0077A2F6 */); // 0x000000018107AE60-0x000000018107AFC0
		public static bool CTContainsAll(this string str, string searchTerms, char splitChar = ' ' /* Metadata: 0x0077A2F8 */); // 0x000000018107AD00-0x000000018107AE60
		public static bool CTisNumeric(this string str); // 0x000000018107CA20-0x000000018107CA40
		public static void CTShuffle<T>(this T[] array, int seed = 0 /* Metadata: 0x0077A2FA */);
		public static string CTDump<T>(this T[] array, string prefix = "" /* Metadata: 0x0077A2FE */, string postfix = "" /* Metadata: 0x0077A302 */);
		public static string CTDump(this Quaternion[] array); // 0x000000018107B330-0x000000018107B4D0
		public static string CTDump(this Vector2[] array); // 0x000000018107C0C0-0x000000018107C220
		public static string CTDump(this Vector3[] array); // 0x000000018107C220-0x000000018107C3B0
		public static string CTDump(this Vector4[] array); // 0x000000018107BC70-0x000000018107BE10
		public static string[] CTToString<T>(this T[] array);
		public static void CTShuffle<T>(this IList<T> list, int seed = 0 /* Metadata: 0x0077A306 */);
		public static string CTDump<T>(this IList<T> list, string prefix = "" /* Metadata: 0x0077A30A */, string postfix = "" /* Metadata: 0x0077A30E */);
		public static string CTDump(this IList<Quaternion> list); // 0x000000018107BE10-0x000000018107C0C0
		public static string CTDump(this IList<Vector2> list); // 0x000000018107B4D0-0x000000018107B730
		public static string CTDump(this IList<Vector3> list); // 0x000000018107B730-0x000000018107B9C0
		public static string CTDump(this IList<Vector4> list); // 0x000000018107B9C0-0x000000018107BC70
		public static List<string> CTToString<T>(this IList<T> list);
		public static string CTDump<K, V>(this IDictionary<K, V> dict, string prefix = "" /* Metadata: 0x0077A312 */, string postfix = "" /* Metadata: 0x0077A316 */);
		public static void CTAddRange<K, V>(this IDictionary<K, V> source, IDictionary<K, V> collection);
		public static bool CTIsVisibleFrom(this Renderer renderer, Camera camera); // 0x000000018107C440-0x000000018107C590
		public static byte[] CTReadFully(this Stream input, int bufferSize = 16384 /* Metadata: 0x0077A31A */); // 0x000000018107C590-0x000000018107C760
	}
}
