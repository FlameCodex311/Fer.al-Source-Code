/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.iOS.Xcode.PBX
{
	internal class PBXNativeTargetData : PBXObjectData // TypeDefIndex: 15807
	{
		// Fields
		public GUIDList phases; // 0x20
		public string buildConfigList; // 0x28
		public string name; // 0x30
		public GUIDList dependencies; // 0x38
		public string productReference; // 0x40
		private static PropertyCommentChecker checkerData; // 0x00
	
		// Properties
		internal override PropertyCommentChecker checker { get; } // 0x0000000181680940-0x00000001816809A0 
	
		// Constructors
		public PBXNativeTargetData(); // 0x00000001816808E0-0x0000000181680940
		static PBXNativeTargetData(); // 0x0000000181680680-0x00000001816808E0
	
		// Methods
		public static PBXNativeTargetData Create(string name, string productRef, string productType, string buildConfigList); // 0x000000018167FEC0-0x0000000181680330
		public override void UpdateProps(); // 0x0000000181680330-0x0000000181680560
		public override void UpdateVars(); // 0x0000000181680560-0x0000000181680680
	}
}
