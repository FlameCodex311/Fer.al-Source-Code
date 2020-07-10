/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace ParadoxNotion
{
	public static class StringUtils // TypeDefIndex: 14696
	{
		// Fields
		private const string ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; // Metadata: 0x0078476A
		private static readonly char[] CHAR_EMPTY_ARRAY; // 0x00
		private static Dictionary<string, string> splitCaseCache; // 0x08
	
		// Constructors
		static StringUtils(); // 0x0000000181177B30-0x0000000181177C70
	
		// Methods
		public static string GetAlphabetLetter(int index); // 0x0000000181176910-0x0000000181176990
		public static float ScoreSearchMatch(string input, string leafName, string categoryName = "" /* Metadata: 0x00784762 */); // 0x0000000181176CF0-0x0000000181176FF0
		public static bool SearchMatch(string input, string leafName, string categoryName = "" /* Metadata: 0x00784766 */); // 0x0000000181176FF0-0x00000001811773A0
	
		// Extension methods
		public static string SplitCamelCase(this string s); // 0x00000001811773A0-0x0000000181177620
		public static string CapitalizeFirst(this string s); // 0x0000000181176850-0x0000000181176910
		public static string CapLength(this string s, int max); // 0x0000000181176780-0x0000000181176850
		public static string GetCapitals(this string s); // 0x0000000181176990-0x0000000181176AB0
		public static string GetStringWithin(this string input, string from, string to); // 0x0000000181176AB0-0x0000000181176BA0
		public static string ReplaceWithin(this string text, char startChar, char endChar, Func<string, string> Process); // 0x0000000181176BA0-0x0000000181176CF0
		public static string ToStringAdvanced(this object o); // 0x0000000181177620-0x0000000181177B30
	}
}
