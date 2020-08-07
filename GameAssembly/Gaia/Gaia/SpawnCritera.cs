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
	[Serializable]
	public class SpawnCritera // TypeDefIndex: 9227
	{
		// Fields
		[Tooltip] // 0x0000000180244B30-0x0000000180244B60
		public string m_name; // 0x10
		[Tooltip] // 0x0000000180244C30-0x0000000180244C60
		public GaiaConstants.SpawnerLocationCheckType m_checkType; // 0x18
		[Tooltip] // 0x0000000180244E40-0x0000000180244E70
		public bool m_virginTerrain; // 0x1C
		[Tooltip] // 0x0000000180244F70-0x0000000180244FA0
		public bool m_checkHeight; // 0x1D
		[Tooltip] // 0x0000000180245130-0x0000000180245160
		public float m_minHeight; // 0x20
		[Tooltip] // 0x00000001802451E0-0x0000000180245210
		public float m_maxHeight; // 0x24
		[Tooltip] // 0x00000001802453A0-0x00000001802453D0
		public AnimationCurve m_heightFitness; // 0x28
		[Tooltip] // 0x00000001802454F0-0x0000000180245520
		public bool m_checkSlope; // 0x30
		[Tooltip] // 0x0000000180245610-0x0000000180245640
		public float m_minSlope; // 0x34
		[Tooltip] // 0x00000001802457F0-0x0000000180245820
		public float m_maxSlope; // 0x38
		[Tooltip] // 0x00000001802459C0-0x00000001802459F0
		public AnimationCurve m_slopeFitness; // 0x40
		[Tooltip] // 0x0000000180245B20-0x0000000180245B50
		public bool m_checkProximity; // 0x48
		[Tooltip] // 0x0000000180245CD0-0x0000000180245D00
		public string m_proximityTag; // 0x50
		[Tooltip] // 0x0000000180245E90-0x0000000180245EC0
		public float m_minProximity; // 0x58
		[Tooltip] // 0x0000000180245FA0-0x0000000180245FD0
		public float m_maxProximity; // 0x5C
		[Tooltip] // 0x0000000180246190-0x00000001802461C0
		public AnimationCurve m_proximityFitness; // 0x60
		[Tooltip] // 0x0000000180246320-0x0000000180246350
		public bool m_checkTexture; // 0x68
		[Tooltip] // 0x00000001802465A0-0x00000001802465D0
		public string m_matchingTextures; // 0x70
		[Tooltip] // 0x00000001802466F0-0x0000000180246720
		public bool m_isActive; // 0x78
		private bool m_isInitialised; // 0x79
	
		// Constructors
		public SpawnCritera(); // 0x0000000181561B20-0x0000000181561F10
	
		// Methods
		public void Initialise(Spawner spawner); // 0x0000000181561910-0x0000000181561B20
		public float GetSlopeFitness(float slope); // 0x0000000181561670-0x00000001815616E0
		public float GetHeightFitness(float height, float sealLevel); // 0x0000000181561590-0x0000000181561600
		public float GetProximityFitness(float proximity); // 0x0000000181561600-0x0000000181561670
		public float GetTextureFitness(float[] textures); // 0x00000001815616E0-0x0000000181561910
		public float GetFitness(ref SpawnInfo spawnInfo); // 0x00000001815610D0-0x0000000181561590
	}
}
