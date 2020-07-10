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

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Converters
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	public class KeyValuePairConverter : JsonConverter // TypeDefIndex: 8016
	{
		// Fields
		private static readonly ThreadSafeStore<Type, ReflectionObject> ReflectionObjectPerType; // 0x00
	
		// Constructors
		public KeyValuePairConverter(); // 0x000000018036B6C0-0x000000018036B6D0
		static KeyValuePairConverter(); // 0x00000001806959A0-0x0000000180695A30
	
		// Methods
		private static ReflectionObject InitializeReflectionObject(Type t); // 0x0000000180695060-0x00000001806952E0
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer); // 0x0000000180695730-0x00000001806959A0
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer); // 0x00000001806952E0-0x0000000180695730
		public override bool CanConvert(Type objectType); // 0x0000000180694F70-0x0000000180695060
	}
}
