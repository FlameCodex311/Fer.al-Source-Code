/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gaia.FullSerializer;
using UnityEngine;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia
{
	[Serializable]
	public class SpawnRule // TypeDefIndex: 9072
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
		[fsIgnore] // 0x00000001800B36B0-0x00000001800B36C0
		public int m_resourceIdxPhysical; // 0x44
		[fsIgnore] // 0x00000001800B36B0-0x00000001800B36C0
		public Transform m_spawnParent; // 0x48
		[fsIgnore] // 0x00000001800B36B0-0x00000001800B36C0
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
		public SpawnRule(); // 0x000000018179F620-0x000000018179F6B0
	
		// Methods
		public void Initialise(Spawner spawner); // 0x000000018179C2D0-0x000000018179CEC0
		public bool ResourceIsInUnity(Spawner spawner); // 0x000000018179CEC0-0x000000018179CF00
		public bool ResourceIsLoadedInTerrain(Spawner spawner); // 0x000000018179CF00-0x000000018179CF50
		public void AddResourceToTerrain(Spawner spawner); // 0x0000000181799F70-0x0000000181799FB0
		public float GetFitness(ref SpawnInfo spawnInfo); // 0x000000018179B240-0x000000018179BA60
		public float GetRadius(ref SpawnInfo spawnInfo); // 0x000000018179BE70-0x000000018179C0A0
		public float GetMaxScaledRadius(ref SpawnInfo spawnInfo); // 0x000000018179BA60-0x000000018179BE70
		public float GetSeedThrowRange(ref SpawnInfo spawnInfo); // 0x000000018179C0A0-0x000000018179C2D0
		public void Spawn(ref SpawnInfo spawnInfo); // 0x000000018179CF50-0x000000018179F620
		public bool CacheHeightMaps(Spawner spawner); // 0x00000001803C28F0-0x00000001803C2900
		public bool CacheTextures(Spawner spawner); // 0x000000018179ABC0-0x000000018179B240
		public bool CacheDetails(Spawner spawner); // 0x0000000181799FB0-0x000000018179A6C0
		public bool CacheProximity(Spawner spawner); // 0x000000018179A6C0-0x000000018179ABC0
		public void AddProximityTags(Spawner spawner, ref List<string> tagList); // 0x0000000181799D40-0x0000000181799F70
	}
}
