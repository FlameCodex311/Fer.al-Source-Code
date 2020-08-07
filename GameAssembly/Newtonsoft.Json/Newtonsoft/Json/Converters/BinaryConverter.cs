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
	public class BinaryConverter : JsonConverter // TypeDefIndex: 8179
	{
		// Fields
		private ReflectionObject _reflectionObject; // 0x10
	
		// Constructors
		public BinaryConverter(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer); // 0x0000000180C5E9A0-0x0000000180C5EB60
		private byte[] GetByteArray(object value); // 0x0000000180C5E290-0x0000000180C5E3F0
		private void EnsureReflectionObject(Type t); // 0x0000000180C5E0F0-0x0000000180C5E290
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer); // 0x0000000180C5E600-0x0000000180C5E9A0
		private byte[] ReadByteArray(JsonReader reader); // 0x0000000180C5E3F0-0x0000000180C5E600
		public override bool CanConvert(Type objectType); // 0x0000000180C5E0A0-0x0000000180C5E0F0
	}
}
