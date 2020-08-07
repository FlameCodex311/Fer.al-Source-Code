/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.iOS.Xcode.PBX
{
	internal class PBXElementDict : PBXElement // TypeDefIndex: 16172
	{
		// Fields
		private Dictionary<string, PBXElement> m_PrivateValue; // 0x10
	
		// Properties
		public IDictionary<string, PBXElement> values { get; } // 0x0000000180372440-0x0000000180372450 
		public new PBXElement this[string key] { get => default; set {} } // 0x0000000180976940-0x0000000180976A30 0x0000000180976A30-0x0000000180976AA0
	
		// Constructors
		public PBXElementDict(); // 0x00000001809768E0-0x0000000180976940
	
		// Methods
		public bool Contains(string key); // 0x00000001809765E0-0x0000000180976640
		public void Remove(string key); // 0x00000001809767E0-0x0000000180976840
		public void SetString(string key, string val); // 0x0000000180976840-0x00000001809768E0
		public PBXElementArray CreateArray(string key); // 0x0000000180976640-0x0000000180976710
		public PBXElementDict CreateDict(string key); // 0x0000000180976710-0x00000001809767E0
	}
}
