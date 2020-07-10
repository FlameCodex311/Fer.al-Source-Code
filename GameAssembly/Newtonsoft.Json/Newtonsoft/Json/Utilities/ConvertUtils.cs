/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Shims;

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	internal static class ConvertUtils // TypeDefIndex: 7856
	{
		// Fields
		private static readonly Dictionary<Type, PrimitiveTypeCode> TypeCodeMap; // 0x00
		private static readonly TypeInformation[] PrimitiveTypeCodes; // 0x08
		private static readonly ThreadSafeStore<TypeConvertKey, Func<object, object>> CastConverters; // 0x10
	
		// Nested types
		internal struct TypeConvertKey : IEquatable<TypeConvertKey> // TypeDefIndex: 7857
		{
			// Fields
			private readonly Type _initialType; // 0x00
			private readonly Type _targetType; // 0x08
	
			// Properties
			public Type InitialType { get; } // 0x0000000180004C30-0x0000000180004C40 
			public Type TargetType { get; } // 0x0000000180002710-0x0000000180002720 
	
			// Constructors
			public TypeConvertKey(Type initialType, Type targetType); // 0x0000000180005D30-0x0000000180005EC0
	
			// Methods
			public override int GetHashCode(); // 0x0000000180007D30-0x0000000180007DB0
			public override bool Equals(object obj); // 0x0000000180007DB0-0x0000000180007F80
			public bool Equals(TypeConvertKey other); // 0x0000000180007D00-0x0000000180007D30
		}
	
		internal enum ConvertResult // TypeDefIndex: 7858
		{
			Success = 0,
			CannotConvertNull = 1,
			NotInstantiableType = 2,
			NoValidConversion = 3
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass9_0 // TypeDefIndex: 7859
		{
			// Fields
			public MethodCall<object, object> call; // 0x10
	
			// Constructors
			public <>c__DisplayClass9_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal object <CreateCastConverter>b__0(object o); // 0x000000018059D010-0x000000018059D0E0
		}
	
		// Constructors
		static ConvertUtils(); // 0x0000000180581EF0-0x0000000180583B40
	
		// Methods
		public static PrimitiveTypeCode GetTypeCode(Type t); // 0x00000001805807B0-0x0000000180580810
		public static PrimitiveTypeCode GetTypeCode(Type t, out bool isEnum); // 0x0000000180580810-0x0000000180580AE0
		public static TypeInformation GetTypeInformation(IConvertible convertable); // 0x0000000180580AE0-0x0000000180580B90
		public static bool IsConvertible(Type t); // 0x00000001805810D0-0x0000000180581160
		public static TimeSpan ParseTimeSpan(string input); // 0x0000000180581280-0x00000001805812E0
		private static Func<object, object> CreateCastConverter(TypeConvertKey t); // 0x00000001805802D0-0x0000000180580530
		private static bool TryConvert(object initialValue, CultureInfo culture, Type targetType, out object value); // 0x0000000180581DA0-0x0000000180581E60
		private static ConvertResult TryConvertInternal(object initialValue, CultureInfo culture, Type targetType, out object value); // 0x0000000180581430-0x0000000180581DA0
		public static object ConvertOrCast(object initialValue, CultureInfo culture, Type targetType); // 0x0000000180580160-0x00000001805802D0
		private static object EnsureTypeAssignable(object value, Type initialType, Type targetType); // 0x0000000180580530-0x0000000180580720
		internal static TypeConverter GetConverter(Type t); // 0x0000000180580720-0x00000001805807B0
		public static bool VersionTryParse(string input, out Version result); // 0x0000000180581E60-0x0000000180581EF0
		public static bool IsInteger(object value); // 0x0000000180581160-0x0000000180581280
		public static ParseResult Int32TryParse(char[] chars, int start, int length, out int value); // 0x0000000180580D40-0x0000000180580F20
		public static ParseResult Int64TryParse(char[] chars, int start, int length, out long value); // 0x0000000180580F20-0x00000001805810D0
		public static bool TryConvertGuid(string s, out Guid g); // 0x00000001805812E0-0x0000000180581430
		public static int HexTextToInt(char[] text, int start, int end); // 0x0000000180580C60-0x0000000180580D40
		private static int HexCharToInt(char ch); // 0x0000000180580B90-0x0000000180580C60
	}
}
