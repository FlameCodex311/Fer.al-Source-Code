/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.iOS.Xcode
{
	public class PlistElementDict : PlistElement // TypeDefIndex: 16143
	{
		// Fields
		private SortedDictionary<string, PlistElement> m_PrivateValue; // 0x10
	
		// Properties
		public IDictionary<string, PlistElement> values { get; } // 0x0000000180372440-0x0000000180372450 
		public new PlistElement this[string key] { get => default; set {} } // 0x00000001805D0A70-0x00000001805D0BE0 0x00000001805D0BE0-0x00000001805D0C50
	
		// Constructors
		public PlistElementDict(); // 0x00000001805D0A10-0x00000001805D0A70
	
		// Methods
		public void SetInteger(string key, int val); // 0x00000001805D08D0-0x00000001805D0970
		public void SetString(string key, string val); // 0x00000001805D0970-0x00000001805D0A10
		public void SetBoolean(string key, bool val); // 0x00000001805D0830-0x00000001805D08D0
		public PlistElementArray CreateArray(string key); // 0x00000001805D0690-0x00000001805D0760
		public PlistElementDict CreateDict(string key); // 0x00000001805D0760-0x00000001805D0830
	}
}
