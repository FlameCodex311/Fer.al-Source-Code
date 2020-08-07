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

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	public abstract class JsonWriter : IDisposable // TypeDefIndex: 7988
	{
		// Fields
		private static readonly State[][] StateArray; // 0x00
		internal static readonly State[][] StateArrayTempate; // 0x08
		private List<JsonPosition> _stack; // 0x10
		private JsonPosition _currentPosition; // 0x18
		private State _currentState; // 0x30
		private Formatting _formatting; // 0x34
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <CloseOutput>k__BackingField; // 0x38
		private DateFormatHandling _dateFormatHandling; // 0x3C
		private DateTimeZoneHandling _dateTimeZoneHandling; // 0x40
		private StringEscapeHandling _stringEscapeHandling; // 0x44
		private FloatFormatHandling _floatFormatHandling; // 0x48
		private string _dateFormatString; // 0x50
		private CultureInfo _culture; // 0x58
	
		// Properties
		public bool CloseOutput { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180379B20-0x0000000180379B30 0x00000001804F1690-0x00000001804F16A0
		protected internal int Top { get; } // 0x0000000181850D40-0x0000000181850D80 
		public WriteState WriteState { get; } // 0x0000000181850D80-0x0000000181850E90 
		internal string ContainerPath { get; } // 0x0000000181850B50-0x0000000181850BE0 
		public string Path { get; } // 0x0000000181850C40-0x0000000181850D40 
		public Formatting Formatting { get; set; } // 0x00000001804EF8F0-0x00000001804EF900 0x0000000181850FE0-0x0000000181851050
		public DateFormatHandling DateFormatHandling { get; set; } // 0x000000018099EBE0-0x000000018099EBF0 0x0000000181850E90-0x0000000181850F00
		public DateTimeZoneHandling DateTimeZoneHandling { get; set; } // 0x0000000180379F10-0x0000000180379F20 0x0000000181850F00-0x0000000181850F70
		public StringEscapeHandling StringEscapeHandling { get; set; } // 0x00000001804ADA70-0x00000001804ADA80 0x0000000181851050-0x00000001818510E0
		public FloatFormatHandling FloatFormatHandling { get; set; } // 0x0000000180379ED0-0x0000000180379EE0 0x0000000181850F70-0x0000000181850FE0
		public string DateFormatString { get; set; } // 0x0000000180378320-0x0000000180378330 0x00000001803F7B90-0x00000001803F7BA0
		public CultureInfo Culture { get; set; } // 0x0000000181850BE0-0x0000000181850C40 0x00000001803A1740-0x00000001803A1750
	
		// Nested types
		internal enum State // TypeDefIndex: 7989
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
		static JsonWriter(); // 0x000000018184FD60-0x0000000181850B20
		protected JsonWriter(); // 0x0000000181850B20-0x0000000181850B50
	
		// Methods
		internal static State[][] BuildStateArray(); // 0x000000018184C830-0x000000018184CBA0
		internal virtual void OnStringEscapeHandlingChanged(); // 0x00000001803774A0-0x00000001803774B0
		internal void UpdateScopeWithFinishedValue(); // 0x000000018184D0A0-0x000000018184D0B0
		private void Push(JsonContainerType value); // 0x000000018184CF50-0x000000018184D030
		private JsonContainerType Pop(); // 0x000000018184CE70-0x000000018184CF50
		private JsonContainerType Peek(); // 0x00000001803F46B0-0x00000001803F46C0
		public virtual void Close(); // 0x000000018183E090-0x000000018183E0F0
		public virtual void WriteStartObject(); // 0x000000018184D5B0-0x000000018184D5C0
		public virtual void WriteEndObject(); // 0x000000018184D320-0x000000018184D330
		public virtual void WriteStartArray(); // 0x000000018184D590-0x000000018184D5A0
		public virtual void WriteEndArray(); // 0x000000018184D300-0x000000018184D310
		public virtual void WriteStartConstructor(string name); // 0x000000018184D5A0-0x000000018184D5B0
		public virtual void WriteEndConstructor(); // 0x000000018184D310-0x000000018184D320
		public virtual void WritePropertyName(string name); // 0x000000018184CD50-0x000000018184CD60
		public virtual void WritePropertyName(string name, bool escape); // 0x000000018184D520-0x000000018184D540
		public virtual void WriteEnd(); // 0x000000018184D420-0x000000018184D500
		public void WriteToken(JsonReader reader); // 0x000000018184D7E0-0x000000018184D850
		public void WriteToken(JsonReader reader, bool writeChildren); // 0x000000018184E070-0x000000018184E0F0
		public void WriteToken(JsonToken token, object value); // 0x000000018184D850-0x000000018184E070
		internal virtual void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments); // 0x000000018184D5C0-0x000000018184D7E0
		private void WriteConstructorDate(JsonReader reader); // 0x000000018184D0B0-0x000000018184D300
		private void WriteEnd(JsonContainerType type); // 0x000000018184D330-0x000000018184D420
		private void AutoCompleteAll(); // 0x000000018183E090-0x000000018183E0F0
		private JsonToken GetCloseTokenForType(JsonContainerType type); // 0x000000018184CC70-0x000000018184CD30
		private void AutoCompleteClose(JsonContainerType type); // 0x000000018184C250-0x000000018184C5D0
		protected virtual void WriteEnd(JsonToken token); // 0x00000001803774A0-0x00000001803774B0
		protected virtual void WriteIndent(); // 0x00000001803774A0-0x00000001803774B0
		protected virtual void WriteValueDelimiter(); // 0x00000001803774A0-0x00000001803774B0
		protected virtual void WriteIndentSpace(); // 0x00000001803774A0-0x00000001803774B0
		internal void AutoComplete(JsonToken tokenBeingWritten); // 0x000000018184C5D0-0x000000018184C830
		public virtual void WriteNull(); // 0x000000018184D500-0x000000018184D520
		public virtual void WriteUndefined(); // 0x000000018184E0F0-0x000000018184E110
		public virtual void WriteRaw(string json); // 0x00000001803774A0-0x00000001803774B0
		public virtual void WriteRawValue(string json); // 0x000000018184D540-0x000000018184D590
		public virtual void WriteValue(string value); // 0x000000018184E180-0x000000018184E1A0
		public virtual void WriteValue(int value); // 0x000000018184F440-0x000000018184F460
		[CLSCompliant] // 0x00000001801CE510-0x00000001801CE530
		public virtual void WriteValue(uint value); // 0x000000018184F440-0x000000018184F460
		public virtual void WriteValue(long value); // 0x000000018184F440-0x000000018184F460
		[CLSCompliant] // 0x00000001801CE510-0x00000001801CE530
		public virtual void WriteValue(ulong value); // 0x000000018184F440-0x000000018184F460
		public virtual void WriteValue(float value); // 0x000000018184F8C0-0x000000018184F8E0
		public virtual void WriteValue(double value); // 0x000000018184F8C0-0x000000018184F8E0
		public virtual void WriteValue(bool value); // 0x000000018184F740-0x000000018184F760
		public virtual void WriteValue(short value); // 0x000000018184F440-0x000000018184F460
		[CLSCompliant] // 0x00000001801CE510-0x00000001801CE530
		public virtual void WriteValue(ushort value); // 0x000000018184F440-0x000000018184F460
		public virtual void WriteValue(char value); // 0x000000018184E180-0x000000018184E1A0
		public virtual void WriteValue(byte value); // 0x000000018184F440-0x000000018184F460
		[CLSCompliant] // 0x00000001801CE510-0x00000001801CE530
		public virtual void WriteValue(sbyte value); // 0x000000018184F440-0x000000018184F460
		public virtual void WriteValue(decimal value); // 0x000000018184F8C0-0x000000018184F8E0
		public virtual void WriteValue(DateTime value); // 0x000000018184F8A0-0x000000018184F8C0
		public virtual void WriteValue(DateTimeOffset value); // 0x000000018184F8A0-0x000000018184F8C0
		public virtual void WriteValue(Guid value); // 0x000000018184E180-0x000000018184E1A0
		public virtual void WriteValue(TimeSpan value); // 0x000000018184E180-0x000000018184E1A0
		public virtual void WriteValue(int? value); // 0x000000018184F5E0-0x000000018184F650
		[CLSCompliant] // 0x00000001801CE510-0x00000001801CE530
		public virtual void WriteValue(uint? value); // 0x000000018184FCF0-0x000000018184FD60
		public virtual void WriteValue(long? value); // 0x000000018184FB90-0x000000018184FC00
		[CLSCompliant] // 0x00000001801CE510-0x00000001801CE530
		public virtual void WriteValue(ulong? value); // 0x000000018184E110-0x000000018184E180
		public virtual void WriteValue(float? value); // 0x000000018184FC00-0x000000018184FC70
		public virtual void WriteValue(double? value); // 0x000000018184F4D0-0x000000018184F540
		public virtual void WriteValue(bool? value); // 0x000000018184F9C0-0x000000018184FA30
		public virtual void WriteValue(short? value); // 0x000000018184F8E0-0x000000018184F950
		[CLSCompliant] // 0x00000001801CE510-0x00000001801CE530
		public virtual void WriteValue(ushort? value); // 0x000000018184F650-0x000000018184F6C0
		public virtual void WriteValue(char? value); // 0x000000018184F950-0x000000018184F9C0
		public virtual void WriteValue(byte? value); // 0x000000018184F760-0x000000018184F7D0
		[CLSCompliant] // 0x00000001801CE510-0x00000001801CE530
		public virtual void WriteValue(sbyte? value); // 0x000000018184F460-0x000000018184F4D0
		public virtual void WriteValue(decimal? value); // 0x000000018184F6C0-0x000000018184F740
		public virtual void WriteValue(DateTime? value); // 0x000000018184FB20-0x000000018184FB90
		public virtual void WriteValue(DateTimeOffset? value); // 0x000000018184FC70-0x000000018184FCF0
		public virtual void WriteValue(Guid? value); // 0x000000018184FA30-0x000000018184FAB0
		public virtual void WriteValue(TimeSpan? value); // 0x000000018184FAB0-0x000000018184FB20
		public virtual void WriteValue(byte[] value); // 0x000000018184E1A0-0x000000018184E1D0
		public virtual void WriteValue(Uri value); // 0x000000018184F540-0x000000018184F5E0
		public virtual void WriteValue(object value); // 0x000000018184F7D0-0x000000018184F8A0
		public virtual void WriteComment(string text); // 0x000000018184CD30-0x000000018184CD40
		void IDisposable.Dispose(); // 0x000000018184D030-0x000000018184D0A0
		protected virtual void Dispose(bool disposing); // 0x000000018184CC50-0x000000018184CC70
		internal static void WriteValue(JsonWriter writer, PrimitiveTypeCode typeCode, object value); // 0x000000018184E1D0-0x000000018184F440
		private static JsonWriterException CreateUnsupportedTypeException(JsonWriter writer, object value); // 0x000000018184CBA0-0x000000018184CC50
		internal void InternalWriteEnd(JsonContainerType container); // 0x000000018184CD40-0x000000018184CD50
		internal void InternalWritePropertyName(string name); // 0x000000018184CD50-0x000000018184CD60
		internal void InternalWriteRaw(); // 0x00000001803774A0-0x00000001803774B0
		internal void InternalWriteStart(JsonToken token, JsonContainerType container); // 0x000000018184CD60-0x000000018184CE50
		internal void InternalWriteValue(JsonToken token); // 0x000000018184CE50-0x000000018184CE70
		internal void InternalWriteComment(); // 0x000000018184CD30-0x000000018184CD40
	}
}
