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
	internal class PropertyCommentChecker // TypeDefIndex: 16211
	{
		// Fields
		private int m_Level; // 0x10
		private bool m_All; // 0x14
		private List<List<string>> m_Props; // 0x18
	
		// Constructors
		protected PropertyCommentChecker(int level, List<List<string>> props); // 0x00000001814CF760-0x00000001814CF7A0
		public PropertyCommentChecker(); // 0x00000001814CF470-0x00000001814CF4E0
		public PropertyCommentChecker(IEnumerable<string> props); // 0x00000001814CF4E0-0x00000001814CF760
	
		// Methods
		private bool CheckContained(string prop); // 0x00000001814CEE00-0x00000001814CF010
		public bool CheckStringValueInArray(string value); // 0x00000001814CF010-0x00000001814CF020
		public bool CheckKeyInDict(string key); // 0x00000001814CF010-0x00000001814CF020
		public bool CheckStringValueInDict(string key, string value); // 0x00000001814CF020-0x00000001814CF250
		public PropertyCommentChecker NextLevel(string prop); // 0x00000001814CF250-0x00000001814CF470
	}
}
