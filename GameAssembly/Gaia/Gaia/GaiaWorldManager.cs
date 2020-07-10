/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia
{
	public class GaiaWorldManager // TypeDefIndex: 9039
	{
		// Fields
		private Bounds m_worldBoundsWU; // 0x10
		private Vector3 m_worldBoundsWUMin; // 0x28
		private Vector3 m_worldBoundsWUMax; // 0x34
		private Vector3 m_worldBoundsWUSize; // 0x40
		private Bounds m_worldBoundsTU; // 0x4C
		private Vector3 m_worldBoundsTUMin; // 0x64
		private Vector3 m_worldBoundsTUMax; // 0x70
		private Vector3 m_worldBoundsTUSize; // 0x7C
		private Bounds m_worldBoundsNU; // 0x88
		private Vector3 m_worldBoundsNUMin; // 0xA0
		private Vector3 m_worldBoundsNUMax; // 0xAC
		private Vector3 m_WUtoTU; // 0xB8
		private Vector3 m_TUtoWU; // 0xC4
		private Vector3 m_TUtoNU; // 0xD0
		private Vector3 m_NUtoTU; // 0xDC
		private Vector3 m_WUtoNU; // 0xE8
		private Vector3 m_NUtoWU; // 0xF4
		private Vector3 m_NUZeroOffset; // 0x100
		private Vector3 m_TUZeroOffset; // 0x10C
		private ulong m_boundsCheckErrors; // 0x118
		private Terrain[,] m_physicalTerrainArray; // 0x120
		private UnityHeightMap[,] m_heightMapTerrainArray; // 0x128
		private int m_tileCount; // 0x130
	
		// Properties
		public int TileCount { get; } // 0x00000001810E21D0-0x00000001810E21E0 
		public Terrain[,] PhysicalTerrainArray { get; set; } // 0x00000001803BD3D0-0x00000001803BD3E0 0x00000001803BE5F0-0x00000001803BE600
		public UnityHeightMap[,] HeightMapTerrainArray { get; set; } // 0x00000001803BD350-0x00000001803BD360 0x00000001803BE570-0x00000001803BE580
		public Bounds WorldBoundsWU { get; } // 0x00000001815A61C0-0x00000001815A61E0 
		public Bounds WorldBoundsTU { get; } // 0x00000001815A61A0-0x00000001815A61C0 
		public Bounds WorldBoundsNU { get; } // 0x00000001815A6180-0x00000001815A61A0 
		public Vector3 WUtoTUConversionFactor { get; } // 0x00000001815A6160-0x00000001815A6180 
		public Vector3 WUtoNUConversionFactor { get; } // 0x00000001815A6140-0x00000001815A6160 
		public ulong BoundsCheckErrors { get; set; } // 0x00000001803BD3A0-0x00000001803BD3B0 0x00000001803BE5C0-0x00000001803BE5D0
	
		// Constructors
		public GaiaWorldManager(); // 0x00000001815A4EE0-0x00000001815A5040
		public GaiaWorldManager(Terrain[] terrains); // 0x00000001815A5040-0x00000001815A6140
	
		// Methods
		public string IsValidWorld(Terrain[] terrains); // 0x000000018159EF60-0x00000001815A09B0
		private Terrain GetTerrainWU(Vector3 positionWU); // 0x000000018159ECB0-0x000000018159EE60
		private Terrain GetTerrainTU(Vector3 positionTU); // 0x000000018159EB60-0x000000018159ECB0
		private Terrain GetTerrainNU(Vector3 positionNU); // 0x000000018159EA70-0x000000018159EB60
		private UnityHeightMap GetHeightMapWU(Vector3 positionWU); // 0x000000018159E4F0-0x000000018159E8C0
		private UnityHeightMap GetHeightMapTU(Vector3 positionTU); // 0x000000018159E180-0x000000018159E4F0
		private UnityHeightMap GetHeightMapNU(Vector3 positionNU); // 0x000000018159DEC0-0x000000018159E180
		public void LoadFromWorld(); // 0x00000001815A09B0-0x00000001815A0BA0
		public void SaveToWorld(bool forceWrite = false /* Metadata: 0x007441F6 */); // 0x00000001815A1140-0x00000001815A1290
		public void SetHeightWU(float heightWU); // 0x00000001815A1460-0x00000001815A15A0
		public void SetHeightWU(Vector3 positionWU, float height); // 0x00000001815A13A0-0x00000001815A1460
		public float GetHeightWU(Vector3 positionWU); // 0x000000018159E9C0-0x000000018159EA70
		public float GetHeightInterpolatedWU(Vector3 positionWU); // 0x000000018159DE10-0x000000018159DEC0
		public void SetHeightTU(Vector3 positionTU, float height); // 0x00000001815A1290-0x00000001815A13A0
		public float GetHeightTU(Vector3 positionTU); // 0x000000018159E8C0-0x000000018159E9C0
		public float GetHeightInterpolatedTU(Vector3 positionTU); // 0x000000018159DD10-0x000000018159DE10
		public void FlattenWorld(); // 0x000000018159DA50-0x000000018159DC50
		public void SmoothWorld(); // 0x00000001815A15A0-0x00000001815A17A0
		public void ExportWorldAsPng(string path); // 0x000000018159D890-0x000000018159DA50
		public void ExportSplatmapAsPng(string path, int textureIdx); // 0x000000018159D240-0x000000018159D490
		public void ExportGrassmapAsPng(string path); // 0x000000018159C5A0-0x000000018159C990
		public void ExportNormalmapAsPng(string path); // 0x000000018159CF10-0x000000018159CFA0
		public void ExportNormalmapAsPng1(string path); // 0x000000018159C990-0x000000018159CF10
		public void ExportWaterflowMapAsPng(int iterations, string path); // 0x000000018159D490-0x000000018159D890
		public void ExportShorelineMask(string path, float shoreHeightWU, float shoreWidthWU); // 0x000000018159CFA0-0x000000018159D240
		private void MakeMask(Vector3 positionTU, float shoreHeightNU, float maskSizeTU, HeightMap waterMask); // 0x00000001815A0BA0-0x00000001815A0E70
		public bool InBoundsWU(Vector3 positionWU); // 0x000000018159EF10-0x000000018159EF60
		public bool InBoundsTU(Vector3 positionTU); // 0x000000018159EEC0-0x000000018159EF10
		public bool InBoundsNU(Vector3 positionNU); // 0x000000018159EE60-0x000000018159EEC0
		public Vector3 WUtoTU(Vector3 positionWU); // 0x00000001815A4E20-0x00000001815A4EE0
		public Vector3 WUtoNU(Vector3 positionWU); // 0x00000001815A4B20-0x00000001815A4BE0
		public Vector3 WUtoPTI(Vector3 positionWU); // 0x00000001815A4BE0-0x00000001815A4CD0
		public Vector3 WUtoPTO(Vector3 positionWU); // 0x00000001815A4CD0-0x00000001815A4E20
		public Vector3 TUtoWU(Vector3 positionTU); // 0x00000001815A1950-0x00000001815A1A10
		public Vector3 TUtoNU(Vector3 positionTU); // 0x00000001815A17A0-0x00000001815A1860
		public void TUtoPTI(ref Vector3 positionTU); // 0x00000001815A1860-0x00000001815A18D0
		public void TUtoPTO(ref Vector3 positionTU); // 0x00000001815A18D0-0x00000001815A1950
		public Vector3 NUtoWU(Vector3 positionNU); // 0x00000001815A1080-0x00000001815A1140
		public Vector3 NUtoTU(Vector3 positionNU); // 0x00000001815A0FC0-0x00000001815A1080
		public void NUtoPTI(ref Vector3 positionNU); // 0x00000001815A0E70-0x00000001815A0F30
		public void NUtoPTO(ref Vector3 positionNU); // 0x00000001815A0F30-0x00000001815A0FC0
		public Vector3 Ceil(Vector3 source); // 0x000000018159C4E0-0x000000018159C5A0
		public Vector3 Floor(Vector3 source); // 0x000000018159DC50-0x000000018159DD10
		public void Test(); // 0x00000001815A1E80-0x00000001815A4B20
		public void TestBlobWU(Vector3 positionWU, int widthWU, float height); // 0x00000001815A1C10-0x00000001815A1E80
		public void TestBlobTU(Vector3 positionTU, int widthWU, float height); // 0x00000001815A1A10-0x00000001815A1C10
	}
}
