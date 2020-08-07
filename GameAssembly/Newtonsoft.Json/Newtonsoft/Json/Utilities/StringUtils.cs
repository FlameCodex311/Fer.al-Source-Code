/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Shims;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001801CDDD0-0x00000001801CDE00
	internal static class StringUtils // TypeDefIndex: 8048
	{
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass15_0<TSource> // TypeDefIndex: 8049
		{
			// Fields
			public Func<TSource, string> valueSelector;
			public string testValue;
	
			// Constructors
			public <>c__DisplayClass15_0();
	
			// Methods
			internal bool <ForgivingCaseSensitiveFind>b__0(TSource s);
			internal bool <ForgivingCaseSensitiveFind>b__1(TSource s);
		}
	
		// Methods
		public static StringWriter CreateStringWriter(int capacity); // 0x00000001820D3A20-0x00000001820D3AD0
		public static int? GetLength(string value); // 0x00000001820D42E0-0x00000001820D4340
		public static void ToCharAsUnicode(char c, char[] buffer); // 0x00000001820D4690-0x00000001820D47A0
		public static string ToCamelCase(string s); // 0x00000001820D4440-0x00000001820D4690
		public static bool IsHighSurrogate(char c); // 0x00000001820D4340-0x00000001820D43A0
		public static bool IsLowSurrogate(char c); // 0x00000001820D43A0-0x00000001820D4400
	
		// Extension methods
		public static string FormatWith(this string format, IFormatProvider provider, object arg0); // 0x00000001820D3BD0-0x00000001820D3D10
		public static string FormatWith(this string format, IFormatProvider provider, object arg0, object arg1); // 0x00000001820D3F50-0x00000001820D40F0
		public static string FormatWith(this string format, IFormatProvider provider, object arg0, object arg1, object arg2); // 0x00000001820D40F0-0x00000001820D42E0
		public static string FormatWith(this string format, IFormatProvider provider, object arg0, object arg1, object arg2, object arg3); // 0x00000001820D3D10-0x00000001820D3F50
		private static string FormatWith(this string format, IFormatProvider provider, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ object[] args); // 0x00000001820D3B10-0x00000001820D3BD0
		public static TSource ForgivingCaseSensitiveFind<TSource>(this IEnumerable<TSource> source, Func<TSource, string> valueSelector, string testValue);
		public static bool StartsWith(this string source, char value); // 0x00000001820D4400-0x00000001820D4440
		public static bool EndsWith(this string source, char value); // 0x00000001820D3AD0-0x00000001820D3B10
	}
}
