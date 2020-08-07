/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class JsonDictionaryContract : JsonContainerContract // TypeDefIndex: 8094
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Func<string, string> <DictionaryKeyResolver>k__BackingField; // 0xC0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Type <DictionaryKeyType>k__BackingField; // 0xC8
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Type <DictionaryValueType>k__BackingField; // 0xD0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private JsonContract <KeyContract>k__BackingField; // 0xD8
		private readonly Type _genericCollectionDefinitionType; // 0xE0
		private Type _genericWrapperType; // 0xE8
		private ObjectConstructor<object> _genericWrapperCreator; // 0xF0
		private Func<object> _genericTemporaryDictionaryCreator; // 0xF8
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <ShouldCreateWrapper>k__BackingField; // 0x100
		private readonly ConstructorInfo _parameterizedConstructor; // 0x108
		private ObjectConstructor<object> _overrideCreator; // 0x110
		private ObjectConstructor<object> _parameterizedCreator; // 0x118
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <HasParameterizedCreator>k__BackingField; // 0x120
	
		// Properties
		public Func<string, string> DictionaryKeyResolver { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180529360-0x0000000180529370 0x0000000180529410-0x0000000180529420
		public Type DictionaryKeyType { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001804AF400-0x00000001804AF410 0x00000001804AF520-0x00000001804AF530
		public Type DictionaryValueType { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001805293A0-0x00000001805293B0 0x0000000180529420-0x0000000180529430
		internal JsonContract KeyContract { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001805CB740-0x00000001805CB750 0x00000001809E2CC0-0x00000001809E4880
		internal bool ShouldCreateWrapper { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180D18C60-0x0000000180D18C70 0x0000000180E8F160-0x0000000180E8F170
		internal ObjectConstructor<object> ParameterizedCreator { get; } // 0x0000000180E8F0C0-0x0000000180E8F150 
		public ObjectConstructor<object> OverrideCreator { get; set; } // 0x0000000180385320-0x0000000180385330 0x00000001804846D0-0x00000001804846E0
		public bool HasParameterizedCreator { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180641DC0-0x0000000180641DD0 0x0000000180E8F150-0x0000000180E8F160
		internal bool HasParameterizedCreatorInternal { get; } // 0x0000000180E8F090-0x0000000180E8F0C0 
	
		// Constructors
		public JsonDictionaryContract(Type underlyingType); // 0x0000000180E8E950-0x0000000180E8F090
	
		// Methods
		internal IWrappedDictionary CreateWrapper(object dictionary); // 0x0000000180E8E610-0x0000000180E8E950
		internal IDictionary CreateTemporaryDictionary(); // 0x0000000180E8E370-0x0000000180E8E610
	}
}
