/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	public abstract class JsonWriter : IDisposable // TypeDefIndex: 7822
	{
		// Fields
		private static readonly State[][] StateArray; // 0x00
		internal static readonly State[][] StateArrayTempate; // 0x08
		private List<JsonPosition> _stack; // 0x10
		private JsonPosition _currentPosition; // 0x18
		private State _currentState; // 0x30
		private Formatting _formatting; // 0x34
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <CloseOutput>k__BackingField; // 0x38
		private DateFormatHandling _dateFormatHandling; // 0x3C
		private DateTimeZoneHandling _dateTimeZoneHandling; // 0x40
		private StringEscapeHandling _stringEscapeHandling; // 0x44
		private FloatFormatHandling _floatFormatHandling; // 0x48
		private string _dateFormatString; // 0x50
		private CultureInfo _culture; // 0x58
	
		// Properties
		public bool CloseOutput { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804AEAD0-0x00000001804AEAE0 0x000000018044E330-0x000000018044E340
		protected internal int Top { get; } // 0x000000018096D610-0x000000018096D650 
		public WriteState WriteState { get; } // 0x000000018096D650-0x000000018096D760 
		internal string ContainerPath { get; } // 0x000000018096D420-0x000000018096D4B0 
		public string Path { get; } // 0x000000018096D510-0x000000018096D610 
		public Formatting Formatting { get; set; } // 0x000000018043E170-0x000000018043E180 0x000000018096D8B0-0x000000018096D920
		public DateFormatHandling DateFormatHandling { get; set; } // 0x0000000180487DC0-0x0000000180487DD0 0x000000018096D760-0x000000018096D7D0
		public DateTimeZoneHandling DateTimeZoneHandling { get; set; } // 0x000000018047AB20-0x000000018047AB30 0x000000018096D7D0-0x000000018096D840
		public StringEscapeHandling StringEscapeHandling { get; set; } // 0x0000000180478650-0x0000000180478660 0x000000018096D920-0x000000018096D9B0
		public FloatFormatHandling FloatFormatHandling { get; set; } // 0x0000000180384C10-0x0000000180384C20 0x000000018096D840-0x000000018096D8B0
		public string DateFormatString { get; set; } // 0x00000001803A27A0-0x00000001803A27B0 0x00000001803A2850-0x00000001803A2860
		public CultureInfo Culture { get; set; } // 0x000000018096D4B0-0x000000018096D510 0x0000000180485C70-0x0000000180485C80
	
		// Nested types
		internal enum State // TypeDefIndex: 7823
		{
			Start = 0,
			Property = 1,
			ObjectStart = 2,
			Object = 3,
			ArrayStart = 4,
			Array = 5,
			ConstructorStart = 6,
			Constructor = 7,
			Closed = 8,
			Error = 9
		}
	
		// Constructors
		static JsonWriter(); // 0x000000018096C510-0x000000018096D3F0
		protected JsonWriter(); // 0x000000018096D3F0-0x000000018096D420
	
		// Methods
		internal static State[][] BuildStateArray(); // 0x0000000180969010-0x0000000180969390
		internal virtual void OnStringEscapeHandlingChanged(); // 0x00000001803581E0-0x00000001803581F0
		internal void UpdateScopeWithFinishedValue(); // 0x0000000180969890-0x00000001809698A0
		private void Push(JsonContainerType value); // 0x0000000180969740-0x0000000180969820
		private JsonContainerType Pop(); // 0x0000000180969660-0x0000000180969740
		private JsonContainerType Peek(); // 0x0000000180367710-0x0000000180367720
		public virtual void Close(); // 0x00000001809689C0-0x0000000180968A20
		public virtual void WriteStartObject(); // 0x0000000180969DB0-0x0000000180969DC0
		public virtual void WriteEndObject(); // 0x0000000180969B20-0x0000000180969B30
		public virtual void WriteStartArray(); // 0x0000000180969D90-0x0000000180969DA0
		public virtual void WriteEndArray(); // 0x0000000180969B00-0x0000000180969B10
		public virtual void WriteStartConstructor(string name); // 0x0000000180969DA0-0x0000000180969DB0
		public virtual void WriteEndConstructor(); // 0x0000000180969B10-0x0000000180969B20
		public virtual void WritePropertyName(string name); // 0x0000000180969540-0x0000000180969550
		public virtual void WritePropertyName(string name, bool escape); // 0x0000000180969D20-0x0000000180969D40
		public virtual void WriteEnd(); // 0x0000000180969C20-0x0000000180969D00
		public void WriteToken(JsonReader reader); // 0x0000000180969FE0-0x000000018096A050
		public void WriteToken(JsonReader reader, bool writeChildren); // 0x000000018096A880-0x000000018096A900
		public void WriteToken(JsonToken token, object value); // 0x000000018096A050-0x000000018096A880
		internal virtual void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments); // 0x0000000180969DC0-0x0000000180969FE0
		private void WriteConstructorDate(JsonReader reader); // 0x00000001809698A0-0x0000000180969B00
		private void WriteEnd(JsonContainerType type); // 0x0000000180969B30-0x0000000180969C20
		private void AutoCompleteAll(); // 0x00000001809689C0-0x0000000180968A20
		private JsonToken GetCloseTokenForType(JsonContainerType type); // 0x0000000180969460-0x0000000180969520
		private void AutoCompleteClose(JsonContainerType type); // 0x0000000180968A20-0x0000000180968DA0
		protected virtual void WriteEnd(JsonToken token); // 0x00000001803581E0-0x00000001803581F0
		protected virtual void WriteIndent(); // 0x00000001803581E0-0x00000001803581F0
		protected virtual void WriteValueDelimiter(); // 0x00000001803581E0-0x00000001803581F0
		protected virtual void WriteIndentSpace(); // 0x00000001803581E0-0x00000001803581F0
		internal void AutoComplete(JsonToken tokenBeingWritten); // 0x0000000180968DA0-0x0000000180969010
		public virtual void WriteNull(); // 0x0000000180969D00-0x0000000180969D20
		public virtual void WriteUndefined(); // 0x000000018096A900-0x000000018096A920
		public virtual void WriteRaw(string json); // 0x00000001803581E0-0x00000001803581F0
		public virtual void WriteRawValue(string json); // 0x0000000180969D40-0x0000000180969D90
		public virtual void WriteValue(string value); // 0x000000018096A990-0x000000018096A9B0
		public virtual void WriteValue(int value); // 0x000000018096BCC0-0x000000018096BCE0
		[CLSCompliant] // 0x00000001800BD1B0-0x00000001800BD1D0
		public virtual void WriteValue(uint value); // 0x000000018096BCC0-0x000000018096BCE0
		public virtual void WriteValue(long value); // 0x000000018096BCC0-0x000000018096BCE0
		[CLSCompliant] // 0x00000001800BD1B0-0x00000001800BD1D0
		public virtual void WriteValue(ulong value); // 0x000000018096BCC0-0x000000018096BCE0
		public virtual void WriteValue(float value); // 0x000000018096C070-0x000000018096C090
		public virtual void WriteValue(double value); // 0x000000018096C070-0x000000018096C090
		public virtual void WriteValue(bool value); // 0x000000018096BFC0-0x000000018096BFE0
		public virtual void WriteValue(short value); // 0x000000018096BCC0-0x000000018096BCE0
		[CLSCompliant] // 0x00000001800BD1B0-0x00000001800BD1D0
		public virtual void WriteValue(ushort value); // 0x000000018096BCC0-0x000000018096BCE0
		public virtual void WriteValue(char value); // 0x000000018096A990-0x000000018096A9B0
		public virtual void WriteValue(byte value); // 0x000000018096BCC0-0x000000018096BCE0
		[CLSCompliant] // 0x00000001800BD1B0-0x00000001800BD1D0
		public virtual void WriteValue(sbyte value); // 0x000000018096BCC0-0x000000018096BCE0
		public virtual void WriteValue(decimal value); // 0x000000018096C070-0x000000018096C090
		public virtual void WriteValue(DateTime value); // 0x000000018096C050-0x000000018096C070
		public virtual void WriteValue(DateTimeOffset value); // 0x000000018096C050-0x000000018096C070
		public virtual void WriteValue(Guid value); // 0x000000018096A990-0x000000018096A9B0
		public virtual void WriteValue(TimeSpan value); // 0x000000018096A990-0x000000018096A9B0
		public virtual void WriteValue(int? value); // 0x000000018096BE60-0x000000018096BED0
		[CLSCompliant] // 0x00000001800BD1B0-0x00000001800BD1D0
		public virtual void WriteValue(uint? value); // 0x000000018096C4A0-0x000000018096C510
		public virtual void WriteValue(long? value); // 0x000000018096C340-0x000000018096C3B0
		[CLSCompliant] // 0x00000001800BD1B0-0x00000001800BD1D0
		public virtual void WriteValue(ulong? value); // 0x000000018096A920-0x000000018096A990
		public virtual void WriteValue(float? value); // 0x000000018096C3B0-0x000000018096C420
		public virtual void WriteValue(double? value); // 0x000000018096BD50-0x000000018096BDC0
		public virtual void WriteValue(bool? value); // 0x000000018096C170-0x000000018096C1E0
		public virtual void WriteValue(short? value); // 0x000000018096C090-0x000000018096C100
		[CLSCompliant] // 0x00000001800BD1B0-0x00000001800BD1D0
		public virtual void WriteValue(ushort? value); // 0x000000018096BED0-0x000000018096BF40
		public virtual void WriteValue(char? value); // 0x000000018096C100-0x000000018096C170
		public virtual void WriteValue(byte? value); // 0x000000018096BFE0-0x000000018096C050
		[CLSCompliant] // 0x00000001800BD1B0-0x00000001800BD1D0
		public virtual void WriteValue(sbyte? value); // 0x000000018096BCE0-0x000000018096BD50
		public virtual void WriteValue(decimal? value); // 0x000000018096BF40-0x000000018096BFC0
		public virtual void WriteValue(DateTime? value); // 0x000000018096C2D0-0x000000018096C340
		public virtual void WriteValue(DateTimeOffset? value); // 0x000000018096C420-0x000000018096C4A0
		public virtual void WriteValue(Guid? value); // 0x000000018096C1E0-0x000000018096C260
		public virtual void WriteValue(TimeSpan? value); // 0x000000018096C260-0x000000018096C2D0
		public virtual void WriteValue(byte[] value); // 0x000000018096A9B0-0x000000018096A9E0
		public virtual void WriteValue(Uri value); // 0x000000018096BDC0-0x000000018096BE60
		public virtual void WriteValue(object value); // 0x0000000180967760-0x0000000180967830
		public virtual void WriteComment(string text); // 0x0000000180969520-0x0000000180969530
		void IDisposable.Dispose(); // 0x0000000180969820-0x0000000180969890
		protected virtual void Dispose(bool disposing); // 0x0000000180969440-0x0000000180969460
		internal static void WriteValue(JsonWriter writer, PrimitiveTypeCode typeCode, object value); // 0x000000018096A9E0-0x000000018096BCC0
		private static JsonWriterException CreateUnsupportedTypeException(JsonWriter writer, object value); // 0x0000000180969390-0x0000000180969440
		internal void InternalWriteEnd(JsonContainerType container); // 0x0000000180969530-0x0000000180969540
		internal void InternalWritePropertyName(string name); // 0x0000000180969540-0x0000000180969550
		internal void InternalWriteRaw(); // 0x00000001803581E0-0x00000001803581F0
		internal void InternalWriteStart(JsonToken token, JsonContainerType container); // 0x0000000180969550-0x0000000180969640
		internal void InternalWriteValue(JsonToken token); // 0x0000000180969640-0x0000000180969660
		internal void InternalWriteComment(); // 0x0000000180969520-0x0000000180969530
	}
}
