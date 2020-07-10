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

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	public class JsonProperty // TypeDefIndex: 7929
	{
		// Fields
		internal Required? _required; // 0x10
		internal bool _hasExplicitDefaultValue; // 0x18
		private object _defaultValue; // 0x20
		private bool _hasGeneratedDefaultValue; // 0x28
		private string _propertyName; // 0x30
		internal bool _skipPropertyNameEscape; // 0x38
		private Type _propertyType; // 0x40
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private JsonContract <PropertyContract>k__BackingField; // 0x48
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Type <DeclaringType>k__BackingField; // 0x50
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private int? <Order>k__BackingField; // 0x58
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private string <UnderlyingName>k__BackingField; // 0x60
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private IValueProvider <ValueProvider>k__BackingField; // 0x68
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private IAttributeProvider <AttributeProvider>k__BackingField; // 0x70
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private JsonConverter <Converter>k__BackingField; // 0x78
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private JsonConverter <MemberConverter>k__BackingField; // 0x80
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <Ignored>k__BackingField; // 0x88
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <Readable>k__BackingField; // 0x89
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <Writable>k__BackingField; // 0x8A
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <HasMemberAttribute>k__BackingField; // 0x8B
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool? <IsReference>k__BackingField; // 0x8C
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private NullValueHandling? <NullValueHandling>k__BackingField; // 0x90
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private DefaultValueHandling? <DefaultValueHandling>k__BackingField; // 0x98
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private ReferenceLoopHandling? <ReferenceLoopHandling>k__BackingField; // 0xA0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private ObjectCreationHandling? <ObjectCreationHandling>k__BackingField; // 0xA8
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private TypeNameHandling? <TypeNameHandling>k__BackingField; // 0xB0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Predicate<object> <ShouldSerialize>k__BackingField; // 0xB8
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Predicate<object> <ShouldDeserialize>k__BackingField; // 0xC0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Predicate<object> <GetIsSpecified>k__BackingField; // 0xC8
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Action<object, object> <SetIsSpecified>k__BackingField; // 0xD0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private JsonConverter <ItemConverter>k__BackingField; // 0xD8
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool? <ItemIsReference>k__BackingField; // 0xE0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private TypeNameHandling? <ItemTypeNameHandling>k__BackingField; // 0xE4
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private ReferenceLoopHandling? <ItemReferenceLoopHandling>k__BackingField; // 0xEC
	
		// Properties
		internal JsonContract PropertyContract { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180369C40-0x0000000180369C50 0x00000001803A27F0-0x00000001803A2800
		public string PropertyName { get; set; } // 0x0000000180397720-0x0000000180397730 0x00000001804EB130-0x00000001804EB1B0
		public Type DeclaringType { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001803A27A0-0x00000001803A27B0 0x00000001803A2850-0x00000001803A2860
		public int? Order { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180357120-0x0000000180357130 0x0000000180485C70-0x0000000180485C80
		public string UnderlyingName { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180369B40-0x0000000180369B50 0x00000001803A27E0-0x00000001803A27F0
		public IValueProvider ValueProvider { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180358970-0x0000000180358980 0x00000001803A27D0-0x00000001803A27E0
		public IAttributeProvider AttributeProvider { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001803C87F0-0x00000001803C8800
		public Type PropertyType { get; set; } // 0x0000000180369B30-0x0000000180369B40 0x00000001804EB1B0-0x00000001804EB1C0
		public JsonConverter Converter { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180369C70-0x0000000180369C80 0x00000001803D8EF0-0x00000001803D8F00
		public JsonConverter MemberConverter { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018035FCB0-0x000000018035FCC0 0x00000001803D8ED0-0x00000001803D8EE0
		public bool Ignored { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804E88A0-0x00000001804E88B0 0x0000000180386220-0x0000000180386230
		public bool Readable { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804EB070-0x00000001804EB080 0x00000001804EB1C0-0x00000001804EB1D0
		public bool Writable { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804EB0C0-0x00000001804EB0D0 0x00000001804EB1D0-0x00000001804EB1E0
		public bool HasMemberAttribute { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804EB020-0x00000001804EB030 0x00000001804EB0E0-0x00000001804EB0F0
		public object DefaultValue { get; set; } // 0x00000001804EB010-0x00000001804EB020 0x00000001804EB0D0-0x00000001804EB0E0
		public Required Required { get; } // 0x00000001804EB080-0x00000001804EB0C0 
		public bool? IsReference { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804EB030-0x00000001804EB040 0x00000001804EB0F0-0x00000001804EB100
		public NullValueHandling? NullValueHandling { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180382A80-0x0000000180382A90 0x000000018049D4D0-0x000000018049D4E0
		public DefaultValueHandling? DefaultValueHandling { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180369B70-0x0000000180369B80 0x000000018036A3D0-0x000000018036A3E0
		public ReferenceLoopHandling? ReferenceLoopHandling { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180382AA0-0x0000000180382AB0 0x00000001803D8EE0-0x00000001803D8EF0
		public ObjectCreationHandling? ObjectCreationHandling { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180382A90-0x0000000180382AA0 0x00000001804A1230-0x00000001804A1240
		public TypeNameHandling? TypeNameHandling { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001803ED9D0-0x00000001803ED9E0 0x00000001804A0A60-0x00000001804A0A70
		public Predicate<object> ShouldSerialize { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001803ED9C0-0x00000001803ED9D0 0x00000001803D8F00-0x00000001803D8F10
		public Predicate<object> ShouldDeserialize { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x00000001804A1050-0x00000001804A1060 
		public Predicate<object> GetIsSpecified { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804A2590-0x00000001804A25A0 0x00000001804A22E0-0x00000001804A22F0
		public Action<object, object> SetIsSpecified { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804A24D0-0x00000001804A24E0 0x00000001804A22C0-0x00000001804A22D0
		public JsonConverter ItemConverter { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804E9920-0x00000001804E9930 0x00000001804BEA30-0x00000001804BEA40
		public bool? ItemIsReference { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804EB040-0x00000001804EB050 0x00000001804EB100-0x00000001804EB110
		public TypeNameHandling? ItemTypeNameHandling { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804EB060-0x00000001804EB070 0x00000001804EB120-0x00000001804EB130
		public ReferenceLoopHandling? ItemReferenceLoopHandling { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804EB050-0x00000001804EB060 0x00000001804EB110-0x00000001804EB120
	
		// Constructors
		public JsonProperty(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		internal object GetResolvedDefaultValue(); // 0x00000001804EAF10-0x00000001804EAFA0
		public override string ToString(); // 0x0000000180397720-0x0000000180397730
		internal void WritePropertyName(JsonWriter writer); // 0x00000001804EAFA0-0x00000001804EB010
	}
}
