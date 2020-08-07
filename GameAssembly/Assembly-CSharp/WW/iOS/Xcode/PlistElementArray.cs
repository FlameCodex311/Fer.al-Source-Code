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
	public class PlistElementArray : PlistElement // TypeDefIndex: 16144
	{
		// Fields
		public List<PlistElement> values; // 0x10
	
		// Constructors
		public PlistElementArray(); // 0x00000001805D0600-0x00000001805D0660
	
		// Methods
		public void AddString(string val); // 0x00000001805D0580-0x00000001805D0600
		public void AddInteger(int val); // 0x00000001805D0500-0x00000001805D0580
		public void AddBoolean(bool val); // 0x00000001805D03C0-0x00000001805D0440
		public PlistElementArray AddArray(); // 0x00000001805D0300-0x00000001805D03C0
		public PlistElementDict AddDict(); // 0x00000001805D0440-0x00000001805D0500
	}
}
