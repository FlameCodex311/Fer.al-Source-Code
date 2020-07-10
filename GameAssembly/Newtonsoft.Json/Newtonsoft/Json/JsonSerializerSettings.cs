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
	public class JsonSerializerSettings // TypeDefIndex: 7799
	{
		// Fields
		internal const ReferenceLoopHandling DefaultReferenceLoopHandling = ReferenceLoopHandling.Error; // Metadata: 0x0074224E
		internal const MissingMemberHandling DefaultMissingMemberHandling = MissingMemberHandling.Ignore; // Metadata: 0x00742252
		internal const NullValueHandling DefaultNullValueHandling = NullValueHandling.Include; // Metadata: 0x00742256
		internal const DefaultValueHandling DefaultDefaultValueHandling = DefaultValueHandling.Include; // Metadata: 0x0074225A
		internal const ObjectCreationHandling DefaultObjectCreationHandling = ObjectCreationHandling.Auto; // Metadata: 0x0074225E
		internal const PreserveReferencesHandling DefaultPreserveReferencesHandling = PreserveReferencesHandling.None; // Metadata: 0x00742262
		internal const ConstructorHandling DefaultConstructorHandling = ConstructorHandling.Default; // Metadata: 0x00742266
		internal const TypeNameHandling DefaultTypeNameHandling = TypeNameHandling.None; // Metadata: 0x0074226A
		internal const MetadataPropertyHandling DefaultMetadataPropertyHandling = MetadataPropertyHandling.Default; // Metadata: 0x0074226E
		internal const FormatterAssemblyStyle DefaultTypeNameAssemblyFormat = FormatterAssemblyStyle.Simple; // Metadata: 0x00742272
		internal static readonly StreamingContext DefaultContext; // 0x00
		internal const Formatting DefaultFormatting = Formatting.None; // Metadata: 0x00742276
		internal const DateFormatHandling DefaultDateFormatHandling = DateFormatHandling.IsoDateFormat; // Metadata: 0x0074227A
		internal const DateTimeZoneHandling DefaultDateTimeZoneHandling = DateTimeZoneHandling.RoundtripKind; // Metadata: 0x0074227E
		internal const DateParseHandling DefaultDateParseHandling = DateParseHandling.DateTime; // Metadata: 0x00742282
		internal const FloatParseHandling DefaultFloatParseHandling = FloatParseHandling.Double; // Metadata: 0x00742286
		internal const FloatFormatHandling DefaultFloatFormatHandling = FloatFormatHandling.String; // Metadata: 0x0074228A
		internal const StringEscapeHandling DefaultStringEscapeHandling = StringEscapeHandling.Default; // Metadata: 0x0074228E
		internal const FormatterAssemblyStyle DefaultFormatterAssemblyStyle = FormatterAssemblyStyle.Simple; // Metadata: 0x00742292
		internal static readonly CultureInfo DefaultCulture; // 0x10
		internal const bool DefaultCheckAdditionalContent = false; // Metadata: 0x00742296
		internal const string DefaultDateFormatString = "yyyy\'-\'MM\'-\'dd\'T\'HH\':\'mm\':\'ss.FFFFFFFK"; // Metadata: 0x00742297
		internal Formatting? _formatting; // 0x10
		internal DateFormatHandling? _dateFormatHandling; // 0x18
		internal DateTimeZoneHandling? _dateTimeZoneHandling; // 0x20
		internal DateParseHandling? _dateParseHandling; // 0x28
		internal FloatFormatHandling? _floatFormatHandling; // 0x30
		internal FloatParseHandling? _floatParseHandling; // 0x38
		internal StringEscapeHandling? _stringEscapeHandling; // 0x40
		internal CultureInfo _culture; // 0x48
		internal bool? _checkAdditionalContent; // 0x50
		internal int? _maxDepth; // 0x54
		internal bool _maxDepthSet; // 0x5C
		internal string _dateFormatString; // 0x60
		internal bool _dateFormatStringSet; // 0x68
		internal FormatterAssemblyStyle? _typeNameAssemblyFormat; // 0x6C
		internal DefaultValueHandling? _defaultValueHandling; // 0x74
		internal PreserveReferencesHandling? _preserveReferencesHandling; // 0x7C
		internal NullValueHandling? _nullValueHandling; // 0x84
		internal ObjectCreationHandling? _objectCreationHandling; // 0x8C
		internal MissingMemberHandling? _missingMemberHandling; // 0x94
		internal ReferenceLoopHandling? _referenceLoopHandling; // 0x9C
		internal StreamingContext? _context; // 0xA8
		internal ConstructorHandling? _constructorHandling; // 0xC0
		internal TypeNameHandling? _typeNameHandling; // 0xC8
		internal MetadataPropertyHandling? _metadataPropertyHandling; // 0xD0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private IList<JsonConverter> <Converters>k__BackingField; // 0xD8
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private IContractResolver <ContractResolver>k__BackingField; // 0xE0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private IEqualityComparer <EqualityComparer>k__BackingField; // 0xE8
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Func<IReferenceResolver> <ReferenceResolverProvider>k__BackingField; // 0xF0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private ITraceWriter <TraceWriter>k__BackingField; // 0xF8
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private SerializationBinder <Binder>k__BackingField; // 0x100
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private EventHandler<ErrorEventArgs> <Error>k__BackingField; // 0x108
	
		// Properties
		public ReferenceLoopHandling ReferenceLoopHandling { get; } // 0x000000018095EEB0-0x000000018095EEF0 
		public MissingMemberHandling MissingMemberHandling { get; } // 0x000000018095EDB0-0x000000018095EDF0 
		public ObjectCreationHandling ObjectCreationHandling { get; } // 0x000000018095EE30-0x000000018095EE70 
		public NullValueHandling NullValueHandling { get; set; } // 0x000000018095EDF0-0x000000018095EE30 0x000000018095EF70-0x000000018095EFD0
		public DefaultValueHandling DefaultValueHandling { get; } // 0x000000018095ED30-0x000000018095ED70 
		public IList<JsonConverter> Converters { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804E9920-0x00000001804E9930 0x00000001804BEA30-0x00000001804BEA40
		public PreserveReferencesHandling PreserveReferencesHandling { get; } // 0x000000018095EE70-0x000000018095EEB0 
		public TypeNameHandling TypeNameHandling { get; } // 0x000000018095EF30-0x000000018095EF70 
		public MetadataPropertyHandling MetadataPropertyHandling { get; } // 0x000000018095ED70-0x000000018095EDB0 
		public FormatterAssemblyStyle TypeNameAssemblyFormat { get; } // 0x000000018095EEF0-0x000000018095EF30 
		public ConstructorHandling ConstructorHandling { get; } // 0x000000018095EC50-0x000000018095EC90 
		public IContractResolver ContractResolver { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x00000001804A0FC0-0x00000001804A0FD0 
		public IEqualityComparer EqualityComparer { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018037A250-0x000000018037A260 
		public Func<IReferenceResolver> ReferenceResolverProvider { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x00000001803BD320-0x00000001803BD330 
		public ITraceWriter TraceWriter { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x00000001803BD310-0x00000001803BD320 
		public SerializationBinder Binder { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x00000001803BD370-0x00000001803BD380 
		public EventHandler<ErrorEventArgs> Error { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x00000001803BD3C0-0x00000001803BD3D0 
		public StreamingContext Context { get; } // 0x000000018095EC90-0x000000018095ED30 
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass90_0 // TypeDefIndex: 7800
		{
			// Constructors
			public <>c__DisplayClass90_0(); // 0x000000018036B6C0-0x000000018036B6D0
		}
	
		// Constructors
		static JsonSerializerSettings(); // 0x000000018095EB30-0x000000018095EBA0
		public JsonSerializerSettings(); // 0x000000018095EBA0-0x000000018095EC50
	}
}
