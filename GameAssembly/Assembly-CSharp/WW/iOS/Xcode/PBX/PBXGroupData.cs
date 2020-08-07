/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using WW.iOS.Xcode;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.iOS.Xcode.PBX
{
	internal class PBXGroupData : PBXObjectData // TypeDefIndex: 16185
	{
		// Fields
		public GUIDList children; // 0x20
		public PBXSourceTree tree; // 0x28
		public string name; // 0x30
		public string path; // 0x38
		private static PropertyCommentChecker checkerData; // 0x00
	
		// Properties
		internal override PropertyCommentChecker checker { get; } // 0x00000001809780D0-0x0000000180978130 
	
		// Constructors
		public PBXGroupData(); // 0x0000000180978070-0x00000001809780D0
		static PBXGroupData(); // 0x0000000180977FA0-0x0000000180978070
	
		// Methods
		public static PBXGroupData Create(string name, string path, PBXSourceTree tree); // 0x0000000180977C10-0x0000000180977DC0
		public static PBXGroupData CreateRelative(string name); // 0x0000000180977A30-0x0000000180977C10
		public override void UpdateProps(); // 0x0000000180977DC0-0x0000000180977EC0
		public override void UpdateVars(); // 0x0000000180977EC0-0x0000000180977FA0
	}
}
