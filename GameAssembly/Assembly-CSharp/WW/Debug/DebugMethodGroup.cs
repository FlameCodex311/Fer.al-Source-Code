/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.Debug
{
	public class DebugMethodGroup // TypeDefIndex: 16246
	{
		// Fields
		private string _name; // 0x10
		private string _path; // 0x18
		public List<ConsoleMethodInfo> methods; // 0x20
		public List<ConsoleFieldInfo> fields; // 0x28
		public List<DebugMethodGroup> subGroups; // 0x30
	
		// Properties
		public string Name { get; } // 0x0000000180372440-0x0000000180372450 
		public string Path { get; } // 0x0000000180372430-0x0000000180372440 
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass10_0 // TypeDefIndex: 16247
		{
			// Fields
			public string[] inGroupPath; // 0x10
			public int inStartIndex; // 0x18
	
			// Constructors
			public <>c__DisplayClass10_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <GetSubGroup>b__0(DebugMethodGroup group); // 0x000000018097C130-0x000000018097C180
		}
	
		// Constructors
		public DebugMethodGroup(string inName, string inPath); // 0x000000018096E240-0x000000018096E300
	
		// Methods
		public DebugMethodGroup GetSubGroup(string[] inGroupPath, int inStartIndex, bool inCreateIfNeeded); // 0x000000018096DEF0-0x000000018096E240
	}
}
