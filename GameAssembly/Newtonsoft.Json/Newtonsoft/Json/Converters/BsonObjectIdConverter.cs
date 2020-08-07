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

namespace Newtonsoft.Json.Converters
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class BsonObjectIdConverter : JsonConverter // TypeDefIndex: 8183
	{
		// Constructors
		public BsonObjectIdConverter(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer); // 0x0000000180C5EF80-0x0000000180C5F190
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer); // 0x0000000180C5ED90-0x0000000180C5EF80
		public override bool CanConvert(Type objectType); // 0x0000000180C5ED20-0x0000000180C5ED90
	}
}
