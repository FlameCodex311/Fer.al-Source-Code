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
	internal class AssetImageSet : AssetCatalogItemWithVariants // TypeDefIndex: 15737
	{
		// Nested types
		private class ImageSetVariant : AssetCatalogItemWithVariants.VariantData // TypeDefIndex: 15738
		{
			// Fields
			public ImageAlignment alignment; // 0x20
			public ImageResizing resizing; // 0x28
	
			// Constructors
			public ImageSetVariant(DeviceRequirement requirement, string path); // 0x00000001812BB5F0-0x00000001812BB600
		}
	
		// Constructors
		internal AssetImageSet(string assetCatalogPath, string name, string authorId); // 0x00000001811193C0-0x0000000181119470
	
		// Methods
		public void AddVariant(DeviceRequirement requirement, string path); // 0x0000000181118B60-0x0000000181118BE0
		public void AddVariant(DeviceRequirement requirement, string path, ImageAlignment alignment, ImageResizing resizing); // 0x0000000181118AB0-0x0000000181118B60
		private void WriteAlignmentToJson(JsonElementDict item, ImageAlignment alignment); // 0x0000000181118CA0-0x0000000181118D70
		private static string GetSlicingMode(ImageResizing.SlicingType mode); // 0x0000000181118C30-0x0000000181118CA0
		private static string GetCenterResizeMode(ImageResizing.ResizeMode mode); // 0x0000000181118BE0-0x0000000181118C30
		private void WriteResizingToJson(JsonElementDict item, ImageResizing resizing); // 0x0000000181118D70-0x0000000181118F80
		public override void Write(List<string> warnings); // 0x0000000181118F80-0x00000001811193C0
	}
}
