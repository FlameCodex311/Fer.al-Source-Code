/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia
{
	public class GaiaDefaults : ScriptableObject // TypeDefIndex: 9202
	{
		// Fields
		[HideInInspector] // 0x00000001802260A0-0x00000001802260F0
		[Tooltip] // 0x00000001802260A0-0x00000001802260F0
		public string m_defaultsID; // 0x18
		[Tooltip] // 0x0000000180226360-0x0000000180226390
		public float m_seaLevel; // 0x20
		[Tooltip] // 0x0000000180226500-0x0000000180226530
		public float m_beachHeight; // 0x24
		[HideInInspector] // 0x0000000180226650-0x00000001802266C0
		[Range] // 0x0000000180226650-0x00000001802266C0
		[Tooltip] // 0x0000000180226650-0x00000001802266C0
		public int m_tilesX; // 0x28
		[HideInInspector] // 0x0000000180226920-0x0000000180226990
		[Range] // 0x0000000180226920-0x0000000180226990
		[Tooltip] // 0x0000000180226920-0x0000000180226990
		public int m_tilesZ; // 0x2C
		[Header] // 0x0000000180226D20-0x0000000180226DC0
		[Range] // 0x0000000180226D20-0x0000000180226DC0
		[Space] // 0x0000000180226D20-0x0000000180226DC0
		[Tooltip] // 0x0000000180226D20-0x0000000180226DC0
		public int m_pixelError; // 0x30
		[Range] // 0x0000000180227100-0x0000000180227160
		[Tooltip] // 0x0000000180227100-0x0000000180227160
		public int m_baseMapDist; // 0x34
		[Tooltip] // 0x0000000180227450-0x0000000180227480
		public ShadowCastingMode m_shaodwCastingMode; // 0x38
		[Tooltip] // 0x0000000180227590-0x00000001802275C0
		public Material m_material; // 0x40
		[Tooltip] // 0x0000000180228A70-0x0000000180228AA0
		public PhysicMaterial m_physicsMaterial; // 0x48
		[Header] // 0x0000000180228C90-0x0000000180228D10
		[Space] // 0x0000000180228C90-0x0000000180228D10
		[Tooltip] // 0x0000000180228C90-0x0000000180228D10
		public bool m_draw; // 0x50
		[Range] // 0x0000000180229130-0x0000000180229190
		[Tooltip] // 0x0000000180229130-0x0000000180229190
		public int m_detailDistance; // 0x54
		[Range] // 0x0000000180229490-0x00000001802294F0
		[Tooltip] // 0x0000000180229490-0x00000001802294F0
		public float m_detailDensity; // 0x58
		[Range] // 0x0000000180229760-0x00000001802297C0
		[Tooltip] // 0x0000000180229760-0x00000001802297C0
		public int m_treeDistance; // 0x5C
		[Range] // 0x0000000180229A50-0x0000000180229AB0
		[Tooltip] // 0x0000000180229A50-0x0000000180229AB0
		public int m_billboardStart; // 0x60
		[Range] // 0x0000000180229D30-0x0000000180229D90
		[Tooltip] // 0x0000000180229D30-0x0000000180229D90
		public int m_fadeLength; // 0x64
		[Range] // 0x000000018022A1C0-0x000000018022A220
		[Tooltip] // 0x000000018022A1C0-0x000000018022A220
		public int m_maxMeshTrees; // 0x68
		[Header] // 0x000000018022A470-0x000000018022A500
		[Range] // 0x000000018022A470-0x000000018022A500
		[Space] // 0x000000018022A470-0x000000018022A500
		[Tooltip] // 0x000000018022A470-0x000000018022A500
		public float m_speed; // 0x6C
		[Range] // 0x000000018022A710-0x000000018022A770
		[Tooltip] // 0x000000018022A710-0x000000018022A770
		public float m_size; // 0x70
		[Range] // 0x000000018022AA50-0x000000018022AAB0
		[Tooltip] // 0x000000018022AA50-0x000000018022AAB0
		public float m_bending; // 0x74
		[Tooltip] // 0x000000018022AD40-0x000000018022AD70
		public Color m_grassTint; // 0x78
		[Header] // 0x000000018022AE60-0x000000018022AEE0
		[Space] // 0x000000018022AE60-0x000000018022AEE0
		[Tooltip] // 0x000000018022AE60-0x000000018022AEE0
		public int m_terrainSize; // 0x88
		[Tooltip] // 0x000000018022B0E0-0x000000018022B110
		public int m_terrainHeight; // 0x8C
		[Tooltip] // 0x000000018022B270-0x000000018022B2A0
		public int m_heightmapResolution; // 0x90
		[Tooltip] // 0x000000018022B400-0x000000018022B430
		public int m_detailResolution; // 0x94
		[Tooltip] // 0x000000018022B5C0-0x000000018022B5F0
		public int m_detailResolutionPerPatch; // 0x98
		[Tooltip] // 0x000000018022B740-0x000000018022B770
		public int m_controlTextureResolution; // 0x9C
		[Tooltip] // 0x000000018022B8C0-0x000000018022B8F0
		public int m_baseMapSize; // 0xA0
	
		// Constructors
		public GaiaDefaults(); // 0x0000000180E3D5B0-0x0000000180E3D730
	
		// Methods
		public void CreateTerrain(); // 0x0000000180E3BB00-0x0000000180E3BD70
		public void UpdateFromTerrain(); // 0x0000000180E3D300-0x0000000180E3D5B0
		public void CreateTerrain(GaiaResource resources); // 0x0000000180E3BD70-0x0000000180E3BFD0
		public GaiaOperation GetTerrainCreationOperation(GaiaResource resources); // 0x0000000180E3D000-0x0000000180E3D100
		public static Terrain GetActiveTerrain(); // 0x0000000180E3C830-0x0000000180E3CA30
		private void CreateTile(int tx, int tz, ref Terrain[,] world, GaiaResource resources); // 0x0000000180E3BFD0-0x0000000180E3C790
		private void RemoveWorldSeams(ref Terrain[,] world); // 0x0000000180E3D100-0x0000000180E3D270
		public string GetAndFixDefaults(); // 0x0000000180E3CA30-0x0000000180E3D000
		public string SerialiseJson(); // 0x0000000180E3D270-0x0000000180E3D300
		public void DeSerialiseJson(string json); // 0x0000000180E3C790-0x0000000180E3C830
	}
}
