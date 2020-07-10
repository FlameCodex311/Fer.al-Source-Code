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
	public class JsonTextWriter : JsonWriter // TypeDefIndex: 7807
	{
		// Fields
		private readonly TextWriter _writer; // 0x60
		private Base64Encoder _base64Encoder; // 0x68
		private char _indentChar; // 0x70
		private int _indentation; // 0x74
		private char _quoteChar; // 0x78
		private bool _quoteName; // 0x7A
		private bool[] _charEscapeFlags; // 0x80
		private char[] _writeBuffer; // 0x88
		private IArrayPool<char> _arrayPool; // 0x90
		private char[] _indentChars; // 0x98
	
		// Properties
		private Base64Encoder Base64Encoder { get; } // 0x00000001809686E0-0x0000000180968760 
		public char QuoteChar { get; } // 0x0000000180968760-0x0000000180968770 
	
		// Constructors
		public JsonTextWriter(TextWriter textWriter); // 0x0000000180968600-0x00000001809686E0
	
		// Methods
		public override void Close(); // 0x00000001809667C0-0x0000000180966870
		public override void WriteStartObject(); // 0x00000001809672A0-0x00000001809672F0
		public override void WriteStartArray(); // 0x0000000180967190-0x00000001809671E0
		public override void WriteStartConstructor(string name); // 0x00000001809671E0-0x00000001809672A0
		protected override void WriteEnd(JsonToken token); // 0x0000000180966A00-0x0000000180966AF0
		public override void WritePropertyName(string name); // 0x00000001809670F0-0x0000000180967160
		public override void WritePropertyName(string name, bool escape); // 0x0000000180966FF0-0x00000001809670F0
		internal override void OnStringEscapeHandlingChanged(); // 0x00000001809668B0-0x00000001809668C0
		private void UpdateCharEscapeFlags(); // 0x00000001809668C0-0x0000000180966940
		protected override void WriteIndent(); // 0x0000000180966C10-0x0000000180966D60
		protected override void WriteValueDelimiter(); // 0x0000000180967390-0x00000001809673C0
		protected override void WriteIndentSpace(); // 0x0000000180966BE0-0x0000000180966C10
		private void WriteValueInternal(string value, JsonToken token); // 0x0000000180967160-0x0000000180967190
		public override void WriteValue(object value); // 0x0000000180967760-0x0000000180967830
		public override void WriteNull(); // 0x0000000180966F50-0x0000000180966FF0
		public override void WriteUndefined(); // 0x00000001809672F0-0x0000000180967390
		public override void WriteRaw(string json); // 0x0000000180967160-0x0000000180967190
		public override void WriteValue(string value); // 0x00000001809683A0-0x0000000180968460
		private void WriteEscapedString(string value, bool quote); // 0x0000000180966AF0-0x0000000180966BE0
		public override void WriteValue(int value); // 0x0000000180968360-0x00000001809683A0
		[CLSCompliant] // 0x00000001800BD1B0-0x00000001800BD1D0
		public override void WriteValue(uint value); // 0x00000001809680D0-0x0000000180968110
		public override void WriteValue(long value); // 0x00000001809682A0-0x00000001809682E0
		[CLSCompliant] // 0x00000001800BD1B0-0x00000001800BD1D0
		public override void WriteValue(ulong value); // 0x0000000180967650-0x0000000180967690
		public override void WriteValue(float value); // 0x0000000180967490-0x0000000180967560
		public override void WriteValue(float? value); // 0x0000000180967560-0x0000000180967650
		public override void WriteValue(double value); // 0x0000000180967690-0x0000000180967760
		public override void WriteValue(double? value); // 0x0000000180968110-0x0000000180968200
		public override void WriteValue(bool value); // 0x0000000180968200-0x00000001809682A0
		public override void WriteValue(short value); // 0x0000000180967EF0-0x0000000180967F30
		[CLSCompliant] // 0x00000001800BD1B0-0x00000001800BD1D0
		public override void WriteValue(ushort value); // 0x00000001809682E0-0x0000000180968320
		public override void WriteValue(char value); // 0x0000000180968030-0x00000001809680D0
		public override void WriteValue(byte value); // 0x0000000180968320-0x0000000180968360
		[CLSCompliant] // 0x00000001800BD1B0-0x00000001800BD1D0
		public override void WriteValue(sbyte value); // 0x00000001809685C0-0x0000000180968600
		public override void WriteValue(decimal value); // 0x0000000180968460-0x0000000180968510
		public override void WriteValue(DateTime value); // 0x0000000180967930-0x0000000180967C20
		public override void WriteValue(byte[] value); // 0x0000000180967830-0x0000000180967930
		public override void WriteValue(DateTimeOffset value); // 0x0000000180967C20-0x0000000180967EF0
		public override void WriteValue(Guid value); // 0x0000000180967F30-0x0000000180968030
		public override void WriteValue(TimeSpan value); // 0x0000000180968510-0x00000001809685C0
		public override void WriteValue(Uri value); // 0x00000001809673C0-0x0000000180967490
		public override void WriteComment(string text); // 0x0000000180966940-0x0000000180966A00
		private void EnsureWriteBuffer(); // 0x0000000180966870-0x00000001809668B0
		private void WriteIntegerValue(long value); // 0x0000000180966EB0-0x0000000180966F50
		private void WriteIntegerValue(ulong uvalue); // 0x0000000180966D60-0x0000000180966EB0
	}
}
