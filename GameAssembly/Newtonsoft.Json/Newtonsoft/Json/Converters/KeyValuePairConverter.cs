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
using Newtonsoft.Json.Utilities;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Converters
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class KeyValuePairConverter : JsonConverter // TypeDefIndex: 8182
	{
		// Fields
		private static readonly ThreadSafeStore<Type, ReflectionObject> ReflectionObjectPerType; // 0x00
	
		// Constructors
		public KeyValuePairConverter(); // 0x0000000180373240-0x0000000180373250
		static KeyValuePairConverter(); // 0x0000000180C750E0-0x0000000180C75170
	
		// Methods
		private static ReflectionObject InitializeReflectionObject(Type t); // 0x0000000180C747F0-0x0000000180C74A50
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer); // 0x0000000180C74E80-0x0000000180C750E0
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer); // 0x0000000180C74A50-0x0000000180C74E80
		public override bool CanConvert(Type objectType); // 0x0000000180C74700-0x0000000180C747F0
	}
}
