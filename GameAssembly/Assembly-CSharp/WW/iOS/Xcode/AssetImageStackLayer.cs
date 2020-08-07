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
	internal class AssetImageStackLayer : AssetCatalogItem // TypeDefIndex: 16119
	{
		// Fields
		private AssetImageSet m_Imageset; // 0x30
		private string m_ReferencedName; // 0x38
	
		// Constructors
		internal AssetImageStackLayer(string assetCatalogPath, string name, string authorId); // 0x0000000180966A90-0x0000000180966B70
	
		// Methods
		public void SetReference(string name); // 0x0000000180966870-0x0000000180966880
		public string ReferencedName(); // 0x00000001803743D0-0x00000001803743E0
		public AssetImageSet GetImageSet(); // 0x00000001803745C0-0x00000001803745D0
		public override void Write(List<string> warnings); // 0x0000000180966880-0x0000000180966A90
	}
}
