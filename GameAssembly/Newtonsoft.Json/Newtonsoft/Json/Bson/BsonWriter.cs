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

namespace Newtonsoft.Json.Bson
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	public class BsonWriter : JsonWriter // TypeDefIndex: 8059
	{
		// Fields
		private readonly BsonBinaryWriter _writer; // 0x60
		private BsonToken _root; // 0x68
		private BsonToken _parent; // 0x70
		private string _propertyName; // 0x78
	
		// Methods
		protected override void WriteEnd(JsonToken token); // 0x0000000180689880-0x0000000180689900
		public override void WriteComment(string text); // 0x0000000180689830-0x0000000180689880
		public override void WriteStartConstructor(string name); // 0x0000000180689CC0-0x0000000180689D10
		public override void WriteRaw(string json); // 0x0000000180689AA0-0x0000000180689AF0
		public override void WriteRawValue(string json); // 0x0000000180689A50-0x0000000180689AA0
		public override void WriteStartArray(); // 0x0000000180689C10-0x0000000180689CC0
		public override void WriteStartObject(); // 0x0000000180689D10-0x0000000180689DC0
		public override void WritePropertyName(string name); // 0x0000000180689A20-0x0000000180689A50
		public override void Close(); // 0x00000001806897B0-0x0000000180689800
		private void AddParent(BsonToken container); // 0x0000000180689340-0x0000000180689370
		private void RemoveParent(); // 0x0000000180689800-0x0000000180689830
		private void AddValue(object value, BsonType type); // 0x0000000180689730-0x00000001806897B0
		internal void AddToken(BsonToken token); // 0x0000000180689370-0x0000000180689730
		public override void WriteValue(object value); // 0x00000001804E3C60-0x00000001804E3C70
		public override void WriteNull(); // 0x0000000180689900-0x0000000180689970
		public override void WriteUndefined(); // 0x0000000180689DC0-0x0000000180689E30
		public override void WriteValue(string value); // 0x0000000180689E30-0x0000000180689F00
		public override void WriteValue(int value); // 0x000000018068A410-0x000000018068A4C0
		[CLSCompliant] // 0x00000001800BD1B0-0x00000001800BD1D0
		public override void WriteValue(uint value); // 0x000000018068A370-0x000000018068A410
		public override void WriteValue(long value); // 0x000000018068A960-0x000000018068AA20
		[CLSCompliant] // 0x00000001800BD1B0-0x00000001800BD1D0
		public override void WriteValue(ulong value); // 0x000000018068A8C0-0x000000018068A960
		public override void WriteValue(float value); // 0x0000000180689F00-0x0000000180689FC0
		public override void WriteValue(double value); // 0x000000018068A740-0x000000018068A800
		public override void WriteValue(bool value); // 0x000000018068A560-0x000000018068A610
		public override void WriteValue(short value); // 0x000000018068AA20-0x000000018068AAE0
		[CLSCompliant] // 0x00000001800BD1B0-0x00000001800BD1D0
		public override void WriteValue(ushort value); // 0x000000018068A2B0-0x000000018068A370
		public override void WriteValue(char value); // 0x000000018068A110-0x000000018068A1D0
		public override void WriteValue(byte value); // 0x000000018068A060-0x000000018068A110
		[CLSCompliant] // 0x00000001800BD1B0-0x00000001800BD1D0
		public override void WriteValue(sbyte value); // 0x000000018068ABA0-0x000000018068AC50
		public override void WriteValue(decimal value); // 0x000000018068AAE0-0x000000018068ABA0
		public override void WriteValue(DateTime value); // 0x000000018068A1D0-0x000000018068A2B0
		public override void WriteValue(DateTimeOffset value); // 0x000000018068A800-0x000000018068A8C0
		public override void WriteValue(byte[] value); // 0x000000018068A6C0-0x000000018068A740
		public override void WriteValue(Guid value); // 0x0000000180689FC0-0x000000018068A060
		public override void WriteValue(TimeSpan value); // 0x000000018068A4C0-0x000000018068A560
		public override void WriteValue(Uri value); // 0x000000018068A610-0x000000018068A6C0
		public void WriteObjectId(byte[] value); // 0x0000000180689970-0x0000000180689A20
		public void WriteRegex(string pattern, string options); // 0x0000000180689AF0-0x0000000180689C10
	}
}
