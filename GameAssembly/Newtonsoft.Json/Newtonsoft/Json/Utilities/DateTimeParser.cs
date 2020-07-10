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

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	internal struct DateTimeParser // TypeDefIndex: 7826
	{
		// Fields
		public int Year; // 0x00
		public int Month; // 0x04
		public int Day; // 0x08
		public int Hour; // 0x0C
		public int Minute; // 0x10
		public int Second; // 0x14
		public int Fraction; // 0x18
		public int ZoneHour; // 0x1C
		public int ZoneMinute; // 0x20
		public ParserTimeZone Zone; // 0x24
		private char[] _text; // 0x28
		private int _end; // 0x30
		private static readonly int[] Power10; // 0x00
		private static readonly int Lzyyyy; // 0x08
		private static readonly int Lzyyyy_; // 0x0C
		private static readonly int Lzyyyy_MM; // 0x10
		private static readonly int Lzyyyy_MM_; // 0x14
		private static readonly int Lzyyyy_MM_dd; // 0x18
		private static readonly int Lzyyyy_MM_ddT; // 0x1C
		private static readonly int LzHH; // 0x20
		private static readonly int LzHH_; // 0x24
		private static readonly int LzHH_mm; // 0x28
		private static readonly int LzHH_mm_; // 0x2C
		private static readonly int LzHH_mm_ss; // 0x30
		private static readonly int Lz_; // 0x34
		private static readonly int Lz_zz; // 0x38
	
		// Constructors
		static DateTimeParser(); // 0x0000000180583B40-0x0000000180583DD0
	
		// Methods
		public bool Parse(char[] text, int startIndex, int length); // 0x0000000180007A60-0x0000000180007C60
		private bool ParseDate(int start); // 0x00000001800079F0-0x0000000180007A00
		private bool ParseTimeAndZoneAndWhitespace(int start); // 0x0000000180007A00-0x0000000180007A40
		private bool ParseTime(ref int start); // 0x0000000180007A40-0x0000000180007A50
		private bool ParseZone(int start); // 0x0000000180007A50-0x0000000180007A60
		private bool Parse4Digit(int start, out int num); // 0x0000000180007990-0x00000001800079A0
		private bool Parse2Digit(int start, out int num); // 0x0000000180007980-0x0000000180007990
		private bool ParseChar(int start, char ch); // 0x00000001800079A0-0x00000001800079F0
	}
}
