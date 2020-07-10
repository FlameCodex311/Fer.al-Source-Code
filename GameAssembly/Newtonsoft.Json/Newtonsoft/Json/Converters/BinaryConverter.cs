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
	public class BinaryConverter : JsonConverter // TypeDefIndex: 8013
	{
		// Fields
		private ReflectionObject _reflectionObject; // 0x10
	
		// Constructors
		public BinaryConverter(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer); // 0x0000000180684BC0-0x0000000180684D80
		private byte[] GetByteArray(object value); // 0x0000000180684490-0x00000001806845F0
		private void EnsureReflectionObject(Type t); // 0x00000001806842E0-0x0000000180684490
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer); // 0x0000000180684810-0x0000000180684BC0
		private byte[] ReadByteArray(JsonReader reader); // 0x00000001806845F0-0x0000000180684810
		public override bool CanConvert(Type objectType); // 0x0000000180684290-0x00000001806842E0
	}
}
