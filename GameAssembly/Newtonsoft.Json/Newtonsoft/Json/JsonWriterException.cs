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
	public class JsonWriterException : JsonException // TypeDefIndex: 7974
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string <Path>k__BackingField; // 0x88
	
		// Properties
		private string Path { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001804794C0-0x00000001804794D0
	
		// Constructors
		public JsonWriterException(); // 0x000000018184C240-0x000000018184C250
		public JsonWriterException(SerializationInfo info, StreamingContext context); // 0x000000018184C220-0x000000018184C240
		internal JsonWriterException(string message, Exception innerException, string path); // 0x000000018184C1F0-0x000000018184C220
	
		// Methods
		internal static JsonWriterException Create(JsonWriter writer, string message, Exception ex); // 0x000000018184C000-0x000000018184C140
		internal static JsonWriterException Create(string path, string message, Exception ex); // 0x000000018184C140-0x000000018184C1F0
	}
}
