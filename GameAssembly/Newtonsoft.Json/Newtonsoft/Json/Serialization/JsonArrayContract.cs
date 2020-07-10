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
	public class JsonArrayContract : JsonContainerContract // TypeDefIndex: 7919
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Type <CollectionItemType>k__BackingField; // 0xC0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <IsMultidimensionalArray>k__BackingField; // 0xC8
		private readonly Type _genericCollectionDefinitionType; // 0xD0
		private Type _genericWrapperType; // 0xD8
		private ObjectConstructor<object> _genericWrapperCreator; // 0xE0
		private Func<object> _genericTemporaryCollectionCreator; // 0xE8
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <IsArray>k__BackingField; // 0xF0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <ShouldCreateWrapper>k__BackingField; // 0xF1
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <CanDeserialize>k__BackingField; // 0xF2
		private readonly ConstructorInfo _parameterizedConstructor; // 0xF8
		private ObjectConstructor<object> _parameterizedCreator; // 0x100
		private ObjectConstructor<object> _overrideCreator; // 0x108
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <HasParameterizedCreator>k__BackingField; // 0x110
	
		// Properties
		public Type CollectionItemType { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001804A1050-0x00000001804A1060 0x00000001804A0A80-0x00000001804A0A90
		public bool IsMultidimensionalArray { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001804E7B40-0x00000001804E7B50 0x00000001804E7C20-0x00000001804E7C30
		internal bool IsArray { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001804E7B30-0x00000001804E7B40 0x00000001804E7C10-0x00000001804E7C20
		internal bool ShouldCreateWrapper { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001804E7BE0-0x00000001804E7BF0 0x00000001804E7C40-0x00000001804E7C50
		internal bool CanDeserialize { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001804E7AE0-0x00000001804E7AF0 0x00000001804E7BF0-0x00000001804E7C00
		internal ObjectConstructor<object> ParameterizedCreator { get; } // 0x00000001804E7B50-0x00000001804E7BE0 
		public ObjectConstructor<object> OverrideCreator { get; set; } // 0x00000001803BD3C0-0x00000001803BD3D0 0x00000001804E7C30-0x00000001804E7C40
		public bool HasParameterizedCreator { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804E7B20-0x00000001804E7B30 0x00000001804E7C00-0x00000001804E7C10
		internal bool HasParameterizedCreatorInternal { get; } // 0x00000001804E7AF0-0x00000001804E7B20 
	
		// Constructors
		public JsonArrayContract(Type underlyingType); // 0x00000001804E6F90-0x00000001804E7AE0
	
		// Methods
		internal IWrappedCollection CreateWrapper(object list); // 0x00000001804E6AF0-0x00000001804E6F90
		internal IList CreateTemporaryCollection(); // 0x00000001804E68C0-0x00000001804E6AF0
	}
}
