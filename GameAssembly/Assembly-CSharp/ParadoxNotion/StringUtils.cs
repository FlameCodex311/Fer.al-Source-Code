/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ParadoxNotion
{
	public static class StringUtils // TypeDefIndex: 15845
	{
		// Fields
		public const string SPACE = " "; // Metadata: 0x007BB5F6
		public const string ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; // Metadata: 0x007BB5FB
		public static readonly char[] CHAR_SPACE_ARRAY; // 0x00
		private static Dictionary<string, string> splitCaseCache; // 0x08
	
		// Constructors
		static StringUtils(); // 0x00000001804E8D40-0x00000001804E8E80
	
		// Methods
		public static string GetAlphabetLetter(int index); // 0x00000001804E7A50-0x00000001804E7AD0
		public static float ScoreSearchMatch(string input, string leafName, string categoryName = "" /* Metadata: 0x007BB5EE */); // 0x00000001804E7E70-0x00000001804E81E0
		public static bool SearchMatch(string input, string leafName, string categoryName = "" /* Metadata: 0x007BB5F2 */); // 0x00000001804E81E0-0x00000001804E8570
	
		// Extension methods
		public static string SplitCamelCase(this string s); // 0x00000001804E8570-0x00000001804E87E0
		public static string CapitalizeFirst(this string s); // 0x00000001804E7950-0x00000001804E7A10
		public static string CapLength(this string s, int max); // 0x00000001804E7880-0x00000001804E7950
		public static string GetCapitals(this string s); // 0x00000001804E7AD0-0x00000001804E7BF0
		public static string FormatError(this string input); // 0x00000001804E7A10-0x00000001804E7A50
		public static string GetStringWithinOuter(this string input, char from, char to); // 0x00000001804E7CA0-0x00000001804E7D20
		public static string GetStringWithinInner(this string input, char from, char to); // 0x00000001804E7BF0-0x00000001804E7CA0
		public static string ReplaceWithin(this string text, char startChar, char endChar, Func<string, string> Process); // 0x00000001804E7D20-0x00000001804E7E70
		public static string ToStringAdvanced(this object o); // 0x00000001804E87E0-0x00000001804E8D40
	}
}
