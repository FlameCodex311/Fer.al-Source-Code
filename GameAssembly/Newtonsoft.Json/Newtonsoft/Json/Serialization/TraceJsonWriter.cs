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

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	internal class TraceJsonWriter : JsonWriter // TypeDefIndex: 7894
	{
		// Fields
		private readonly JsonWriter _innerWriter; // 0x60
		private readonly JsonTextWriter _textWriter; // 0x68
		private readonly StringWriter _sw; // 0x70
	
		// Constructors
		public TraceJsonWriter(JsonWriter innerWriter); // 0x000000018059C700-0x000000018059C990
	
		// Methods
		public string GetSerializedJsonMessage(); // 0x000000018059B780-0x000000018059B7B0
		public override void WriteValue(decimal value); // 0x000000018059C340-0x000000018059C3D0
		public override void WriteValue(bool value); // 0x000000018059BF30-0x000000018059BFA0
		public override void WriteValue(byte value); // 0x000000018059C4B0-0x000000018059C520
		public override void WriteValue(byte? value); // 0x000000018059C2D0-0x000000018059C340
		public override void WriteValue(char value); // 0x000000018059BDE0-0x000000018059BE50
		public override void WriteValue(byte[] value); // 0x000000018059BD00-0x000000018059BD70
		public override void WriteValue(DateTime value); // 0x000000018059C590-0x000000018059C600
		public override void WriteValue(DateTimeOffset value); // 0x000000018059C600-0x000000018059C690
		public override void WriteValue(double value); // 0x000000018059C110-0x000000018059C180
		public override void WriteUndefined(); // 0x000000018059BCA0-0x000000018059BD00
		public override void WriteNull(); // 0x000000018059B940-0x000000018059B9A0
		public override void WriteValue(float value); // 0x000000018059C520-0x000000018059C590
		public override void WriteValue(Guid value); // 0x000000018059C010-0x000000018059C0A0
		public override void WriteValue(int value); // 0x000000018059BD70-0x000000018059BDE0
		public override void WriteValue(long value); // 0x000000018059BE50-0x000000018059BEC0
		public override void WriteValue(object value); // 0x000000018059BFA0-0x000000018059C010
		public override void WriteValue(sbyte value); // 0x000000018059C3D0-0x000000018059C440
		public override void WriteValue(short value); // 0x000000018059C0A0-0x000000018059C110
		public override void WriteValue(string value); // 0x000000018059C1F0-0x000000018059C260
		public override void WriteValue(TimeSpan value); // 0x000000018059C690-0x000000018059C700
		public override void WriteValue(uint value); // 0x000000018059C440-0x000000018059C4B0
		public override void WriteValue(ulong value); // 0x000000018059BEC0-0x000000018059BF30
		public override void WriteValue(Uri value); // 0x000000018059C180-0x000000018059C1F0
		public override void WriteValue(ushort value); // 0x000000018059C260-0x000000018059C2D0
		public override void WriteComment(string text); // 0x000000018059B7B0-0x000000018059B820
		public override void WriteStartArray(); // 0x000000018059BB70-0x000000018059BBD0
		public override void WriteEndArray(); // 0x000000018059B820-0x000000018059B880
		public override void WriteStartConstructor(string name); // 0x000000018059BBD0-0x000000018059BC40
		public override void WriteEndConstructor(); // 0x000000018059B880-0x000000018059B8E0
		public override void WritePropertyName(string name); // 0x000000018059BA20-0x000000018059BA90
		public override void WritePropertyName(string name, bool escape); // 0x000000018059B9A0-0x000000018059BA20
		public override void WriteStartObject(); // 0x000000018059BC40-0x000000018059BCA0
		public override void WriteEndObject(); // 0x000000018059B8E0-0x000000018059B940
		public override void WriteRawValue(string json); // 0x000000018059BA90-0x000000018059BB00
		public override void WriteRaw(string json); // 0x000000018059BB00-0x000000018059BB70
		public override void Close(); // 0x000000018059B720-0x000000018059B780
	}
}
