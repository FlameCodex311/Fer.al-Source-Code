/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.Debug
{
	[AttributeUsage] // 0x0000000180133010-0x0000000180133040
	public class DebugButtonAttribute : Attribute // TypeDefIndex: 15692
	{
		// Fields
		private string _name; // 0x10
		private string _group; // 0x18
		private bool _persistent; // 0x20
		private bool _closeOnClick; // 0x21
	
		// Properties
		public string Name { get; } // 0x000000018036AC80-0x000000018036AC90 
		public string Group { get; } // 0x000000018038B150-0x000000018038B160 
		public bool Persistent { get; } // 0x00000001803C19E0-0x00000001803C19F0 
		public bool CloseOnClick { get; } // 0x00000001803C19F0-0x00000001803C1A00 
	
		// Constructors
		public DebugButtonAttribute(string inName, string inGroup = "General" /* Metadata: 0x00784E19 */, bool inPersistent = false /* Metadata: 0x00784E24 */, bool inCloseOnClick = false /* Metadata: 0x00784E25 */); // 0x0000000181119FA0-0x000000018111A050
	}
}
