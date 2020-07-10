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
	public class ResourceProtoStamp // TypeDefIndex: 9047
	{
		// Fields
		[Tooltip] // 0x00000001800DAF50-0x00000001800DAF80
		public string m_name; // 0x10
		[Tooltip] // 0x00000001800DB150-0x00000001800DB180
		public Texture2D m_texture; // 0x18
		[Tooltip] // 0x00000001800DB310-0x00000001800DB340
		public bool m_stickToGround; // 0x20
		[Tooltip] // 0x00000001800DB720-0x00000001800DB750
		public ResourceProtoDNA m_dna; // 0x28
		[Tooltip] // 0x00000001800D4980-0x00000001800D49B0
		public SpawnCritera[] m_spawnCriteria; // 0x30
	
		// Constructors
		public ResourceProtoStamp(); // 0x000000018178FFA0-0x000000018178FFF0
	
		// Methods
		public void Initialise(Spawner spawner); // 0x000000018178FF20-0x000000018178FFA0
		public bool HasActiveCriteria(); // 0x000000018178FE90-0x000000018178FF20
		public bool ChecksTextures(); // 0x000000018178FDD0-0x000000018178FE90
		public bool ChecksProximity(); // 0x000000018178FD10-0x000000018178FDD0
		public void AddTags(ref List<string> tagList); // 0x000000018178FB30-0x000000018178FD10
		public void AddStamps(ref List<string> stampList); // 0x000000018178FAD0-0x000000018178FB30
	}
}
