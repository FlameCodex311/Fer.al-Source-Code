/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.iOS.Xcode
{
	internal abstract class AssetCatalogItemWithVariants : AssetCatalogItem // TypeDefIndex: 16109
	{
		// Fields
		protected List<VariantData> m_Variants; // 0x30
		protected List<string> m_ODRTags; // 0x38
	
		// Nested types
		protected class VariantData // TypeDefIndex: 16110
		{
			// Fields
			public DeviceRequirement requirement; // 0x10
			public string path; // 0x18
	
			// Constructors
			public VariantData(DeviceRequirement requirement, string path); // 0x0000000180372010-0x00000001803720F0
		}
	
		// Constructors
		protected AssetCatalogItemWithVariants(string name, string authorId); // 0x0000000180963E50-0x0000000180963F00
	
		// Methods
		public bool HasVariant(DeviceRequirement requirement); // 0x0000000180963910-0x0000000180963AC0
		public void AddOnDemandResourceTag(string tag); // 0x00000001809635A0-0x0000000180963620
		protected void AddVariant(VariantData newItem); // 0x0000000180963620-0x0000000180963910
		protected void WriteODRTagsToJson(JsonElementDict info); // 0x0000000180963AC0-0x0000000180963CB0
		protected void WriteRequirementsToJson(JsonElementDict item, DeviceRequirement req); // 0x0000000180963CB0-0x0000000180963E50
	}
}
