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

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	public class JsonSerializer // TypeDefIndex: 7816
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
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private EventHandler<ErrorEventArgs> Error; // 0xD8
	
		// Properties
		public virtual IReferenceResolver ReferenceResolver { set; } // 0x0000000180694E10-0x0000000180694E90
		public virtual SerializationBinder Binder { set; } // 0x00000001806948E0-0x0000000180694960
		public virtual ITraceWriter TraceWriter { get; set; } // 0x0000000180369C40-0x0000000180369C50 0x00000001803A27F0-0x00000001803A2800
		public virtual IEqualityComparer EqualityComparer { set; } // 0x00000001803A2850-0x00000001803A2860
		public virtual TypeNameHandling TypeNameHandling { set; } // 0x0000000180694F00-0x0000000180694F70
		public virtual FormatterAssemblyStyle TypeNameAssemblyFormat { set; } // 0x0000000180694E90-0x0000000180694F00
		public virtual PreserveReferencesHandling PreserveReferencesHandling { set; } // 0x0000000180694D30-0x0000000180694DA0
		public virtual ReferenceLoopHandling ReferenceLoopHandling { set; } // 0x0000000180694DA0-0x0000000180694E10
		public virtual MissingMemberHandling MissingMemberHandling { set; } // 0x0000000180694BE0-0x0000000180694C50
		public virtual NullValueHandling NullValueHandling { set; } // 0x0000000180694C50-0x0000000180694CC0
		public virtual DefaultValueHandling DefaultValueHandling { set; } // 0x0000000180694B00-0x0000000180694B70
		public virtual ObjectCreationHandling ObjectCreationHandling { set; } // 0x0000000180694CC0-0x0000000180694D30
		public virtual ConstructorHandling ConstructorHandling { set; } // 0x00000001806949C0-0x0000000180694A30
		public virtual MetadataPropertyHandling MetadataPropertyHandling { get; set; } // 0x000000018043E170-0x000000018043E180 0x0000000180694B70-0x0000000180694BE0
		public virtual JsonConverterCollection Converters { get; } // 0x0000000180694770-0x0000000180694800 
		public virtual IContractResolver ContractResolver { get; set; } // 0x0000000180369B30-0x0000000180369B40 0x0000000180694A40-0x0000000180694B00
		public virtual StreamingContext Context { get; set; } // 0x000000018037A310-0x000000018037A320 0x0000000180694A30-0x0000000180694A40
		public virtual Formatting Formatting { get; } // 0x0000000180694800-0x0000000180694840 
		public virtual bool CheckAdditionalContent { get; set; } // 0x0000000180694720-0x0000000180694770 0x0000000180694960-0x00000001806949C0
	
		// Events
		public virtual event EventHandler<ErrorEventArgs> Error {
			add; // 0x0000000180694680-0x0000000180694720
			remove; // 0x0000000180694840-0x00000001806948E0
		}
	
		// Constructors
		public JsonSerializer(); // 0x0000000180694530-0x0000000180694680
	
		// Methods
		internal bool IsCheckAdditionalContentSet(); // 0x0000000180693630-0x0000000180693670
		public static JsonSerializer Create(); // 0x0000000180692D90-0x0000000180692F10
		public static JsonSerializer Create(JsonSerializerSettings settings); // 0x0000000180692F10-0x00000001806930B0
		public static JsonSerializer CreateDefault(); // 0x0000000180692B10-0x0000000180692D50
		public static JsonSerializer CreateDefault(JsonSerializerSettings settings); // 0x0000000180692D50-0x0000000180692D90
		private static void ApplySerializerSettings(JsonSerializer serializer, JsonSerializerSettings settings); // 0x00000001806923C0-0x0000000180692B10
		public void Populate(JsonReader reader, object target); // 0x0000000180693A30-0x0000000180693A50
		internal virtual void PopulateInternal(JsonReader reader, object target); // 0x00000001806936D0-0x0000000180693A30
		public T Deserialize<T>(JsonReader reader);
		public object Deserialize(JsonReader reader, Type objectType); // 0x0000000180693420-0x0000000180693440
		internal virtual object DeserializeInternal(JsonReader reader, Type objectType); // 0x00000001806930B0-0x0000000180693420
		private void SetupReader(JsonReader reader, out CultureInfo previousCulture, out DateTimeZoneHandling? previousDateTimeZoneHandling, out DateParseHandling? previousDateParseHandling, out FloatParseHandling? previousFloatParseHandling, out int? previousMaxDepth, out string previousDateFormatString); // 0x0000000180694150-0x0000000180694530
		private void ResetReader(JsonReader reader, CultureInfo previousCulture, DateTimeZoneHandling? previousDateTimeZoneHandling, DateParseHandling? previousDateParseHandling, FloatParseHandling? previousFloatParseHandling, int? previousMaxDepth, string previousDateFormatString); // 0x0000000180693A50-0x0000000180693BE0
		public void Serialize(JsonWriter jsonWriter, object value, Type objectType); // 0x0000000180694130-0x0000000180694150
		public void Serialize(JsonWriter jsonWriter, object value); // 0x0000000180694100-0x0000000180694130
		internal virtual void SerializeInternal(JsonWriter jsonWriter, object value, Type objectType); // 0x0000000180693BE0-0x0000000180694100
		internal IReferenceResolver GetReferenceResolver(); // 0x00000001806935C0-0x0000000180693630
		internal JsonConverter GetMatchingConverter(Type type); // 0x0000000180693440-0x0000000180693500
		internal static JsonConverter GetMatchingConverter(IList<JsonConverter> converters, Type objectType); // 0x0000000180693500-0x00000001806935C0
		internal void OnError(ErrorEventArgs e); // 0x0000000180693670-0x00000001806936D0
	}
}
