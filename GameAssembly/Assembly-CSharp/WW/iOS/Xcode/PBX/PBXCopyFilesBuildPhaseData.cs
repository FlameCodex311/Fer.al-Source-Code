/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.iOS.Xcode.PBX
{
	internal class PBXCopyFilesBuildPhaseData : FileGUIDListBase // TypeDefIndex: 15812
	{
		// Fields
		private static PropertyCommentChecker checkerData; // 0x00
		public string name; // 0x28
	
		// Properties
		internal override PropertyCommentChecker checker { get; } // 0x000000018167DAA0-0x000000018167DB00 
	
		// Constructors
		public PBXCopyFilesBuildPhaseData(); // 0x000000018167DA10-0x000000018167DAA0
		static PBXCopyFilesBuildPhaseData(); // 0x000000018167D930-0x000000018167DA10
	
		// Methods
		public static PBXCopyFilesBuildPhaseData Create(string name, string dstPath, string subfolderSpec); // 0x000000018167D340-0x000000018167D7B0
		public override void UpdateProps(); // 0x000000018167D7B0-0x000000018167D8A0
		public override void UpdateVars(); // 0x000000018167D8A0-0x000000018167D930
	}
}
