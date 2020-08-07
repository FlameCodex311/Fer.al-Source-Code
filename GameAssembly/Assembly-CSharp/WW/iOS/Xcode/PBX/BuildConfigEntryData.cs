/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.iOS.Xcode.PBX
{
	internal class BuildConfigEntryData // TypeDefIndex: 16194
	{
		// Fields
		public string name; // 0x10
		public List<string> val; // 0x18
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass4_0 // TypeDefIndex: 16195
		{
			// Fields
			public string value; // 0x10
	
			// Constructors
			public <>c__DisplayClass4_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <RemoveValue>b__0(string v); // 0x000000018097C1D0-0x000000018097C1F0
		}
	
		// Constructors
		public BuildConfigEntryData(); // 0x00000001809677A0-0x0000000180967800
	
		// Methods
		public static string ExtractValue(string src); // 0x0000000180967400-0x00000001809674A0
		public void AddValue(string value); // 0x0000000180967380-0x0000000180967400
		public void RemoveValue(string value); // 0x00000001809676F0-0x00000001809677A0
		public void RemoveValueList(IEnumerable<string> values); // 0x00000001809675B0-0x00000001809676F0
		public static BuildConfigEntryData FromNameValue(string name, string value); // 0x00000001809674A0-0x00000001809675B0
	}
}
