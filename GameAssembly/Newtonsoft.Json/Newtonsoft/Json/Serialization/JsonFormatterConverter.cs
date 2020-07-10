/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Newtonsoft.Json.Shims;

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	internal class JsonFormatterConverter : IFormatterConverter // TypeDefIndex: 7895
	{
		// Fields
		private readonly JsonSerializerInternalReader _reader; // 0x10
		private readonly JsonISerializableContract _contract; // 0x18
		private readonly JsonProperty _member; // 0x20
	
		// Constructors
		public JsonFormatterConverter(JsonSerializerInternalReader reader, JsonISerializableContract contract, JsonProperty member); // 0x00000001804E9E10-0x00000001804E9EA0
	
		// Methods
		private T GetTokenValue<T>(object value);
		public object Convert(object value, Type type); // 0x00000001804E99F0-0x00000001804E9C80
		public bool ToBoolean(object value); // 0x00000001804E9C80-0x00000001804E9CD0
		public int ToInt32(object value); // 0x00000001804E9CD0-0x00000001804E9D20
		public long ToInt64(object value); // 0x00000001804E9D20-0x00000001804E9D70
		public float ToSingle(object value); // 0x00000001804E9D70-0x00000001804E9DC0
		public string ToString(object value); // 0x00000001804E9DC0-0x00000001804E9E10
	}
}
