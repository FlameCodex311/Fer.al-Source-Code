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
	public class JsonReaderException : JsonException // TypeDefIndex: 7975
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int <LineNumber>k__BackingField; // 0x88
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int <LinePosition>k__BackingField; // 0x8C
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string <Path>k__BackingField; // 0x90
	
		// Properties
		private int LineNumber { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803CCEB0-0x00000001803CCEC0
		private int LinePosition { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180A8E090-0x0000000180A8E0A0
		private string Path { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x000000018072D660-0x000000018072D670
	
		// Constructors
		public JsonReaderException(); // 0x0000000180C64480-0x0000000180C644E0
		public JsonReaderException(SerializationInfo info, StreamingContext context); // 0x0000000180C64400-0x0000000180C64480
		internal JsonReaderException(string message, Exception innerException, string path, int lineNumber, int linePosition); // 0x0000000180C65390-0x0000000180C65430
	
		// Methods
		internal static JsonReaderException Create(JsonReader reader, string message); // 0x0000000180C65090-0x0000000180C650A0
		internal static JsonReaderException Create(JsonReader reader, string message, Exception ex); // 0x0000000180C650A0-0x0000000180C65240
		internal static JsonReaderException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex); // 0x0000000180C65240-0x0000000180C65390
	}
}
