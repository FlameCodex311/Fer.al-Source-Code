/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Shims;

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	internal static class JavaScriptUtils // TypeDefIndex: 7872
	{
		// Fields
		internal static readonly bool[] SingleQuoteCharEscapeFlags; // 0x00
		internal static readonly bool[] DoubleQuoteCharEscapeFlags; // 0x08
		internal static readonly bool[] HtmlCharEscapeFlags; // 0x10
	
		// Constructors
		static JavaScriptUtils(); // 0x000000018058AA50-0x000000018058B2D0
	
		// Methods
		public static bool[] GetCharEscapeFlags(StringEscapeHandling stringEscapeHandling, char quoteChar); // 0x000000018058A070-0x000000018058A150
		public static bool ShouldEscapeJavaScriptString(string s, bool[] charEscapeFlags); // 0x000000018058A150-0x000000018058A1F0
		public static void WriteEscapedJavaScriptString(TextWriter writer, string s, char delimiter, bool appendDelimiters, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, IArrayPool<char> bufferPool, ref char[] writeBuffer); // 0x000000018058A440-0x000000018058AA50
		public static string ToEscapedJavaScriptString(string value, char delimiter, bool appendDelimiters, StringEscapeHandling stringEscapeHandling); // 0x000000018058A1F0-0x000000018058A440
	}
}
