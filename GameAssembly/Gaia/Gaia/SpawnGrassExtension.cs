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
	public class SpawnGrassExtension : SpawnRuleExtension // TypeDefIndex: 9228
	{
		// Fields
		[Tooltip] // 0x00000001802469F0-0x0000000180246A20
		public int m_grassIndex; // 0x18
		[Range] // 0x0000000180246B90-0x0000000180246BF0
		[Tooltip] // 0x0000000180246B90-0x0000000180246BF0
		public int m_minGrassStrenth; // 0x1C
		[Range] // 0x0000000180247120-0x0000000180247180
		[Tooltip] // 0x0000000180247120-0x0000000180247180
		public int m_maxGrassStrength; // 0x20
		[Tooltip] // 0x00000001802472E0-0x0000000180247310
		public Texture2D m_grassMask; // 0x28
		[Tooltip] // 0x0000000180247420-0x0000000180247450
		public bool m_normaliseMask; // 0x30
		[Tooltip] // 0x0000000180247510-0x0000000180247540
		public bool m_invertMask; // 0x31
		[Tooltip] // 0x0000000180247690-0x00000001802476C0
		public bool m_flipMask; // 0x32
		[Range] // 0x00000001802477B0-0x0000000180247810
		[Tooltip] // 0x00000001802477B0-0x0000000180247810
		public float m_scaleMask; // 0x34
		private UnityHeightMap m_textureHM; // 0x38
	
		// Constructors
		public SpawnGrassExtension(); // 0x0000000181562610-0x0000000181562630
	
		// Methods
		public override void Initialise(); // 0x0000000181561F10-0x0000000181562020
		public override bool AffectsDetails(); // 0x0000000180380B60-0x0000000180380B70
		public override void PostSpawn(SpawnRule spawnRule, ref SpawnInfo spawnInfo); // 0x0000000181562020-0x0000000181562610
	}
}
