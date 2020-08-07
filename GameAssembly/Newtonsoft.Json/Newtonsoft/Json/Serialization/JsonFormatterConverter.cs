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

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	internal class JsonFormatterConverter : IFormatterConverter // TypeDefIndex: 8061
	{
		// Fields
		private readonly JsonSerializerInternalReader _reader; // 0x10
		private readonly JsonISerializableContract _contract; // 0x18
		private readonly JsonProperty _member; // 0x20
	
		// Constructors
		public JsonFormatterConverter(JsonSerializerInternalReader reader, JsonISerializableContract contract, JsonProperty member); // 0x0000000180E8F580-0x0000000180E8F610
	
		// Methods
		private T GetTokenValue<T>(object value);
		public object Convert(object value, Type type); // 0x0000000180E8F170-0x0000000180E8F3F0
		public bool ToBoolean(object value); // 0x0000000180E8F3F0-0x0000000180E8F440
		public int ToInt32(object value); // 0x0000000180E8F440-0x0000000180E8F490
		public long ToInt64(object value); // 0x0000000180E8F490-0x0000000180E8F4E0
		public float ToSingle(object value); // 0x0000000180E8F4E0-0x0000000180E8F530
		public string ToString(object value); // 0x0000000180E8F530-0x0000000180E8F580
	}
}
