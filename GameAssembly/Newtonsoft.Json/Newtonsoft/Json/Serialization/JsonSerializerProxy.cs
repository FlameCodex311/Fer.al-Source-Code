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

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	internal class JsonSerializerProxy : JsonSerializer // TypeDefIndex: 7941
	{
		// Fields
		private readonly JsonSerializerInternalReader _serializerReader; // 0xE0
		private readonly JsonSerializerInternalWriter _serializerWriter; // 0xE8
		private readonly JsonSerializer _serializer; // 0xF0
	
		// Properties
		public override IReferenceResolver ReferenceResolver { set; } // 0x00000001805926F0-0x0000000180592720
		public override ITraceWriter TraceWriter { get; set; } // 0x0000000180592410-0x0000000180592440 0x0000000180592720-0x0000000180592750
		public override IEqualityComparer EqualityComparer { set; } // 0x00000001805925A0-0x00000001805925D0
		public override JsonConverterCollection Converters { get; } // 0x0000000180592380-0x00000001805923B0 
		public override DefaultValueHandling DefaultValueHandling { set; } // 0x0000000180592570-0x00000001805925A0
		public override IContractResolver ContractResolver { get; set; } // 0x0000000180592350-0x0000000180592380 0x0000000180592540-0x0000000180592570
		public override MissingMemberHandling MissingMemberHandling { set; } // 0x0000000180592600-0x0000000180592630
		public override NullValueHandling NullValueHandling { set; } // 0x0000000180592630-0x0000000180592660
		public override ObjectCreationHandling ObjectCreationHandling { set; } // 0x0000000180592660-0x0000000180592690
		public override ReferenceLoopHandling ReferenceLoopHandling { set; } // 0x00000001805926C0-0x00000001805926F0
		public override PreserveReferencesHandling PreserveReferencesHandling { set; } // 0x0000000180592690-0x00000001805926C0
		public override TypeNameHandling TypeNameHandling { set; } // 0x0000000180592780-0x00000001805927B0
		public override MetadataPropertyHandling MetadataPropertyHandling { get; set; } // 0x00000001805923E0-0x0000000180592410 0x00000001805925D0-0x0000000180592600
		public override FormatterAssemblyStyle TypeNameAssemblyFormat { set; } // 0x0000000180592750-0x0000000180592780
		public override ConstructorHandling ConstructorHandling { set; } // 0x00000001805924D0-0x0000000180592500
		public override SerializationBinder Binder { set; } // 0x0000000180592470-0x00000001805924A0
		public override StreamingContext Context { get; set; } // 0x0000000180592300-0x0000000180592350 0x0000000180592500-0x0000000180592540
		public override Formatting Formatting { get; } // 0x00000001805923B0-0x00000001805923E0 
		public override bool CheckAdditionalContent { get; set; } // 0x00000001805922D0-0x0000000180592300 0x00000001805924A0-0x00000001805924D0
	
		// Events
		public override event EventHandler<ErrorEventArgs> Error {
			add; // 0x00000001805922A0-0x00000001805922D0
			remove; // 0x0000000180592440-0x0000000180592470
		}
	
		// Constructors
		public JsonSerializerProxy(JsonSerializerInternalReader serializerReader); // 0x00000001805921A0-0x0000000180592220
		public JsonSerializerProxy(JsonSerializerInternalWriter serializerWriter); // 0x0000000180592220-0x00000001805922A0
	
		// Methods
		internal JsonSerializerInternalBase GetInternalSerializer(); // 0x00000001805920F0-0x0000000180592110
		internal override object DeserializeInternal(JsonReader reader, Type objectType); // 0x00000001805920A0-0x00000001805920F0
		internal override void PopulateInternal(JsonReader reader, object target); // 0x0000000180592110-0x0000000180592150
		internal override void SerializeInternal(JsonWriter jsonWriter, object value, Type rootType); // 0x0000000180592150-0x00000001805921A0
	}
}
