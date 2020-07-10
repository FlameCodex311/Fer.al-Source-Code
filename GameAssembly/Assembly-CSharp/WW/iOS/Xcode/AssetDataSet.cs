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
	internal class AssetDataSet : AssetCatalogItemWithVariants // TypeDefIndex: 15731
	{
		// Nested types
		private class DataSetVariant : AssetCatalogItemWithVariants.VariantData // TypeDefIndex: 15732
		{
			// Fields
			public string id; // 0x20
	
			// Constructors
			public DataSetVariant(DeviceRequirement requirement, string path, string id); // 0x00000001806D0A80-0x00000001806D0AD0
		}
	
		// Constructors
		internal AssetDataSet(string parentPath, string name, string authorId); // 0x0000000181117D40-0x0000000181117DF0
	
		// Methods
		public void AddVariant(DeviceRequirement requirement, string path, string typeIdentifier); // 0x00000001811176D0-0x0000000181117910
		public override void Write(List<string> warnings); // 0x0000000181117910-0x0000000181117D40
	}
}
