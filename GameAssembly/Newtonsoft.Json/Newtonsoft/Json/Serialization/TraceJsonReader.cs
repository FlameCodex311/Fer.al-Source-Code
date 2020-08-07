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

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	internal class TraceJsonReader : JsonReader, IJsonLineInfo // TypeDefIndex: 8059
	{
		// Fields
		private readonly JsonReader _innerReader; // 0x78
		private readonly JsonTextWriter _textWriter; // 0x80
		private readonly StringWriter _sw; // 0x88
	
		// Properties
		public override int Depth { get; } // 0x0000000180C33870-0x0000000180C338A0 
		public override string Path { get; } // 0x0000000180C338A0-0x0000000180C338D0 
		public override JsonToken TokenType { get; } // 0x0000000180C338D0-0x0000000180C33900 
		public override object Value { get; } // 0x0000000180C33930-0x0000000180C33960 
		public override Type ValueType { get; } // 0x0000000180C33900-0x0000000180C33930 
		int IJsonLineInfo.LineNumber { get; } // 0x0000000180C331F0-0x0000000180C33250 
		int IJsonLineInfo.LinePosition { get; } // 0x0000000180C33250-0x0000000180C332B0 
	
		// Constructors
		public TraceJsonReader(JsonReader innerReader); // 0x0000000180C33750-0x0000000180C33870
	
		// Methods
		public string GetDeserializedJsonMessage(); // 0x0000000180C33160-0x0000000180C33190
		public override bool Read(); // 0x0000000180C336D0-0x0000000180C33750
		public override int? ReadAsInt32(); // 0x0000000180C335D0-0x0000000180C33650
		public override string ReadAsString(); // 0x0000000180C33650-0x0000000180C336D0
		public override byte[] ReadAsBytes(); // 0x0000000180C33330-0x0000000180C333B0
		public override decimal? ReadAsDecimal(); // 0x0000000180C334C0-0x0000000180C33550
		public override double? ReadAsDouble(); // 0x0000000180C33550-0x0000000180C335D0
		public override bool? ReadAsBoolean(); // 0x0000000180C332B0-0x0000000180C33330
		public override DateTime? ReadAsDateTime(); // 0x0000000180C33440-0x0000000180C334C0
		public override DateTimeOffset? ReadAsDateTimeOffset(); // 0x0000000180C333B0-0x0000000180C33440
		public override void Close(); // 0x0000000180C33130-0x0000000180C33160
		bool IJsonLineInfo.HasLineInfo(); // 0x0000000180C33190-0x0000000180C331F0
	}
}
