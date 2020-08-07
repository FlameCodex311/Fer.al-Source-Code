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
	internal class AssetBrandAssetGroup : AssetCatalogItem // TypeDefIndex: 16121
	{
		// Fields
		private List<AssetBrandAssetItem> m_Items; // 0x30
	
		// Nested types
		private class AssetBrandAssetItem // TypeDefIndex: 16122
		{
			// Fields
			internal string idiom; // 0x10
			internal string role; // 0x18
			internal int width; // 0x20
			internal int height; // 0x24
			internal AssetCatalogItem item; // 0x28
	
			// Constructors
			public AssetBrandAssetItem(); // 0x0000000180373240-0x0000000180373250
		}
	
		// Constructors
		internal AssetBrandAssetGroup(string assetCatalogPath, string name, string authorId); // 0x00000001809634C0-0x00000001809635A0
	
		// Methods
		private void AddItem(AssetCatalogItem item, string idiom, string role, int width, int height); // 0x0000000180962D20-0x0000000180962F50
		public AssetImageSet OpenImageSet(string name, string idiom, string role, int width, int height); // 0x0000000180962F50-0x0000000180963020
		public AssetImageStack OpenImageStack(string name, string idiom, string role, int width, int height); // 0x0000000180963020-0x00000001809630F0
		public override void Write(List<string> warnings); // 0x00000001809630F0-0x00000001809634C0
	}
}
