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

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	internal static class EnumUtils // TypeDefIndex: 8033
	{
		// Fields
		private static readonly ThreadSafeStore<Type, BidirectionalDictionary<string, string>> EnumMemberNamesPerType; // 0x00
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 8034
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<EnumMemberAttribute, string> <>9__1_0; // 0x08
			public static Func<FieldInfo, bool> <>9__5_0; // 0x10
	
			// Constructors
			static <>c(); // 0x0000000180C352F0-0x0000000180C35350
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal string <InitializeEnumType>b__1_0(EnumMemberAttribute a); // 0x0000000180386C00-0x0000000180386C20
			internal bool <GetValues>b__5_0(FieldInfo f); // 0x0000000180C34C10-0x0000000180C34C30
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__2<T> // TypeDefIndex: 8035
			where T : struct
		{
			// Fields
			public static readonly <>c__2<T> <>9;
	
			// Constructors
			static <>c__2();
			public <>c__2();
		}
	
		// Constructors
		static EnumUtils(); // 0x0000000180C21F70-0x0000000180C22000
	
		// Methods
		private static BidirectionalDictionary<string, string> InitializeEnumType(Type type); // 0x0000000180C215D0-0x0000000180C219B0
		public static IList<object> GetValues(Type enumType); // 0x0000000180C21290-0x0000000180C215D0
		public static object ParseEnumName(string enumText, bool isNullable, Type t); // 0x0000000180C219B0-0x0000000180C21CF0
		public static string ToEnumName(Type enumType, string enumText, bool camelCaseText); // 0x0000000180C21D60-0x0000000180C21F70
		private static string ResolvedEnumName(BidirectionalDictionary<string, string> map, string enumText); // 0x0000000180C21CF0-0x0000000180C21D60
	}
}
