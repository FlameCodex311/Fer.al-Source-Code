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
	public class JsonArrayContract : JsonContainerContract // TypeDefIndex: 8085
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Type <CollectionItemType>k__BackingField; // 0xC0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <IsMultidimensionalArray>k__BackingField; // 0xC8
		private readonly Type _genericCollectionDefinitionType; // 0xD0
		private Type _genericWrapperType; // 0xD8
		private ObjectConstructor<object> _genericWrapperCreator; // 0xE0
		private Func<object> _genericTemporaryCollectionCreator; // 0xE8
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <IsArray>k__BackingField; // 0xF0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <ShouldCreateWrapper>k__BackingField; // 0xF1
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <CanDeserialize>k__BackingField; // 0xF2
		private readonly ConstructorInfo _parameterizedConstructor; // 0xF8
		private ObjectConstructor<object> _parameterizedCreator; // 0x100
		private ObjectConstructor<object> _overrideCreator; // 0x108
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <HasParameterizedCreator>k__BackingField; // 0x110
	
		// Properties
		public Type CollectionItemType { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180529360-0x0000000180529370 0x0000000180529410-0x0000000180529420
		public bool IsMultidimensionalArray { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180AB93C0-0x0000000180AB93D0 0x0000000180AB93D0-0x0000000180AB93E0
		internal bool IsArray { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180D11D60-0x0000000180D11D70 0x0000000180E8D450-0x0000000180E8D460
		internal bool ShouldCreateWrapper { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180D11D70-0x0000000180D11D80 0x0000000180E8D470-0x0000000180E8D480
		internal bool CanDeserialize { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180D11D40-0x0000000180D11D50 0x0000000180E8D430-0x0000000180E8D440
		internal ObjectConstructor<object> ParameterizedCreator { get; } // 0x0000000180E8D3A0-0x0000000180E8D430 
		public ObjectConstructor<object> OverrideCreator { get; set; } // 0x0000000180380B50-0x0000000180380B60 0x0000000180E8D460-0x0000000180E8D470
		public bool HasParameterizedCreator { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180E8D390-0x0000000180E8D3A0 0x0000000180E8D440-0x0000000180E8D450
		internal bool HasParameterizedCreatorInternal { get; } // 0x0000000180E8D360-0x0000000180E8D390 
	
		// Constructors
		public JsonArrayContract(Type underlyingType); // 0x0000000180E8C850-0x0000000180E8D360
	
		// Methods
		internal IWrappedCollection CreateWrapper(object list); // 0x0000000180E8C3E0-0x0000000180E8C850
		internal IList CreateTemporaryCollection(); // 0x0000000180E8C1C0-0x0000000180E8C3E0
	}
}
