/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Newtonsoft.Json.Shims;

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	internal static class EnumUtils // TypeDefIndex: 7867
	{
		// Fields
		private static readonly ThreadSafeStore<Type, BidirectionalDictionary<string, string>> EnumMemberNamesPerType; // 0x00
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 7868
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<EnumMemberAttribute, string> <>9__1_0; // 0x08
			public static Func<FieldInfo, bool> <>9__5_0; // 0x10
	
			// Constructors
			static <>c(); // 0x000000018059D0E0-0x000000018059D140
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal string <InitializeEnumType>b__1_0(EnumMemberAttribute a); // 0x000000018059C9F0-0x000000018059CA10
			internal bool <GetValues>b__5_0(FieldInfo f); // 0x000000018059C9C0-0x000000018059C9F0
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__2<T> // TypeDefIndex: 7869
			where T : struct
		{
			// Fields
			public static readonly <>c__2<T> <>9;
	
			// Constructors
			static <>c__2();
			public <>c__2();
		}
	
		// Constructors
		static EnumUtils(); // 0x0000000180589A30-0x0000000180589AC0
	
		// Methods
		private static BidirectionalDictionary<string, string> InitializeEnumType(Type type); // 0x0000000180589040-0x0000000180589430
		public static IList<object> GetValues(Type enumType); // 0x0000000180588CF0-0x0000000180589040
		public static object ParseEnumName(string enumText, bool isNullable, Type t); // 0x0000000180589430-0x0000000180589780
		public static string ToEnumName(Type enumType, string enumText, bool camelCaseText); // 0x0000000180589800-0x0000000180589A30
		private static string ResolvedEnumName(BidirectionalDictionary<string, string> map, string enumText); // 0x0000000180589780-0x0000000180589800
	}
}
