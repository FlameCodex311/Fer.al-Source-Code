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

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001800B4050-0x00000001800B4080
	internal static class StringUtils // TypeDefIndex: 7882
	{
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass15_0<TSource> // TypeDefIndex: 7883
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
		public static StringWriter CreateStringWriter(int capacity); // 0x0000000180DF1720-0x0000000180DF17D0
		public static int? GetLength(string value); // 0x0000000180DF2020-0x0000000180DF2080
		public static void ToCharAsUnicode(char c, char[] buffer); // 0x0000000180DF23E0-0x0000000180DF2510
		public static string ToCamelCase(string s); // 0x0000000180DF2180-0x0000000180DF23E0
		public static bool IsHighSurrogate(char c); // 0x0000000180DF2080-0x0000000180DF20E0
		public static bool IsLowSurrogate(char c); // 0x0000000180DF20E0-0x0000000180DF2140
	
		// Extension methods
		public static string FormatWith(this string format, IFormatProvider provider, object arg0); // 0x0000000180DF18D0-0x0000000180DF1A10
		public static string FormatWith(this string format, IFormatProvider provider, object arg0, object arg1); // 0x0000000180DF1C70-0x0000000180DF1E20
		public static string FormatWith(this string format, IFormatProvider provider, object arg0, object arg1, object arg2); // 0x0000000180DF1E20-0x0000000180DF2020
		public static string FormatWith(this string format, IFormatProvider provider, object arg0, object arg1, object arg2, object arg3); // 0x0000000180DF1A10-0x0000000180DF1C70
		private static string FormatWith(this string format, IFormatProvider provider, params /* 0x00000001800B36B0-0x00000001800B36C0 */ object[] args); // 0x0000000180DF1810-0x0000000180DF18D0
		public static TSource ForgivingCaseSensitiveFind<TSource>(this IEnumerable<TSource> source, Func<TSource, string> valueSelector, string testValue);
		public static bool StartsWith(this string source, char value); // 0x0000000180DF2140-0x0000000180DF2180
		public static bool EndsWith(this string source, char value); // 0x0000000180DF17D0-0x0000000180DF1810
	}
}
