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

namespace Newtonsoft.Json.Bson
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	internal class BsonRegex : BsonToken // TypeDefIndex: 8222
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private BsonString <Pattern>k__BackingField; // 0x18
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private BsonString <Options>k__BackingField; // 0x20
	
		// Properties
		public BsonString Pattern { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180379F30-0x0000000180379F40
		public BsonString Options { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803F70C0-0x00000001803F70D0
		public override BsonType Type { get; } // 0x0000000180C619A0-0x0000000180C619B0 
	
		// Constructors
		public BsonRegex(string pattern, string options); // 0x0000000180C618F0-0x0000000180C619A0
	}
}
