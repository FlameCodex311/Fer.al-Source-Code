/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace Crosstales
{
	public static class ExtensionMethods // TypeDefIndex: 9919
	{
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass5_0 // TypeDefIndex: 9920
		{
			// Fields
			public string str; // 0x10
	
			// Constructors
			public <>c__DisplayClass5_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <CTContainsAny>b__0(string searchTerm); // 0x00000001815ED820-0x00000001815ED8B0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass6_0 // TypeDefIndex: 9921
		{
			// Fields
			public string str; // 0x10
	
			// Constructors
			public <>c__DisplayClass6_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <CTContainsAll>b__0(string searchTerm); // 0x00000001815ED820-0x00000001815ED8B0
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__21<T> // TypeDefIndex: 9922
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
		public static Transform CTDeepSearch(Transform parent, string name); // 0x00000001815D1300-0x00000001815D15F0
	
		// Extension methods
		public static string CTToTitleCase(this string str); // 0x00000001815D2C80-0x00000001815D2D60
		public static string CTReverse(this string str); // 0x00000001815D2BF0-0x00000001815D2C80
		public static string CTReplace(this string str, string oldString, string newString, StringComparison comp = StringComparison.OrdinalIgnoreCase /* Metadata: 0x0074601F */); // 0x00000001815D2AA0-0x00000001815D2BF0
		public static bool CTEquals(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase /* Metadata: 0x00746023 */); // 0x00000001815D26E0-0x00000001815D2770
		public static bool CTContains(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase /* Metadata: 0x00746027 */); // 0x00000001815D1260-0x00000001815D1300
		public static bool CTContainsAny(this string str, string searchTerms, char splitChar = ' ' /* Metadata: 0x0074602B */); // 0x00000001815D10F0-0x00000001815D1260
		public static bool CTContainsAll(this string str, string searchTerms, char splitChar = ' ' /* Metadata: 0x0074602D */); // 0x00000001815D0F80-0x00000001815D10F0
		public static bool CTisNumeric(this string str); // 0x00000001815D2D60-0x00000001815D2D80
		public static void CTShuffle<T>(this T[] array, int seed = 0 /* Metadata: 0x0074602F */);
		public static string CTDump<T>(this T[] array, string prefix = "" /* Metadata: 0x00746033 */, string postfix = "" /* Metadata: 0x00746037 */);
		public static string CTDump(this Quaternion[] array); // 0x00000001815D15F0-0x00000001815D17A0
		public static string CTDump(this Vector2[] array); // 0x00000001815D23E0-0x00000001815D2550
		public static string CTDump(this Vector3[] array); // 0x00000001815D2550-0x00000001815D26E0
		public static string CTDump(this Vector4[] array); // 0x00000001815D1F70-0x00000001815D2120
		public static string[] CTToString<T>(this T[] array);
		public static void CTShuffle<T>(this IList<T> list, int seed = 0 /* Metadata: 0x0074603B */);
		public static string CTDump<T>(this IList<T> list, string prefix = "" /* Metadata: 0x0074603F */, string postfix = "" /* Metadata: 0x00746043 */);
		public static string CTDump(this IList<Quaternion> list); // 0x00000001815D2120-0x00000001815D23E0
		public static string CTDump(this IList<Vector2> list); // 0x00000001815D17A0-0x00000001815D1A10
		public static string CTDump(this IList<Vector3> list); // 0x00000001815D1A10-0x00000001815D1CB0
		public static string CTDump(this IList<Vector4> list); // 0x00000001815D1CB0-0x00000001815D1F70
		public static List<string> CTToString<T>(this IList<T> list);
		public static string CTDump<K, V>(this IDictionary<K, V> dict, string prefix = "" /* Metadata: 0x00746047 */, string postfix = "" /* Metadata: 0x0074604B */);
		public static void CTAddRange<K, V>(this IDictionary<K, V> source, IDictionary<K, V> collection);
		public static bool CTIsVisibleFrom(this Renderer renderer, Camera camera); // 0x00000001815D2770-0x00000001815D28C0
		public static byte[] CTReadFully(this Stream input, int bufferSize = 16384 /* Metadata: 0x0074604F */); // 0x00000001815D28C0-0x00000001815D2AA0
	}
}
