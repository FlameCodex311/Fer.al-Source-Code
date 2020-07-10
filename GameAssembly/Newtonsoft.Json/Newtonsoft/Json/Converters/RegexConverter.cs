/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Shims;

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Converters
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	public class RegexConverter : JsonConverter // TypeDefIndex: 8018
	{
		// Constructors
		public RegexConverter(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer); // 0x0000000180696280-0x00000001806966C0
		private bool HasFlag(RegexOptions options, RegexOptions flag); // 0x00000001804F1960-0x00000001804F1970
		private void WriteBson(BsonWriter writer, Regex regex); // 0x0000000180696080-0x0000000180696280
		private void WriteJson(JsonWriter writer, Regex regex, JsonSerializer serializer); // 0x00000001806966C0-0x0000000180696880
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer); // 0x0000000180695AA0-0x0000000180695CA0
		private object ReadRegexString(JsonReader reader); // 0x0000000180695F10-0x0000000180696080
		private Regex ReadRegexObject(JsonReader reader, JsonSerializer serializer); // 0x0000000180695CA0-0x0000000180695F10
		public override bool CanConvert(Type objectType); // 0x0000000180695A30-0x0000000180695AA0
	}
}
