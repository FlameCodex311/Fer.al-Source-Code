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
	public class ResourceProtoDetail // TypeDefIndex: 9040
	{
		// Fields
		[Tooltip] // 0x00000001800D22D0-0x00000001800D2300
		public string m_name; // 0x10
		[Tooltip] // 0x00000001800D2510-0x00000001800D2540
		public DetailRenderMode m_renderMode; // 0x18
		[Tooltip] // 0x00000001800D2890-0x00000001800D28C0
		public GameObject m_detailProtoype; // 0x20
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public string m_detailPrototypeFileName; // 0x28
		[Tooltip] // 0x00000001800D2DC0-0x00000001800D2DF0
		public Texture2D m_detailTexture; // 0x30
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public string m_detailTextureFileName; // 0x38
		[Tooltip] // 0x00000001800D3250-0x00000001800D3280
		public float m_minWidth; // 0x40
		[Tooltip] // 0x00000001800D3540-0x00000001800D3570
		public float m_maxWidth; // 0x44
		[Tooltip] // 0x00000001800D37F0-0x00000001800D3820
		public float m_minHeight; // 0x48
		[Tooltip] // 0x00000001800D39C0-0x00000001800D39F0
		public float m_maxHeight; // 0x4C
		[Range] // 0x00000001800D3CD0-0x00000001800D3D30
		[Tooltip] // 0x00000001800D3CD0-0x00000001800D3D30
		public float m_noiseSpread; // 0x50
		[Range] // 0x00000001800D4070-0x00000001800D40D0
		[Tooltip] // 0x00000001800D4070-0x00000001800D40D0
		public float m_bendFactor; // 0x54
		[Tooltip] // 0x00000001800D4360-0x00000001800D4390
		public Color m_healthyColour; // 0x58
		[Tooltip] // 0x00000001800D45C0-0x00000001800D45F0
		public Color m_dryColour; // 0x68
		[Tooltip] // 0x00000001800D4790-0x00000001800D47C0
		public ResourceProtoDNA m_dna; // 0x78
		[Tooltip] // 0x00000001800D4980-0x00000001800D49B0
		public SpawnCritera[] m_spawnCriteria; // 0x80
		[Tooltip] // 0x00000001800D4BF0-0x00000001800D4C20
		public SpawnRuleExtension[] m_spawnExtensions; // 0x88
	
		// Constructors
		public ResourceProtoDetail(); // 0x000000018178F330-0x000000018178F3C0
	
		// Methods
		public void Initialise(Spawner spawner); // 0x000000018178F2B0-0x000000018178F330
		public bool HasActiveCriteria(); // 0x000000018178F220-0x000000018178F2B0
		public bool SetAssetAssociations(); // 0x00000001803C28F0-0x00000001803C2900
		public bool AssociateAssets(); // 0x00000001803C28F0-0x00000001803C2900
		public bool ChecksTextures(); // 0x000000018178F160-0x000000018178F220
		public bool ChecksProximity(); // 0x000000018178F0A0-0x000000018178F160
		public void AddTags(ref List<string> tagList); // 0x000000018178EEB0-0x000000018178F0A0
	}
}
