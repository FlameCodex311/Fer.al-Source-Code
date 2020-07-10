/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia
{
	[Serializable]
	public class GaiaResource : ScriptableObject // TypeDefIndex: 9037
	{
		// Fields
		[HideInInspector] // 0x00000001800CB350-0x00000001800CB3A0
		[Tooltip] // 0x00000001800CB350-0x00000001800CB3A0
		public string m_resourcesID; // 0x18
		[Tooltip] // 0x00000001800CB700-0x00000001800CB730
		public string m_name; // 0x20
		[Tooltip] // 0x00000001800CBA00-0x00000001800CBA30
		public float m_seaLevel; // 0x28
		[Tooltip] // 0x00000001800CBD60-0x00000001800CBD90
		public float m_beachHeight; // 0x2C
		[Tooltip] // 0x00000001800CBEA0-0x00000001800CBED0
		public float m_terrainHeight; // 0x30
		[Tooltip] // 0x00000001800CC0C0-0x00000001800CC0F0
		public ResourceProtoTexture[] m_texturePrototypes; // 0x38
		[Tooltip] // 0x00000001800CC250-0x00000001800CC280
		public ResourceProtoDetail[] m_detailPrototypes; // 0x40
		[Tooltip] // 0x00000001800CC6B0-0x00000001800CC6E0
		public ResourceProtoTree[] m_treePrototypes; // 0x48
		[Tooltip] // 0x00000001800CC880-0x00000001800CC8B0
		public ResourceProtoGameObject[] m_gameObjectPrototypes; // 0x50
	
		// Constructors
		public GaiaResource(); // 0x00000001815919D0-0x0000000181591AC0
	
		// Methods
		public bool SetAssetAssociations(); // 0x000000018158A050-0x000000018158A300
		public bool AssociateAssets(); // 0x000000018158A050-0x000000018158A300
		public void DeletePrototypes(); // 0x000000018158E480-0x000000018158E500
		public bool PrototypesMissingFromTerrain(); // 0x000000018158F080-0x000000018158F3D0
		public bool PrototypeMissingFromTerrain(GaiaConstants.SpawnerResourceType resourceType, int resourceIdx); // 0x000000018158F060-0x000000018158F080
		public int PrototypeIdxInTerrain(GaiaConstants.SpawnerResourceType resourceType, int resourceIdx); // 0x000000018158EC20-0x000000018158F060
		public bool ResourceIdxOutOfBounds(GaiaConstants.SpawnerResourceType resourceType, int resourceIdx); // 0x000000018158F3D0-0x000000018158F460
		public bool ResourceIsInUnity(GaiaConstants.SpawnerResourceType resourceType, int resourceIdx); // 0x000000018158F460-0x000000018158F710
		public void UpdatePrototypesFromTerrain(); // 0x000000018158FAF0-0x00000001815919D0
		private string GetUniqueName(string name, ref Dictionary<string, string> names); // 0x000000018158EB50-0x000000018158EC20
		private void UpdateDNA(GameObject prefab, ref ResourceProtoDNA dna); // 0x000000018158F7A0-0x000000018158FAF0
		public void ChangeHeight(float oldHeight, float newHeight); // 0x000000018158A300-0x000000018158A690
		public void ChangeSeaLevel(float newSeaLevel); // 0x000000018158AAF0-0x000000018158AB10
		public void ChangeSeaLevel(float oldSeaLevel, float newSeaLevel); // 0x000000018158A690-0x000000018158AAF0
		public void ApplyPrototypesToTerrain(); // 0x0000000181589FD0-0x000000018158A050
		public void ApplyPrototypesToTerrain(Terrain terrain); // 0x0000000181589810-0x0000000181589FD0
		public void AddMissingPrototypesToTerrain(); // 0x00000001815885E0-0x0000000181588660
		public void AddMissingPrototypesToTerrain(Terrain terrain); // 0x0000000181588660-0x00000001815891C0
		public void AddPrototypeToTerrain(GaiaConstants.SpawnerResourceType resourceType, int resourceIdx); // 0x0000000181589770-0x0000000181589810
		public void AddPrototypeToTerrain(GaiaConstants.SpawnerResourceType resourceType, int resourceIdx, Terrain terrain); // 0x00000001815891C0-0x0000000181589770
		public bool ChecksTextures(); // 0x000000018158AD70-0x000000018158AFD0
		public bool ChecksProximity(); // 0x000000018158AB10-0x000000018158AD70
		public void AddGameObject(GameObject prefab); // 0x00000001815884E0-0x0000000181588570
		public void AddGameObject(List<GameObject> prototypes); // 0x0000000181588570-0x00000001815885E0
		public GameObject CreateCoverageTextureSpawner(float range, float increment); // 0x000000018158D7D0-0x000000018158DD60
		public GameObject CreateCoverageDetailSpawner(float range, float increment); // 0x000000018158C530-0x000000018158CC90
		public GameObject CreateOrFindGaia(); // 0x000000018158E2D0-0x000000018158E360
		public GameObject CreateOrFindSessionManager(); // 0x000000018158E360-0x000000018158E3D0
		public GameObject CreateClusteredDetailSpawner(float range, float increment); // 0x000000018158AFD0-0x000000018158B580
		public GameObject CreateClusteredTreeSpawner(float range); // 0x000000018158BFD0-0x000000018158C530
		public GameObject CreateCoverageTreeSpawner(float range); // 0x000000018158DD60-0x000000018158E2D0
		public GameObject CreateCoverageGameObjectSpawner(float range); // 0x000000018158D260-0x000000018158D7D0
		public GameObject CreateCoverageGameObjectSpawnerForTrees(float range); // 0x000000018158CC90-0x000000018158D260
		public GameObject CreateClusteredGameObjectSpawner(float range); // 0x000000018158BAE0-0x000000018158BFD0
		public GameObject CreateClusteredGameObjectSpawnerForTrees(float range); // 0x000000018158B580-0x000000018158BAE0
		public void ExportTexture(); // 0x000000018158E500-0x000000018158EB50
		public string SerialiseJson(); // 0x000000018158F710-0x000000018158F7A0
		public void DeSerialiseJson(string json); // 0x000000018158E3D0-0x000000018158E480
	}
}
