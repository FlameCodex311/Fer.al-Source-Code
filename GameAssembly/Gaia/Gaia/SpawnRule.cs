/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gaia.FullSerializer;
using UnityEngine;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia
{
	[Serializable]
	public class SpawnRule // TypeDefIndex: 9231
	{
		// Fields
		public string m_name; // 0x10
		public bool m_useExtendedSpawn; // 0x18
		public float m_minViableFitness; // 0x1C
		public float m_failureRate; // 0x20
		public ulong m_maxInstances; // 0x28
		public bool m_ignoreMaxInstances; // 0x30
		public float m_minDirection; // 0x34
		public float m_maxDirection; // 0x38
		public GaiaConstants.SpawnerResourceType m_resourceType; // 0x3C
		public int m_resourceIdx; // 0x40
		[fsIgnore] // 0x00000001801CDAD0-0x00000001801CDAE0
		public int m_resourceIdxPhysical; // 0x44
		[fsIgnore] // 0x00000001801CDAD0-0x00000001801CDAE0
		public Transform m_spawnParent; // 0x48
		[fsIgnore] // 0x00000001801CDAD0-0x00000001801CDAE0
		public string m_colliderName; // 0x50
		public GaiaConstants.NoiseType m_noiseMask; // 0x58
		public float m_noiseMaskSeed; // 0x5C
		public int m_noiseMaskOctaves; // 0x60
		public float m_noiseMaskPersistence; // 0x64
		public float m_noiseMaskFrequency; // 0x68
		public float m_noiseMaskLacunarity; // 0x6C
		public float m_noiseZoom; // 0x70
		public float m_noiseStrength; // 0x74
		public bool m_noiseInvert; // 0x78
		private FractalGenerator m_noiseGenerator; // 0x80
		public bool m_isActive; // 0x88
		public bool m_isFoldedOut; // 0x89
		public ulong m_currInstanceCnt; // 0x90
		public ulong m_activeInstanceCnt; // 0x98
		public ulong m_inactiveInstanceCnt; // 0xA0
	
		// Constructors
		public SpawnRule(); // 0x0000000181567970-0x0000000181567A00
	
		// Methods
		public void Initialise(Spawner spawner); // 0x0000000181564810-0x0000000181565370
		public bool ResourceIsInUnity(Spawner spawner); // 0x0000000181565370-0x00000001815653B0
		public bool ResourceIsLoadedInTerrain(Spawner spawner); // 0x00000001815653B0-0x00000001815653F0
		public void AddResourceToTerrain(Spawner spawner); // 0x0000000181562840-0x0000000181562880
		public float GetFitness(ref SpawnInfo spawnInfo); // 0x00000001815638B0-0x0000000181564060
		public float GetRadius(ref SpawnInfo spawnInfo); // 0x0000000181564410-0x0000000181564610
		public float GetMaxScaledRadius(ref SpawnInfo spawnInfo); // 0x0000000181564060-0x0000000181564410
		public float GetSeedThrowRange(ref SpawnInfo spawnInfo); // 0x0000000181564610-0x0000000181564810
		public void Spawn(ref SpawnInfo spawnInfo); // 0x00000001815653F0-0x0000000181567970
		public bool CacheHeightMaps(Spawner spawner); // 0x0000000180380950-0x0000000180380960
		public bool CacheTextures(Spawner spawner); // 0x0000000181563280-0x00000001815638B0
		public bool CacheDetails(Spawner spawner); // 0x0000000181562880-0x0000000181562F30
		public bool CacheProximity(Spawner spawner); // 0x0000000181562F30-0x0000000181563280
		public void AddProximityTags(Spawner spawner, ref List<string> tagList); // 0x0000000181562630-0x0000000181562840
	}
}
