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

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Bson
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	internal class BsonArray : BsonToken, IEnumerable<Newtonsoft.Json.Bson.BsonToken> // TypeDefIndex: 8218
	{
		// Fields
		private readonly List<BsonToken> _children; // 0x18
	
		// Properties
		public override BsonType Type { get; } // 0x0000000180C5ECB0-0x0000000180C5ECC0 
	
		// Constructors
		public BsonArray(); // 0x0000000180C5EC50-0x0000000180C5ECB0
	
		// Methods
		public void Add(BsonToken token); // 0x0000000180C5EB60-0x0000000180C5EBD0
		public IEnumerator<BsonToken> GetEnumerator(); // 0x0000000180C5EBD0-0x0000000180C5EC50
		IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180C5EBD0-0x0000000180C5EC50
	}
}
