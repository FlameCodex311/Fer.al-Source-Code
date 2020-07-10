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
	internal class AssetBrandAssetGroup : AssetCatalogItem // TypeDefIndex: 15741
	{
		// Fields
		private List<AssetBrandAssetItem> m_Items; // 0x30
	
		// Nested types
		private class AssetBrandAssetItem // TypeDefIndex: 15742
		{
			// Fields
			internal string idiom; // 0x10
			internal string role; // 0x18
			internal int width; // 0x20
			internal int height; // 0x24
			internal AssetCatalogItem item; // 0x28
	
			// Constructors
			public AssetBrandAssetItem(); // 0x000000018036B6C0-0x000000018036B6D0
		}
	
		// Constructors
		internal AssetBrandAssetGroup(string assetCatalogPath, string name, string authorId); // 0x0000000181116000-0x00000001811160E0
	
		// Methods
		private void AddItem(AssetCatalogItem item, string idiom, string role, int width, int height); // 0x0000000181115850-0x0000000181115A90
		public AssetImageSet OpenImageSet(string name, string idiom, string role, int width, int height); // 0x0000000181115A90-0x0000000181115B60
		public AssetImageStack OpenImageStack(string name, string idiom, string role, int width, int height); // 0x0000000181115B60-0x0000000181115C30
		public override void Write(List<string> warnings); // 0x0000000181115C30-0x0000000181116000
	}
}
