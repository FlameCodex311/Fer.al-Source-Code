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
	public class ResourceProtoTexture // TypeDefIndex: 9048
	{
		// Fields
		[Tooltip] // 0x00000001800D22D0-0x00000001800D2300
		public string m_name; // 0x10
		[Tooltip] // 0x00000001800DBC50-0x00000001800DBC80
		public Texture2D m_texture; // 0x18
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public string m_textureFileName; // 0x20
		[Tooltip] // 0x00000001800DBFB0-0x00000001800DBFE0
		public Texture2D m_normal; // 0x28
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public string m_normalFileName; // 0x30
		[Tooltip] // 0x00000001800DC290-0x00000001800DC2C0
		public float m_sizeX; // 0x38
		[Tooltip] // 0x00000001800DC4B0-0x00000001800DC4E0
		public float m_sizeY; // 0x3C
		[Tooltip] // 0x00000001800DB310-0x00000001800DB340
		public float m_offsetX; // 0x40
		[Tooltip] // 0x00000001800DB310-0x00000001800DB340
		public float m_offsetY; // 0x44
		[Range] // 0x00000001800DC9E0-0x00000001800DCA40
		[Tooltip] // 0x00000001800DC9E0-0x00000001800DCA40
		public float m_metalic; // 0x48
		[Range] // 0x00000001800DCCE0-0x00000001800DCD40
		[Tooltip] // 0x00000001800DCCE0-0x00000001800DCD40
		public float m_smoothness; // 0x4C
		[Tooltip] // 0x00000001800D4980-0x00000001800D49B0
		public SpawnCritera[] m_spawnCriteria; // 0x50
		[Tooltip] // 0x00000001800D4BF0-0x00000001800D4C20
		public SpawnRuleExtension[] m_spawnExtensions; // 0x58
	
		// Constructors
		public ResourceProtoTexture(); // 0x0000000181790460-0x00000001817904D0
	
		// Methods
		public void Initialise(Spawner spawner); // 0x00000001817903E0-0x0000000181790460
		public bool HasActiveCriteria(); // 0x0000000181790350-0x00000001817903E0
		public bool SetAssetAssociations(); // 0x00000001803C28F0-0x00000001803C2900
		public bool AssociateAssets(); // 0x00000001803C28F0-0x00000001803C2900
		public bool ChecksTextures(); // 0x0000000181790290-0x0000000181790350
		public bool ChecksProximity(); // 0x00000001817901D0-0x0000000181790290
		public void AddTags(ref List<string> tagList); // 0x000000018178FFF0-0x00000001817901D0
	}
}
