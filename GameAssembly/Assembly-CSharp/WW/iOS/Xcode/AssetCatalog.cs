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
	internal class AssetCatalog // TypeDefIndex: 16106
	{
		// Fields
		private AssetFolder m_Root; // 0x10
	
		// Properties
		public string path { get; } // 0x000000018055F620-0x000000018055F640 
		public AssetFolder root { get; } // 0x0000000180372440-0x0000000180372450 
	
		// Constructors
		public AssetCatalog(string path, string authorId); // 0x0000000180964A50-0x0000000180964BD0
	
		// Methods
		private AssetFolder OpenFolderForResource(string relativePath); // 0x00000001809643A0-0x0000000180964530
		public AssetDataSet OpenDataSet(string relativePath); // 0x0000000180964210-0x00000001809643A0
		public AssetImageSet OpenImageSet(string relativePath); // 0x00000001809645E0-0x0000000180964710
		public AssetImageStack OpenImageStack(string relativePath); // 0x0000000180964710-0x0000000180964840
		public AssetBrandAssetGroup OpenBrandAssetGroup(string relativePath); // 0x0000000180964070-0x0000000180964210
		public AssetFolder OpenFolder(string relativePath); // 0x0000000180964530-0x00000001809645E0
		public AssetFolder OpenNamespacedFolder(string relativeBasePath, string namespacePath); // 0x0000000180964840-0x00000001809649F0
		public void Write(); // 0x0000000180964A20-0x0000000180964A50
		public void Write(List<string> warnings); // 0x00000001809649F0-0x0000000180964A20
	}
}
