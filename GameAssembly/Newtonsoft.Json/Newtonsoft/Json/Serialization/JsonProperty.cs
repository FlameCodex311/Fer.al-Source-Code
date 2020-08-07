/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Shims;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class JsonProperty // TypeDefIndex: 8095
	{
		// Fields
		internal Required? _required; // 0x10
		internal bool _hasExplicitDefaultValue; // 0x18
		private object _defaultValue; // 0x20
		private bool _hasGeneratedDefaultValue; // 0x28
		private string _propertyName; // 0x30
		internal bool _skipPropertyNameEscape; // 0x38
		private Type _propertyType; // 0x40
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private JsonContract <PropertyContract>k__BackingField; // 0x48
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Type <DeclaringType>k__BackingField; // 0x50
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int? <Order>k__BackingField; // 0x58
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string <UnderlyingName>k__BackingField; // 0x60
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private IValueProvider <ValueProvider>k__BackingField; // 0x68
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private IAttributeProvider <AttributeProvider>k__BackingField; // 0x70
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private JsonConverter <Converter>k__BackingField; // 0x78
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private JsonConverter <MemberConverter>k__BackingField; // 0x80
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <Ignored>k__BackingField; // 0x88
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <Readable>k__BackingField; // 0x89
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <Writable>k__BackingField; // 0x8A
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <HasMemberAttribute>k__BackingField; // 0x8B
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool? <IsReference>k__BackingField; // 0x8C
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private NullValueHandling? <NullValueHandling>k__BackingField; // 0x90
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private DefaultValueHandling? <DefaultValueHandling>k__BackingField; // 0x98
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ReferenceLoopHandling? <ReferenceLoopHandling>k__BackingField; // 0xA0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ObjectCreationHandling? <ObjectCreationHandling>k__BackingField; // 0xA8
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private TypeNameHandling? <TypeNameHandling>k__BackingField; // 0xB0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Predicate<object> <ShouldSerialize>k__BackingField; // 0xB8
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Predicate<object> <ShouldDeserialize>k__BackingField; // 0xC0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Predicate<object> <GetIsSpecified>k__BackingField; // 0xC8
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Action<object, object> <SetIsSpecified>k__BackingField; // 0xD0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private JsonConverter <ItemConverter>k__BackingField; // 0xD8
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool? <ItemIsReference>k__BackingField; // 0xE0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private TypeNameHandling? <ItemTypeNameHandling>k__BackingField; // 0xE4
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ReferenceLoopHandling? <ItemReferenceLoopHandling>k__BackingField; // 0xEC
	
		// Properties
		internal JsonContract PropertyContract { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803743E0-0x00000001803743F0 0x00000001804ADAE0-0x00000001804ADAF0
		public string PropertyName { get; set; } // 0x00000001803745C0-0x00000001803745D0 0x0000000180E90840-0x0000000180E908C0
		public Type DeclaringType { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180378320-0x0000000180378330 0x00000001803F7B90-0x00000001803F7BA0
		public int? Order { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803A1580-0x00000001803A1590 0x00000001803A1740-0x00000001803A1750
		public string UnderlyingName { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180418970-0x0000000180418980 0x00000001804AF510-0x00000001804AF520
		public IValueProvider ValueProvider { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803765E0-0x00000001803765F0 0x00000001804ADAC0-0x00000001804ADAD0
		public IAttributeProvider AttributeProvider { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001804C61A0-0x00000001804C61B0
		public Type PropertyType { get; set; } // 0x00000001803C7290-0x00000001803C72A0 0x0000000180E908C0-0x0000000180E908D0
		public JsonConverter Converter { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180418A40-0x0000000180418A50 0x00000001804B47D0-0x00000001804B47E0
		public JsonConverter MemberConverter { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x000000018040ED60-0x000000018040ED70 0x00000001804793A0-0x00000001804793B0
		public bool Ignored { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001804A0200-0x00000001804A0210 0x0000000180434D60-0x0000000180434D70
		public bool Readable { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180647A40-0x0000000180647A50 0x0000000180B68520-0x0000000180B68530
		public bool Writable { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180E907D0-0x0000000180E907E0 0x0000000180E908D0-0x0000000180E908E0
		public bool HasMemberAttribute { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180E90750-0x0000000180E90760 0x0000000180E907F0-0x0000000180E90800
		public object DefaultValue { get; set; } // 0x0000000180E90740-0x0000000180E90750 0x0000000180E907E0-0x0000000180E907F0
		public Required Required { get; } // 0x0000000180E90790-0x0000000180E907D0 
		public bool? IsReference { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803FA7A0-0x00000001803FA7B0 0x0000000180E90800-0x0000000180E90810
		public NullValueHandling? NullValueHandling { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803D6D80-0x00000001803D6D90 0x000000018072D660-0x000000018072D670
		public DefaultValueHandling? DefaultValueHandling { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180418990-0x00000001804189A0 0x0000000180419170-0x0000000180419180
		public ReferenceLoopHandling? ReferenceLoopHandling { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803D6D90-0x00000001803D6DA0 0x00000001804A0450-0x00000001804A0460
		public ObjectCreationHandling? ObjectCreationHandling { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180431310-0x0000000180431320 0x0000000180479500-0x0000000180479510
		public TypeNameHandling? TypeNameHandling { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x000000018067DD20-0x000000018067DD30 0x000000018067E630-0x000000018067E640
		public Predicate<object> ShouldSerialize { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803CFB60-0x00000001803CFB70 0x000000018049F9C0-0x000000018049F9D0
		public Predicate<object> ShouldDeserialize { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180529360-0x0000000180529370 
		public Predicate<object> GetIsSpecified { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001804AF400-0x00000001804AF410 0x00000001804AF520-0x00000001804AF530
		public Action<object, object> SetIsSpecified { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001805293A0-0x00000001805293B0 0x0000000180529420-0x0000000180529430
		public JsonConverter ItemConverter { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001805CB740-0x00000001805CB750 0x00000001809E2CC0-0x00000001809E4880
		public bool? ItemIsReference { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180E90760-0x0000000180E90770 0x0000000180E90810-0x0000000180E90820
		public TypeNameHandling? ItemTypeNameHandling { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180E90780-0x0000000180E90790 0x0000000180E90830-0x0000000180E90840
		public ReferenceLoopHandling? ItemReferenceLoopHandling { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180E90770-0x0000000180E90780 0x0000000180E90820-0x0000000180E90830
	
		// Constructors
		public JsonProperty(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		internal object GetResolvedDefaultValue(); // 0x0000000180E90650-0x0000000180E906E0
		public override string ToString(); // 0x00000001803745C0-0x00000001803745D0
		internal void WritePropertyName(JsonWriter writer); // 0x0000000180E906E0-0x0000000180E90740
	}
}
