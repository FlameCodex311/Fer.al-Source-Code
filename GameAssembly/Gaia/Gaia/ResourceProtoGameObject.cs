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
	public class ResourceProtoGameObject // TypeDefIndex: 9045
	{
		// Fields
		[Tooltip] // 0x00000001800D22D0-0x00000001800D2300
		public string m_name; // 0x10
		[Tooltip] // 0x00000001800DA730-0x00000001800DA760
		public ResourceProtoGameObjectInstance[] m_instances; // 0x18
		[Tooltip] // 0x00000001800DA8D0-0x00000001800DA900
		public ResourceProtoDNA m_dna; // 0x20
		[Tooltip] // 0x00000001800D4980-0x00000001800D49B0
		public SpawnCritera[] m_spawnCriteria; // 0x28
		[Tooltip] // 0x00000001800D4BF0-0x00000001800D4C20
		public SpawnRuleExtension[] m_spawnExtensions; // 0x30
		[Tooltip] // 0x00000001800DACB0-0x00000001800DACE0
		public bool m_canSpawnAsTree; // 0x38
	
		// Constructors
		public ResourceProtoGameObject(); // 0x000000018178F9F0-0x000000018178FAD0
	
		// Methods
		public void Initialise(Spawner spawner); // 0x000000018178F970-0x000000018178F9F0
		public bool HasActiveCriteria(); // 0x000000018178F8E0-0x000000018178F970
		public bool SetAssetAssociations(); // 0x00000001803C28F0-0x00000001803C2900
		public bool AssociateAssets(); // 0x00000001803C28F0-0x00000001803C2900
		public bool ChecksTextures(); // 0x000000018178F820-0x000000018178F8E0
		public bool ChecksProximity(); // 0x000000018178F760-0x000000018178F820
		public void AddTags(ref List<string> tagList); // 0x000000018178F580-0x000000018178F760
	}
}
