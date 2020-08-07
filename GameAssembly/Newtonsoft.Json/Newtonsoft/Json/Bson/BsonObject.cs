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
	internal class BsonObject : BsonToken, IEnumerable<Newtonsoft.Json.Bson.BsonProperty> // TypeDefIndex: 8217
	{
		// Fields
		private readonly List<BsonProperty> _children; // 0x18
	
		// Properties
		public override BsonType Type { get; } // 0x0000000180C5F3F0-0x0000000180C5F400 
	
		// Constructors
		public BsonObject(); // 0x0000000180C5F390-0x0000000180C5F3F0
	
		// Methods
		public void Add(string name, BsonToken token); // 0x0000000180C5F230-0x0000000180C5F310
		public IEnumerator<BsonProperty> GetEnumerator(); // 0x0000000180C5F310-0x0000000180C5F390
		IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180C5F310-0x0000000180C5F390
	}
}
