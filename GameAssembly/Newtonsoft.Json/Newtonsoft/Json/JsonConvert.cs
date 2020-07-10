/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Shims;

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	public static class JsonConvert // TypeDefIndex: 7814
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
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
		public static Func<JsonSerializerSettings> DefaultSettings { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018068CE40-0x000000018068CEA0 0x000000018068CEA0-0x000000018068CF00
	
		// Constructors
		static JsonConvert(); // 0x000000018068CCB0-0x000000018068CE40
	
		// Methods
		internal static JsonSerializerSettings GetDefaultSettings(); // 0x000000018068C1A0-0x000000018068C200
		public static string ToString(bool value); // 0x000000018068CA40-0x000000018068CAE0
		public static string ToString(char value); // 0x000000018068C620-0x000000018068C770
		internal static string ToString(float value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable); // 0x000000018068C770-0x000000018068C870
		private static string EnsureFloatFormat(double value, string text, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable); // 0x000000018068C040-0x000000018068C1A0
		internal static string ToString(double value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable); // 0x000000018068CBB0-0x000000018068CCB0
		private static string EnsureDecimalPlace(double value, string text); // 0x000000018068BF40-0x000000018068C040
		private static string EnsureDecimalPlace(string text); // 0x000000018068BED0-0x000000018068BF40
		public static string ToString(decimal value); // 0x000000018068C870-0x000000018068C950
		public static string ToString(string value); // 0x000000018068C540-0x000000018068C620
		public static string ToString(string value, char delimiter); // 0x000000018068C950-0x000000018068CA40
		public static string ToString(string value, char delimiter, StringEscapeHandling stringEscapeHandling); // 0x000000018068CAE0-0x000000018068CBB0
		public static string SerializeObject(object value); // 0x000000018068C490-0x000000018068C540
		public static string SerializeObject(object value, Type type, JsonSerializerSettings settings); // 0x000000018068C3F0-0x000000018068C490
		private static string SerializeObjectInternal(object value, Type type, JsonSerializer jsonSerializer); // 0x000000018068C200-0x000000018068C3F0
		public static object DeserializeObject(string value, Type type); // 0x000000018068BE60-0x000000018068BED0
		public static T DeserializeObject<T>(string value);
		public static T DeserializeObject<T>(string value, JsonSerializerSettings settings);
		public static object DeserializeObject(string value, Type type, JsonSerializerSettings settings); // 0x000000018068BCB0-0x000000018068BE60
	}
}
