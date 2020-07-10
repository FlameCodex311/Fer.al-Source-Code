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
	public class SpawnGrassExtension : SpawnRuleExtension // TypeDefIndex: 9069
	{
		// Fields
		[Tooltip] // 0x00000001800EBB00-0x00000001800EBB30
		public int m_grassIndex; // 0x18
		[Range] // 0x00000001800EBC00-0x00000001800EBC60
		[Tooltip] // 0x00000001800EBC00-0x00000001800EBC60
		public int m_minGrassStrenth; // 0x1C
		[Range] // 0x00000001800EBEF0-0x00000001800EBF50
		[Tooltip] // 0x00000001800EBEF0-0x00000001800EBF50
		public int m_maxGrassStrength; // 0x20
		[Tooltip] // 0x00000001800EC060-0x00000001800EC090
		public Texture2D m_grassMask; // 0x28
		[Tooltip] // 0x00000001800EC280-0x00000001800EC2B0
		public bool m_normaliseMask; // 0x30
		[Tooltip] // 0x00000001800EC3C0-0x00000001800EC3F0
		public bool m_invertMask; // 0x31
		[Tooltip] // 0x00000001800EC500-0x00000001800EC530
		public bool m_flipMask; // 0x32
		[Range] // 0x00000001800EC6E0-0x00000001800EC740
		[Tooltip] // 0x00000001800EC6E0-0x00000001800EC740
		public float m_scaleMask; // 0x34
		private UnityHeightMap m_textureHM; // 0x38
	
		// Constructors
		public SpawnGrassExtension(); // 0x0000000181799D20-0x0000000181799D40
	
		// Methods
		public override void Initialise(); // 0x0000000181799510-0x00000001817996E0
		public override bool AffectsDetails(); // 0x00000001803C29F0-0x00000001803C2A00
		public override void PostSpawn(SpawnRule spawnRule, ref SpawnInfo spawnInfo); // 0x00000001817996E0-0x0000000181799D20
	}
}
