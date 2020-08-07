/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.iOS.Xcode.PBX
{
	internal class PBXCopyFilesBuildPhaseData : FileGUIDListBase // TypeDefIndex: 16192
	{
		// Fields
		private static PropertyCommentChecker checkerData; // 0x00
		public string name; // 0x28
	
		// Properties
		internal override PropertyCommentChecker checker { get; } // 0x0000000180976320-0x0000000180976380 
	
		// Constructors
		public PBXCopyFilesBuildPhaseData(); // 0x0000000180976290-0x0000000180976320
		static PBXCopyFilesBuildPhaseData(); // 0x00000001809761C0-0x0000000180976290
	
		// Methods
		public static PBXCopyFilesBuildPhaseData Create(string name, string dstPath, string subfolderSpec); // 0x0000000180975ED0-0x00000001809760F0
		public override void UpdateProps(); // 0x00000001809760F0-0x0000000180976160
		public override void UpdateVars(); // 0x0000000180976160-0x00000001809761C0
	}
}
