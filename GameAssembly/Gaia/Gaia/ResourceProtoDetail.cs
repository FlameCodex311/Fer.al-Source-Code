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
	public class ResourceProtoDetail // TypeDefIndex: 9208
	{
		// Fields
		[Tooltip] // 0x0000000180232530-0x0000000180232560
		public string m_name; // 0x10
		[Tooltip] // 0x00000001802326F0-0x0000000180232720
		public DetailRenderMode m_renderMode; // 0x18
		[Tooltip] // 0x00000001802327A0-0x00000001802327D0
		public GameObject m_detailProtoype; // 0x20
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public string m_detailPrototypeFileName; // 0x28
		[Tooltip] // 0x0000000180232B00-0x0000000180232B30
		public Texture2D m_detailTexture; // 0x30
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public string m_detailTextureFileName; // 0x38
		[Tooltip] // 0x0000000180232CF0-0x0000000180232D20
		public float m_minWidth; // 0x40
		[Tooltip] // 0x0000000180232F00-0x0000000180232F30
		public float m_maxWidth; // 0x44
		[Tooltip] // 0x00000001802331C0-0x00000001802331F0
		public float m_minHeight; // 0x48
		[Tooltip] // 0x00000001802334E0-0x0000000180233510
		public float m_maxHeight; // 0x4C
		[Range] // 0x0000000180233770-0x00000001802337D0
		[Tooltip] // 0x0000000180233770-0x00000001802337D0
		public float m_noiseSpread; // 0x50
		[Range] // 0x0000000180233A80-0x0000000180233AE0
		[Tooltip] // 0x0000000180233A80-0x0000000180233AE0
		public float m_bendFactor; // 0x54
		[Tooltip] // 0x0000000180233F10-0x0000000180233F40
		public Color m_healthyColour; // 0x58
		[Tooltip] // 0x0000000180234080-0x00000001802340B0
		public Color m_dryColour; // 0x68
		[Tooltip] // 0x0000000180234330-0x0000000180234360
		public ResourceProtoDNA m_dna; // 0x78
		[Tooltip] // 0x0000000180234500-0x0000000180234530
		public SpawnCritera[] m_spawnCriteria; // 0x80
		[Tooltip] // 0x0000000180234640-0x0000000180234670
		public SpawnRuleExtension[] m_spawnExtensions; // 0x88
	
		// Constructors
		public ResourceProtoDetail(); // 0x00000001819A3DE0-0x00000001819A3E70
	
		// Methods
		public void Initialise(Spawner spawner); // 0x00000001819A3D60-0x00000001819A3DE0
		public bool HasActiveCriteria(); // 0x00000001819A3CE0-0x00000001819A3D60
		public bool SetAssetAssociations(); // 0x0000000180380950-0x0000000180380960
		public bool AssociateAssets(); // 0x0000000180380950-0x0000000180380960
		public bool ChecksTextures(); // 0x00000001819A3C30-0x00000001819A3CE0
		public bool ChecksProximity(); // 0x00000001819A3B80-0x00000001819A3C30
		public void AddTags(ref List<string> tagList); // 0x00000001819A39B0-0x00000001819A3B80
	}
}
