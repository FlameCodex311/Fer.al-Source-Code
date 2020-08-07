/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Shims;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json
{
	[AttributeUsage] // 0x0000000180252FA0-0x0000000180252FF0
	[Preserve] // 0x0000000180252FA0-0x0000000180252FF0
	public sealed class JsonPropertyAttribute : Attribute // TypeDefIndex: 7971
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
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Type <ItemConverterType>k__BackingField; // 0x60
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private object[] <ItemConverterParameters>k__BackingField; // 0x68
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string <PropertyName>k__BackingField; // 0x70
	
		// Properties
		public Type ItemConverterType { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180418970-0x0000000180418980 
		public object[] ItemConverterParameters { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001803765E0-0x00000001803765F0 
		public string PropertyName { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180418980-0x0000000180418990 
	
		// Constructors
		public JsonPropertyAttribute(); // 0x00000001803F46D0-0x00000001803F46E0
	}
}
