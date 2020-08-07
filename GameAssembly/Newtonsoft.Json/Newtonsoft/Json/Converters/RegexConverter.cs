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

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Converters
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class RegexConverter : JsonConverter // TypeDefIndex: 8184
	{
		// Constructors
		public RegexConverter(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer); // 0x0000000180C759A0-0x0000000180C75DD0
		private bool HasFlag(RegexOptions options, RegexOptions flag); // 0x0000000180C24C30-0x0000000180C24C40
		private void WriteBson(BsonWriter writer, Regex regex); // 0x0000000180C757A0-0x0000000180C759A0
		private void WriteJson(JsonWriter writer, Regex regex, JsonSerializer serializer); // 0x0000000180C75DD0-0x0000000180C75F90
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer); // 0x0000000180C751E0-0x0000000180C753E0
		private object ReadRegexString(JsonReader reader); // 0x0000000180C75640-0x0000000180C757A0
		private Regex ReadRegexObject(JsonReader reader, JsonSerializer serializer); // 0x0000000180C753E0-0x0000000180C75640
		public override bool CanConvert(Type objectType); // 0x0000000180C75170-0x0000000180C751E0
	}
}
