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

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class JsonTextReader : JsonReader, IJsonLineInfo // TypeDefIndex: 7970
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
		public int LineNumber { get; } // 0x0000000180C746A0-0x0000000180C746F0 
		public int LinePosition { get; } // 0x0000000180C746F0-0x0000000180C74700 
	
		// Constructors
		public JsonTextReader(TextReader reader); // 0x0000000180C74600-0x0000000180C746A0
	
		// Methods
		private void EnsureBufferNotEmpty(); // 0x0000000180C6CAF0-0x0000000180C6CB50
		private void OnNewLine(int pos); // 0x0000000180C6D300-0x0000000180C6D310
		private void ParseString(char quote, ReadType readType); // 0x0000000180C6FC30-0x0000000180C70050
		private static void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count); // 0x0000000180C6C7D0-0x0000000180C6C7F0
		private void ShiftBufferIfNeeded(); // 0x0000000180C74440-0x0000000180C74520
		private int ReadData(bool append); // 0x0000000180C72710-0x0000000180C72720
		private int ReadData(bool append, int charsRequired); // 0x0000000180C72470-0x0000000180C72710
		private bool EnsureChars(int relativePosition, bool append); // 0x0000000180C6CBB0-0x0000000180C6CC50
		private bool ReadChars(int relativePosition, bool append); // 0x0000000180C723E0-0x0000000180C72470
		public override bool Read(); // 0x0000000180C74140-0x0000000180C74440
		public override int? ReadAsInt32(); // 0x0000000180C722F0-0x0000000180C72380
		public override DateTime? ReadAsDateTime(); // 0x0000000180C72110-0x0000000180C721B0
		public override string ReadAsString(); // 0x0000000180C72380-0x0000000180C723E0
		public override byte[] ReadAsBytes(); // 0x0000000180C719E0-0x0000000180C72070
		private object ReadStringValue(ReadType readType); // 0x0000000180C737E0-0x0000000180C74140
		private JsonReaderException CreateUnexpectedCharacterException(char c); // 0x0000000180C6C890-0x0000000180C6C940
		public override bool? ReadAsBoolean(); // 0x0000000180C71130-0x0000000180C719E0
		private void ProcessValueComma(); // 0x0000000180C710C0-0x0000000180C71130
		private object ReadNumberValue(ReadType readType); // 0x0000000180C72B40-0x0000000180C73120
		public override DateTimeOffset? ReadAsDateTimeOffset(); // 0x0000000180C72070-0x0000000180C72110
		public override decimal? ReadAsDecimal(); // 0x0000000180C721B0-0x0000000180C72250
		public override double? ReadAsDouble(); // 0x0000000180C72250-0x0000000180C722F0
		private void HandleNull(); // 0x0000000180C6CC50-0x0000000180C6CD80
		private void ReadFinished(); // 0x0000000180C72720-0x0000000180C728A0
		private bool ReadNullChar(); // 0x0000000180C728A0-0x0000000180C728F0
		private void EnsureBuffer(); // 0x0000000180C6CB50-0x0000000180C6CBB0
		private void ReadStringIntoBuffer(char quote); // 0x0000000180C73120-0x0000000180C737E0
		private void WriteCharToBuffer(char writeChar, int lastWritePosition, int writeToPosition); // 0x0000000180C74590-0x0000000180C74600
		private char ParseUnicode(); // 0x0000000180C70230-0x0000000180C70320
		private void ReadNumberIntoBuffer(); // 0x0000000180C728F0-0x0000000180C72B40
		private void ClearRecentString(); // 0x0000000180C6C7F0-0x0000000180C6C810
		private bool ParsePostValue(); // 0x0000000180C6F5D0-0x0000000180C6F900
		private bool ParseObject(); // 0x0000000180C6F3F0-0x0000000180C6F5D0
		private bool ParseProperty(); // 0x0000000180C6F900-0x0000000180C6FC30
		private bool ValidIdentifierChar(char value); // 0x0000000180C74520-0x0000000180C74590
		private void ParseUnquotedProperty(); // 0x0000000180C70320-0x0000000180C70590
		private bool ParseValue(); // 0x0000000180C70590-0x0000000180C70FC0
		private void ProcessLineFeed(); // 0x0000000180C710A0-0x0000000180C710C0
		private void ProcessCarriageReturn(bool append); // 0x0000000180C70FC0-0x0000000180C710A0
		private bool EatWhitespace(bool oneOrMore); // 0x0000000180C6C940-0x0000000180C6CA90
		private void ParseConstructor(); // 0x0000000180C6D750-0x0000000180C6DB30
		private void ParseNumber(ReadType readType); // 0x0000000180C6E370-0x0000000180C6F3F0
		private void ParseComment(bool setToken); // 0x0000000180C6D310-0x0000000180C6D750
		private void EndComment(bool setToken, int initialPosition, int endPosition); // 0x0000000180C6CA90-0x0000000180C6CAF0
		private bool MatchValue(string value); // 0x0000000180C6D1F0-0x0000000180C6D300
		private bool MatchValueWithTrailingSeparator(string value); // 0x0000000180C6CEE0-0x0000000180C6D1F0
		private bool IsSeparator(char c); // 0x0000000180C6CD80-0x0000000180C6CEE0
		private void ParseTrue(); // 0x0000000180C70050-0x0000000180C70150
		private void ParseNull(); // 0x0000000180C6DC30-0x0000000180C6DD10
		private void ParseUndefined(); // 0x0000000180C70150-0x0000000180C70230
		private void ParseFalse(); // 0x0000000180C6DB30-0x0000000180C6DC30
		private object ParseNumberNegativeInfinity(ReadType readType); // 0x0000000180C6DF30-0x0000000180C6E150
		private object ParseNumberPositiveInfinity(ReadType readType); // 0x0000000180C6E150-0x0000000180C6E370
		private object ParseNumberNaN(ReadType readType); // 0x0000000180C6DD10-0x0000000180C6DF30
		public override void Close(); // 0x0000000180C6C810-0x0000000180C6C890
		public bool HasLineInfo(); // 0x0000000180380B60-0x0000000180380B70
	}
}
