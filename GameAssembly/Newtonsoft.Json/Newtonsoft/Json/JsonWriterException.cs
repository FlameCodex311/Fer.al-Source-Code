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
	public class JsonWriterException : JsonException // TypeDefIndex: 7808
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private string <Path>k__BackingField; // 0x88
	
		// Properties
		private string Path { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018049D700-0x000000018049D710
	
		// Constructors
		public JsonWriterException(); // 0x00000001809689B0-0x00000001809689C0
		public JsonWriterException(SerializationInfo info, StreamingContext context); // 0x0000000180968990-0x00000001809689B0
		internal JsonWriterException(string message, Exception innerException, string path); // 0x0000000180968960-0x0000000180968990
	
		// Methods
		internal static JsonWriterException Create(JsonWriter writer, string message, Exception ex); // 0x0000000180968770-0x00000001809688B0
		internal static JsonWriterException Create(string path, string message, Exception ex); // 0x00000001809688B0-0x0000000180968960
	}
}
