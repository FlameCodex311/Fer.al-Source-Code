/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.Debug
{
	public class DebugFieldAttribute : Attribute // TypeDefIndex: 15693
	{
		// Fields
		private string _name; // 0x10
		private string _group; // 0x18
		private bool _readonly; // 0x20
		private bool _persistent; // 0x21
	
		// Properties
		public string Name { get; } // 0x000000018036AC80-0x000000018036AC90 
		public string Group { get; } // 0x000000018038B150-0x000000018038B160 
		public bool Readonly { get; } // 0x00000001803C19E0-0x00000001803C19F0 
		public bool Persistent { get; } // 0x00000001803C19F0-0x00000001803C1A00 
	
		// Constructors
		public DebugFieldAttribute(string inName = "" /* Metadata: 0x00784E26 */, string inGroup = "General" /* Metadata: 0x00784E2A */, bool inReadonly = false /* Metadata: 0x00784E35 */, bool inPersistent = false /* Metadata: 0x00784E36 */); // 0x00000001811242A0-0x0000000181124300
	}
}
