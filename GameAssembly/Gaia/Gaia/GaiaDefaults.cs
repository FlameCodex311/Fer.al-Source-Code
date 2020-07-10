/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia
{
	public class GaiaDefaults : ScriptableObject // TypeDefIndex: 9036
	{
		// Fields
		[HideInInspector] // 0x00000001800C5B00-0x00000001800C5B50
		[Tooltip] // 0x00000001800C5B00-0x00000001800C5B50
		public string m_defaultsID; // 0x18
		[Tooltip] // 0x00000001800C5DC0-0x00000001800C5DF0
		public float m_seaLevel; // 0x20
		[Tooltip] // 0x00000001800C6020-0x00000001800C6050
		public float m_beachHeight; // 0x24
		[HideInInspector] // 0x00000001800C6300-0x00000001800C6370
		[Range] // 0x00000001800C6300-0x00000001800C6370
		[Tooltip] // 0x00000001800C6300-0x00000001800C6370
		public int m_tilesX; // 0x28
		[HideInInspector] // 0x00000001800C6580-0x00000001800C65F0
		[Range] // 0x00000001800C6580-0x00000001800C65F0
		[Tooltip] // 0x00000001800C6580-0x00000001800C65F0
		public int m_tilesZ; // 0x2C
		[Header] // 0x00000001800C6910-0x00000001800C69B0
		[Range] // 0x00000001800C6910-0x00000001800C69B0
		[Space] // 0x00000001800C6910-0x00000001800C69B0
		[Tooltip] // 0x00000001800C6910-0x00000001800C69B0
		public int m_pixelError; // 0x30
		[Range] // 0x00000001800C6D20-0x00000001800C6D80
		[Tooltip] // 0x00000001800C6D20-0x00000001800C6D80
		public int m_baseMapDist; // 0x34
		[Tooltip] // 0x00000001800C6E40-0x00000001800C6E70
		public ShadowCastingMode m_shaodwCastingMode; // 0x38
		[Tooltip] // 0x00000001800C7100-0x00000001800C7130
		public Material m_material; // 0x40
		[Tooltip] // 0x00000001800C7330-0x00000001800C7360
		public PhysicMaterial m_physicsMaterial; // 0x48
		[Header] // 0x00000001800C75C0-0x00000001800C7640
		[Space] // 0x00000001800C75C0-0x00000001800C7640
		[Tooltip] // 0x00000001800C75C0-0x00000001800C7640
		public bool m_draw; // 0x50
		[Range] // 0x00000001800C7B70-0x00000001800C7BD0
		[Tooltip] // 0x00000001800C7B70-0x00000001800C7BD0
		public int m_detailDistance; // 0x54
		[Range] // 0x00000001800C7EE0-0x00000001800C7F40
		[Tooltip] // 0x00000001800C7EE0-0x00000001800C7F40
		public float m_detailDensity; // 0x58
		[Range] // 0x00000001800C8390-0x00000001800C83F0
		[Tooltip] // 0x00000001800C8390-0x00000001800C83F0
		public int m_treeDistance; // 0x5C
		[Range] // 0x00000001800C8760-0x00000001800C87C0
		[Tooltip] // 0x00000001800C8760-0x00000001800C87C0
		public int m_billboardStart; // 0x60
		[Range] // 0x00000001800C8BA0-0x00000001800C8C00
		[Tooltip] // 0x00000001800C8BA0-0x00000001800C8C00
		public int m_fadeLength; // 0x64
		[Range] // 0x00000001800C90B0-0x00000001800C9110
		[Tooltip] // 0x00000001800C90B0-0x00000001800C9110
		public int m_maxMeshTrees; // 0x68
		[Header] // 0x00000001800C9390-0x00000001800C9420
		[Range] // 0x00000001800C9390-0x00000001800C9420
		[Space] // 0x00000001800C9390-0x00000001800C9420
		[Tooltip] // 0x00000001800C9390-0x00000001800C9420
		public float m_speed; // 0x6C
		[Range] // 0x00000001800C97C0-0x00000001800C9820
		[Tooltip] // 0x00000001800C97C0-0x00000001800C9820
		public float m_size; // 0x70
		[Range] // 0x00000001800C9B60-0x00000001800C9BC0
		[Tooltip] // 0x00000001800C9B60-0x00000001800C9BC0
		public float m_bending; // 0x74
		[Tooltip] // 0x00000001800C9D80-0x00000001800C9DB0
		public Color m_grassTint; // 0x78
		[Header] // 0x00000001800CA010-0x00000001800CA090
		[Space] // 0x00000001800CA010-0x00000001800CA090
		[Tooltip] // 0x00000001800CA010-0x00000001800CA090
		public int m_terrainSize; // 0x88
		[Tooltip] // 0x00000001800CA570-0x00000001800CA5A0
		public int m_terrainHeight; // 0x8C
		[Tooltip] // 0x00000001800CA6A0-0x00000001800CA6D0
		public int m_heightmapResolution; // 0x90
		[Tooltip] // 0x00000001800CA920-0x00000001800CA950
		public int m_detailResolution; // 0x94
		[Tooltip] // 0x00000001800CAAE0-0x00000001800CAB10
		public int m_detailResolutionPerPatch; // 0x98
		[Tooltip] // 0x00000001800CACF0-0x00000001800CAD20
		public int m_controlTextureResolution; // 0x9C
		[Tooltip] // 0x00000001800CAFD0-0x00000001800CB000
		public int m_baseMapSize; // 0xA0
	
		// Constructors
		public GaiaDefaults(); // 0x0000000181586680-0x0000000181586800
	
		// Methods
		public void CreateTerrain(); // 0x0000000181584BD0-0x0000000181584E40
		public void UpdateFromTerrain(); // 0x00000001815863D0-0x0000000181586680
		public void CreateTerrain(GaiaResource resources); // 0x0000000181584E40-0x00000001815850A0
		public GaiaOperation GetTerrainCreationOperation(GaiaResource resources); // 0x00000001815860D0-0x00000001815861D0
		public static Terrain GetActiveTerrain(); // 0x00000001815858E0-0x0000000181585AF0
		private void CreateTile(int tx, int tz, ref Terrain[,] world, GaiaResource resources); // 0x00000001815850A0-0x0000000181585830
		private void RemoveWorldSeams(ref Terrain[,] world); // 0x00000001815861D0-0x0000000181586340
		public string GetAndFixDefaults(); // 0x0000000181585AF0-0x00000001815860D0
		public string SerialiseJson(); // 0x0000000181586340-0x00000001815863D0
		public void DeSerialiseJson(string json); // 0x0000000181585830-0x00000001815858E0
	}
}
