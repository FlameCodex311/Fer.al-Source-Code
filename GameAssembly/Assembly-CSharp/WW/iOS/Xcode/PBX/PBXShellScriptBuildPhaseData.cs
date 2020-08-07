/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.iOS.Xcode.PBX
{
	internal class PBXShellScriptBuildPhaseData : FileGUIDListBase // TypeDefIndex: 16193
	{
		// Fields
		public string name; // 0x28
		public string shellPath; // 0x30
		public string shellScript; // 0x38
	
		// Constructors
		public PBXShellScriptBuildPhaseData(); // 0x00000001814CB440-0x00000001814CB4A0
	
		// Methods
		public static PBXShellScriptBuildPhaseData Create(string name, string shellPath, string shellScript); // 0x00000001814CB070-0x00000001814CB260
		public override void UpdateProps(); // 0x00000001814CB260-0x00000001814CB350
		public override void UpdateVars(); // 0x00000001814CB350-0x00000001814CB440
	}
}
