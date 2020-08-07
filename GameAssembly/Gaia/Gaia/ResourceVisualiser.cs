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
	public class ResourceVisualiser : UnityEngine.MonoBehaviour // TypeDefIndex: 9218
	{
		// Fields
		[Tooltip] // 0x000000018023D910-0x000000018023D940
		public GaiaResource m_resources; // 0x18
		[Tooltip] // 0x000000018023DAA0-0x000000018023DAD0
		public float m_range; // 0x20
		[Range] // 0x000000018023DBB0-0x000000018023DC10
		[Tooltip] // 0x000000018023DBB0-0x000000018023DC10
		public float m_resolution; // 0x24
		[Range] // 0x000000018023DD30-0x000000018023DD90
		[Tooltip] // 0x000000018023DD30-0x000000018023DD90
		public float m_minimumFitness; // 0x28
		[Tooltip] // 0x000000018023DF70-0x000000018023DFA0
		public LayerMask m_fitnessCollisionLayers; // 0x2C
		[Tooltip] // 0x000000018023E120-0x000000018023E150
		public Color m_fitColour; // 0x30
		[Tooltip] // 0x000000018023E280-0x000000018023E2B0
		public Color m_unfitColour; // 0x40
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public Spawner m_spawner; // 0x50
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public Vector3 m_lastHitPoint; // 0x58
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public string m_lastHitObjectname; // 0x68
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public float m_lastHitFitness; // 0x70
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public float m_lastHitHeight; // 0x74
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public float m_lastHitTerrainHeight; // 0x78
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public float m_lastHitTerrainRelativeHeight; // 0x7C
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public float m_lastHitTerrainSlope; // 0x80
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public float m_lastHitAreaSlope; // 0x84
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public bool m_lastHitWasVirgin; // 0x88
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public GaiaConstants.SpawnerResourceType m_selectedResourceType; // 0x8C
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public int m_selectedResourceIdx; // 0x90
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		private DateTime m_lastUpdateDate; // 0x98
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		private DateTime m_lastCacheUpdateDate; // 0xA0
		private UnityHeightMap m_terrainHeightMap; // 0xA8
	
		// Constructors
		public ResourceVisualiser(); // 0x000000018155B380-0x000000018155B430
	
		// Methods
		private void Awake(); // 0x00000001803CAFE0-0x00000001803CB010
		private void OnEnable(); // 0x000000018155B300-0x000000018155B310
		public void Initialise(); // 0x000000018155A6F0-0x000000018155A860
		public void Visualise(); // 0x000000018155B310-0x000000018155B380
		public SpawnInfo GetSpawnInfo(Vector3 location); // 0x000000018155A5B0-0x000000018155A6F0
		public float GetFitness(ref SpawnInfo spawnInfo); // 0x00000001815599F0-0x0000000181559D60
		public float GetMinFitness(ref SpawnInfo spawnInfo); // 0x000000018155A100-0x000000018155A5B0
		public float GetMaxScaledRadius(ref SpawnInfo spawnInfo); // 0x0000000181559D60-0x000000018155A100
		private void OnDrawGizmos(); // 0x000000018155A860-0x000000018155B300
	}
}
