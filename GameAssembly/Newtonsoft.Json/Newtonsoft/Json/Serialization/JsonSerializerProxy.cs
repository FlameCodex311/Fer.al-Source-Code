/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using Newtonsoft.Json;
using Newtonsoft.Json.Shims;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	internal class JsonSerializerProxy : JsonSerializer // TypeDefIndex: 8107
	{
		// Fields
		private readonly JsonSerializerInternalReader _serializerReader; // 0xE0
		private readonly JsonSerializerInternalWriter _serializerWriter; // 0xE8
		private readonly JsonSerializer _serializer; // 0xF0
	
		// Properties
		public override IReferenceResolver ReferenceResolver { set; } // 0x0000000180C2A8D0-0x0000000180C2A900
		public override ITraceWriter TraceWriter { get; set; } // 0x0000000180C2A5F0-0x0000000180C2A620 0x0000000180C2A900-0x0000000180C2A930
		public override IEqualityComparer EqualityComparer { set; } // 0x0000000180C2A780-0x0000000180C2A7B0
		public override JsonConverterCollection Converters { get; } // 0x0000000180C2A560-0x0000000180C2A590 
		public override DefaultValueHandling DefaultValueHandling { set; } // 0x0000000180C2A750-0x0000000180C2A780
		public override IContractResolver ContractResolver { get; set; } // 0x0000000180C2A530-0x0000000180C2A560 0x0000000180C2A720-0x0000000180C2A750
		public override MissingMemberHandling MissingMemberHandling { set; } // 0x0000000180C2A7E0-0x0000000180C2A810
		public override NullValueHandling NullValueHandling { set; } // 0x0000000180C2A810-0x0000000180C2A840
		public override ObjectCreationHandling ObjectCreationHandling { set; } // 0x0000000180C2A840-0x0000000180C2A870
		public override ReferenceLoopHandling ReferenceLoopHandling { set; } // 0x0000000180C2A8A0-0x0000000180C2A8D0
		public override PreserveReferencesHandling PreserveReferencesHandling { set; } // 0x0000000180C2A870-0x0000000180C2A8A0
		public override TypeNameHandling TypeNameHandling { set; } // 0x0000000180C2A960-0x0000000180C2A990
		public override MetadataPropertyHandling MetadataPropertyHandling { get; set; } // 0x0000000180C2A5C0-0x0000000180C2A5F0 0x0000000180C2A7B0-0x0000000180C2A7E0
		public override FormatterAssemblyStyle TypeNameAssemblyFormat { set; } // 0x0000000180C2A930-0x0000000180C2A960
		public override ConstructorHandling ConstructorHandling { set; } // 0x0000000180C2A6B0-0x0000000180C2A6E0
		public override SerializationBinder Binder { set; } // 0x0000000180C2A650-0x0000000180C2A680
		public override StreamingContext Context { get; set; } // 0x0000000180C2A4F0-0x0000000180C2A530 0x0000000180C2A6E0-0x0000000180C2A720
		public override Formatting Formatting { get; } // 0x0000000180C2A590-0x0000000180C2A5C0 
		public override bool CheckAdditionalContent { get; set; } // 0x0000000180C2A4C0-0x0000000180C2A4F0 0x0000000180C2A680-0x0000000180C2A6B0
	
		// Events
		public override event EventHandler<ErrorEventArgs> Error {
			add; // 0x0000000180C2A490-0x0000000180C2A4C0
			remove; // 0x0000000180C2A620-0x0000000180C2A650
		}
	
		// Constructors
		public JsonSerializerProxy(JsonSerializerInternalReader serializerReader); // 0x0000000180C2A3B0-0x0000000180C2A420
		public JsonSerializerProxy(JsonSerializerInternalWriter serializerWriter); // 0x0000000180C2A420-0x0000000180C2A490
	
		// Methods
		internal JsonSerializerInternalBase GetInternalSerializer(); // 0x0000000180C2A300-0x0000000180C2A320
		internal override object DeserializeInternal(JsonReader reader, Type objectType); // 0x0000000180C2A2B0-0x0000000180C2A300
		internal override void PopulateInternal(JsonReader reader, object target); // 0x0000000180C2A320-0x0000000180C2A360
		internal override void SerializeInternal(JsonWriter jsonWriter, object value, Type rootType); // 0x0000000180C2A360-0x0000000180C2A3B0
	}
}
