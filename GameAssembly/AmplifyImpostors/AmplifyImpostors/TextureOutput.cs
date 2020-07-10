/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 73: AmplifyImpostors.dll - Assembly: AmplifyImpostors, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8910-8940

namespace AmplifyImpostors
{
	[Serializable]
	public class TextureOutput // TypeDefIndex: 8926
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public int Index; // 0x10
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public OverrideMask OverrideMask; // 0x14
		public bool Active; // 0x18
		public string Name; // 0x20
		public TextureScale Scale; // 0x28
		public bool SRGB; // 0x2C
		public TextureChannels Channels; // 0x30
		public TextureCompression Compression; // 0x34
		public ImageFormat ImageFormat; // 0x38
	
		// Constructors
		public TextureOutput(); // 0x00000001822B30C0-0x00000001822B3130
		public TextureOutput(bool a, string n, TextureScale s, bool sr, TextureChannels c, TextureCompression nc, ImageFormat i); // 0x00000001822B3000-0x00000001822B30C0
	
		// Methods
		public TextureOutput Clone(); // 0x00000001822B2F70-0x00000001822B3000
	}
}
