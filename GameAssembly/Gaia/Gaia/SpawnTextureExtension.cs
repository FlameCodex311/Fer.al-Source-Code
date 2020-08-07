/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia
{
	public class SpawnTextureExtension : SpawnRuleExtension // TypeDefIndex: 9229
	{
		// Fields
		[Tooltip] // 0x0000000180247B10-0x0000000180247B40
		public int m_textureIndex; // 0x18
		[Tooltip] // 0x0000000180247CA0-0x0000000180247CD0
		public Texture2D m_textureMask; // 0x20
		[Tooltip] // 0x0000000180247420-0x0000000180247450
		public bool m_normaliseMask; // 0x28
		[Tooltip] // 0x0000000180247510-0x0000000180247540
		public bool m_invertMask; // 0x29
		[Tooltip] // 0x0000000180247690-0x00000001802476C0
		public bool m_flipMask; // 0x2A
		[Range] // 0x00000001802477B0-0x0000000180247810
		[Tooltip] // 0x00000001802477B0-0x0000000180247810
		public float m_scaleMask; // 0x2C
		private UnityHeightMap m_textureHM; // 0x30
	
		// Constructors
		public SpawnTextureExtension(); // 0x0000000181568150-0x0000000181568170
	
		// Methods
		public override void Initialise(); // 0x0000000181567A00-0x0000000181567B10
		public override bool AffectsTextures(); // 0x0000000180380B60-0x0000000180380B70
		public override void PostSpawn(SpawnRule spawnRule, ref SpawnInfo spawnInfo); // 0x0000000181567B10-0x0000000181568150
	}
}
