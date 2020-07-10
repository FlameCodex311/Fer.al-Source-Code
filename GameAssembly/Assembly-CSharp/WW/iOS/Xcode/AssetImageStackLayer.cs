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
	internal class AssetImageStackLayer : AssetCatalogItem // TypeDefIndex: 15739
	{
		// Fields
		private AssetImageSet m_Imageset; // 0x30
		private string m_ReferencedName; // 0x38
	
		// Constructors
		internal AssetImageStackLayer(string assetCatalogPath, string name, string authorId); // 0x0000000181674630-0x0000000181674710
	
		// Methods
		public void SetReference(string name); // 0x0000000181674470-0x0000000181674480
		public string ReferencedName(); // 0x0000000180369BB0-0x0000000180369BC0
		public AssetImageSet GetImageSet(); // 0x0000000180397720-0x0000000180397730
		public override void Write(List<string> warnings); // 0x0000000181674480-0x0000000181674630
	}
}
