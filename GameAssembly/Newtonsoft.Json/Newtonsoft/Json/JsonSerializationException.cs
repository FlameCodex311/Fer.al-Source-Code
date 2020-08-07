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

namespace Newtonsoft.Json
{
	[Serializable]
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class JsonSerializationException : JsonException // TypeDefIndex: 7981
	{
		// Constructors
		public JsonSerializationException(); // 0x0000000180C64480-0x0000000180C644E0
		public JsonSerializationException(string message); // 0x0000000180C64560-0x0000000180C645D0
		public JsonSerializationException(string message, Exception innerException); // 0x0000000180C644E0-0x0000000180C64560
		public JsonSerializationException(SerializationInfo info, StreamingContext context); // 0x0000000180C64400-0x0000000180C64480
	
		// Methods
		internal static JsonSerializationException Create(JsonReader reader, string message); // 0x0000000180C69530-0x0000000180C69540
		internal static JsonSerializationException Create(JsonReader reader, string message, Exception ex); // 0x0000000180C69540-0x0000000180C69670
		internal static JsonSerializationException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex); // 0x0000000180C69450-0x0000000180C69530
	}
}
