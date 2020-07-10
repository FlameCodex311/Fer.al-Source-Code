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
	[Serializable]
	public class SpawnCritera // TypeDefIndex: 9061
	{
		// Fields
		[Tooltip] // 0x00000001800E4E60-0x00000001800E4E90
		public string m_name; // 0x10
		[Tooltip] // 0x00000001800E50D0-0x00000001800E5100
		public GaiaConstants.SpawnerLocationCheckType m_checkType; // 0x18
		[Tooltip] // 0x00000001800E53E0-0x00000001800E5410
		public bool m_virginTerrain; // 0x1C
		[Tooltip] // 0x00000001800E5880-0x00000001800E58B0
		public bool m_checkHeight; // 0x1D
		[Tooltip] // 0x00000001800E59F0-0x00000001800E5A20
		public float m_minHeight; // 0x20
		[Tooltip] // 0x00000001800E5B60-0x00000001800E5B90
		public float m_maxHeight; // 0x24
		[Tooltip] // 0x00000001800E5DD0-0x00000001800E5E00
		public AnimationCurve m_heightFitness; // 0x28
		[Tooltip] // 0x00000001800E6020-0x00000001800E6050
		public bool m_checkSlope; // 0x30
		[Tooltip] // 0x00000001800E6190-0x00000001800E61C0
		public float m_minSlope; // 0x34
		[Tooltip] // 0x00000001800E6410-0x00000001800E6440
		public float m_maxSlope; // 0x38
		[Tooltip] // 0x00000001800E6610-0x00000001800E6640
		public AnimationCurve m_slopeFitness; // 0x40
		[Tooltip] // 0x00000001800E67B0-0x00000001800E67E0
		public bool m_checkProximity; // 0x48
		[Tooltip] // 0x00000001800E68B0-0x00000001800E68E0
		public string m_proximityTag; // 0x50
		[Tooltip] // 0x00000001800E6970-0x00000001800E69A0
		public float m_minProximity; // 0x58
		[Tooltip] // 0x00000001800E6B00-0x00000001800E6B30
		public float m_maxProximity; // 0x5C
		[Tooltip] // 0x00000001800E6C90-0x00000001800E6CC0
		public AnimationCurve m_proximityFitness; // 0x60
		[Tooltip] // 0x00000001800E6D20-0x00000001800E6D50
		public bool m_checkTexture; // 0x68
		[Tooltip] // 0x00000001800E6E30-0x00000001800E6E60
		public string m_matchingTextures; // 0x70
		[Tooltip] // 0x00000001800E8260-0x00000001800E8290
		public bool m_isActive; // 0x78
		private bool m_isInitialised; // 0x79
	
		// Constructors
		public SpawnCritera(); // 0x0000000181799110-0x0000000181799510
	
		// Methods
		public void Initialise(Spawner spawner); // 0x0000000181798F00-0x0000000181799110
		public float GetSlopeFitness(float slope); // 0x0000000181798C50-0x0000000181798CC0
		public float GetHeightFitness(float height, float sealLevel); // 0x0000000181798B70-0x0000000181798BE0
		public float GetProximityFitness(float proximity); // 0x0000000181798BE0-0x0000000181798C50
		public float GetTextureFitness(float[] textures); // 0x0000000181798CC0-0x0000000181798F00
		public float GetFitness(ref SpawnInfo spawnInfo); // 0x0000000181798690-0x0000000181798B70
	}
}
