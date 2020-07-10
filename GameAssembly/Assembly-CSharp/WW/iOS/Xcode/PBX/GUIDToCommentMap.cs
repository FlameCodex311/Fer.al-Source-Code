/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.iOS.Xcode.PBX
{
	internal class GUIDToCommentMap // TypeDefIndex: 15833
	{
		// Fields
		private Dictionary<string, string> m_Dict; // 0x10
	
		// Properties
		public string this[string guid] { get => default; } // 0x0000000181677A50-0x0000000181677AE0 
	
		// Constructors
		public GUIDToCommentMap(); // 0x00000001816779F0-0x0000000181677A50
	
		// Methods
		public void Add(string guid, string comment); // 0x00000001816777A0-0x0000000181677830
		public void Remove(string guid); // 0x0000000181677830-0x0000000181677890
		public string Write(string guid); // 0x0000000181677980-0x00000001816779F0
		public void WriteStringBuilder(StringBuilder sb, string guid); // 0x0000000181677890-0x0000000181677980
	}
}
