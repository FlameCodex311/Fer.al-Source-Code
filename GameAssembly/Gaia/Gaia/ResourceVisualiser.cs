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
	public class ResourceVisualiser : UnityEngine.MonoBehaviour // TypeDefIndex: 9052
	{
		// Fields
		[Tooltip] // 0x00000001800DECB0-0x00000001800DECE0
		public GaiaResource m_resources; // 0x18
		[Tooltip] // 0x00000001800DEEF0-0x00000001800DEF20
		public float m_range; // 0x20
		[Range] // 0x00000001800DF160-0x00000001800DF1C0
		[Tooltip] // 0x00000001800DF160-0x00000001800DF1C0
		public float m_resolution; // 0x24
		[Range] // 0x00000001800DF530-0x00000001800DF590
		[Tooltip] // 0x00000001800DF530-0x00000001800DF590
		public float m_minimumFitness; // 0x28
		[Tooltip] // 0x00000001800DF810-0x00000001800DF840
		public LayerMask m_fitnessCollisionLayers; // 0x2C
		[Tooltip] // 0x00000001800DFAD0-0x00000001800DFB00
		public Color m_fitColour; // 0x30
		[Tooltip] // 0x00000001800DFC10-0x00000001800DFC40
		public Color m_unfitColour; // 0x40
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public Spawner m_spawner; // 0x50
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public Vector3 m_lastHitPoint; // 0x58
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public string m_lastHitObjectname; // 0x68
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public float m_lastHitFitness; // 0x70
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public float m_lastHitHeight; // 0x74
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public float m_lastHitTerrainHeight; // 0x78
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public float m_lastHitTerrainRelativeHeight; // 0x7C
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public float m_lastHitTerrainSlope; // 0x80
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public float m_lastHitAreaSlope; // 0x84
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public bool m_lastHitWasVirgin; // 0x88
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public GaiaConstants.SpawnerResourceType m_selectedResourceType; // 0x8C
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public int m_selectedResourceIdx; // 0x90
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		private DateTime m_lastUpdateDate; // 0x98
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		private DateTime m_lastCacheUpdateDate; // 0xA0
		private UnityHeightMap m_terrainHeightMap; // 0xA8
	
		// Constructors
		public ResourceVisualiser(); // 0x0000000181792460-0x0000000181792510
	
		// Methods
		private void Awake(); // 0x0000000180E816A0-0x0000000180E816D0
		private void OnEnable(); // 0x00000001817923E0-0x00000001817923F0
		public void Initialise(); // 0x0000000181791790-0x0000000181791910
		public void Visualise(); // 0x00000001817923F0-0x0000000181792460
		public SpawnInfo GetSpawnInfo(Vector3 location); // 0x0000000181791650-0x0000000181791790
		public float GetFitness(ref SpawnInfo spawnInfo); // 0x00000001817909C0-0x0000000181790D60
		public float GetMinFitness(ref SpawnInfo spawnInfo); // 0x0000000181791160-0x0000000181791650
		public float GetMaxScaledRadius(ref SpawnInfo spawnInfo); // 0x0000000181790D60-0x0000000181791160
		private void OnDrawGizmos(); // 0x0000000181791910-0x00000001817923E0
	}
}
