/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.Debug
{
	[AttributeUsage] // 0x0000000180215260-0x0000000180215290
	public class DebugButtonAttribute : Attribute // TypeDefIndex: 16239
	{
		// Fields
		private string _name; // 0x10
		private string _group; // 0x18
		private bool _persistent; // 0x20
		private bool _closeOnClick; // 0x21
	
		// Properties
		public string Name { get; } // 0x0000000180372440-0x0000000180372450 
		public string Group { get; } // 0x0000000180372430-0x0000000180372440 
		public bool Persistent { get; } // 0x00000001803FA090-0x00000001803FA0A0 
		public bool CloseOnClick { get; } // 0x00000001804F2E80-0x00000001804F2E90 
	
		// Constructors
		public DebugButtonAttribute(string inName, string inGroup = "General" /* Metadata: 0x007BB9E9 */, bool inPersistent = false /* Metadata: 0x007BB9F4 */, bool inCloseOnClick = false /* Metadata: 0x007BB9F5 */); // 0x000000018065FCA0-0x000000018065FD50
	}
}
