/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.Debug
{
	public class DebugFieldAttribute : Attribute // TypeDefIndex: 16240
	{
		// Fields
		private string _name; // 0x10
		private string _group; // 0x18
		private bool _readonly; // 0x20
		private bool _persistent; // 0x21
	
		// Properties
		public string Name { get; } // 0x0000000180372440-0x0000000180372450 
		public string Group { get; } // 0x0000000180372430-0x0000000180372440 
		public bool Readonly { get; } // 0x00000001803FA090-0x00000001803FA0A0 
		public bool Persistent { get; } // 0x00000001804F2E80-0x00000001804F2E90 
	
		// Constructors
		public DebugFieldAttribute(string inName = "" /* Metadata: 0x007BB9F6 */, string inGroup = "General" /* Metadata: 0x007BB9FA */, bool inReadonly = false /* Metadata: 0x007BBA05 */, bool inPersistent = false /* Metadata: 0x007BBA06 */); // 0x00000001809692C0-0x0000000180969320
	}
}
