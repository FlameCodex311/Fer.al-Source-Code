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
	public class ResourceProtoTree // TypeDefIndex: 9216
	{
		// Fields
		[Tooltip] // 0x0000000180232530-0x0000000180232560
		public string m_name; // 0x10
		[Tooltip] // 0x0000000180234820-0x0000000180234850
		public GameObject m_desktopPrefab; // 0x18
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public string m_desktopPrefabFileName; // 0x20
		[Tooltip] // 0x0000000180234B80-0x0000000180234BB0
		public GameObject m_mobilePrefab; // 0x28
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public string m_mobilePrefabFileName; // 0x30
		[Tooltip] // 0x000000018023D250-0x000000018023D280
		public float m_bendFactor; // 0x38
		[Tooltip] // 0x000000018023D310-0x000000018023D340
		public Color m_healthyColour; // 0x3C
		[Tooltip] // 0x000000018023D410-0x000000018023D440
		public Color m_dryColour; // 0x4C
		[Tooltip] // 0x000000018023A2B0-0x000000018023A2E0
		public ResourceProtoDNA m_dna; // 0x60
		[Tooltip] // 0x0000000180234500-0x0000000180234530
		public SpawnCritera[] m_spawnCriteria; // 0x68
		[Tooltip] // 0x0000000180234640-0x0000000180234670
		public SpawnRuleExtension[] m_spawnExtensions; // 0x70
	
		// Constructors
		public ResourceProtoTree(); // 0x0000000181559970-0x00000001815599F0
	
		// Methods
		public void Initialise(Spawner spawner); // 0x00000001815598F0-0x0000000181559970
		public bool HasActiveCriteria(); // 0x0000000181559870-0x00000001815598F0
		public bool SetAssetAssociations(); // 0x0000000180380950-0x0000000180380960
		public bool AssociateAssets(); // 0x0000000180380950-0x0000000180380960
		public bool ChecksTextures(); // 0x00000001815597D0-0x0000000181559870
		public bool ChecksProximity(); // 0x0000000181559730-0x00000001815597D0
		public void AddTags(ref List<string> tagList); // 0x0000000181559560-0x0000000181559730
	}
}
