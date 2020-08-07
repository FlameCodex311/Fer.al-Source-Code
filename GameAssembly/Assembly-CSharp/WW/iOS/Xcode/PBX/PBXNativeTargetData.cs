/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.iOS.Xcode.PBX
{
	internal class PBXNativeTargetData : PBXObjectData // TypeDefIndex: 16187
	{
		// Fields
		public GUIDList phases; // 0x20
		public string buildConfigList; // 0x28
		public string name; // 0x30
		public GUIDList dependencies; // 0x38
		public string productReference; // 0x40
		private static PropertyCommentChecker checkerData; // 0x00
	
		// Properties
		internal override PropertyCommentChecker checker { get; } // 0x00000001814B6D10-0x00000001814B6D70 
	
		// Constructors
		public PBXNativeTargetData(); // 0x00000001814B6C70-0x00000001814B6D10
		static PBXNativeTargetData(); // 0x00000001814B6A30-0x00000001814B6C70
	
		// Methods
		public static PBXNativeTargetData Create(string name, string productRef, string productType, string buildConfigList); // 0x00000001814B6540-0x00000001814B67D0
		public override void UpdateProps(); // 0x00000001814B67D0-0x00000001814B6910
		public override void UpdateVars(); // 0x00000001814B6910-0x00000001814B6A30
	}
}
