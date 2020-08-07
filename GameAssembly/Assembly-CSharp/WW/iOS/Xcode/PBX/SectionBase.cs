/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.iOS.Xcode.PBX
{
	internal abstract class SectionBase // TypeDefIndex: 16208
	{
		// Constructors
		protected SectionBase(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public abstract void AddObject(string key, PBXElementDict value);
		public abstract void WriteSection(StringBuilder sb, GUIDToCommentMap comments);
	}
}
