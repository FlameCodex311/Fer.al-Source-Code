/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Shims;

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Bson
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	internal class BsonObject : BsonToken, IEnumerable<Newtonsoft.Json.Bson.BsonProperty> // TypeDefIndex: 8051
	{
		// Fields
		private readonly List<BsonProperty> _children; // 0x20
	
		// Properties
		public override BsonType Type { get; } // 0x0000000180686C90-0x0000000180686CA0 
	
		// Constructors
		public BsonObject(); // 0x0000000180686C30-0x0000000180686C90
	
		// Methods
		public void Add(string name, BsonToken token); // 0x0000000180686AC0-0x0000000180686BA0
		public IEnumerator<BsonProperty> GetEnumerator(); // 0x0000000180686BA0-0x0000000180686C20
		IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180686C20-0x0000000180686C30
	}
}
