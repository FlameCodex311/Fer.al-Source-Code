/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia
{
	public class SpawnTextureExtension : SpawnRuleExtension // TypeDefIndex: 9070
	{
		// Fields
		[Tooltip] // 0x00000001800EC9C0-0x00000001800EC9F0
		public int m_textureIndex; // 0x18
		[Tooltip] // 0x00000001800ECBC0-0x00000001800ECBF0
		public Texture2D m_textureMask; // 0x20
		[Tooltip] // 0x00000001800EC280-0x00000001800EC2B0
		public bool m_normaliseMask; // 0x28
		[Tooltip] // 0x00000001800EC3C0-0x00000001800EC3F0
		public bool m_invertMask; // 0x29
		[Tooltip] // 0x00000001800EC500-0x00000001800EC530
		public bool m_flipMask; // 0x2A
		[Range] // 0x00000001800EC6E0-0x00000001800EC740
		[Tooltip] // 0x00000001800EC6E0-0x00000001800EC740
		public float m_scaleMask; // 0x2C
		private UnityHeightMap m_textureHM; // 0x30
	
		// Constructors
		public SpawnTextureExtension(); // 0x000000018179FF70-0x000000018179FF90
	
		// Methods
		public override void Initialise(); // 0x000000018179F6B0-0x000000018179F880
		public override bool AffectsTextures(); // 0x00000001803C29F0-0x00000001803C2A00
		public override void PostSpawn(SpawnRule spawnRule, ref SpawnInfo spawnInfo); // 0x000000018179F880-0x000000018179FF70
	}
}
