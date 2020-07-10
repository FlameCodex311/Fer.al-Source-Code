/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Shims;

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	internal class TraceJsonReader : JsonReader, IJsonLineInfo // TypeDefIndex: 7893
	{
		// Fields
		private readonly JsonReader _innerReader; // 0x78
		private readonly JsonTextWriter _textWriter; // 0x80
		private readonly StringWriter _sw; // 0x88
	
		// Properties
		public override int Depth { get; } // 0x000000018059B630-0x000000018059B660 
		public override string Path { get; } // 0x000000018059B660-0x000000018059B690 
		public override JsonToken TokenType { get; } // 0x000000018059B690-0x000000018059B6C0 
		public override object Value { get; } // 0x000000018059B6F0-0x000000018059B720 
		public override Type ValueType { get; } // 0x000000018059B6C0-0x000000018059B6F0 
		int IJsonLineInfo.LineNumber { get; } // 0x000000018059AF90-0x000000018059AFF0 
		int IJsonLineInfo.LinePosition { get; } // 0x000000018059AFF0-0x000000018059B050 
	
		// Constructors
		public TraceJsonReader(JsonReader innerReader); // 0x000000018059B510-0x000000018059B630
	
		// Methods
		public string GetDeserializedJsonMessage(); // 0x000000018059AF00-0x000000018059AF30
		public override bool Read(); // 0x000000018059B490-0x000000018059B510
		public override int? ReadAsInt32(); // 0x000000018059B390-0x000000018059B410
		public override string ReadAsString(); // 0x000000018059B410-0x000000018059B490
		public override byte[] ReadAsBytes(); // 0x000000018059B0D0-0x000000018059B150
		public override decimal? ReadAsDecimal(); // 0x000000018059B270-0x000000018059B300
		public override double? ReadAsDouble(); // 0x000000018059B300-0x000000018059B390
		public override bool? ReadAsBoolean(); // 0x000000018059B050-0x000000018059B0D0
		public override DateTime? ReadAsDateTime(); // 0x000000018059B1E0-0x000000018059B270
		public override DateTimeOffset? ReadAsDateTimeOffset(); // 0x000000018059B150-0x000000018059B1E0
		public override void Close(); // 0x000000018059AED0-0x000000018059AF00
		bool IJsonLineInfo.HasLineInfo(); // 0x000000018059AF30-0x000000018059AF90
	}
}
