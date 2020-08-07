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
	internal class AssetImageStack : AssetCatalogItem // TypeDefIndex: 16120
	{
		// Fields
		private List<AssetImageStackLayer> m_Layers; // 0x30
	
		// Constructors
		internal AssetImageStack(string assetCatalogPath, string name, string authorId); // 0x0000000180967100-0x00000001809671E0
	
		// Methods
		public AssetImageStackLayer AddLayer(string name); // 0x0000000180966B70-0x0000000180966DF0
		public override void Write(List<string> warnings); // 0x0000000180966DF0-0x0000000180967100
	}
}
