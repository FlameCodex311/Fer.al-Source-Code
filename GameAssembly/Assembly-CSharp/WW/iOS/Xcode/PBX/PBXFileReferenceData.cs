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
	internal class PBXFileReferenceData : PBXObjectData // TypeDefIndex: 15801
	{
		// Fields
		private string m_Path; // 0x20
		private string m_ExplicitFileType; // 0x28
		private string m_LastKnownFileType; // 0x30
		public string name; // 0x38
		public PBXSourceTree tree; // 0x40
	
		// Properties
		public string path { get; set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018167F060-0x000000018167F070
		public bool isFolderReference { get; } // 0x000000018167F010-0x000000018167F060 
		internal override bool shouldCompact { get; } // 0x00000001803C29F0-0x00000001803C2A00 
	
		// Constructors
		public PBXFileReferenceData(); // 0x000000018167EFB0-0x000000018167F010
	
		// Methods
		public static PBXFileReferenceData CreateFromFile(string path, string projectFileName, PBXSourceTree tree); // 0x000000018167E590-0x000000018167E790
		public static PBXFileReferenceData CreateFromFolderReference(string path, string projectFileName, PBXSourceTree tree); // 0x000000018167E790-0x000000018167E800
		public override void UpdateProps(); // 0x000000018167E800-0x000000018167EE10
		public override void UpdateVars(); // 0x000000018167EE10-0x000000018167EFB0
	}
}
