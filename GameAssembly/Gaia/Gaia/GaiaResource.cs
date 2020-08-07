/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia
{
	[Serializable]
	public class GaiaResource : ScriptableObject // TypeDefIndex: 9203
	{
		// Fields
		[HideInInspector] // 0x000000018022BC70-0x000000018022BCC0
		[Tooltip] // 0x000000018022BC70-0x000000018022BCC0
		public string m_resourcesID; // 0x18
		[Tooltip] // 0x000000018022BE80-0x000000018022BEB0
		public string m_name; // 0x20
		[Tooltip] // 0x000000018022C1F0-0x000000018022C220
		public float m_seaLevel; // 0x28
		[Tooltip] // 0x000000018022C400-0x000000018022C430
		public float m_beachHeight; // 0x2C
		[Tooltip] // 0x000000018022C730-0x000000018022C760
		public float m_terrainHeight; // 0x30
		[Tooltip] // 0x000000018022C8F0-0x000000018022C920
		public ResourceProtoTexture[] m_texturePrototypes; // 0x38
		[Tooltip] // 0x000000018022CB30-0x000000018022CB60
		public ResourceProtoDetail[] m_detailPrototypes; // 0x40
		[Tooltip] // 0x000000018022CDC0-0x000000018022CDF0
		public ResourceProtoTree[] m_treePrototypes; // 0x48
		[Tooltip] // 0x000000018022D0D0-0x000000018022D100
		public ResourceProtoGameObject[] m_gameObjectPrototypes; // 0x50
	
		// Constructors
		public GaiaResource(); // 0x0000000180E48440-0x0000000180E48530
	
		// Methods
		public bool SetAssetAssociations(); // 0x0000000180E40E60-0x0000000180E41100
		public bool AssociateAssets(); // 0x0000000180E40E60-0x0000000180E41100
		public void DeletePrototypes(); // 0x0000000180E45090-0x0000000180E45110
		public bool PrototypesMissingFromTerrain(); // 0x0000000180E45C30-0x0000000180E45F70
		public bool PrototypeMissingFromTerrain(GaiaConstants.SpawnerResourceType resourceType, int resourceIdx); // 0x0000000180E45C10-0x0000000180E45C30
		public int PrototypeIdxInTerrain(GaiaConstants.SpawnerResourceType resourceType, int resourceIdx); // 0x0000000180E45800-0x0000000180E45C10
		public bool ResourceIdxOutOfBounds(GaiaConstants.SpawnerResourceType resourceType, int resourceIdx); // 0x0000000180E45F70-0x0000000180E46000
		public bool ResourceIsInUnity(GaiaConstants.SpawnerResourceType resourceType, int resourceIdx); // 0x0000000180E46000-0x0000000180E46290
		public void UpdatePrototypesFromTerrain(); // 0x0000000180E46650-0x0000000180E48440
		private string GetUniqueName(string name, ref Dictionary<string, string> names); // 0x0000000180E45730-0x0000000180E45800
		private void UpdateDNA(GameObject prefab, ref ResourceProtoDNA dna); // 0x0000000180E46320-0x0000000180E46650
		public void ChangeHeight(float oldHeight, float newHeight); // 0x0000000180E41100-0x0000000180E41460
		public void ChangeSeaLevel(float newSeaLevel); // 0x0000000180E41880-0x0000000180E418A0
		public void ChangeSeaLevel(float oldSeaLevel, float newSeaLevel); // 0x0000000180E41460-0x0000000180E41880
		public void ApplyPrototypesToTerrain(); // 0x0000000180E40DE0-0x0000000180E40E60
		public void ApplyPrototypesToTerrain(Terrain terrain); // 0x0000000180E40650-0x0000000180E40DE0
		public void AddMissingPrototypesToTerrain(); // 0x0000000180E3F4A0-0x0000000180E3F520
		public void AddMissingPrototypesToTerrain(Terrain terrain); // 0x0000000180E3F520-0x0000000180E40030
		public void AddPrototypeToTerrain(GaiaConstants.SpawnerResourceType resourceType, int resourceIdx); // 0x0000000180E405B0-0x0000000180E40650
		public void AddPrototypeToTerrain(GaiaConstants.SpawnerResourceType resourceType, int resourceIdx, Terrain terrain); // 0x0000000180E40030-0x0000000180E405B0
		public bool ChecksTextures(); // 0x0000000180E41AE0-0x0000000180E41D20
		public bool ChecksProximity(); // 0x0000000180E418A0-0x0000000180E41AE0
		public void AddGameObject(GameObject prefab); // 0x0000000180E3F3A0-0x0000000180E3F430
		public void AddGameObject(List<GameObject> prototypes); // 0x0000000180E3F430-0x0000000180E3F4A0
		public GameObject CreateCoverageTextureSpawner(float range, float increment); // 0x0000000180E44430-0x0000000180E449A0
		public GameObject CreateCoverageDetailSpawner(float range, float increment); // 0x0000000180E431F0-0x0000000180E43930
		public GameObject CreateOrFindGaia(); // 0x0000000180E44EF0-0x0000000180E44F80
		public GameObject CreateOrFindSessionManager(); // 0x0000000180E44F80-0x0000000180E44FF0
		public GameObject CreateClusteredDetailSpawner(float range, float increment); // 0x0000000180E41D20-0x0000000180E422B0
		public GameObject CreateClusteredTreeSpawner(float range); // 0x0000000180E42CB0-0x0000000180E431F0
		public GameObject CreateCoverageTreeSpawner(float range); // 0x0000000180E449A0-0x0000000180E44EF0
		public GameObject CreateCoverageGameObjectSpawner(float range); // 0x0000000180E43EE0-0x0000000180E44430
		public GameObject CreateCoverageGameObjectSpawnerForTrees(float range); // 0x0000000180E43930-0x0000000180E43EE0
		public GameObject CreateClusteredGameObjectSpawner(float range); // 0x0000000180E427E0-0x0000000180E42CB0
		public GameObject CreateClusteredGameObjectSpawnerForTrees(float range); // 0x0000000180E422B0-0x0000000180E427E0
		public void ExportTexture(); // 0x0000000180E45110-0x0000000180E45730
		public string SerialiseJson(); // 0x0000000180E46290-0x0000000180E46320
		public void DeSerialiseJson(string json); // 0x0000000180E44FF0-0x0000000180E45090
	}
}
