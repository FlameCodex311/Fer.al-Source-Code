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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Candlelight
{
	public static class StringX // TypeDefIndex: 14497
	{
		// Fields
		private static readonly Dictionary<Type, ParseEnumCallback> s_EnumParsers; // 0x00
		private static readonly Regex s_MatchBaseName; // 0x08
		private static readonly int s_MatchBaseNameNameGroup; // 0x10
		private static readonly int s_MatchBaseNameNumberGroup; // 0x14
		private static readonly ObjectPool<StringBuilder> s_StringBuilderPool; // 0x18
		private static readonly TextInfo s_TitleCaseTextInfo; // 0x20
	
		// Nested types
		private delegate bool ParseEnumCallback(string value, out object parsedValue); // TypeDefIndex: 14498; 0x00000001804A53D0-0x00000001804A58D0
	
		public struct StringBuilderScope : IDisposable // TypeDefIndex: 14499
		{
			// Fields
			private StringBuilder m_StringBuilder; // 0x00
	
			// Properties
			public StringBuilder StringBuilder { get; } // 0x0000000180004FB0-0x0000000180005090 
	
			// Methods
			public void Dispose(); // 0x0000000180004F20-0x0000000180004FB0
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 14500
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static MatchEvaluator <>9__16_0; // 0x08
	
			// Constructors
			static <>c(); // 0x00000001804A92B0-0x00000001804A9310
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal string <ToSnakeCase>b__16_0(Match m); // 0x00000001804A8D80-0x00000001804A8DF0
			internal bool <.cctor>b__21_1(string s, out object parsedValue); // 0x00000001804A8E30-0x00000001804A8EA0
			internal bool <.cctor>b__21_2(string s, out object parsedValue); // 0x00000001804A8EA0-0x00000001804A8F10
			internal bool <.cctor>b__21_3(string s, out object parsedValue); // 0x00000001804A8F10-0x00000001804A8F90
			internal bool <.cctor>b__21_4(string s, out object parsedValue); // 0x00000001804A8F90-0x00000001804A9000
			internal bool <.cctor>b__21_5(string s, out object parsedValue); // 0x00000001804A9000-0x00000001804A9080
			internal bool <.cctor>b__21_6(string s, out object parsedValue); // 0x00000001804A9080-0x00000001804A90F0
			internal bool <.cctor>b__21_7(string s, out object parsedValue); // 0x00000001804A90F0-0x00000001804A9170
			internal bool <.cctor>b__21_8(string s, out object parsedValue); // 0x00000001804A9170-0x00000001804A91F0
			internal void <.cctor>b__21_0(StringBuilder sb); // 0x00000001804A8DF0-0x00000001804A8E30
		}
	
		// Constructors
		static StringX(); // 0x00000001804A6970-0x00000001804A6E10
	
		// Methods
		public static bool TryParseNumberStringAsEnum(Type enumType, string numberString, out object enumValue); // 0x00000001804A67D0-0x00000001804A6970
	
		// Extension methods
		public static bool ContainsLowercase(this string str); // 0x00000001804A5900-0x00000001804A59B0
		public static bool ContainsUppercase(this string str); // 0x00000001804A59B0-0x00000001804A5A60
		public static string GetUniqueName(this string baseName, IList<string> existingNames); // 0x00000001804A5D10-0x00000001804A5EF0
		public static string GetUniqueName(this string baseName, HashSet<string> existingNames); // 0x00000001804A5A60-0x00000001804A5D10
		public static string Join(this string separator, IEnumerable<string> strings); // 0x00000001804A5EF0-0x00000001804A5F50
		public static string Range(this string str, int start, int end = -1 /* Metadata: 0x007BAC73 */, int skip = 1 /* Metadata: 0x007BAC77 */); // 0x00000001804A5F50-0x00000001804A6120
		public static string ToFeetInchesString(this float meters); // 0x00000001804A6120-0x00000001804A61D0
		public static string ToHexString(this Color color); // 0x00000001804A61D0-0x00000001804A6430
		public static string ToSnakeCase(this string compoundWord); // 0x00000001804A6430-0x00000001804A65B0
		public static string ToTimeString(this float time); // 0x00000001804A65B0-0x00000001804A6660
		public static string ToTitleCase(this string words); // 0x00000001804A6660-0x00000001804A66E0
		public static string ToWords(this string compoundWord); // 0x00000001804A66E0-0x00000001804A67D0
	}
}
