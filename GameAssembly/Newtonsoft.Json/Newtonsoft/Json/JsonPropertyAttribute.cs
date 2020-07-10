/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Shims;

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json
{
	[AttributeUsage] // 0x00000001800EFF00-0x00000001800EFF50
	[Preserve] // 0x00000001800EFF00-0x00000001800EFF50
	public sealed class JsonPropertyAttribute : Attribute // TypeDefIndex: 7805
	{
		// Fields
		internal NullValueHandling? _nullValueHandling; // 0x10
		internal DefaultValueHandling? _defaultValueHandling; // 0x18
		internal ReferenceLoopHandling? _referenceLoopHandling; // 0x20
		internal ObjectCreationHandling? _objectCreationHandling; // 0x28
		internal TypeNameHandling? _typeNameHandling; // 0x30
		internal bool? _isReference; // 0x38
		internal int? _order; // 0x3C
		internal Required? _required; // 0x44
		internal bool? _itemIsReference; // 0x4C
		internal ReferenceLoopHandling? _itemReferenceLoopHandling; // 0x50
		internal TypeNameHandling? _itemTypeNameHandling; // 0x58
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Type <ItemConverterType>k__BackingField; // 0x60
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private object[] <ItemConverterParameters>k__BackingField; // 0x68
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private string <PropertyName>k__BackingField; // 0x70
	
		// Properties
		public Type ItemConverterType { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180369B40-0x0000000180369B50 
		public object[] ItemConverterParameters { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180358970-0x0000000180358980 
		public string PropertyName { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180369B50-0x0000000180369B60 
	
		// Constructors
		public JsonPropertyAttribute(); // 0x000000018037E800-0x000000018037E810
	}
}
