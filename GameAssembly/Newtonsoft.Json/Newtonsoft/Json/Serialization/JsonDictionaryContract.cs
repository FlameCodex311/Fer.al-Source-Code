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

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	public class JsonDictionaryContract : JsonContainerContract // TypeDefIndex: 7928
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Func<string, string> <DictionaryKeyResolver>k__BackingField; // 0xC0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Type <DictionaryKeyType>k__BackingField; // 0xC8
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Type <DictionaryValueType>k__BackingField; // 0xD0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private JsonContract <KeyContract>k__BackingField; // 0xD8
		private readonly Type _genericCollectionDefinitionType; // 0xE0
		private Type _genericWrapperType; // 0xE8
		private ObjectConstructor<object> _genericWrapperCreator; // 0xF0
		private Func<object> _genericTemporaryDictionaryCreator; // 0xF8
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <ShouldCreateWrapper>k__BackingField; // 0x100
		private readonly ConstructorInfo _parameterizedConstructor; // 0x108
		private ObjectConstructor<object> _overrideCreator; // 0x110
		private ObjectConstructor<object> _parameterizedCreator; // 0x118
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <HasParameterizedCreator>k__BackingField; // 0x120
	
		// Properties
		public Func<string, string> DictionaryKeyResolver { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804A1050-0x00000001804A1060 0x00000001804A0A80-0x00000001804A0A90
		public Type DictionaryKeyType { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001804A2590-0x00000001804A25A0 0x00000001804A22E0-0x00000001804A22F0
		public Type DictionaryValueType { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001804A24D0-0x00000001804A24E0 0x00000001804A22C0-0x00000001804A22D0
		internal JsonContract KeyContract { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804E9920-0x00000001804E9930 0x00000001804BEA30-0x00000001804BEA40
		internal bool ShouldCreateWrapper { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001804E99C0-0x00000001804E99D0 0x00000001804E99E0-0x00000001804E99F0
		internal ObjectConstructor<object> ParameterizedCreator { get; } // 0x00000001804E9930-0x00000001804E99C0 
		public ObjectConstructor<object> OverrideCreator { get; set; } // 0x00000001803BD380-0x00000001803BD390 0x00000001803BE5A0-0x00000001803BE5B0
		public bool HasParameterizedCreator { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804E9910-0x00000001804E9920 0x00000001804E99D0-0x00000001804E99E0
		internal bool HasParameterizedCreatorInternal { get; } // 0x00000001804E98E0-0x00000001804E9910 
	
		// Constructors
		public JsonDictionaryContract(Type underlyingType); // 0x00000001804E9170-0x00000001804E98E0
	
		// Methods
		internal IWrappedDictionary CreateWrapper(object dictionary); // 0x00000001804E8E10-0x00000001804E9170
		internal IDictionary CreateTemporaryDictionary(); // 0x00000001804E8B60-0x00000001804E8E10
	}
}
