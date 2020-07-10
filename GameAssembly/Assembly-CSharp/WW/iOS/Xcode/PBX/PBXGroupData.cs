/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using WW.iOS.Xcode;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.iOS.Xcode.PBX
{
	internal class PBXGroupData : PBXObjectData // TypeDefIndex: 15805
	{
		// Fields
		public GUIDList children; // 0x20
		public PBXSourceTree tree; // 0x28
		public string name; // 0x30
		public string path; // 0x38
		private static PropertyCommentChecker checkerData; // 0x00
	
		// Properties
		internal override PropertyCommentChecker checker { get; } // 0x000000018167FE60-0x000000018167FEC0 
	
		// Constructors
		public PBXGroupData(); // 0x000000018167FE00-0x000000018167FE60
		static PBXGroupData(); // 0x000000018167FD20-0x000000018167FE00
	
		// Methods
		public static PBXGroupData Create(string name, string path, PBXSourceTree tree); // 0x000000018167F690-0x000000018167F8D0
		public static PBXGroupData CreateRelative(string name); // 0x000000018167F630-0x000000018167F690
		public override void UpdateProps(); // 0x000000018167F8D0-0x000000018167FBD0
		public override void UpdateVars(); // 0x000000018167FBD0-0x000000018167FD20
	}
}
