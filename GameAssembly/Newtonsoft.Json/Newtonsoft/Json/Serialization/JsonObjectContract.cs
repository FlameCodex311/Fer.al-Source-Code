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
	public class JsonObjectContract : JsonContainerContract // TypeDefIndex: 7932
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private MemberSerialization <MemberSerialization>k__BackingField; // 0xC0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Required? <ItemRequired>k__BackingField; // 0xC4
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private JsonPropertyCollection <Properties>k__BackingField; // 0xD0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private ExtensionDataSetter <ExtensionDataSetter>k__BackingField; // 0xD8
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private ExtensionDataGetter <ExtensionDataGetter>k__BackingField; // 0xE0
		internal bool ExtensionDataIsJToken; // 0xE8
		private bool? _hasRequiredOrDefaultValueProperties; // 0xE9
		private ConstructorInfo _parametrizedConstructor; // 0xF0
		private ConstructorInfo _overrideConstructor; // 0xF8
		private ObjectConstructor<object> _overrideCreator; // 0x100
		private ObjectConstructor<object> _parameterizedCreator; // 0x108
		private JsonPropertyCollection _creatorParameters; // 0x110
		private Type _extensionDataValueType; // 0x118
	
		// Properties
		public MemberSerialization MemberSerialization { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804288C0-0x00000001804288D0 0x00000001804EA430-0x00000001804EA440
		public Required? ItemRequired { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804EA350-0x00000001804EA360 0x00000001804EA420-0x00000001804EA430
		public JsonPropertyCollection Properties { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001804A24D0-0x00000001804A24E0 0x00000001804A22C0-0x00000001804A22D0
		public JsonPropertyCollection CreatorParameters { get; } // 0x00000001804EA060-0x00000001804EA0E0 
		[Obsolete] // 0x000000018011E220-0x000000018011E250
		public ConstructorInfo OverrideConstructor { set; } // 0x00000001804EA440-0x00000001804EA4F0
		[Obsolete] // 0x000000018011E400-0x000000018011E430
		public ConstructorInfo ParametrizedConstructor { set; } // 0x00000001804EA4F0-0x00000001804EA5A0
		public ObjectConstructor<object> OverrideCreator { get; } // 0x00000001803BD370-0x00000001803BD380 
		internal ObjectConstructor<object> ParameterizedCreator { get; } // 0x00000001803BD3C0-0x00000001803BD3D0 
		public ExtensionDataSetter ExtensionDataSetter { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804E9920-0x00000001804E9930 0x00000001804BEA30-0x00000001804BEA40
		public ExtensionDataGetter ExtensionDataGetter { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804A0FC0-0x00000001804A0FD0 0x00000001804A0A50-0x00000001804A0A60
		public Type ExtensionDataValueType { set; } // 0x00000001804EA360-0x00000001804EA420
		internal bool HasRequiredOrDefaultValueProperties { get; } // 0x00000001804EA0E0-0x00000001804EA350 
	
		// Constructors
		public JsonObjectContract(Type underlyingType); // 0x00000001804E9FE0-0x00000001804EA060
	
		// Methods
		internal object GetUninitializedObject(); // 0x00000001804E9EE0-0x00000001804E9FE0
	}
}
