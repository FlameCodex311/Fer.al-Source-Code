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

namespace Newtonsoft.Json.Bson
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	internal class BsonValue : BsonToken // TypeDefIndex: 8053
	{
		// Fields
		private readonly object _value; // 0x20
		private readonly BsonType _type; // 0x28
	
		// Properties
		public object Value { get; } // 0x000000018036AC70-0x000000018036AC80 
		public override BsonType Type { get; } // 0x00000001803A2790-0x00000001803A27A0 
	
		// Constructors
		public BsonValue(object value, BsonType type); // 0x0000000180689300-0x0000000180689340
	}
}
