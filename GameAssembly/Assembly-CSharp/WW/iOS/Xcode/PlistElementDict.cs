/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.iOS.Xcode
{
	public class PlistElementDict : PlistElement // TypeDefIndex: 15763
	{
		// Fields
		private SortedDictionary<string, PlistElement> m_PrivateValue; // 0x10
	
		// Properties
		public IDictionary<string, PlistElement> values { get; } // 0x000000018036AC80-0x000000018036AC90 
		public new PlistElement this[string key] { get => default; set {} } // 0x0000000180FE88D0-0x0000000180FE8A40 0x0000000180FE8A40-0x0000000180FE8AB0
	
		// Constructors
		public PlistElementDict(); // 0x0000000180FE8870-0x0000000180FE88D0
	
		// Methods
		public void SetInteger(string key, int val); // 0x0000000180FE8730-0x0000000180FE87D0
		public void SetString(string key, string val); // 0x0000000180FE87D0-0x0000000180FE8870
		public void SetBoolean(string key, bool val); // 0x0000000180FE8690-0x0000000180FE8730
		public PlistElementArray CreateArray(string key); // 0x0000000180FE84F0-0x0000000180FE85C0
		public PlistElementDict CreateDict(string key); // 0x0000000180FE85C0-0x0000000180FE8690
	}
}
