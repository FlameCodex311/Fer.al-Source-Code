/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gaia.FullSerializer;
using UnityEngine;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia
{
	[ExecuteInEditMode] // 0x00000001800B36B0-0x00000001800B36C0
	public class Spawner : UnityEngine.MonoBehaviour // TypeDefIndex: 9062
	{
		// Fields
		[fsIgnore] // 0x00000001800B36B0-0x00000001800B36C0
		public GaiaResource m_resources; // 0x18
		public string m_resourcesPath; // 0x20
		public string m_spawnerID; // 0x28
		public GaiaConstants.OperationMode m_mode; // 0x30
		public int m_seed; // 0x34
		public GaiaConstants.SpawnerShape m_spawnerShape; // 0x38
		public GaiaConstants.SpawnerRuleSelector m_spawnRuleSelector; // 0x3C
		public GaiaConstants.SpawnerLocation m_spawnLocationAlgorithm; // 0x40
		public GaiaConstants.SpawnerLocationCheckType m_spawnLocationCheckType; // 0x44
		public float m_locationIncrement; // 0x48
		public float m_maxJitteredLocationOffsetPct; // 0x4C
		public int m_locationChecksPerInt; // 0x50
		public int m_maxRandomClusterSize; // 0x54
		public float m_spawnRange; // 0x58
		public AnimationCurve m_spawnFitnessAttenuator; // 0x60
		public GaiaConstants.ImageFitnessFilterMode m_areaMaskMode; // 0x68
		public bool m_enableColliderCacheAtRuntime; // 0x6C
		public Texture2D m_imageMask; // 0x70
		public bool m_imageMaskInvert; // 0x78
		public bool m_imageMaskNormalise; // 0x79
		public bool m_imageMaskFlip; // 0x7A
		public int m_imageMaskSmoothIterations; // 0x7C
		[fsIgnore] // 0x00000001800B36B0-0x00000001800B36C0
		public HeightMap m_imageMaskHM; // 0x80
		private FractalGenerator m_noiseGenerator; // 0x88
		public float m_noiseMaskSeed; // 0x90
		public int m_noiseMaskOctaves; // 0x94
		public float m_noiseMaskPersistence; // 0x98
		public float m_noiseMaskFrequency; // 0x9C
		public float m_noiseMaskLacunarity; // 0xA0
		public float m_noiseZoom; // 0xA4
		public bool m_noiseInvert; // 0xA8
		public float m_spawnInterval; // 0xAC
		public string m_triggerTags; // 0xB0
		public float m_triggerRange; // 0xB8
		public List<SpawnRule> m_spawnerRules; // 0xC0
		public LayerMask m_spawnCollisionLayers; // 0xC8
		public int m_spawnColliderLayer; // 0xCC
		public bool m_showGizmos; // 0xD0
		public bool m_showDebug; // 0xD1
		public bool m_showStatistics; // 0xD2
		public bool m_showTerrainHelper; // 0xD3
		public XorshiftPlus m_rndGenerator; // 0xD8
		private bool m_cacheDetails; // 0xE0
		private Dictionary<int, List<HeightMap>> m_detailMapCache; // 0xE8
		private bool m_cacheTextures; // 0xF0
		private bool m_textureMapsDirty; // 0xF1
		private Dictionary<int, List<HeightMap>> m_textureMapCache; // 0xF8
		private bool m_cacheTags; // 0x100
		private Dictionary<string, Quadtree<GameObject>> m_taggedGameObjectCache; // 0x108
		public TreeManager m_treeCache; // 0x110
		private bool m_cacheHeightMaps; // 0x118
		private bool m_heightMapDirty; // 0x119
		private Dictionary<int, UnityHeightMap> m_heightMapCache; // 0x120
		private Dictionary<string, HeightMap> m_stampCache; // 0x128
		[fsIgnore] // 0x00000001800B36B0-0x00000001800B36C0
		public GameObject m_areaBoundsColliderCache; // 0x130
		[fsIgnore] // 0x00000001800B36B0-0x00000001800B36C0
		public GameObject m_goColliderCache; // 0x138
		[fsIgnore] // 0x00000001800B36B0-0x00000001800B36C0
		public GameObject m_goParentGameObject; // 0x140
		private bool m_cancelSpawn; // 0x148
		public int m_totalRuleCnt; // 0x14C
		public int m_activeRuleCnt; // 0x150
		public int m_inactiveRuleCnt; // 0x154
		public ulong m_maxInstanceCnt; // 0x158
		public ulong m_activeInstanceCnt; // 0x160
		public ulong m_inactiveInstanceCnt; // 0x168
		public ulong m_totalInstanceCnt; // 0x170
		private float m_terrainHeight; // 0x178
		private float m_checkDistance; // 0x17C
		private RaycastHit m_checkHitInfo; // 0x180
		public IEnumerator m_updateCoroutine; // 0x1B0
		public float m_updateTimeAllowed; // 0x1B8
		public float m_spawnProgress; // 0x1BC
		public bool m_spawnComplete; // 0x1C0
		public Bounds m_spawnerBounds; // 0x1C4
		private bool m_isTextureSpawner; // 0x1DC
		private bool m_isDetailSpawner; // 0x1DD
		private bool m_isTreeSpawnwer; // 0x1DE
		private bool m_isGameObjectSpawner; // 0x1DF
	
		// Nested types
		private class SpawnLocation // TypeDefIndex: 9063
		{
			// Fields
			public Vector3 m_location; // 0x10
			public float m_seedDistance; // 0x1C
	
			// Constructors
			public SpawnLocation(); // 0x000000018036B6C0-0x000000018036B6D0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <RunRandomSpawnerIteration>d__100 : IEnumerator<object> // TypeDefIndex: 9064
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Spawner <>4__this; // 0x20
			private SpawnInfo <spawnInfo>5__2; // 0x28
			private List<SpawnLocation> <spawnLocations>5__3; // 0x30
			private int <spawnLocationsIdx>5__4; // 0x38
			private int <failedSpawns>5__5; // 0x3C
			private float <currentTime>5__6; // 0x40
			private float <accumulatedTime>5__7; // 0x44
			private int <checks>5__8; // 0x48
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <RunRandomSpawnerIteration>d__100(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181C06930-0x0000000181C074D0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181C074D0-0x0000000181C07520
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <RunAreaSpawnerIteration>d__101 : IEnumerator<object> // TypeDefIndex: 9065
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Spawner <>4__this; // 0x20
			private SpawnInfo <spawnInfo>5__2; // 0x28
			private long <currChecks>5__3; // 0x30
			private long <totalChecks>5__4; // 0x38
			private float <xWUMax>5__5; // 0x40
			private float <yMid>5__6; // 0x44
			private float <zWUMin>5__7; // 0x48
			private float <zWUMax>5__8; // 0x4C
			private float <jitMin>5__9; // 0x50
			private float <jitMax>5__10; // 0x54
			private float <xWU>5__11; // 0x58
			private float <zWU>5__12; // 0x5C
			private float <currentTime>5__13; // 0x60
			private float <accumulatedTime>5__14; // 0x64
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <RunAreaSpawnerIteration>d__101(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181C05F40-0x0000000181C068E0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181C068E0-0x0000000181C06930
		}
	
		// Constructors
		public Spawner(); // 0x00000001817AAAA0-0x00000001817AAE40
	
		// Methods
		private void OnEnable(); // 0x00000001817A7F70-0x00000001817A8020
		private void OnDisable(); // 0x00000001803581E0-0x00000001803581F0
		public void StartEditorUpdates(); // 0x00000001803581E0-0x00000001803581F0
		public void StopEditorUpdates(); // 0x00000001803581E0-0x00000001803581F0
		private void EditorUpdate(); // 0x00000001803581E0-0x00000001803581F0
		private void Start(); // 0x00000001817AA2E0-0x00000001817AA4B0
		public void Initialise(); // 0x00000001817A6000-0x00000001817A68B0
		private void PreSpawnInitialise(); // 0x00000001817A8040-0x00000001817A86A0
		public void SetUpSpawnerTypeFlags(); // 0x00000001817A9FD0-0x00000001817AA250
		public void AssociateAssets(); // 0x00000001817A03C0-0x00000001817A04A0
		public int[] GetMissingResources(); // 0x00000001817A5830-0x00000001817A59C0
		public void AddResourcesToTerrain(int[] rules); // 0x000000018179FF90-0x00000001817A0110
		private void PostSpawn(); // 0x00000001817A8020-0x00000001817A8040
		public bool IsTextureSpawner(); // 0x00000001817A6B30-0x00000001817A6B40
		public bool IsDetailSpawner(); // 0x00000001817A68B0-0x00000001817A68C0
		public bool IsTreeSpawner(); // 0x00000001817A6B40-0x00000001817A6B50
		public bool IsGameObjectSpawner(); // 0x00000001817A6B10-0x00000001817A6B20
		public void ResetSpawner(); // 0x00000001817A8710-0x00000001817A8720
		public void CancelSpawn(); // 0x00000001817A1180-0x00000001817A11A0
		public bool IsSpawning(); // 0x00000001817A6B20-0x00000001817A6B30
		private bool CanSpawnInstances(); // 0x00000001817A10A0-0x00000001817A1180
		public void RunSpawnerIteration(); // 0x00000001817A8800-0x00000001817A90D0
		[IteratorStateMachine] // 0x00000001800E8D10-0x00000001800E8D60
		public IEnumerator RunRandomSpawnerIteration(); // 0x00000001817A8790-0x00000001817A8800
		[IteratorStateMachine] // 0x00000001800E9000-0x00000001800E9050
		public IEnumerator RunAreaSpawnerIteration(); // 0x00000001817A8720-0x00000001817A8790
		public void GroundToTerrain(); // 0x00000001817A5D70-0x00000001817A6000
		public void FitToTerrain(); // 0x00000001817A4D10-0x00000001817A4FA0
		public bool IsFitToTerrain(); // 0x00000001817A68C0-0x00000001817A6B10
		public bool LoadImageMask(); // 0x00000001817A6B50-0x00000001817A7A00
		public void CreateSpawnCaches(); // 0x00000001817A44C0-0x00000001817A4830
		public void CreateSpawnCaches(GaiaConstants.SpawnerResourceType resourceType, int resourceIdx); // 0x00000001817A3E90-0x00000001817A44C0
		public void DeleteSpawnCaches(bool flushDirty = false /* Metadata: 0x00744221 */); // 0x00000001817A4A40-0x00000001817A4C50
		public bool TryExecuteRule(ref SpawnRule rule, ref SpawnInfo spawnInfo); // 0x00000001817AA4B0-0x00000001817AA8F0
		public bool CheckLocation(Vector3 locationWU, ref SpawnInfo spawnInfo); // 0x00000001817A2F60-0x00000001817A3DF0
		public bool CheckLocationBounds(ref SpawnInfo spawnInfo, float distance); // 0x00000001817A11A0-0x00000001817A2F60
		public void UpdateCounters(); // 0x00000001817AA8F0-0x00000001817AAAA0
		private void OnDrawGizmosSelected(); // 0x00000001817A7A00-0x00000001817A7F70
		public void CacheTextureMapsFromTerrain(int terrainID); // 0x00000001817A0DD0-0x00000001817A1070
		public List<HeightMap> GetTextureMaps(int terrainID); // 0x00000001817A5CF0-0x00000001817A5D70
		public void SaveTextureMapsToTerrain(int terrainID); // 0x00000001817A9AA0-0x00000001817A9F20
		public void DeleteTextureMapCache(); // 0x00000001817A4C50-0x00000001817A4CB0
		public void SetTextureMapsDirty(); // 0x00000001817A9FC0-0x00000001817A9FD0
		public void CacheDetailMapsFromTerrain(int terrainID); // 0x00000001817A04A0-0x00000001817A0760
		public void SaveDetailMapsToTerrain(int terrainID); // 0x00000001817A90D0-0x00000001817A98E0
		public List<HeightMap> GetDetailMaps(int terrainID); // 0x00000001817A5730-0x00000001817A57B0
		public HeightMap GetDetailMap(int terrainID, int detailIndex); // 0x00000001817A5670-0x00000001817A5730
		public void DeleteDetailMapCache(); // 0x00000001817A4980-0x00000001817A49E0
		public void CacheTreesFromTerrain(); // 0x00000001817A1070-0x00000001817A10A0
		public void DeleteTreeCache(); // 0x00000001817A4CB0-0x00000001817A4D10
		public void AddToSession(GaiaOperation.OperationType opType, string opName); // 0x00000001817A0110-0x00000001817A03C0
		public string SerialiseJson(); // 0x00000001817A9F20-0x00000001817A9FB0
		public void DeSerialiseJson(string json); // 0x00000001817A4830-0x00000001817A4980
		public void FlattenTerrain(); // 0x00000001817A4FA0-0x00000001817A5030
		public void SmoothTerrain(); // 0x00000001817AA250-0x00000001817AA2E0
		public void ClearTrees(); // 0x00000001817A3E40-0x00000001817A3E90
		public void ClearDetails(); // 0x00000001817A3DF0-0x00000001817A3E40
		public void CacheHeightMapFromTerrain(int terrainID); // 0x00000001817A0760-0x00000001817A08F0
		public UnityHeightMap GetHeightMap(int terrainID); // 0x00000001817A57B0-0x00000001817A5830
		public void SaveHeightMapToTerrain(int terrainID); // 0x00000001817A98E0-0x00000001817A9AA0
		public void DeleteHeightMapCache(); // 0x00000001817A49E0-0x00000001817A4A40
		public void SetHeightMapsDirty(); // 0x00000001817A9FB0-0x00000001817A9FC0
		public void CacheStamps(List<string> stampList); // 0x00000001817A08F0-0x00000001817A0980
		private void CacheTaggedGameObjectsFromScene(List<string> tagList); // 0x00000001817A0980-0x00000001817A0DD0
		private void DeleteTagCache(); // 0x0000000181406600-0x0000000181406610
		public List<GameObject> GetNearbyObjects(List<string> tagList, Rect area); // 0x00000001817A59C0-0x00000001817A5C30
		public GameObject GetClosestObject(List<string> tagList, Rect area); // 0x00000001817A5030-0x00000001817A53A0
		public GameObject GetClosestObject(string tag, Rect area); // 0x00000001817A53A0-0x00000001817A5670
		public void ResetRandomGenertor(); // 0x00000001817A86A0-0x00000001817A8710
		public int GetRandomInt(int min, int max); // 0x00000001817A5C60-0x00000001817A5C90
		public float GetRandomFloat(float min, float max); // 0x00000001817A5C30-0x00000001817A5C60
		public Vector3 GetRandomV3(float range); // 0x00000001817A5C90-0x00000001817A5CF0
	}
}
