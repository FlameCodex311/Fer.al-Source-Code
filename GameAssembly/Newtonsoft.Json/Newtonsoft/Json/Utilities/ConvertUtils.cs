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

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	internal static class ConvertUtils // TypeDefIndex: 8022
	{
		// Fields
		private static readonly Dictionary<Type, PrimitiveTypeCode> TypeCodeMap; // 0x00
		private static readonly TypeInformation[] PrimitiveTypeCodes; // 0x08
		private static readonly ThreadSafeStore<TypeConvertKey, Func<object, object>> CastConverters; // 0x10
	
		// Nested types
		internal struct TypeConvertKey : IEquatable<TypeConvertKey> // TypeDefIndex: 8023
		{
			// Fields
			private readonly Type _initialType; // 0x00
			private readonly Type _targetType; // 0x08
	
			// Properties
			public Type InitialType { get; } // 0x000000018001A8D0-0x000000018001A8E0 
			public Type TargetType { get; } // 0x00000001800034E0-0x00000001800034F0 
	
			// Constructors
			public TypeConvertKey(Type initialType, Type targetType); // 0x0000000180006CF0-0x0000000180006D00
	
			// Methods
			public override int GetHashCode(); // 0x000000018001B770-0x000000018001B7D0
			public override bool Equals(object obj); // 0x000000018005D020-0x000000018005DAE0
			public bool Equals(TypeConvertKey other); // 0x000000018005CFD0-0x000000018005D020
		}
	
		internal enum ConvertResult // TypeDefIndex: 8024
		{
			Success = 0,
			CannotConvertNull = 1,
			NotInstantiableType = 2,
			NoValidConversion = 3
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass9_0 // TypeDefIndex: 8025
		{
			// Fields
			public MethodCall<object, object> call; // 0x10
	
			// Constructors
			public <>c__DisplayClass9_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal object <CreateCastConverter>b__0(object o); // 0x0000000180C35220-0x0000000180C352F0
		}
	
		// Constructors
		static ConvertUtils(); // 0x0000000180C1A670-0x0000000180C1C220
	
		// Methods
		public static PrimitiveTypeCode GetTypeCode(Type t); // 0x0000000180C18F80-0x0000000180C18FE0
		public static PrimitiveTypeCode GetTypeCode(Type t, out bool isEnum); // 0x0000000180C18FE0-0x0000000180C192A0
		public static TypeInformation GetTypeInformation(IConvertible convertable); // 0x0000000180C192A0-0x0000000180C19350
		public static bool IsConvertible(Type t); // 0x0000000180C19860-0x0000000180C198F0
		public static TimeSpan ParseTimeSpan(string input); // 0x0000000180C19A10-0x0000000180C19A70
		private static Func<object, object> CreateCastConverter(TypeConvertKey t); // 0x0000000180C18AB0-0x0000000180C18D00
		private static bool TryConvert(object initialValue, CultureInfo culture, Type targetType, out object value); // 0x0000000180C1A520-0x0000000180C1A5E0
		private static ConvertResult TryConvertInternal(object initialValue, CultureInfo culture, Type targetType, out object value); // 0x0000000180C19BB0-0x0000000180C1A520
		public static object ConvertOrCast(object initialValue, CultureInfo culture, Type targetType); // 0x0000000180C18940-0x0000000180C18AB0
		private static object EnsureTypeAssignable(object value, Type initialType, Type targetType); // 0x0000000180C18D00-0x0000000180C18EF0
		internal static TypeConverter GetConverter(Type t); // 0x0000000180C18EF0-0x0000000180C18F80
		public static bool VersionTryParse(string input, out Version result); // 0x0000000180C1A5E0-0x0000000180C1A670
		public static bool IsInteger(object value); // 0x0000000180C198F0-0x0000000180C19A10
		public static ParseResult Int32TryParse(char[] chars, int start, int length, out int value); // 0x0000000180C19500-0x0000000180C196C0
		public static ParseResult Int64TryParse(char[] chars, int start, int length, out long value); // 0x0000000180C196C0-0x0000000180C19860
		public static bool TryConvertGuid(string s, out Guid g); // 0x0000000180C19A70-0x0000000180C19BB0
		public static int HexTextToInt(char[] text, int start, int end); // 0x0000000180C19420-0x0000000180C19500
		private static int HexCharToInt(char ch); // 0x0000000180C19350-0x0000000180C19420
	}
}
