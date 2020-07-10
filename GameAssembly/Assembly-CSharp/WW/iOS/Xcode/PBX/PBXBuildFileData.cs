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
	internal class PBXBuildFileData : PBXObjectData // TypeDefIndex: 15799
	{
		// Fields
		public string fileRef; // 0x20
		public string compileFlags; // 0x28
		public bool weak; // 0x30
		public List<string> assetTags; // 0x38
		private static PropertyCommentChecker checkerData; // 0x00
	
		// Properties
		internal override PropertyCommentChecker checker { get; } // 0x000000018167C060-0x000000018167C0C0 
		internal override bool shouldCompact { get; } // 0x00000001803C29F0-0x00000001803C2A00 
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 15800
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Predicate<PBXElement> <>9__10_0; // 0x08
	
			// Constructors
			static <>c(); // 0x000000018169D310-0x000000018169D370
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <UpdateProps>b__10_0(PBXElement el); // 0x000000018169D270-0x000000018169D310
		}
	
		// Constructors
		public PBXBuildFileData(); // 0x000000018167C000-0x000000018167C060
		static PBXBuildFileData(); // 0x000000018167BF20-0x000000018167C000
	
		// Methods
		public static PBXBuildFileData CreateFromFile(string fileRefGUID, bool weak, string compileFlags); // 0x000000018167ABA0-0x000000018167ADB0
		public override void UpdateProps(); // 0x000000018167ADB0-0x000000018167B880
		public override void UpdateVars(); // 0x000000018167B880-0x000000018167BF20
	}
}
