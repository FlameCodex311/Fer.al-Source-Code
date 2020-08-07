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
	public class ResourceProtoGameObject // TypeDefIndex: 9211
	{
		// Fields
		[Tooltip] // 0x0000000180232530-0x0000000180232560
		public string m_name; // 0x10
		[Tooltip] // 0x00000001802390C0-0x00000001802390F0
		public ResourceProtoGameObjectInstance[] m_instances; // 0x18
		[Tooltip] // 0x00000001802393A0-0x00000001802393D0
		public ResourceProtoDNA m_dna; // 0x20
		[Tooltip] // 0x0000000180234500-0x0000000180234530
		public SpawnCritera[] m_spawnCriteria; // 0x28
		[Tooltip] // 0x0000000180234640-0x0000000180234670
		public SpawnRuleExtension[] m_spawnExtensions; // 0x30
		[Tooltip] // 0x0000000180239960-0x0000000180239990
		public bool m_canSpawnAsTree; // 0x38
	
		// Constructors
		public ResourceProtoGameObject(); // 0x00000001819A4430-0x00000001819A4510
	
		// Methods
		public void Initialise(Spawner spawner); // 0x00000001819A43B0-0x00000001819A4430
		public bool HasActiveCriteria(); // 0x00000001819A4330-0x00000001819A43B0
		public bool SetAssetAssociations(); // 0x0000000180380950-0x0000000180380960
		public bool AssociateAssets(); // 0x0000000180380950-0x0000000180380960
		public bool ChecksTextures(); // 0x00000001819A4290-0x00000001819A4330
		public bool ChecksProximity(); // 0x00000001819A41F0-0x00000001819A4290
		public void AddTags(ref List<string> tagList); // 0x00000001819A4020-0x00000001819A41F0
	}
}
