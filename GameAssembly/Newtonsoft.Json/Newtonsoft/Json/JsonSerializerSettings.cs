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
	public class JsonSerializerSettings // TypeDefIndex: 7965
	{
		// Fields
		internal const ReferenceLoopHandling DefaultReferenceLoopHandling = ReferenceLoopHandling.Error; // Metadata: 0x00776F3C
		internal const MissingMemberHandling DefaultMissingMemberHandling = MissingMemberHandling.Ignore; // Metadata: 0x00776F40
		internal const NullValueHandling DefaultNullValueHandling = NullValueHandling.Include; // Metadata: 0x00776F44
		internal const DefaultValueHandling DefaultDefaultValueHandling = DefaultValueHandling.Include; // Metadata: 0x00776F48
		internal const ObjectCreationHandling DefaultObjectCreationHandling = ObjectCreationHandling.Auto; // Metadata: 0x00776F4C
		internal const PreserveReferencesHandling DefaultPreserveReferencesHandling = PreserveReferencesHandling.None; // Metadata: 0x00776F50
		internal const ConstructorHandling DefaultConstructorHandling = ConstructorHandling.Default; // Metadata: 0x00776F54
		internal const TypeNameHandling DefaultTypeNameHandling = TypeNameHandling.None; // Metadata: 0x00776F58
		internal const MetadataPropertyHandling DefaultMetadataPropertyHandling = MetadataPropertyHandling.Default; // Metadata: 0x00776F5C
		internal const FormatterAssemblyStyle DefaultTypeNameAssemblyFormat = FormatterAssemblyStyle.Simple; // Metadata: 0x00776F60
		internal static readonly StreamingContext DefaultContext; // 0x00
		internal const Formatting DefaultFormatting = Formatting.None; // Metadata: 0x00776F64
		internal const DateFormatHandling DefaultDateFormatHandling = DateFormatHandling.IsoDateFormat; // Metadata: 0x00776F68
		internal const DateTimeZoneHandling DefaultDateTimeZoneHandling = DateTimeZoneHandling.RoundtripKind; // Metadata: 0x00776F6C
		internal const DateParseHandling DefaultDateParseHandling = DateParseHandling.DateTime; // Metadata: 0x00776F70
		internal const FloatParseHandling DefaultFloatParseHandling = FloatParseHandling.Double; // Metadata: 0x00776F74
		internal const FloatFormatHandling DefaultFloatFormatHandling = FloatFormatHandling.String; // Metadata: 0x00776F78
		internal const StringEscapeHandling DefaultStringEscapeHandling = StringEscapeHandling.Default; // Metadata: 0x00776F7C
		internal const FormatterAssemblyStyle DefaultFormatterAssemblyStyle = FormatterAssemblyStyle.Simple; // Metadata: 0x00776F80
		internal static readonly CultureInfo DefaultCulture; // 0x10
		internal const bool DefaultCheckAdditionalContent = false; // Metadata: 0x00776F84
		internal const string DefaultDateFormatString = "yyyy\'-\'MM\'-\'dd\'T\'HH\':\'mm\':\'ss.FFFFFFFK"; // Metadata: 0x00776F85
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
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private IList<JsonConverter> <Converters>k__BackingField; // 0xD8
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private IContractResolver <ContractResolver>k__BackingField; // 0xE0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private IEqualityComparer <EqualityComparer>k__BackingField; // 0xE8
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Func<IReferenceResolver> <ReferenceResolverProvider>k__BackingField; // 0xF0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ITraceWriter <TraceWriter>k__BackingField; // 0xF8
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private SerializationBinder <Binder>k__BackingField; // 0x100
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EventHandler<ErrorEventArgs> <Error>k__BackingField; // 0x108
	
		// Properties
		public ReferenceLoopHandling ReferenceLoopHandling { get; } // 0x0000000180C699F0-0x0000000180C69A30 
		public MissingMemberHandling MissingMemberHandling { get; } // 0x0000000180C698F0-0x0000000180C69930 
		public ObjectCreationHandling ObjectCreationHandling { get; } // 0x0000000180C69970-0x0000000180C699B0 
		public NullValueHandling NullValueHandling { get; set; } // 0x0000000180C69930-0x0000000180C69970 0x0000000180C69AB0-0x0000000180C69B10
		public DefaultValueHandling DefaultValueHandling { get; } // 0x0000000180C69870-0x0000000180C698B0 
		public IList<JsonConverter> Converters { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001805CB740-0x00000001805CB750 0x00000001809E2CC0-0x00000001809E4880
		public PreserveReferencesHandling PreserveReferencesHandling { get; } // 0x0000000180C699B0-0x0000000180C699F0 
		public TypeNameHandling TypeNameHandling { get; } // 0x0000000180C69A70-0x0000000180C69AB0 
		public MetadataPropertyHandling MetadataPropertyHandling { get; } // 0x0000000180C698B0-0x0000000180C698F0 
		public FormatterAssemblyStyle TypeNameAssemblyFormat { get; } // 0x0000000180C69A30-0x0000000180C69A70 
		public ConstructorHandling ConstructorHandling { get; } // 0x0000000180C69790-0x0000000180C697D0 
		public IContractResolver ContractResolver { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x000000018057C4E0-0x000000018057C4F0 
		public IEqualityComparer EqualityComparer { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x000000018037DDD0-0x000000018037DDE0 
		public Func<IReferenceResolver> ReferenceResolverProvider { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x000000018037DDB0-0x000000018037DDC0 
		public ITraceWriter TraceWriter { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x000000018037E230-0x000000018037E240 
		public SerializationBinder Binder { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x000000018037F030-0x000000018037F040 
		public EventHandler<ErrorEventArgs> Error { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180380B50-0x0000000180380B60 
		public StreamingContext Context { get; } // 0x0000000180C697D0-0x0000000180C69870 
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass90_0 // TypeDefIndex: 7966
		{
			// Constructors
			public <>c__DisplayClass90_0(); // 0x0000000180373240-0x0000000180373250
		}
	
		// Constructors
		static JsonSerializerSettings(); // 0x0000000180C69670-0x0000000180C696E0
		public JsonSerializerSettings(); // 0x0000000180C696E0-0x0000000180C69790
	}
}
