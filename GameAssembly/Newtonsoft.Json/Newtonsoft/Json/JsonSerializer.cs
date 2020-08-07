/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class JsonSerializer // TypeDefIndex: 7982
	{
		// Fields
		internal TypeNameHandling _typeNameHandling; // 0x10
		internal FormatterAssemblyStyle _typeNameAssemblyFormat; // 0x14
		internal PreserveReferencesHandling _preserveReferencesHandling; // 0x18
		internal ReferenceLoopHandling _referenceLoopHandling; // 0x1C
		internal MissingMemberHandling _missingMemberHandling; // 0x20
		internal ObjectCreationHandling _objectCreationHandling; // 0x24
		internal NullValueHandling _nullValueHandling; // 0x28
		internal DefaultValueHandling _defaultValueHandling; // 0x2C
		internal ConstructorHandling _constructorHandling; // 0x30
		internal MetadataPropertyHandling _metadataPropertyHandling; // 0x34
		internal JsonConverterCollection _converters; // 0x38
		internal IContractResolver _contractResolver; // 0x40
		internal ITraceWriter _traceWriter; // 0x48
		internal IEqualityComparer _equalityComparer; // 0x50
		internal SerializationBinder _binder; // 0x58
		internal StreamingContext _context; // 0x60
		private IReferenceResolver _referenceResolver; // 0x70
		private Formatting? _formatting; // 0x78
		private DateFormatHandling? _dateFormatHandling; // 0x80
		private DateTimeZoneHandling? _dateTimeZoneHandling; // 0x88
		private DateParseHandling? _dateParseHandling; // 0x90
		private FloatFormatHandling? _floatFormatHandling; // 0x98
		private FloatParseHandling? _floatParseHandling; // 0xA0
		private StringEscapeHandling? _stringEscapeHandling; // 0xA8
		private CultureInfo _culture; // 0xB0
		private int? _maxDepth; // 0xB8
		private bool _maxDepthSet; // 0xC0
		private bool? _checkAdditionalContent; // 0xC1
		private string _dateFormatString; // 0xC8
		private bool _dateFormatStringSet; // 0xD0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EventHandler<ErrorEventArgs> Error; // 0xD8
	
		// Properties
		public virtual IReferenceResolver ReferenceResolver { set; } // 0x0000000180C6C670-0x0000000180C6C6F0
		public virtual SerializationBinder Binder { set; } // 0x0000000180C6C140-0x0000000180C6C1C0
		public virtual ITraceWriter TraceWriter { get; set; } // 0x00000001803743E0-0x00000001803743F0 0x00000001804ADAE0-0x00000001804ADAF0
		public virtual IEqualityComparer EqualityComparer { set; } // 0x00000001803F7B90-0x00000001803F7BA0
		public virtual TypeNameHandling TypeNameHandling { set; } // 0x0000000180C6C760-0x0000000180C6C7D0
		public virtual FormatterAssemblyStyle TypeNameAssemblyFormat { set; } // 0x0000000180C6C6F0-0x0000000180C6C760
		public virtual PreserveReferencesHandling PreserveReferencesHandling { set; } // 0x0000000180C6C590-0x0000000180C6C600
		public virtual ReferenceLoopHandling ReferenceLoopHandling { set; } // 0x0000000180C6C600-0x0000000180C6C670
		public virtual MissingMemberHandling MissingMemberHandling { set; } // 0x0000000180C6C440-0x0000000180C6C4B0
		public virtual NullValueHandling NullValueHandling { set; } // 0x0000000180C6C4B0-0x0000000180C6C520
		public virtual DefaultValueHandling DefaultValueHandling { set; } // 0x0000000180C6C360-0x0000000180C6C3D0
		public virtual ObjectCreationHandling ObjectCreationHandling { set; } // 0x0000000180C6C520-0x0000000180C6C590
		public virtual ConstructorHandling ConstructorHandling { set; } // 0x0000000180C6C220-0x0000000180C6C290
		public virtual MetadataPropertyHandling MetadataPropertyHandling { get; set; } // 0x00000001804EF8F0-0x00000001804EF900 0x0000000180C6C3D0-0x0000000180C6C440
		public virtual JsonConverterCollection Converters { get; } // 0x0000000180C6BFD0-0x0000000180C6C060 
		public virtual IContractResolver ContractResolver { get; set; } // 0x00000001803C7290-0x00000001803C72A0 0x0000000180C6C2A0-0x0000000180C6C360
		public virtual StreamingContext Context { get; set; } // 0x0000000180428FB0-0x0000000180428FC0 0x0000000180C6C290-0x0000000180C6C2A0
		public virtual Formatting Formatting { get; } // 0x0000000180C6C060-0x0000000180C6C0A0 
		public virtual bool CheckAdditionalContent { get; set; } // 0x0000000180C6BF80-0x0000000180C6BFD0 0x0000000180C6C1C0-0x0000000180C6C220
	
		// Events
		public virtual event EventHandler<ErrorEventArgs> Error {
			add; // 0x0000000180C6BEE0-0x0000000180C6BF80
			remove; // 0x0000000180C6C0A0-0x0000000180C6C140
		}
	
		// Constructors
		public JsonSerializer(); // 0x0000000180C6BD90-0x0000000180C6BEE0
	
		// Methods
		internal bool IsCheckAdditionalContentSet(); // 0x0000000180C6AEE0-0x0000000180C6AF20
		public static JsonSerializer Create(); // 0x0000000180C6A650-0x0000000180C6A7D0
		public static JsonSerializer Create(JsonSerializerSettings settings); // 0x0000000180C6A7D0-0x0000000180C6A970
		public static JsonSerializer CreateDefault(); // 0x0000000180C6A3D0-0x0000000180C6A610
		public static JsonSerializer CreateDefault(JsonSerializerSettings settings); // 0x0000000180C6A610-0x0000000180C6A650
		private static void ApplySerializerSettings(JsonSerializer serializer, JsonSerializerSettings settings); // 0x0000000180C69B10-0x0000000180C6A3D0
		public void Populate(JsonReader reader, object target); // 0x0000000180C6B2D0-0x0000000180C6B2F0
		internal virtual void PopulateInternal(JsonReader reader, object target); // 0x0000000180C6AF80-0x0000000180C6B2D0
		public T Deserialize<T>(JsonReader reader);
		public object Deserialize(JsonReader reader, Type objectType); // 0x0000000180C6ACD0-0x0000000180C6ACF0
		internal virtual object DeserializeInternal(JsonReader reader, Type objectType); // 0x0000000180C6A970-0x0000000180C6ACD0
		private void SetupReader(JsonReader reader, out CultureInfo previousCulture, out DateTimeZoneHandling? previousDateTimeZoneHandling, out DateParseHandling? previousDateParseHandling, out FloatParseHandling? previousFloatParseHandling, out int? previousMaxDepth, out string previousDateFormatString); // 0x0000000180C6B9C0-0x0000000180C6BD90
		private void ResetReader(JsonReader reader, CultureInfo previousCulture, DateTimeZoneHandling? previousDateTimeZoneHandling, DateParseHandling? previousDateParseHandling, FloatParseHandling? previousFloatParseHandling, int? previousMaxDepth, string previousDateFormatString); // 0x0000000180C6B2F0-0x0000000180C6B470
		public void Serialize(JsonWriter jsonWriter, object value, Type objectType); // 0x0000000180C6B9A0-0x0000000180C6B9C0
		public void Serialize(JsonWriter jsonWriter, object value); // 0x0000000180C6B970-0x0000000180C6B9A0
		internal virtual void SerializeInternal(JsonWriter jsonWriter, object value, Type objectType); // 0x0000000180C6B470-0x0000000180C6B970
		internal IReferenceResolver GetReferenceResolver(); // 0x0000000180C6AE70-0x0000000180C6AEE0
		internal JsonConverter GetMatchingConverter(Type type); // 0x0000000180C6ACF0-0x0000000180C6ADB0
		internal static JsonConverter GetMatchingConverter(IList<JsonConverter> converters, Type objectType); // 0x0000000180C6ADB0-0x0000000180C6AE70
		internal void OnError(ErrorEventArgs e); // 0x0000000180C6AF20-0x0000000180C6AF80
	}
}
