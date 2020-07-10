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
	internal class BsonArray : BsonToken, IEnumerable<Newtonsoft.Json.Bson.BsonToken> // TypeDefIndex: 8052
	{
		// Fields
		private readonly List<BsonToken> _children; // 0x20
	
		// Properties
		public override BsonType Type { get; } // 0x0000000180684EE0-0x0000000180684EF0 
	
		// Constructors
		public BsonArray(); // 0x0000000180684E80-0x0000000180684EE0
	
		// Methods
		public void Add(BsonToken token); // 0x0000000180684D80-0x0000000180684DF0
		public IEnumerator<BsonToken> GetEnumerator(); // 0x0000000180684DF0-0x0000000180684E70
		IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180684E70-0x0000000180684E80
	}
}
