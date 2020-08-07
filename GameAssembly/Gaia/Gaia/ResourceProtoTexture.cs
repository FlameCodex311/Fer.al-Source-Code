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
	public class ResourceProtoTexture // TypeDefIndex: 9214
	{
		// Fields
		[Tooltip] // 0x0000000180232530-0x0000000180232560
		public string m_name; // 0x10
		[Tooltip] // 0x000000018023A680-0x000000018023A6B0
		public Texture2D m_texture; // 0x18
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public string m_textureFileName; // 0x20
		[Tooltip] // 0x000000018023AA30-0x000000018023AA60
		public Texture2D m_normal; // 0x28
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public string m_normalFileName; // 0x30
		[Tooltip] // 0x000000018023AD00-0x000000018023AD30
		public float m_sizeX; // 0x38
		[Tooltip] // 0x000000018023AEC0-0x000000018023AEF0
		public float m_sizeY; // 0x3C
		[Tooltip] // 0x000000018023A020-0x000000018023A050
		public float m_offsetX; // 0x40
		[Tooltip] // 0x000000018023A020-0x000000018023A050
		public float m_offsetY; // 0x44
		[Range] // 0x000000018023B250-0x000000018023B2B0
		[Tooltip] // 0x000000018023B250-0x000000018023B2B0
		public float m_metalic; // 0x48
		[Range] // 0x000000018023B3E0-0x000000018023B440
		[Tooltip] // 0x000000018023B3E0-0x000000018023B440
		public float m_smoothness; // 0x4C
		[Tooltip] // 0x0000000180234500-0x0000000180234530
		public SpawnCritera[] m_spawnCriteria; // 0x50
		[Tooltip] // 0x0000000180234640-0x0000000180234670
		public SpawnRuleExtension[] m_spawnExtensions; // 0x58
	
		// Constructors
		public ResourceProtoTexture(); // 0x00000001815594F0-0x0000000181559560
	
		// Methods
		public void Initialise(Spawner spawner); // 0x0000000181559470-0x00000001815594F0
		public bool HasActiveCriteria(); // 0x00000001815593F0-0x0000000181559470
		public bool SetAssetAssociations(); // 0x0000000180380950-0x0000000180380960
		public bool AssociateAssets(); // 0x0000000180380950-0x0000000180380960
		public bool ChecksTextures(); // 0x0000000181559350-0x00000001815593F0
		public bool ChecksProximity(); // 0x00000001815592B0-0x0000000181559350
		public void AddTags(ref List<string> tagList); // 0x00000001815590E0-0x00000001815592B0
	}
}
