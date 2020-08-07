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
	internal class AssetDataSet : AssetCatalogItemWithVariants // TypeDefIndex: 16111
	{
		// Nested types
		private class DataSetVariant : AssetCatalogItemWithVariants.VariantData // TypeDefIndex: 16112
		{
			// Fields
			public string id; // 0x20
	
			// Constructors
			public DataSetVariant(DeviceRequirement requirement, string path, string id); // 0x0000000180852BD0-0x0000000180852C20
		}
	
		// Constructors
		internal AssetDataSet(string parentPath, string name, string authorId); // 0x0000000180965240-0x00000001809652F0
	
		// Methods
		public void AddVariant(DeviceRequirement requirement, string path, string typeIdentifier); // 0x0000000180964BD0-0x0000000180964E10
		public override void Write(List<string> warnings); // 0x0000000180964E10-0x0000000180965240
	}
}
