/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Shims;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001801CDDD0-0x00000001801CDE00
	internal static class DateTimeUtils // TypeDefIndex: 8028
	{
		// Fields
		internal static readonly long InitialJavaScriptDateTicks; // 0x00
		private static readonly int[] DaysToMonth365; // 0x08
		private static readonly int[] DaysToMonth366; // 0x10
	
		// Constructors
		static DateTimeUtils(); // 0x0000000180C1F880-0x0000000180C1F940
	
		// Methods
		public static XmlDateTimeSerializationMode ToSerializationMode(DateTimeKind kind); // 0x0000000180C1CEB0-0x0000000180C1CF40
		internal static DateTime EnsureDateTime(DateTime value, DateTimeZoneHandling timeZone); // 0x0000000180C1C980-0x0000000180C1CB50
		private static DateTime SwitchToLocalTime(DateTime value); // 0x0000000180C1CDC0-0x0000000180C1CE30
		private static DateTime SwitchToUtcTime(DateTime value); // 0x0000000180C1CE30-0x0000000180C1CEB0
		private static long ToUniversalTicks(DateTime dateTime); // 0x0000000180C1D060-0x0000000180C1D0F0
		private static long ToUniversalTicks(DateTime dateTime, TimeSpan offset); // 0x0000000180C1CF40-0x0000000180C1D060
		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, TimeSpan offset); // 0x0000000180C1C4A0-0x0000000180C1C510
		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime); // 0x0000000180C1C510-0x0000000180C1C650
		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, bool convertToUtc); // 0x0000000180C1C650-0x0000000180C1C770
		private static long UniversialTicksToJavaScriptTicks(long universialTicks); // 0x0000000180C1E9B0-0x0000000180C1EA30
		internal static DateTime ConvertJavaScriptTicksToDateTime(long javaScriptTicks); // 0x0000000180C1C770-0x0000000180C1C800
		internal static bool TryParseDateTimeIso(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt); // 0x0000000180C1D1E0-0x0000000180C1D610
		internal static bool TryParseDateTimeOffsetIso(StringReference text, out DateTimeOffset dt); // 0x0000000180C1D840-0x0000000180C1D9F0
		private static DateTime CreateDateTime(DateTimeParser dateTimeParser); // 0x0000000180C1C880-0x0000000180C1C980
		internal static bool TryParseDateTime(StringReference s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt); // 0x0000000180C1E320-0x0000000180C1E560
		internal static bool TryParseDateTime(string s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt); // 0x0000000180C1E060-0x0000000180C1E320
		internal static bool TryParseDateTimeOffset(StringReference s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt); // 0x0000000180C1DB60-0x0000000180C1DD80
		internal static bool TryParseDateTimeOffset(string s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt); // 0x0000000180C1DD80-0x0000000180C1E060
		private static bool TryParseMicrosoftDate(StringReference text, out long ticks, out TimeSpan offset, out DateTimeKind kind); // 0x0000000180C1E560-0x0000000180C1E6F0
		private static bool TryParseDateTimeMicrosoft(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt); // 0x0000000180C1D610-0x0000000180C1D780
		private static bool TryParseDateTimeExact(string text, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt); // 0x0000000180C1D0F0-0x0000000180C1D1E0
		private static bool TryParseDateTimeOffsetMicrosoft(StringReference text, out DateTimeOffset dt); // 0x0000000180C1D9F0-0x0000000180C1DB60
		private static bool TryParseDateTimeOffsetExact(string text, string dateFormatString, CultureInfo culture, out DateTimeOffset dt); // 0x0000000180C1D780-0x0000000180C1D840
		private static bool TryReadOffset(StringReference offsetText, int startIndex, out TimeSpan offset); // 0x0000000180C1E6F0-0x0000000180C1E9B0
		internal static void WriteDateTimeString(TextWriter writer, DateTime value, DateFormatHandling format, string formatString, CultureInfo culture); // 0x0000000180C1EDE0-0x0000000180C1EF40
		internal static int WriteDateTimeString(char[] chars, int start, DateTime value, TimeSpan? offset, DateTimeKind kind, DateFormatHandling format); // 0x0000000180C1EF40-0x0000000180C1F320
		internal static int WriteDefaultIsoDate(char[] chars, int start, DateTime dt); // 0x0000000180C1F320-0x0000000180C1F880
		private static void CopyIntToCharArray(char[] chars, int start, int value, int digits); // 0x0000000180C1C800-0x0000000180C1C880
		internal static int WriteDateTimeOffset(char[] chars, int start, TimeSpan offset, DateFormatHandling format); // 0x0000000180C1EBB0-0x0000000180C1EDE0
		internal static void WriteDateTimeOffsetString(TextWriter writer, DateTimeOffset value, DateFormatHandling format, string formatString, CultureInfo culture); // 0x0000000180C1EA30-0x0000000180C1EBB0
		private static void GetDateValues(DateTime td, out int year, out int month, out int day); // 0x0000000180C1CB50-0x0000000180C1CD50
	
		// Extension methods
		public static TimeSpan GetUtcOffset(this DateTime d); // 0x0000000180C1CD50-0x0000000180C1CDC0
	}
}
