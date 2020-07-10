/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 70: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8742-8901

namespace TMPro.SpriteAssetUtilities
{
	public class TexturePacker // TypeDefIndex: 8894
	{
		// Nested types
		[Serializable]
		public struct SpriteFrame // TypeDefIndex: 8895
		{
			// Fields
			public float x; // 0x00
			public float y; // 0x04
			public float w; // 0x08
			public float h; // 0x0C
	
			// Methods
			public override string ToString(); // 0x000000018020AB30-0x000000018020AB40
		}
	
		[Serializable]
		public struct SpriteSize // TypeDefIndex: 8896
		{
			// Fields
			public float w; // 0x00
			public float h; // 0x04
	
			// Methods
			public override string ToString(); // 0x000000018020AB40-0x000000018020ABE0
		}
	
		[Serializable]
		public struct SpriteData // TypeDefIndex: 8897
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
		public class SpriteDataObject // TypeDefIndex: 8898
		{
			// Fields
			public List<SpriteData> frames; // 0x10
	
			// Constructors
			public SpriteDataObject(); // 0x000000018036B6C0-0x000000018036B6D0
		}
	
		// Constructors
		public TexturePacker(); // 0x000000018036B6C0-0x000000018036B6D0
	}
}
