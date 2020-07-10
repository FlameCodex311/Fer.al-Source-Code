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

namespace Newtonsoft.Json.Converters
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	public class BsonObjectIdConverter : JsonConverter // TypeDefIndex: 8017
	{
		// Constructors
		public BsonObjectIdConverter(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer); // 0x0000000180686840-0x0000000180686A10
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer); // 0x0000000180686640-0x0000000180686840
		public override bool CanConvert(Type objectType); // 0x00000001806865D0-0x0000000180686640
	}
}
