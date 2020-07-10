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
	public class ResourceProtoTree // TypeDefIndex: 9050
	{
		// Fields
		[Tooltip] // 0x00000001800D22D0-0x00000001800D2300
		public string m_name; // 0x10
		[Tooltip] // 0x00000001800D6060-0x00000001800D6090
		public GameObject m_desktopPrefab; // 0x18
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public string m_desktopPrefabFileName; // 0x20
		[Tooltip] // 0x00000001800D6530-0x00000001800D6560
		public GameObject m_mobilePrefab; // 0x28
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public string m_mobilePrefabFileName; // 0x30
		[Tooltip] // 0x00000001800DE000-0x00000001800DE030
		public float m_bendFactor; // 0x38
		[Tooltip] // 0x00000001800DE210-0x00000001800DE240
		public Color m_healthyColour; // 0x3C
		[Tooltip] // 0x00000001800DE4A0-0x00000001800DE4D0
		public Color m_dryColour; // 0x4C
		[Tooltip] // 0x00000001800DB720-0x00000001800DB750
		public ResourceProtoDNA m_dna; // 0x60
		[Tooltip] // 0x00000001800D4980-0x00000001800D49B0
		public SpawnCritera[] m_spawnCriteria; // 0x68
		[Tooltip] // 0x00000001800D4BF0-0x00000001800D4C20
		public SpawnRuleExtension[] m_spawnExtensions; // 0x70
	
		// Constructors
		public ResourceProtoTree(); // 0x0000000181790940-0x00000001817909C0
	
		// Methods
		public void Initialise(Spawner spawner); // 0x00000001817908C0-0x0000000181790940
		public bool HasActiveCriteria(); // 0x0000000181790830-0x00000001817908C0
		public bool SetAssetAssociations(); // 0x00000001803C28F0-0x00000001803C2900
		public bool AssociateAssets(); // 0x00000001803C28F0-0x00000001803C2900
		public bool ChecksTextures(); // 0x0000000181790770-0x0000000181790830
		public bool ChecksProximity(); // 0x00000001817906B0-0x0000000181790770
		public void AddTags(ref List<string> tagList); // 0x00000001817904D0-0x00000001817906B0
	}
}
