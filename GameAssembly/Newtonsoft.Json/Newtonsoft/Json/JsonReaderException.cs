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
	public class JsonReaderException : JsonException // TypeDefIndex: 7809
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private int <LineNumber>k__BackingField; // 0x88
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private int <LinePosition>k__BackingField; // 0x8C
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private string <Path>k__BackingField; // 0x90
	
		// Properties
		private int LineNumber { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018049D3C0-0x000000018049D3D0
		private int LinePosition { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804D0BA0-0x00000001804D0BB0
		private string Path { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018049D4D0-0x000000018049D4E0
	
		// Constructors
		public JsonReaderException(); // 0x000000018068CFC0-0x000000018068D020
		public JsonReaderException(SerializationInfo info, StreamingContext context); // 0x000000018068CF40-0x000000018068CFC0
		internal JsonReaderException(string message, Exception innerException, string path, int lineNumber, int linePosition); // 0x000000018068E0A0-0x000000018068E140
	
		// Methods
		internal static JsonReaderException Create(JsonReader reader, string message); // 0x000000018068DC10-0x000000018068DDB0
		internal static JsonReaderException Create(JsonReader reader, string message, Exception ex); // 0x000000018068DDB0-0x000000018068DF50
		internal static JsonReaderException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex); // 0x000000018068DF50-0x000000018068E0A0
	}
}
