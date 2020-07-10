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
	public class JsonContainerContract : JsonContract // TypeDefIndex: 7890
	{
		// Fields
		private JsonContract _itemContract; // 0x90
		private JsonContract _finalItemContract; // 0x98
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private JsonConverter <ItemConverter>k__BackingField; // 0xA0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool? <ItemIsReference>k__BackingField; // 0xA8
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private ReferenceLoopHandling? <ItemReferenceLoopHandling>k__BackingField; // 0xAC
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private TypeNameHandling? <ItemTypeNameHandling>k__BackingField; // 0xB4
	
		// Properties
		internal JsonContract ItemContract { get; set; } // 0x0000000180382A80-0x0000000180382A90 0x00000001804E7D70-0x00000001804E7DD0
		internal JsonContract FinalItemContract { get; } // 0x0000000180369B70-0x0000000180369B80 
		public JsonConverter ItemConverter { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180382AA0-0x0000000180382AB0 0x00000001803D8EE0-0x00000001803D8EF0
		public bool? ItemIsReference { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804E7D40-0x00000001804E7D50 0x00000001804E7DD0-0x00000001804E7DE0
		public ReferenceLoopHandling? ItemReferenceLoopHandling { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804E7D50-0x00000001804E7D60 0x00000001804E7DE0-0x00000001804E7DF0
		public TypeNameHandling? ItemTypeNameHandling { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804E7D60-0x00000001804E7D70 0x00000001804E7DF0-0x00000001804E7E00
	
		// Constructors
		internal JsonContainerContract(Type underlyingType); // 0x00000001804E7C50-0x00000001804E7D40
	}
}
