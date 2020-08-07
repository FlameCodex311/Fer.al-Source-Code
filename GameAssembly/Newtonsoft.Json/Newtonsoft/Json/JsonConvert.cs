/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Shims;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	public static class JsonConvert // TypeDefIndex: 7980
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Func<JsonSerializerSettings> <DefaultSettings>k__BackingField; // 0x00
		public static readonly string True; // 0x08
		public static readonly string False; // 0x10
		public static readonly string Null; // 0x18
		public static readonly string Undefined; // 0x20
		public static readonly string PositiveInfinity; // 0x28
		public static readonly string NegativeInfinity; // 0x30
		public static readonly string NaN; // 0x38
		private static readonly JsonSerializerSettings InitialSerializerSettings; // 0x40
	
		// Properties
		public static Func<JsonSerializerSettings> DefaultSettings { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180C64300-0x0000000180C64360 0x0000000180C64360-0x0000000180C643C0
	
		// Constructors
		static JsonConvert(); // 0x0000000180C640F0-0x0000000180C64300
	
		// Methods
		internal static JsonSerializerSettings GetDefaultSettings(); // 0x0000000180C63600-0x0000000180C63660
		public static string ToString(bool value); // 0x0000000180C63E90-0x0000000180C63F30
		public static string ToString(char value); // 0x0000000180C63A70-0x0000000180C63BC0
		internal static string ToString(float value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable); // 0x0000000180C63BC0-0x0000000180C63CC0
		private static string EnsureFloatFormat(double value, string text, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable); // 0x0000000180C634A0-0x0000000180C63600
		internal static string ToString(double value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable); // 0x0000000180C63FF0-0x0000000180C640F0
		private static string EnsureDecimalPlace(double value, string text); // 0x0000000180C633A0-0x0000000180C634A0
		private static string EnsureDecimalPlace(string text); // 0x0000000180C63330-0x0000000180C633A0
		public static string ToString(decimal value); // 0x0000000180C63CC0-0x0000000180C63DA0
		public static string ToString(string value); // 0x0000000180C63990-0x0000000180C63A70
		public static string ToString(string value, char delimiter); // 0x0000000180C63DA0-0x0000000180C63E90
		public static string ToString(string value, char delimiter, StringEscapeHandling stringEscapeHandling); // 0x0000000180C63F30-0x0000000180C63FF0
		public static string SerializeObject(object value); // 0x0000000180C638E0-0x0000000180C63990
		public static string SerializeObject(object value, Type type, JsonSerializerSettings settings); // 0x0000000180C63840-0x0000000180C638E0
		private static string SerializeObjectInternal(object value, Type type, JsonSerializer jsonSerializer); // 0x0000000180C63660-0x0000000180C63840
		public static object DeserializeObject(string value, Type type); // 0x0000000180C632C0-0x0000000180C63330
		public static T DeserializeObject<T>(string value);
		public static T DeserializeObject<T>(string value, JsonSerializerSettings settings);
		public static object DeserializeObject(string value, Type type, JsonSerializerSettings settings); // 0x0000000180C630B0-0x0000000180C632C0
	}
}
