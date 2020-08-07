/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.iOS.Xcode
{
	internal class JsonElementArray : JsonElement // TypeDefIndex: 16128
	{
		// Fields
		public List<JsonElement> values; // 0x10
	
		// Constructors
		public JsonElementArray(); // 0x0000000180972B30-0x0000000180972B90
	
		// Methods
		public void AddString(string val); // 0x0000000180972AB0-0x0000000180972B30
		public void AddInteger(int val); // 0x0000000180972A30-0x0000000180972AB0
		public void AddBoolean(bool val); // 0x00000001809728F0-0x0000000180972970
		public JsonElementArray AddArray(); // 0x0000000180972830-0x00000001809728F0
		public JsonElementDict AddDict(); // 0x0000000180972970-0x0000000180972A30
	}
}
