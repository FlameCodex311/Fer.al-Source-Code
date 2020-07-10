/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.Debug
{
	public class DebugMethodGroup // TypeDefIndex: 15699
	{
		// Fields
		private string _name; // 0x10
		private string _path; // 0x18
		public List<ConsoleMethodInfo> methods; // 0x20
		public List<ConsoleFieldInfo> fields; // 0x28
		public List<DebugMethodGroup> subGroups; // 0x30
	
		// Properties
		public string Name { get; } // 0x000000018036AC80-0x000000018036AC90 
		public string Path { get; } // 0x000000018038B150-0x000000018038B160 
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass10_0 // TypeDefIndex: 15700
		{
			// Fields
			public string[] inGroupPath; // 0x10
			public int inStartIndex; // 0x18
	
			// Constructors
			public <>c__DisplayClass10_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <GetSubGroup>b__0(DebugMethodGroup group); // 0x000000018112C4E0-0x000000018112C540
		}
	
		// Constructors
		public DebugMethodGroup(string inName, string inPath); // 0x0000000181128F90-0x0000000181129050
	
		// Methods
		public DebugMethodGroup GetSubGroup(string[] inGroupPath, int inStartIndex, bool inCreateIfNeeded); // 0x0000000181128CB0-0x0000000181128F90
	}
}
