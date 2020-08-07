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

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia
{
	[ExecuteInEditMode] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class Spawner : UnityEngine.MonoBehaviour // TypeDefIndex: 9233
	{
		// Fields
		[fsIgnore] // 0x00000001801CDAD0-0x00000001801CDAE0
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
		[fsIgnore] // 0x00000001801CDAD0-0x00000001801CDAE0
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
		[fsIgnore] // 0x00000001801CDAD0-0x00000001801CDAE0
		public GameObject m_areaBoundsColliderCache; // 0x130
		[fsIgnore] // 0x00000001801CDAD0-0x00000001801CDAE0
		public GameObject m_goColliderCache; // 0x138
		[fsIgnore] // 0x00000001801CDAD0-0x00000001801CDAE0
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
		private class SpawnLocation // TypeDefIndex: 9234
		{
			// Fields
			public Vector3 m_location; // 0x10
			public float m_seedDistance; // 0x1C
	
			// Constructors
			public SpawnLocation(); // 0x0000000180373240-0x0000000180373250
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <RunRandomSpawnerIteration>d__100 : IEnumerator<object> // TypeDefIndex: 9235
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <RunRandomSpawnerIteration>d__100(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001816FBB80-0x00000001816FC6F0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001816FC6F0-0x00000001816FC740
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <RunAreaSpawnerIteration>d__101 : IEnumerator<object> // TypeDefIndex: 9236
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <RunAreaSpawnerIteration>d__101(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001815728C0-0x0000000181573280
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000181573280-0x00000001815732D0
		}
	
		// Constructors
		public Spawner(); // 0x0000000181572520-0x00000001815728C0
	
		// Methods
		private void OnEnable(); // 0x000000018156FC20-0x000000018156FCD0
		private void OnDisable(); // 0x00000001803774A0-0x00000001803774B0
		public void StartEditorUpdates(); // 0x00000001803774A0-0x00000001803774B0
		public void StopEditorUpdates(); // 0x00000001803774A0-0x00000001803774B0
		private void EditorUpdate(); // 0x00000001803774A0-0x00000001803774B0
		private void Start(); // 0x0000000181571D80-0x0000000181571F40
		public void Initialise(); // 0x000000018156DF20-0x000000018156E7A0
		private void PreSpawnInitialise(); // 0x000000018156FCF0-0x0000000181570330
		public void SetUpSpawnerTypeFlags(); // 0x0000000181571A80-0x0000000181571CF0
		public void AssociateAssets(); // 0x0000000181568590-0x0000000181568670
		public int[] GetMissingResources(); // 0x000000018156D780-0x000000018156D910
		public void AddResourcesToTerrain(int[] rules); // 0x0000000181568170-0x00000001815682F0
		private void PostSpawn(); // 0x000000018156FCD0-0x000000018156FCF0
		public bool IsTextureSpawner(); // 0x000000018156EA10-0x000000018156EA20
		public bool IsDetailSpawner(); // 0x000000018156E7A0-0x000000018156E7B0
		public bool IsTreeSpawner(); // 0x000000018156EA20-0x000000018156EA30
		public bool IsGameObjectSpawner(); // 0x000000018156E9F0-0x000000018156EA00
		public void ResetSpawner(); // 0x00000001815703A0-0x00000001815703B0
		public void CancelSpawn(); // 0x00000001815692E0-0x0000000181569300
		public bool IsSpawning(); // 0x000000018156EA00-0x000000018156EA10
		private bool CanSpawnInstances(); // 0x0000000181569210-0x00000001815692E0
		public void RunSpawnerIteration(); // 0x0000000181570480-0x0000000181570C10
		[IteratorStateMachine] // 0x0000000180248B80-0x0000000180248BD0
		public IEnumerator RunRandomSpawnerIteration(); // 0x0000000181570410-0x0000000181570480
		[IteratorStateMachine] // 0x0000000180248EC0-0x0000000180248F10
		public IEnumerator RunAreaSpawnerIteration(); // 0x00000001815703B0-0x0000000181570410
		public void GroundToTerrain(); // 0x000000018156DCA0-0x000000018156DF20
		public void FitToTerrain(); // 0x000000018156CC80-0x000000018156CF10
		public bool IsFitToTerrain(); // 0x000000018156E7B0-0x000000018156E9F0
		public bool LoadImageMask(); // 0x000000018156EA30-0x000000018156F6C0
		public void CreateSpawnCaches(); // 0x000000018156C450-0x000000018156C7A0
		public void CreateSpawnCaches(GaiaConstants.SpawnerResourceType resourceType, int resourceIdx); // 0x000000018156BE60-0x000000018156C450
		public void DeleteSpawnCaches(bool flushDirty = false /* Metadata: 0x00778F0F */); // 0x000000018156C9B0-0x000000018156CBB0
		public bool TryExecuteRule(ref SpawnRule rule, ref SpawnInfo spawnInfo); // 0x0000000181571F40-0x0000000181572370
		public bool CheckLocation(Vector3 locationWU, ref SpawnInfo spawnInfo); // 0x000000018156AFB0-0x000000018156BDC0
		public bool CheckLocationBounds(ref SpawnInfo spawnInfo, float distance); // 0x0000000181569300-0x000000018156AFB0
		public void UpdateCounters(); // 0x0000000181572370-0x0000000181572520
		private void OnDrawGizmosSelected(); // 0x000000018156F6C0-0x000000018156FC20
		public void CacheTextureMapsFromTerrain(int terrainID); // 0x0000000181568F60-0x00000001815691E0
		public List<HeightMap> GetTextureMaps(int terrainID); // 0x000000018156DC20-0x000000018156DCA0
		public void SaveTextureMapsToTerrain(int terrainID); // 0x0000000181571570-0x00000001815719D0
		public void DeleteTextureMapCache(); // 0x000000018156CBC0-0x000000018156CC20
		public void SetTextureMapsDirty(); // 0x0000000181571A70-0x0000000181571A80
		public void CacheDetailMapsFromTerrain(int terrainID); // 0x0000000181568670-0x0000000181568920
		public void SaveDetailMapsToTerrain(int terrainID); // 0x0000000181570C10-0x00000001815713C0
		public List<HeightMap> GetDetailMaps(int terrainID); // 0x000000018156D680-0x000000018156D700
		public HeightMap GetDetailMap(int terrainID, int detailIndex); // 0x000000018156D5C0-0x000000018156D680
		public void DeleteDetailMapCache(); // 0x000000018156C8F0-0x000000018156C950
		public void CacheTreesFromTerrain(); // 0x00000001815691E0-0x0000000181569210
		public void DeleteTreeCache(); // 0x000000018156CC20-0x000000018156CC80
		public void AddToSession(GaiaOperation.OperationType opType, string opName); // 0x00000001815682F0-0x0000000181568590
		public string SerialiseJson(); // 0x00000001815719D0-0x0000000181571A60
		public void DeSerialiseJson(string json); // 0x000000018156C7A0-0x000000018156C8F0
		public void FlattenTerrain(); // 0x000000018156CF10-0x000000018156CFA0
		public void SmoothTerrain(); // 0x0000000181571CF0-0x0000000181571D80
		public void ClearTrees(); // 0x000000018156BE10-0x000000018156BE60
		public void ClearDetails(); // 0x000000018156BDC0-0x000000018156BE10
		public void CacheHeightMapFromTerrain(int terrainID); // 0x0000000181568920-0x0000000181568AA0
		public UnityHeightMap GetHeightMap(int terrainID); // 0x000000018156D700-0x000000018156D780
		public void SaveHeightMapToTerrain(int terrainID); // 0x00000001815713C0-0x0000000181571570
		public void DeleteHeightMapCache(); // 0x000000018156C950-0x000000018156C9B0
		public void SetHeightMapsDirty(); // 0x0000000181571A60-0x0000000181571A70
		public void CacheStamps(List<string> stampList); // 0x0000000181568AA0-0x0000000181568B30
		private void CacheTaggedGameObjectsFromScene(List<string> tagList); // 0x0000000181568B30-0x0000000181568F60
		private void DeleteTagCache(); // 0x000000018156CBB0-0x000000018156CBC0
		public List<GameObject> GetNearbyObjects(List<string> tagList, Rect area); // 0x000000018156D910-0x000000018156DB70
		public GameObject GetClosestObject(List<string> tagList, Rect area); // 0x000000018156CFA0-0x000000018156D300
		public GameObject GetClosestObject(string tag, Rect area); // 0x000000018156D300-0x000000018156D5C0
		public void ResetRandomGenertor(); // 0x0000000181570330-0x00000001815703A0
		public int GetRandomInt(int min, int max); // 0x000000018156DBA0-0x000000018156DBD0
		public float GetRandomFloat(float min, float max); // 0x000000018156DB70-0x000000018156DBA0
		public Vector3 GetRandomV3(float range); // 0x000000018156DBD0-0x000000018156DC20
	}
}
