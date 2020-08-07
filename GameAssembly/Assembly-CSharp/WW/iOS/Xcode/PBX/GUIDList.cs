/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.iOS.Xcode.PBX
{
	internal class GUIDList : IEnumerable<string> // TypeDefIndex: 16182
	{
		// Fields
		private List<string> m_List; // 0x10
	
		// Properties
		public int Count { get; } // 0x0000000180971130-0x0000000180971170 
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass6_0 // TypeDefIndex: 16183
		{
			// Fields
			public string guid; // 0x10
	
			// Constructors
			public <>c__DisplayClass6_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <RemoveGUID>b__0(string x); // 0x000000018097C1D0-0x000000018097C1F0
		}
	
		// Constructors
		public GUIDList(); // 0x00000001809710D0-0x0000000180971130
		public GUIDList(List<string> data); // 0x0000000180971060-0x00000001809710D0
	
		// Methods
		public static implicit operator List<string>(GUIDList list); // 0x000000018049FDD0-0x000000018049FDF0
		public static implicit operator GUIDList(List<string> data); // 0x0000000180971170-0x0000000180971210
		public void AddGUID(string guid); // 0x0000000180970DA0-0x0000000180970E00
		public void RemoveGUID(string guid); // 0x0000000180970EB0-0x0000000180970F60
		public bool Contains(string guid); // 0x0000000180970E50-0x0000000180970EB0
		public void Clear(); // 0x0000000180970E00-0x0000000180970E50
		IEnumerator<string> IEnumerable<string>.GetEnumerator(); // 0x0000000180970F60-0x0000000180970FE0
		IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180970FE0-0x0000000180971060
	}
}
