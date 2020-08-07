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
	internal class PBXFileReferenceData : PBXObjectData // TypeDefIndex: 16181
	{
		// Fields
		private string m_Path; // 0x20
		private string m_ExplicitFileType; // 0x28
		private string m_LastKnownFileType; // 0x30
		public string name; // 0x38
		public PBXSourceTree tree; // 0x40
	
		// Properties
		public string path { get; set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001809775D0-0x00000001809775E0
		public bool isFolderReference { get; } // 0x0000000180977580-0x00000001809775D0 
		internal override bool shouldCompact { get; } // 0x0000000180380B60-0x0000000180380B70 
	
		// Constructors
		public PBXFileReferenceData(); // 0x0000000180977520-0x0000000180977580
	
		// Methods
		public static PBXFileReferenceData CreateFromFile(string path, string projectFileName, PBXSourceTree tree); // 0x0000000180976E00-0x0000000180976F80
		public static PBXFileReferenceData CreateFromFolderReference(string path, string projectFileName, PBXSourceTree tree); // 0x0000000180976F80-0x0000000180977120
		public override void UpdateProps(); // 0x0000000180977120-0x0000000180977430
		public override void UpdateVars(); // 0x0000000180977430-0x0000000180977520
	}
}
