/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.iOS.Xcode.PBX
{
	internal class GUIDToCommentMap // TypeDefIndex: 16213
	{
		// Fields
		private Dictionary<string, string> m_Dict; // 0x10
	
		// Properties
		public string this[string guid] { get => default; } // 0x00000001809714B0-0x0000000180971540 
	
		// Constructors
		public GUIDToCommentMap(); // 0x0000000180971450-0x00000001809714B0
	
		// Methods
		public void Add(string guid, string comment); // 0x0000000180971210-0x00000001809712A0
		public void Remove(string guid); // 0x00000001809712A0-0x0000000180971300
		public string Write(string guid); // 0x00000001809713E0-0x0000000180971450
		public void WriteStringBuilder(StringBuilder sb, string guid); // 0x0000000180971300-0x00000001809713E0
	}
}
