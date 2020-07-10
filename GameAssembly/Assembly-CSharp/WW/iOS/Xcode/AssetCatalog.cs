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
	internal class AssetCatalog // TypeDefIndex: 15726
	{
		// Fields
		private AssetFolder m_Root; // 0x10
	
		// Properties
		public string path { get; } // 0x00000001809759E0-0x0000000180975A00 
		public AssetFolder root { get; } // 0x000000018036AC80-0x000000018036AC90 
	
		// Constructors
		public AssetCatalog(string path, string authorId); // 0x0000000181117550-0x00000001811176D0
	
		// Methods
		private AssetFolder OpenFolderForResource(string relativePath); // 0x0000000181116E90-0x0000000181117020
		public AssetDataSet OpenDataSet(string relativePath); // 0x0000000181116D00-0x0000000181116E90
		public AssetImageSet OpenImageSet(string relativePath); // 0x00000001811170D0-0x0000000181117200
		public AssetImageStack OpenImageStack(string relativePath); // 0x0000000181117200-0x0000000181117330
		public AssetBrandAssetGroup OpenBrandAssetGroup(string relativePath); // 0x0000000181116B60-0x0000000181116D00
		public AssetFolder OpenFolder(string relativePath); // 0x0000000181117020-0x00000001811170D0
		public AssetFolder OpenNamespacedFolder(string relativeBasePath, string namespacePath); // 0x0000000181117330-0x00000001811174F0
		public void Write(); // 0x0000000181117520-0x0000000181117550
		public void Write(List<string> warnings); // 0x00000001811174F0-0x0000000181117520
	}
}
