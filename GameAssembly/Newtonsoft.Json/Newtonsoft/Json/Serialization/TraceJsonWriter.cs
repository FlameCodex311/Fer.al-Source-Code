/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Shims;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	internal class TraceJsonWriter : JsonWriter // TypeDefIndex: 8060
	{
		// Fields
		private readonly JsonWriter _innerWriter; // 0x60
		private readonly JsonTextWriter _textWriter; // 0x68
		private readonly StringWriter _sw; // 0x70
	
		// Constructors
		public TraceJsonWriter(JsonWriter innerWriter); // 0x0000000180C34940-0x0000000180C34BD0
	
		// Methods
		public string GetSerializedJsonMessage(); // 0x0000000180C339C0-0x0000000180C339F0
		public override void WriteValue(decimal value); // 0x0000000180C34580-0x0000000180C34610
		public override void WriteValue(bool value); // 0x0000000180C34170-0x0000000180C341E0
		public override void WriteValue(byte value); // 0x0000000180C346F0-0x0000000180C34760
		public override void WriteValue(byte? value); // 0x0000000180C34510-0x0000000180C34580
		public override void WriteValue(char value); // 0x0000000180C34020-0x0000000180C34090
		public override void WriteValue(byte[] value); // 0x0000000180C33F40-0x0000000180C33FB0
		public override void WriteValue(DateTime value); // 0x0000000180C347D0-0x0000000180C34840
		public override void WriteValue(DateTimeOffset value); // 0x0000000180C34840-0x0000000180C348D0
		public override void WriteValue(double value); // 0x0000000180C34350-0x0000000180C343C0
		public override void WriteUndefined(); // 0x0000000180C33EE0-0x0000000180C33F40
		public override void WriteNull(); // 0x0000000180C33B80-0x0000000180C33BE0
		public override void WriteValue(float value); // 0x0000000180C34760-0x0000000180C347D0
		public override void WriteValue(Guid value); // 0x0000000180C34250-0x0000000180C342E0
		public override void WriteValue(int value); // 0x0000000180C33FB0-0x0000000180C34020
		public override void WriteValue(long value); // 0x0000000180C34090-0x0000000180C34100
		public override void WriteValue(object value); // 0x0000000180C341E0-0x0000000180C34250
		public override void WriteValue(sbyte value); // 0x0000000180C34610-0x0000000180C34680
		public override void WriteValue(short value); // 0x0000000180C342E0-0x0000000180C34350
		public override void WriteValue(string value); // 0x0000000180C34430-0x0000000180C344A0
		public override void WriteValue(TimeSpan value); // 0x0000000180C348D0-0x0000000180C34940
		public override void WriteValue(uint value); // 0x0000000180C34680-0x0000000180C346F0
		public override void WriteValue(ulong value); // 0x0000000180C34100-0x0000000180C34170
		public override void WriteValue(Uri value); // 0x0000000180C343C0-0x0000000180C34430
		public override void WriteValue(ushort value); // 0x0000000180C344A0-0x0000000180C34510
		public override void WriteComment(string text); // 0x0000000180C339F0-0x0000000180C33A60
		public override void WriteStartArray(); // 0x0000000180C33DB0-0x0000000180C33E10
		public override void WriteEndArray(); // 0x0000000180C33A60-0x0000000180C33AC0
		public override void WriteStartConstructor(string name); // 0x0000000180C33E10-0x0000000180C33E80
		public override void WriteEndConstructor(); // 0x0000000180C33AC0-0x0000000180C33B20
		public override void WritePropertyName(string name); // 0x0000000180C33C60-0x0000000180C33CD0
		public override void WritePropertyName(string name, bool escape); // 0x0000000180C33BE0-0x0000000180C33C60
		public override void WriteStartObject(); // 0x0000000180C33E80-0x0000000180C33EE0
		public override void WriteEndObject(); // 0x0000000180C33B20-0x0000000180C33B80
		public override void WriteRawValue(string json); // 0x0000000180C33CD0-0x0000000180C33D40
		public override void WriteRaw(string json); // 0x0000000180C33D40-0x0000000180C33DB0
		public override void Close(); // 0x0000000180C33960-0x0000000180C339C0
	}
}
