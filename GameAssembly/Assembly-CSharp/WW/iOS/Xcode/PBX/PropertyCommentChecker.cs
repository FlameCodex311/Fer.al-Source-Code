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
	internal class PropertyCommentChecker // TypeDefIndex: 15831
	{
		// Fields
		private int m_Level; // 0x10
		private bool m_All; // 0x14
		private List<List<string>> m_Props; // 0x18
	
		// Constructors
		protected PropertyCommentChecker(int level, List<List<string>> props); // 0x000000018169B850-0x000000018169B890
		public PropertyCommentChecker(); // 0x000000018169B550-0x000000018169B5C0
		public PropertyCommentChecker(IEnumerable<string> props); // 0x000000018169B5C0-0x000000018169B850
	
		// Methods
		private bool CheckContained(string prop); // 0x000000018169AED0-0x000000018169B0E0
		public bool CheckStringValueInArray(string value); // 0x000000018169B0E0-0x000000018169B0F0
		public bool CheckKeyInDict(string key); // 0x000000018169B0E0-0x000000018169B0F0
		public bool CheckStringValueInDict(string key, string value); // 0x000000018169B0F0-0x000000018169B320
		public PropertyCommentChecker NextLevel(string prop); // 0x000000018169B320-0x000000018169B550
	}
}
