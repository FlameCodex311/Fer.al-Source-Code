/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 71: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8908-9067

namespace TMPro.SpriteAssetUtilities
{
	public class TexturePacker // TypeDefIndex: 9060
	{
		// Nested types
		[Serializable]
		public struct SpriteFrame // TypeDefIndex: 9061
		{
			// Fields
			public float x; // 0x00
			public float y; // 0x04
			public float w; // 0x08
			public float h; // 0x0C
	
			// Methods
			public override string ToString(); // 0x00000001800073A0-0x00000001800073B0
		}
	
		[Serializable]
		public struct SpriteSize // TypeDefIndex: 9062
		{
			// Fields
			public float w; // 0x00
			public float h; // 0x04
	
			// Methods
			public override string ToString(); // 0x00000001800073B0-0x0000000180007450
		}
	
		[Serializable]
		public struct SpriteData // TypeDefIndex: 9063
		{
			// Fields
			public string filename; // 0x00
			public SpriteFrame frame; // 0x08
			public bool rotated; // 0x18
			public bool trimmed; // 0x19
			public SpriteFrame spriteSourceSize; // 0x1C
			public SpriteSize sourceSize; // 0x2C
			public Vector2 pivot; // 0x34
		}
	
		[Serializable]
		public class SpriteDataObject // TypeDefIndex: 9064
		{
			// Fields
			public List<SpriteData> frames; // 0x10
	
			// Constructors
			public SpriteDataObject(); // 0x0000000180373240-0x0000000180373250
		}
	
		// Constructors
		public TexturePacker(); // 0x0000000180373240-0x0000000180373250
	}
}
