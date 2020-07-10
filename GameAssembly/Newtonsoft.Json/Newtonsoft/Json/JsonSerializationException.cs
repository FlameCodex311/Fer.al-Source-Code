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

namespace Newtonsoft.Json
{
	[Serializable]
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	public class JsonSerializationException : JsonException // TypeDefIndex: 7815
	{
		// Constructors
		public JsonSerializationException(); // 0x000000018068CFC0-0x000000018068D020
		public JsonSerializationException(string message); // 0x000000018068D0A0-0x000000018068D110
		public JsonSerializationException(string message, Exception innerException); // 0x000000018068D020-0x000000018068D0A0
		public JsonSerializationException(SerializationInfo info, StreamingContext context); // 0x000000018068CF40-0x000000018068CFC0
	
		// Methods
		internal static JsonSerializationException Create(JsonReader reader, string message); // 0x0000000180692280-0x0000000180692290
		internal static JsonSerializationException Create(JsonReader reader, string message, Exception ex); // 0x0000000180692290-0x00000001806923C0
		internal static JsonSerializationException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex); // 0x00000001806921A0-0x0000000180692280
	}
}
