/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	public class JsonTextReader : JsonReader, IJsonLineInfo // TypeDefIndex: 7804
	{
		// Fields
		private readonly TextReader _reader; // 0x78
		private char[] _chars; // 0x80
		private int _charsUsed; // 0x88
		private int _charPos; // 0x8C
		private int _lineStartPos; // 0x90
		private int _lineNumber; // 0x94
		private bool _isEndOfFile; // 0x98
		private StringBuffer _stringBuffer; // 0xA0
		private StringReference _stringReference; // 0xB0
		private IArrayPool<char> _arrayPool; // 0xC0
		internal PropertyNameTable NameTable; // 0xC8
	
		// Properties
		public int LineNumber { get; } // 0x0000000180966760-0x00000001809667B0 
		public int LinePosition { get; } // 0x00000001809667B0-0x00000001809667C0 
	
		// Constructors
		public JsonTextReader(TextReader reader); // 0x00000001809666D0-0x0000000180966760
	
		// Methods
		private void EnsureBufferNotEmpty(); // 0x000000018095F2C0-0x000000018095F320
		private void OnNewLine(int pos); // 0x000000018095FB10-0x000000018095FB20
		private void ParseString(char quote, ReadType readType); // 0x0000000180962180-0x00000001809624D0
		private static void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count); // 0x000000018095EFD0-0x000000018095EFF0
		private void ShiftBufferIfNeeded(); // 0x0000000180966510-0x00000001809665F0
		private int ReadData(bool append); // 0x0000000180964830-0x0000000180964840
		private int ReadData(bool append, int charsRequired); // 0x0000000180964580-0x0000000180964830
		private bool EnsureChars(int relativePosition, bool append); // 0x000000018095F380-0x000000018095F420
		private bool ReadChars(int relativePosition, bool append); // 0x00000001809644F0-0x0000000180964580
		public override bool Read(); // 0x0000000180966220-0x0000000180966510
		public override int? ReadAsInt32(); // 0x0000000180964400-0x0000000180964490
		public override DateTime? ReadAsDateTime(); // 0x0000000180964220-0x00000001809642C0
		public override string ReadAsString(); // 0x0000000180964490-0x00000001809644F0
		public override byte[] ReadAsBytes(); // 0x0000000180963B80-0x0000000180964180
		private object ReadStringValue(ReadType readType); // 0x0000000180965900-0x0000000180966220
		private JsonReaderException CreateUnexpectedCharacterException(char c); // 0x000000018095F080-0x000000018095F130
		public override bool? ReadAsBoolean(); // 0x00000001809633D0-0x0000000180963B80
		private void ProcessValueComma(); // 0x0000000180963360-0x00000001809633D0
		private object ReadNumberValue(ReadType readType); // 0x0000000180964C50-0x0000000180965220
		public override DateTimeOffset? ReadAsDateTimeOffset(); // 0x0000000180964180-0x0000000180964220
		public override decimal? ReadAsDecimal(); // 0x00000001809642C0-0x0000000180964360
		public override double? ReadAsDouble(); // 0x0000000180964360-0x0000000180964400
		private void HandleNull(); // 0x000000018095F420-0x000000018095F560
		private void ReadFinished(); // 0x0000000180964840-0x00000001809649B0
		private bool ReadNullChar(); // 0x00000001809649B0-0x0000000180964A00
		private void EnsureBuffer(); // 0x000000018095F320-0x000000018095F380
		private void ReadStringIntoBuffer(char quote); // 0x0000000180965220-0x0000000180965900
		private void WriteCharToBuffer(char writeChar, int lastWritePosition, int writeToPosition); // 0x0000000180966660-0x00000001809666D0
		private char ParseUnicode(); // 0x0000000180962630-0x0000000180962720
		private void ReadNumberIntoBuffer(); // 0x0000000180964A00-0x0000000180964C50
		private void ClearRecentString(); // 0x000000018095EFF0-0x000000018095F010
		private bool ParsePostValue(); // 0x0000000180961BC0-0x0000000180961E80
		private bool ParseObject(); // 0x0000000180961A00-0x0000000180961BC0
		private bool ParseProperty(); // 0x0000000180961E80-0x0000000180962180
		private bool ValidIdentifierChar(char value); // 0x00000001809665F0-0x0000000180966660
		private void ParseUnquotedProperty(); // 0x0000000180962720-0x00000001809629A0
		private bool ParseValue(); // 0x00000001809629A0-0x0000000180963260
		private void ProcessLineFeed(); // 0x0000000180963340-0x0000000180963360
		private void ProcessCarriageReturn(bool append); // 0x0000000180963260-0x0000000180963340
		private bool EatWhitespace(bool oneOrMore); // 0x000000018095F130-0x000000018095F280
		private void ParseConstructor(); // 0x000000018095FF90-0x0000000180960350
		private void ParseNumber(ReadType readType); // 0x0000000180960960-0x0000000180961A00
		private void ParseComment(bool setToken); // 0x000000018095FB20-0x000000018095FF90
		private void EndComment(bool setToken, int initialPosition, int endPosition); // 0x000000018095F280-0x000000018095F2C0
		private bool MatchValue(string value); // 0x000000018095F9F0-0x000000018095FB10
		private bool MatchValueWithTrailingSeparator(string value); // 0x000000018095F6C0-0x000000018095F9F0
		private bool IsSeparator(char c); // 0x000000018095F560-0x000000018095F6C0
		private void ParseTrue(); // 0x00000001809624D0-0x0000000180962590
		private void ParseNull(); // 0x0000000180960410-0x00000001809604B0
		private void ParseUndefined(); // 0x0000000180962590-0x0000000180962630
		private void ParseFalse(); // 0x0000000180960350-0x0000000180960410
		private object ParseNumberNegativeInfinity(ReadType readType); // 0x0000000180960640-0x00000001809607D0
		private object ParseNumberPositiveInfinity(ReadType readType); // 0x00000001809607D0-0x0000000180960960
		private object ParseNumberNaN(ReadType readType); // 0x00000001809604B0-0x0000000180960640
		public override void Close(); // 0x000000018095F010-0x000000018095F080
		public bool HasLineInfo(); // 0x00000001803C29F0-0x00000001803C2A00
	}
}
