/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Shims;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	public abstract class JsonConverter // TypeDefIndex: 7976
	{
		// Properties
		public virtual bool CanRead { get; } // 0x0000000180380B60-0x0000000180380B70 
		public virtual bool CanWrite { get; } // 0x0000000180380B60-0x0000000180380B70 
	
		// Constructors
		protected JsonConverter(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public abstract void WriteJson(JsonWriter writer, object value, JsonSerializer serializer);
		public abstract object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer);
		public abstract bool CanConvert(Type objectType);
	}
}
