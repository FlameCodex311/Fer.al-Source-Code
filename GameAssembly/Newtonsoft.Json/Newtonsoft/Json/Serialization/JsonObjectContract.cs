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
	public class JsonObjectContract : JsonContainerContract // TypeDefIndex: 8098
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private MemberSerialization <MemberSerialization>k__BackingField; // 0xC0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Required? <ItemRequired>k__BackingField; // 0xC4
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private JsonPropertyCollection <Properties>k__BackingField; // 0xD0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ExtensionDataSetter <ExtensionDataSetter>k__BackingField; // 0xD8
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
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
		public MemberSerialization MemberSerialization { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180834060-0x0000000180834070 0x0000000180E8FB90-0x0000000180E8FBA0
		public Required? ItemRequired { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180E8FAC0-0x0000000180E8FAD0 0x0000000180E8FB80-0x0000000180E8FB90
		public JsonPropertyCollection Properties { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001805293A0-0x00000001805293B0 0x0000000180529420-0x0000000180529430
		public JsonPropertyCollection CreatorParameters { get; } // 0x0000000180E8F7D0-0x0000000180E8F850 
		[Obsolete] // 0x0000000180286860-0x0000000180286890
		public ConstructorInfo OverrideConstructor { set; } // 0x0000000180E8FBA0-0x0000000180E8FC50
		[Obsolete] // 0x00000001802869C0-0x00000001802869F0
		public ConstructorInfo ParametrizedConstructor { set; } // 0x0000000180E8FC50-0x0000000180E8FD00
		public ObjectConstructor<object> OverrideCreator { get; } // 0x000000018037F030-0x000000018037F040 
		internal ObjectConstructor<object> ParameterizedCreator { get; } // 0x0000000180380B50-0x0000000180380B60 
		public ExtensionDataSetter ExtensionDataSetter { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001805CB740-0x00000001805CB750 0x00000001809E2CC0-0x00000001809E4880
		public ExtensionDataGetter ExtensionDataGetter { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x000000018057C4E0-0x000000018057C4F0 0x000000018057C5E0-0x000000018057C5F0
		public Type ExtensionDataValueType { set; } // 0x0000000180E8FAD0-0x0000000180E8FB80
		internal bool HasRequiredOrDefaultValueProperties { get; } // 0x0000000180E8F850-0x0000000180E8FAC0 
	
		// Constructors
		public JsonObjectContract(Type underlyingType); // 0x0000000180E8F750-0x0000000180E8F7D0
	
		// Methods
		internal object GetUninitializedObject(); // 0x0000000180E8F650-0x0000000180E8F750
	}
}
