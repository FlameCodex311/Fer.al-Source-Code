/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.iOS.Xcode.PBX
{
	internal class GUIDList : IEnumerable<string> // TypeDefIndex: 15802
	{
		// Fields
		private List<string> m_List; // 0x10
	
		// Properties
		public int Count { get; } // 0x00000001816776C0-0x0000000181677700 
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass6_0 // TypeDefIndex: 15803
		{
			// Fields
			public string guid; // 0x10
	
			// Constructors
			public <>c__DisplayClass6_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <RemoveGUID>b__0(string x); // 0x0000000180FF6910-0x0000000180FF6930
		}
	
		// Constructors
		public GUIDList(); // 0x0000000181677660-0x00000001816776C0
		public GUIDList(List<string> data); // 0x00000001816775F0-0x0000000181677660
	
		// Methods
		public static implicit operator List<string>(GUIDList list); // 0x0000000180407850-0x0000000180407870
		public static implicit operator GUIDList(List<string> data); // 0x0000000181677700-0x00000001816777A0
		public void AddGUID(string guid); // 0x0000000181677320-0x0000000181677380
		public void RemoveGUID(string guid); // 0x0000000181677430-0x00000001816774F0
		public bool Contains(string guid); // 0x00000001816773D0-0x0000000181677430
		public void Clear(); // 0x0000000181677380-0x00000001816773D0
		IEnumerator<string> IEnumerable<string>.GetEnumerator(); // 0x00000001816774F0-0x0000000181677570
		IEnumerator IEnumerable.GetEnumerator(); // 0x0000000181677570-0x00000001816775F0
	}
}
