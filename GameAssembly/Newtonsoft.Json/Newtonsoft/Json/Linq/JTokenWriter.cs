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

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Linq
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	public class JTokenWriter : JsonWriter // TypeDefIndex: 7979
	{
		// Fields
		private JContainer _token; // 0x60
		private JContainer _parent; // 0x68
		private JValue _value; // 0x70
		private JToken _current; // 0x78
	
		// Properties
		public JToken Token { get; } // 0x00000001804E3DB0-0x00000001804E3DC0 
	
		// Constructors
		public JTokenWriter(); // 0x00000001804E3D50-0x00000001804E3DB0
	
		// Methods
		public override void Close(); // 0x00000001804E2D30-0x00000001804E2D40
		public override void WriteStartObject(); // 0x00000001804E3120-0x00000001804E31B0
		private void AddParent(JContainer container); // 0x00000001804E2AD0-0x00000001804E2B20
		private void RemoveParent(); // 0x00000001804E2D40-0x00000001804E2DA0
		public override void WriteStartArray(); // 0x00000001804E3000-0x00000001804E3090
		public override void WriteStartConstructor(string name); // 0x00000001804E3090-0x00000001804E3120
		protected override void WriteEnd(JsonToken token); // 0x00000001804E2D40-0x00000001804E2DA0
		public override void WritePropertyName(string name); // 0x00000001804E2E90-0x00000001804E2F80
		private void AddValue(object value, JsonToken token); // 0x00000001804E2B20-0x00000001804E2C00
		internal void AddValue(JValue value, JsonToken token); // 0x00000001804E2C00-0x00000001804E2D30
		public override void WriteValue(object value); // 0x00000001804E3C60-0x00000001804E3C70
		public override void WriteNull(); // 0x00000001804E2E60-0x00000001804E2E90
		public override void WriteUndefined(); // 0x00000001804E3450-0x00000001804E3480
		public override void WriteRaw(string json); // 0x00000001804E2F80-0x00000001804E3000
		public override void WriteComment(string text); // 0x00000001804E2DA0-0x00000001804E2E60
		public override void WriteValue(string value); // 0x00000001804E39A0-0x00000001804E39E0
		public override void WriteValue(int value); // 0x00000001804E3B40-0x00000001804E3BB0
		[CLSCompliant] // 0x00000001800BD1B0-0x00000001800BD1D0
		public override void WriteValue(uint value); // 0x00000001804E36F0-0x00000001804E3760
		public override void WriteValue(long value); // 0x00000001804E38C0-0x00000001804E3930
		[CLSCompliant] // 0x00000001800BD1B0-0x00000001800BD1D0
		public override void WriteValue(ulong value); // 0x00000001804E3C70-0x00000001804E3CE0
		public override void WriteValue(float value); // 0x00000001804E3640-0x00000001804E36B0
		public override void WriteValue(double value); // 0x00000001804E3A60-0x00000001804E3AD0
		public override void WriteValue(bool value); // 0x00000001804E3BB0-0x00000001804E3C20
		public override void WriteValue(short value); // 0x00000001804E3CE0-0x00000001804E3D50
		[CLSCompliant] // 0x00000001800BD1B0-0x00000001800BD1D0
		public override void WriteValue(ushort value); // 0x00000001804E3930-0x00000001804E39A0
		public override void WriteValue(char value); // 0x00000001804E35B0-0x00000001804E3640
		public override void WriteValue(byte value); // 0x00000001804E37E0-0x00000001804E3850
		[CLSCompliant] // 0x00000001800BD1B0-0x00000001800BD1D0
		public override void WriteValue(sbyte value); // 0x00000001804E3AD0-0x00000001804E3B40
		public override void WriteValue(decimal value); // 0x00000001804E3480-0x00000001804E3500
		public override void WriteValue(DateTime value); // 0x00000001804E3500-0x00000001804E35B0
		public override void WriteValue(DateTimeOffset value); // 0x00000001804E39E0-0x00000001804E3A60
		public override void WriteValue(byte[] value); // 0x00000001804E3C20-0x00000001804E3C60
		public override void WriteValue(TimeSpan value); // 0x00000001804E3850-0x00000001804E38C0
		public override void WriteValue(Guid value); // 0x00000001804E3760-0x00000001804E37E0
		public override void WriteValue(Uri value); // 0x00000001804E36B0-0x00000001804E36F0
		internal override void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments); // 0x00000001804E31B0-0x00000001804E3450
	}
}
