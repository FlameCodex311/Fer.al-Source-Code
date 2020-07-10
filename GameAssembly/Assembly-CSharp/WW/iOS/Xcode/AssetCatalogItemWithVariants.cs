/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.iOS.Xcode
{
	internal abstract class AssetCatalogItemWithVariants : AssetCatalogItem // TypeDefIndex: 15729
	{
		// Fields
		protected List<VariantData> m_Variants; // 0x30
		protected List<string> m_ODRTags; // 0x38
	
		// Nested types
		protected class VariantData // TypeDefIndex: 15730
		{
			// Fields
			public DeviceRequirement requirement; // 0x10
			public string path; // 0x18
	
			// Constructors
			public VariantData(DeviceRequirement requirement, string path); // 0x00000001803DA900-0x00000001803DA940
		}
	
		// Constructors
		protected AssetCatalogItemWithVariants(string name, string authorId); // 0x0000000181116940-0x00000001811169F0
	
		// Methods
		public bool HasVariant(DeviceRequirement requirement); // 0x0000000181116460-0x0000000181116610
		public void AddOnDemandResourceTag(string tag); // 0x00000001811160E0-0x0000000181116160
		protected void AddVariant(VariantData newItem); // 0x0000000181116160-0x0000000181116460
		protected void WriteODRTagsToJson(JsonElementDict info); // 0x0000000181116610-0x0000000181116790
		protected void WriteRequirementsToJson(JsonElementDict item, DeviceRequirement req); // 0x0000000181116790-0x0000000181116940
	}
}
