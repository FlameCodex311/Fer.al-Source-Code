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
	public class JsonTextWriter : JsonWriter // TypeDefIndex: 7973
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
		private Base64Encoder Base64Encoder { get; } // 0x000000018184BF70-0x000000018184BFF0 
		public char QuoteChar { get; } // 0x000000018184BFF0-0x000000018184C000 
	
		// Constructors
		public JsonTextWriter(TextWriter textWriter); // 0x000000018184BEA0-0x000000018184BF70
	
		// Methods
		public override void Close(); // 0x000000018184A160-0x000000018184A210
		public override void WriteStartObject(); // 0x000000018184AC30-0x000000018184AC80
		public override void WriteStartArray(); // 0x000000018184AB20-0x000000018184AB70
		public override void WriteStartConstructor(string name); // 0x000000018184AB70-0x000000018184AC30
		protected override void WriteEnd(JsonToken token); // 0x000000018184A3A0-0x000000018184A490
		public override void WritePropertyName(string name); // 0x000000018184AA80-0x000000018184AAF0
		public override void WritePropertyName(string name, bool escape); // 0x000000018184A980-0x000000018184AA80
		internal override void OnStringEscapeHandlingChanged(); // 0x000000018184A250-0x000000018184A260
		private void UpdateCharEscapeFlags(); // 0x000000018184A260-0x000000018184A2E0
		protected override void WriteIndent(); // 0x000000018184A5B0-0x000000018184A700
		protected override void WriteValueDelimiter(); // 0x000000018184AD20-0x000000018184AD50
		protected override void WriteIndentSpace(); // 0x000000018184A580-0x000000018184A5B0
		private void WriteValueInternal(string value, JsonToken token); // 0x000000018184AAF0-0x000000018184AB20
		public override void WriteValue(object value); // 0x000000018183F320-0x000000018183F330
		public override void WriteNull(); // 0x000000018184A8E0-0x000000018184A980
		public override void WriteUndefined(); // 0x000000018184AC80-0x000000018184AD20
		public override void WriteRaw(string json); // 0x000000018184AAF0-0x000000018184AB20
		public override void WriteValue(string value); // 0x000000018184BC40-0x000000018184BD00
		private void WriteEscapedString(string value, bool quote); // 0x000000018184A490-0x000000018184A580
		public override void WriteValue(int value); // 0x000000018184BC00-0x000000018184BC40
		[CLSCompliant] // 0x00000001801CE510-0x00000001801CE530
		public override void WriteValue(uint value); // 0x000000018184B970-0x000000018184B9B0
		public override void WriteValue(long value); // 0x000000018184BB40-0x000000018184BB80
		[CLSCompliant] // 0x00000001801CE510-0x00000001801CE530
		public override void WriteValue(ulong value); // 0x000000018184AFD0-0x000000018184B010
		public override void WriteValue(float value); // 0x000000018184AE10-0x000000018184AEE0
		public override void WriteValue(float? value); // 0x000000018184AEE0-0x000000018184AFD0
		public override void WriteValue(double value); // 0x000000018184B010-0x000000018184B0E0
		public override void WriteValue(double? value); // 0x000000018184B9B0-0x000000018184BAA0
		public override void WriteValue(bool value); // 0x000000018184BAA0-0x000000018184BB40
		public override void WriteValue(short value); // 0x000000018184B790-0x000000018184B7D0
		[CLSCompliant] // 0x00000001801CE510-0x00000001801CE530
		public override void WriteValue(ushort value); // 0x000000018184BB80-0x000000018184BBC0
		public override void WriteValue(char value); // 0x000000018184B8D0-0x000000018184B970
		public override void WriteValue(byte value); // 0x000000018184BBC0-0x000000018184BC00
		[CLSCompliant] // 0x00000001801CE510-0x00000001801CE530
		public override void WriteValue(sbyte value); // 0x000000018184BE60-0x000000018184BEA0
		public override void WriteValue(decimal value); // 0x000000018184BD00-0x000000018184BDB0
		public override void WriteValue(DateTime value); // 0x000000018184B1E0-0x000000018184B4D0
		public override void WriteValue(byte[] value); // 0x000000018184B0E0-0x000000018184B1E0
		public override void WriteValue(DateTimeOffset value); // 0x000000018184B4D0-0x000000018184B790
		public override void WriteValue(Guid value); // 0x000000018184B7D0-0x000000018184B8D0
		public override void WriteValue(TimeSpan value); // 0x000000018184BDB0-0x000000018184BE60
		public override void WriteValue(Uri value); // 0x000000018184AD50-0x000000018184AE10
		public override void WriteComment(string text); // 0x000000018184A2E0-0x000000018184A3A0
		private void EnsureWriteBuffer(); // 0x000000018184A210-0x000000018184A250
		private void WriteIntegerValue(long value); // 0x000000018184A840-0x000000018184A8E0
		private void WriteIntegerValue(ulong uvalue); // 0x000000018184A700-0x000000018184A840
	}
}
