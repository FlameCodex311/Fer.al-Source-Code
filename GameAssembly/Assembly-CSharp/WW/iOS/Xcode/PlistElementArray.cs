/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.iOS.Xcode
{
	public class PlistElementArray : PlistElement // TypeDefIndex: 15764
	{
		// Fields
		public List<PlistElement> values; // 0x10
	
		// Constructors
		public PlistElementArray(); // 0x0000000180FE8490-0x0000000180FE84F0
	
		// Methods
		public void AddString(string val); // 0x0000000180FE8410-0x0000000180FE8490
		public void AddInteger(int val); // 0x0000000180FE8390-0x0000000180FE8410
		public void AddBoolean(bool val); // 0x0000000180FE8250-0x0000000180FE82D0
		public PlistElementArray AddArray(); // 0x0000000180FE8190-0x0000000180FE8250
		public PlistElementDict AddDict(); // 0x0000000180FE82D0-0x0000000180FE8390
	}
}
