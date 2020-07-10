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
	internal class AssetImageStack : AssetCatalogItem // TypeDefIndex: 15740
	{
		// Fields
		private List<AssetImageStackLayer> m_Layers; // 0x30
	
		// Constructors
		internal AssetImageStack(string assetCatalogPath, string name, string authorId); // 0x0000000181674D60-0x0000000181674E40
	
		// Methods
		public AssetImageStackLayer AddLayer(string name); // 0x0000000181674710-0x00000001816749A0
		public override void Write(List<string> warnings); // 0x00000001816749A0-0x0000000181674D60
	}
}
