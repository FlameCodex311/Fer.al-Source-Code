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
	internal class AssetFolder : AssetCatalogItem // TypeDefIndex: 16108
	{
		// Fields
		private List<AssetCatalogItem> m_Items; // 0x30
		private bool m_ProvidesNamespace; // 0x38
	
		// Properties
		public bool providesNamespace { get; set; } // 0x0000000180379B20-0x0000000180379B30 0x0000000180965E30-0x0000000180965EC0
	
		// Constructors
		internal AssetFolder(string parentPath, string name, string authorId); // 0x0000000180965D60-0x0000000180965E30
	
		// Methods
		public AssetFolder OpenFolder(string name); // 0x00000001809656F0-0x0000000180965870
		private T GetExistingItemWithType<T>(string name)
			where T : class;
		public AssetDataSet OpenDataSet(string name); // 0x00000001809655D0-0x00000001809656F0
		public AssetImageSet OpenImageSet(string name); // 0x0000000180965870-0x0000000180965930
		public AssetImageStack OpenImageStack(string name); // 0x0000000180965930-0x00000001809659F0
		public AssetBrandAssetGroup OpenBrandAssetGroup(string name); // 0x0000000180965490-0x00000001809655D0
		public AssetCatalogItem GetChild(string name); // 0x00000001809652F0-0x0000000180965490
		private void WriteJson(); // 0x00000001809659F0-0x0000000180965BF0
		public override void Write(List<string> warnings); // 0x0000000180965BF0-0x0000000180965D60
	}
}
