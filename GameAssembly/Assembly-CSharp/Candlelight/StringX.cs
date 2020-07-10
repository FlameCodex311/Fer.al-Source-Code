/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Candlelight
{
	public static class StringX // TypeDefIndex: 13830
	{
		// Fields
		private static readonly Dictionary<Type, ParseEnumCallback> s_EnumParsers; // 0x00
		private static readonly Regex s_MatchBaseName; // 0x08
		private static readonly int s_MatchBaseNameNameGroup; // 0x10
		private static readonly int s_MatchBaseNameNumberGroup; // 0x14
		private static readonly ObjectPool<StringBuilder> s_StringBuilderPool; // 0x18
		private static readonly TextInfo s_TitleCaseTextInfo; // 0x20
	
		// Nested types
		private delegate bool ParseEnumCallback(string value, out object parsedValue); // TypeDefIndex: 13831; 0x0000000180B1E320-0x0000000180B1E7C0
	
		public struct StringBuilderScope : IDisposable // TypeDefIndex: 13832
		{
			// Fields
			private StringBuilder m_StringBuilder; // 0x00
	
			// Properties
			public StringBuilder StringBuilder { get; } // 0x00000001801F7A20-0x00000001801F7AE0 
	
			// Methods
			public void Dispose(); // 0x00000001801F7990-0x00000001801F7A20
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 13833
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static MatchEvaluator <>9__16_0; // 0x08
	
			// Constructors
			static <>c(); // 0x0000000181034540-0x00000001810345A0
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal string <ToSnakeCase>b__16_0(Match m); // 0x0000000181034070-0x00000001810340E0
			internal bool <.cctor>b__21_1(string s, out object parsedValue); // 0x0000000181034120-0x0000000181034190
			internal bool <.cctor>b__21_2(string s, out object parsedValue); // 0x0000000181034190-0x0000000181034200
			internal bool <.cctor>b__21_3(string s, out object parsedValue); // 0x0000000181034200-0x0000000181034280
			internal bool <.cctor>b__21_4(string s, out object parsedValue); // 0x0000000181034280-0x00000001810342F0
			internal bool <.cctor>b__21_5(string s, out object parsedValue); // 0x00000001810342F0-0x0000000181034370
			internal bool <.cctor>b__21_6(string s, out object parsedValue); // 0x0000000181034370-0x00000001810343E0
			internal bool <.cctor>b__21_7(string s, out object parsedValue); // 0x00000001810343E0-0x0000000181034460
			internal bool <.cctor>b__21_8(string s, out object parsedValue); // 0x0000000181034460-0x00000001810344E0
			internal void <.cctor>b__21_0(StringBuilder sb); // 0x00000001810340E0-0x0000000181034120
		}
	
		// Constructors
		static StringX(); // 0x000000018102FA70-0x000000018102FF10
	
		// Methods
		public static bool TryParseNumberStringAsEnum(Type enumType, string numberString, out object enumValue); // 0x000000018102F8D0-0x000000018102FA70
	
		// Extension methods
		public static bool ContainsLowercase(this string str); // 0x000000018102E9A0-0x000000018102EA50
		public static bool ContainsUppercase(this string str); // 0x000000018102EA50-0x000000018102EB00
		public static string GetUniqueName(this string baseName, IList<string> existingNames); // 0x000000018102EDC0-0x000000018102EFB0
		public static string GetUniqueName(this string baseName, HashSet<string> existingNames); // 0x000000018102EB00-0x000000018102EDC0
		public static string Join(this string separator, IEnumerable<string> strings); // 0x000000018102EFB0-0x000000018102F010
		public static string Range(this string str, int start, int end = -1 /* Metadata: 0x007841B0 */, int skip = 1 /* Metadata: 0x007841B4 */); // 0x000000018102F010-0x000000018102F1F0
		public static string ToFeetInchesString(this float meters); // 0x000000018102F1F0-0x000000018102F2A0
		public static string ToHexString(this Color color); // 0x000000018102F2A0-0x000000018102F520
		public static string ToSnakeCase(this string compoundWord); // 0x000000018102F520-0x000000018102F6B0
		public static string ToTimeString(this float time); // 0x000000018102F6B0-0x000000018102F760
		public static string ToTitleCase(this string words); // 0x000000018102F760-0x000000018102F7E0
		public static string ToWords(this string compoundWord); // 0x000000018102F7E0-0x000000018102F8D0
	}
}
