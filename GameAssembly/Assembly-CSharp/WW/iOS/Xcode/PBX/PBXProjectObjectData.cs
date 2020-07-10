/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using WW.iOS.Xcode;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.iOS.Xcode.PBX
{
	internal class PBXProjectObjectData : PBXObjectData // TypeDefIndex: 15821
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
		internal override PropertyCommentChecker checker { get; } // 0x000000018168D750-0x000000018168D7B0 
		public string mainGroup { get; } // 0x000000018168D7B0-0x000000018168D810 
	
		// Constructors
		public PBXProjectObjectData(); // 0x000000018168D640-0x000000018168D750
		static PBXProjectObjectData(); // 0x000000018168D3E0-0x000000018168D640
	
		// Methods
		public void AddReference(string productGroup, string projectRef); // 0x000000018168B9A0-0x000000018168BA20
		public override void UpdateProps(); // 0x000000018168BA20-0x000000018168C690
		public override void UpdateVars(); // 0x000000018168C690-0x000000018168D3E0
	}
}
