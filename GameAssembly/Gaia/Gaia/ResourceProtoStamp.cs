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
	public class ResourceProtoStamp // TypeDefIndex: 9213
	{
		// Fields
		[Tooltip] // 0x0000000180239BE0-0x0000000180239C10
		public string m_name; // 0x10
		[Tooltip] // 0x0000000180239D20-0x0000000180239D50
		public Texture2D m_texture; // 0x18
		[Tooltip] // 0x000000018023A020-0x000000018023A050
		public bool m_stickToGround; // 0x20
		[Tooltip] // 0x000000018023A2B0-0x000000018023A2E0
		public ResourceProtoDNA m_dna; // 0x28
		[Tooltip] // 0x0000000180234500-0x0000000180234530
		public SpawnCritera[] m_spawnCriteria; // 0x30
	
		// Constructors
		public ResourceProtoStamp(); // 0x0000000181559090-0x00000001815590E0
	
		// Methods
		public void Initialise(Spawner spawner); // 0x0000000181559010-0x0000000181559090
		public bool HasActiveCriteria(); // 0x0000000181558F90-0x0000000181559010
		public bool ChecksTextures(); // 0x0000000181558EF0-0x0000000181558F90
		public bool ChecksProximity(); // 0x0000000181558E50-0x0000000181558EF0
		public void AddTags(ref List<string> tagList); // 0x0000000181558C80-0x0000000181558E50
		public void AddStamps(ref List<string> stampList); // 0x0000000181558C20-0x0000000181558C80
	}
}
