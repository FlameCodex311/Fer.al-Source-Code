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

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001800B4050-0x00000001800B4080
	internal static class DateTimeUtils // TypeDefIndex: 7862
	{
		// Fields
		internal static readonly long InitialJavaScriptDateTicks; // 0x00
		private static readonly int[] DaysToMonth365; // 0x08
		private static readonly int[] DaysToMonth366; // 0x10
	
		// Constructors
		static DateTimeUtils(); // 0x0000000180587230-0x00000001805872F0
	
		// Methods
		public static XmlDateTimeSerializationMode ToSerializationMode(DateTimeKind kind); // 0x00000001805847F0-0x0000000180584890
		internal static DateTime EnsureDateTime(DateTime value, DateTimeZoneHandling timeZone); // 0x00000001805842B0-0x0000000180584480
		private static DateTime SwitchToLocalTime(DateTime value); // 0x0000000180584700-0x0000000180584770
		private static DateTime SwitchToUtcTime(DateTime value); // 0x0000000180584770-0x00000001805847F0
		private static long ToUniversalTicks(DateTime dateTime); // 0x00000001805849B0-0x0000000180584A40
		private static long ToUniversalTicks(DateTime dateTime, TimeSpan offset); // 0x0000000180584890-0x00000001805849B0
		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, TimeSpan offset); // 0x0000000180583DD0-0x0000000180583E40
		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime); // 0x0000000180583E40-0x0000000180583F80
		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, bool convertToUtc); // 0x0000000180583F80-0x00000001805840A0
		private static long UniversialTicksToJavaScriptTicks(long universialTicks); // 0x0000000180586300-0x0000000180586380
		internal static DateTime ConvertJavaScriptTicksToDateTime(long javaScriptTicks); // 0x00000001805840A0-0x0000000180584130
		internal static bool TryParseDateTimeIso(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt); // 0x0000000180584B30-0x0000000180584F60
		internal static bool TryParseDateTimeOffsetIso(StringReference text, out DateTimeOffset dt); // 0x0000000180585190-0x0000000180585350
		private static DateTime CreateDateTime(DateTimeParser dateTimeParser); // 0x00000001805841B0-0x00000001805842B0
		internal static bool TryParseDateTime(StringReference s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt); // 0x0000000180585C80-0x0000000180585EC0
		internal static bool TryParseDateTime(string s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt); // 0x00000001805859C0-0x0000000180585C80
		internal static bool TryParseDateTimeOffset(StringReference s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt); // 0x00000001805854C0-0x00000001805856E0
		internal static bool TryParseDateTimeOffset(string s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt); // 0x00000001805856E0-0x00000001805859C0
		private static bool TryParseMicrosoftDate(StringReference text, out long ticks, out TimeSpan offset, out DateTimeKind kind); // 0x0000000180585EC0-0x0000000180586180
		private static bool TryParseDateTimeMicrosoft(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt); // 0x0000000180584F60-0x00000001805850D0
		private static bool TryParseDateTimeExact(string text, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt); // 0x0000000180584A40-0x0000000180584B30
		private static bool TryParseDateTimeOffsetMicrosoft(StringReference text, out DateTimeOffset dt); // 0x0000000180585350-0x00000001805854C0
		private static bool TryParseDateTimeOffsetExact(string text, string dateFormatString, CultureInfo culture, out DateTimeOffset dt); // 0x00000001805850D0-0x0000000180585190
		private static bool TryReadOffset(StringReference offsetText, int startIndex, out TimeSpan offset); // 0x0000000180586180-0x0000000180586300
		internal static void WriteDateTimeString(TextWriter writer, DateTime value, DateFormatHandling format, string formatString, CultureInfo culture); // 0x0000000180586740-0x00000001805868B0
		internal static int WriteDateTimeString(char[] chars, int start, DateTime value, TimeSpan? offset, DateTimeKind kind, DateFormatHandling format); // 0x00000001805868B0-0x0000000180586CA0
		internal static int WriteDefaultIsoDate(char[] chars, int start, DateTime dt); // 0x0000000180586CA0-0x0000000180587230
		private static void CopyIntToCharArray(char[] chars, int start, int value, int digits); // 0x0000000180584130-0x00000001805841B0
		internal static int WriteDateTimeOffset(char[] chars, int start, TimeSpan offset, DateFormatHandling format); // 0x0000000180586500-0x0000000180586740
		internal static void WriteDateTimeOffsetString(TextWriter writer, DateTimeOffset value, DateFormatHandling format, string formatString, CultureInfo culture); // 0x0000000180586380-0x0000000180586500
		private static void GetDateValues(DateTime td, out int year, out int month, out int day); // 0x0000000180584480-0x0000000180584680
	
		// Extension methods
		public static TimeSpan GetUtcOffset(this DateTime d); // 0x0000000180584680-0x0000000180584700
	}
}
