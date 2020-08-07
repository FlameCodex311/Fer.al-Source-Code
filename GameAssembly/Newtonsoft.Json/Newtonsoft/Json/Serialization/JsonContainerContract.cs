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
	public class JsonContainerContract : JsonContract // TypeDefIndex: 8056
	{
		// Fields
		private JsonContract _itemContract; // 0x90
		private JsonContract _finalItemContract; // 0x98
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private JsonConverter <ItemConverter>k__BackingField; // 0xA0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool? <ItemIsReference>k__BackingField; // 0xA8
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ReferenceLoopHandling? <ItemReferenceLoopHandling>k__BackingField; // 0xAC
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private TypeNameHandling? <ItemTypeNameHandling>k__BackingField; // 0xB4
	
		// Properties
		internal JsonContract ItemContract { get; set; } // 0x00000001803D6D80-0x00000001803D6D90 0x0000000180E8D5A0-0x0000000180E8D600
		internal JsonContract FinalItemContract { get; } // 0x0000000180418990-0x00000001804189A0 
		public JsonConverter ItemConverter { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803D6D90-0x00000001803D6DA0 0x00000001804A0450-0x00000001804A0460
		public bool? ItemIsReference { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180E8D570-0x0000000180E8D580 0x0000000180E8D600-0x0000000180E8D610
		public ReferenceLoopHandling? ItemReferenceLoopHandling { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180E8D580-0x0000000180E8D590 0x0000000180E8D610-0x0000000180E8D620
		public TypeNameHandling? ItemTypeNameHandling { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180E8D590-0x0000000180E8D5A0 0x0000000180E8D620-0x0000000180E8D630
	
		// Constructors
		internal JsonContainerContract(Type underlyingType); // 0x0000000180E8D480-0x0000000180E8D570
	}
}
