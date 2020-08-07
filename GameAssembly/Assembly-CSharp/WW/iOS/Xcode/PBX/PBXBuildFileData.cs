/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.iOS.Xcode.PBX
{
	internal class PBXBuildFileData : PBXObjectData // TypeDefIndex: 16179
	{
		// Fields
		public string fileRef; // 0x20
		public string compileFlags; // 0x28
		public bool weak; // 0x30
		public List<string> assetTags; // 0x38
		private static PropertyCommentChecker checkerData; // 0x00
	
		// Properties
		internal override PropertyCommentChecker checker { get; } // 0x0000000180975B20-0x0000000180975B80 
		internal override bool shouldCompact { get; } // 0x0000000180380B60-0x0000000180380B70 
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 16180
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Predicate<PBXElement> <>9__10_0; // 0x08
	
			// Constructors
			static <>c(); // 0x000000018097C1F0-0x000000018097C250
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <UpdateProps>b__10_0(PBXElement el); // 0x000000018097C090-0x000000018097C130
		}
	
		// Constructors
		public PBXBuildFileData(); // 0x0000000180975AC0-0x0000000180975B20
		static PBXBuildFileData(); // 0x00000001809759F0-0x0000000180975AC0
	
		// Methods
		public static PBXBuildFileData CreateFromFile(string fileRefGUID, bool weak, string compileFlags); // 0x0000000180974760-0x00000001809748E0
		public override void UpdateProps(); // 0x00000001809748E0-0x0000000180975390
		public override void UpdateVars(); // 0x0000000180975390-0x00000001809759F0
	}
}
