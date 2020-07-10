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
	internal class AssetFolder : AssetCatalogItem // TypeDefIndex: 15728
	{
		// Fields
		private List<AssetCatalogItem> m_Items; // 0x30
		private bool m_ProvidesNamespace; // 0x38
	
		// Properties
		public bool providesNamespace { get; set; } // 0x00000001804AEAD0-0x00000001804AEAE0 0x0000000181118A20-0x0000000181118AB0
	
		// Constructors
		internal AssetFolder(string parentPath, string name, string authorId); // 0x0000000181118950-0x0000000181118A20
	
		// Methods
		public AssetFolder OpenFolder(string name); // 0x00000001811181F0-0x0000000181118370
		private T GetExistingItemWithType<T>(string name)
			where T : class;
		public AssetDataSet OpenDataSet(string name); // 0x00000001811180D0-0x00000001811181F0
		public AssetImageSet OpenImageSet(string name); // 0x0000000181118370-0x0000000181118430
		public AssetImageStack OpenImageStack(string name); // 0x0000000181118430-0x00000001811184F0
		public AssetBrandAssetGroup OpenBrandAssetGroup(string name); // 0x0000000181117F90-0x00000001811180D0
		public AssetCatalogItem GetChild(string name); // 0x0000000181117DF0-0x0000000181117F90
		private void WriteJson(); // 0x00000001811184F0-0x0000000181118670
		public override void Write(List<string> warnings); // 0x0000000181118670-0x0000000181118950
	}
}
