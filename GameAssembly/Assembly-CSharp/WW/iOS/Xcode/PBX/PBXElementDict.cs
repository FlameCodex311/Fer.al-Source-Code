/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.iOS.Xcode.PBX
{
	internal class PBXElementDict : PBXElement // TypeDefIndex: 15792
	{
		// Fields
		private Dictionary<string, PBXElement> m_PrivateValue; // 0x10
	
		// Properties
		public IDictionary<string, PBXElement> values { get; } // 0x000000018036AC80-0x000000018036AC90 
		public new PBXElement this[string key] { get => default; set {} } // 0x000000018167E0C0-0x000000018167E1C0 0x000000018167E1C0-0x000000018167E230
	
		// Constructors
		public PBXElementDict(); // 0x000000018167E060-0x000000018167E0C0
	
		// Methods
		public bool Contains(string key); // 0x000000018167DD60-0x000000018167DDC0
		public void Remove(string key); // 0x000000018167DF60-0x000000018167DFC0
		public void SetString(string key, string val); // 0x000000018167DFC0-0x000000018167E060
		public PBXElementArray CreateArray(string key); // 0x000000018167DDC0-0x000000018167DE90
		public PBXElementDict CreateDict(string key); // 0x000000018167DE90-0x000000018167DF60
	}
}
