/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.iOS.Xcode.PBX
{
	internal class BuildConfigEntryData // TypeDefIndex: 15814
	{
		// Fields
		public string name; // 0x10
		public List<string> val; // 0x18
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass4_0 // TypeDefIndex: 15815
		{
			// Fields
			public string value; // 0x10
	
			// Constructors
			public <>c__DisplayClass4_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <RemoveValue>b__0(string v); // 0x0000000180FF6910-0x0000000180FF6930
		}
	
		// Constructors
		public BuildConfigEntryData(); // 0x00000001816753D0-0x0000000181675430
	
		// Methods
		public static string ExtractValue(string src); // 0x0000000181675060-0x0000000181675110
		public void AddValue(string value); // 0x0000000181674FE0-0x0000000181675060
		public void RemoveValue(string value); // 0x0000000181675310-0x00000001816753D0
		public void RemoveValueList(IEnumerable<string> values); // 0x00000001816751D0-0x0000000181675310
		public static BuildConfigEntryData FromNameValue(string name, string value); // 0x0000000181675110-0x00000001816751D0
	}
}
