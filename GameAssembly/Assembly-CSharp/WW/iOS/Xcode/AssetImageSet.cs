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
	internal class AssetImageSet : AssetCatalogItemWithVariants // TypeDefIndex: 16117
	{
		// Nested types
		private class ImageSetVariant : AssetCatalogItemWithVariants.VariantData // TypeDefIndex: 16118
		{
			// Fields
			public ImageAlignment alignment; // 0x20
			public ImageResizing resizing; // 0x28
	
			// Constructors
			public ImageSetVariant(DeviceRequirement requirement, string path); // 0x0000000180372010-0x00000001803720F0
		}
	
		// Constructors
		internal AssetImageSet(string assetCatalogPath, string name, string authorId); // 0x00000001809667C0-0x0000000180966870
	
		// Methods
		public void AddVariant(DeviceRequirement requirement, string path); // 0x0000000180965F60-0x0000000180965FE0
		public void AddVariant(DeviceRequirement requirement, string path, ImageAlignment alignment, ImageResizing resizing); // 0x0000000180965EC0-0x0000000180965F60
		private void WriteAlignmentToJson(JsonElementDict item, ImageAlignment alignment); // 0x00000001809660A0-0x0000000180966170
		private static string GetSlicingMode(ImageResizing.SlicingType mode); // 0x0000000180966030-0x00000001809660A0
		private static string GetCenterResizeMode(ImageResizing.ResizeMode mode); // 0x0000000180965FE0-0x0000000180966030
		private void WriteResizingToJson(JsonElementDict item, ImageResizing resizing); // 0x0000000180966170-0x0000000180966380
		public override void Write(List<string> warnings); // 0x0000000180966380-0x00000001809667C0
	}
}
