/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.iOS.Xcode.PBX
{
	internal class PBXShellScriptBuildPhaseData : FileGUIDListBase // TypeDefIndex: 15813
	{
		// Fields
		public string name; // 0x28
		public string shellPath; // 0x30
		public string shellScript; // 0x38
	
		// Constructors
		public PBXShellScriptBuildPhaseData(); // 0x0000000181698F60-0x0000000181698FF0
	
		// Methods
		public static PBXShellScriptBuildPhaseData Create(string name, string shellPath, string shellScript); // 0x00000001816988C0-0x0000000181698C20
		public override void UpdateProps(); // 0x0000000181698C20-0x0000000181698E40
		public override void UpdateVars(); // 0x0000000181698E40-0x0000000181698F60
	}
}
