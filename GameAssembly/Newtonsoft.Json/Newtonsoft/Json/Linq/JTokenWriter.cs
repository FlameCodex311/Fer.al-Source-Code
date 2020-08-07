/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Shims;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Linq
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class JTokenWriter : JsonWriter // TypeDefIndex: 8145
	{
		// Fields
		private JContainer _token; // 0x60
		private JContainer _parent; // 0x68
		private JValue _value; // 0x70
		private JToken _current; // 0x78
	
		// Properties
		public JToken Token { get; } // 0x000000018183F4A0-0x000000018183F4B0 
	
		// Constructors
		public JTokenWriter(); // 0x000000018183F430-0x000000018183F4A0
	
		// Methods
		public override void Close(); // 0x000000018183E090-0x000000018183E0F0
		public override void WriteStartObject(); // 0x000000018183E640-0x000000018183E6B0
		private void AddParent(JContainer container); // 0x000000018183DE40-0x000000018183DEE0
		private void RemoveParent(); // 0x000000018183E0F0-0x000000018183E150
		public override void WriteStartArray(); // 0x000000018183E550-0x000000018183E5C0
		public override void WriteStartConstructor(string name); // 0x000000018183E5C0-0x000000018183E640
		protected override void WriteEnd(JsonToken token); // 0x000000018183E0F0-0x000000018183E150
		public override void WritePropertyName(string name); // 0x000000018183E2D0-0x000000018183E420
		private void AddValue(object value, JsonToken token); // 0x000000018183DEE0-0x000000018183DFE0
		internal void AddValue(JValue value, JsonToken token); // 0x000000018183DFE0-0x000000018183E090
		public override void WriteValue(object value); // 0x000000018183F320-0x000000018183F330
		public override void WriteNull(); // 0x000000018183E220-0x000000018183E2D0
		public override void WriteUndefined(); // 0x000000018183E950-0x000000018183EA00
		public override void WriteRaw(string json); // 0x000000018183E420-0x000000018183E550
		public override void WriteComment(string text); // 0x000000018183E150-0x000000018183E220
		public override void WriteValue(string value); // 0x000000018183EFF0-0x000000018183F040
		public override void WriteValue(int value); // 0x000000018183F1C0-0x000000018183F240
		[CLSCompliant] // 0x00000001801CE510-0x00000001801CE530
		public override void WriteValue(uint value); // 0x000000018183ECF0-0x000000018183ED70
		public override void WriteValue(long value); // 0x000000018183EEF0-0x000000018183EF70
		[CLSCompliant] // 0x00000001801CE510-0x00000001801CE530
		public override void WriteValue(ulong value); // 0x000000018183F330-0x000000018183F3B0
		public override void WriteValue(float value); // 0x000000018183EBC0-0x000000018183EC40
		public override void WriteValue(double value); // 0x000000018183F0C0-0x000000018183F140
		public override void WriteValue(bool value); // 0x000000018183F240-0x000000018183F2C0
		public override void WriteValue(short value); // 0x000000018183F3B0-0x000000018183F430
		[CLSCompliant] // 0x00000001801CE510-0x00000001801CE530
		public override void WriteValue(ushort value); // 0x000000018183EF70-0x000000018183EFF0
		public override void WriteValue(char value); // 0x000000018183EB30-0x000000018183EBC0
		public override void WriteValue(byte value); // 0x000000018183EDF0-0x000000018183EE70
		[CLSCompliant] // 0x00000001801CE510-0x00000001801CE530
		public override void WriteValue(sbyte value); // 0x000000018183F140-0x000000018183F1C0
		public override void WriteValue(decimal value); // 0x000000018183EA00-0x000000018183EA80
		public override void WriteValue(DateTime value); // 0x000000018183EA80-0x000000018183EB30
		public override void WriteValue(DateTimeOffset value); // 0x000000018183F040-0x000000018183F0C0
		public override void WriteValue(byte[] value); // 0x000000018183F2C0-0x000000018183F320
		public override void WriteValue(TimeSpan value); // 0x000000018183EE70-0x000000018183EEF0
		public override void WriteValue(Guid value); // 0x000000018183ED70-0x000000018183EDF0
		public override void WriteValue(Uri value); // 0x000000018183EC40-0x000000018183ECF0
		internal override void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments); // 0x000000018183E6B0-0x000000018183E950
	}
}
