/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using WW.iOS.Xcode;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.iOS.Xcode.PBX
{
	internal class PBXProjectObjectData : PBXObjectData // TypeDefIndex: 16201
	{
		// Fields
		private static PropertyCommentChecker checkerData; // 0x00
		public List<ProjectReference> projectReferences; // 0x20
		public List<string> targets; // 0x28
		public List<string> knownAssetTags; // 0x30
		public string buildConfigList; // 0x38
		public string entitlementsFile; // 0x40
		public List<PBXCapabilityType.TargetCapabilityPair> capabilities; // 0x48
		public Dictionary<string, string> teamIDs; // 0x50
	
		// Properties
		internal override PropertyCommentChecker checker { get; } // 0x00000001814C0CF0-0x00000001814C0D50 
		public string mainGroup { get; } // 0x00000001814C0D50-0x00000001814C0DB0 
	
		// Constructors
		public PBXProjectObjectData(); // 0x00000001814C0BB0-0x00000001814C0CF0
		static PBXProjectObjectData(); // 0x00000001814C0970-0x00000001814C0BB0
	
		// Methods
		public void AddReference(string productGroup, string projectRef); // 0x00000001814BF4E0-0x00000001814BF5A0
		public override void UpdateProps(); // 0x00000001814BF5A0-0x00000001814BFF90
		public override void UpdateVars(); // 0x00000001814BFF90-0x00000001814C0970
	}
}
