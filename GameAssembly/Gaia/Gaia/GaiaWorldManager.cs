/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia
{
	public class GaiaWorldManager // TypeDefIndex: 9205
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
		public int TileCount { get; } // 0x000000018091EDF0-0x000000018091EE00 
		public Terrain[,] PhysicalTerrainArray { get; set; } // 0x00000001803EF220-0x00000001803EF230 0x00000001803B7C20-0x00000001803B7C30
		public UnityHeightMap[,] HeightMapTerrainArray { get; set; } // 0x00000001803EF180-0x00000001803EF190 0x00000001805742A0-0x00000001805742B0
		public Bounds WorldBoundsWU { get; } // 0x0000000181999CC0-0x0000000181999CE0 
		public Bounds WorldBoundsTU { get; } // 0x0000000181999CA0-0x0000000181999CC0 
		public Bounds WorldBoundsNU { get; } // 0x0000000181999C80-0x0000000181999CA0 
		public Vector3 WUtoTUConversionFactor { get; } // 0x0000000181999C60-0x0000000181999C80 
		public Vector3 WUtoNUConversionFactor { get; } // 0x0000000181999C40-0x0000000181999C60 
		public ulong BoundsCheckErrors { get; set; } // 0x00000001803916B0-0x00000001803916C0 0x0000000180617A80-0x0000000180617A90
	
		// Constructors
		public GaiaWorldManager(); // 0x0000000181998A10-0x0000000181998B70
		public GaiaWorldManager(Terrain[] terrains); // 0x0000000181998B70-0x0000000181999C40
	
		// Methods
		public string IsValidWorld(Terrain[] terrains); // 0x0000000181992BD0-0x00000001819944C0
		private Terrain GetTerrainWU(Vector3 positionWU); // 0x0000000181992930-0x0000000181992AD0
		private Terrain GetTerrainTU(Vector3 positionTU); // 0x00000001819927E0-0x0000000181992930
		private Terrain GetTerrainNU(Vector3 positionNU); // 0x00000001819926F0-0x00000001819927E0
		private UnityHeightMap GetHeightMapWU(Vector3 positionWU); // 0x00000001819920B0-0x00000001819924A0
		private UnityHeightMap GetHeightMapTU(Vector3 positionTU); // 0x0000000181991D10-0x00000001819920B0
		private UnityHeightMap GetHeightMapNU(Vector3 positionNU); // 0x0000000181991A30-0x0000000181991D10
		public void LoadFromWorld(); // 0x00000001819944C0-0x00000001819946A0
		public void SaveToWorld(bool forceWrite = false /* Metadata: 0x00778EE4 */); // 0x0000000181994C40-0x0000000181994D90
		public void SetHeightWU(float heightWU); // 0x0000000181994FF0-0x0000000181995120
		public void SetHeightWU(Vector3 positionWU, float height); // 0x0000000181994EF0-0x0000000181994FF0
		public float GetHeightWU(Vector3 positionWU); // 0x00000001819925F0-0x00000001819926F0
		public float GetHeightInterpolatedWU(Vector3 positionWU); // 0x0000000181991980-0x0000000181991A30
		public void SetHeightTU(Vector3 positionTU, float height); // 0x0000000181994D90-0x0000000181994EF0
		public float GetHeightTU(Vector3 positionTU); // 0x00000001819924A0-0x00000001819925F0
		public float GetHeightInterpolatedTU(Vector3 positionTU); // 0x0000000181991880-0x0000000181991980
		public void FlattenWorld(); // 0x00000001819915C0-0x00000001819917C0
		public void SmoothWorld(); // 0x0000000181995120-0x0000000181995320
		public void ExportWorldAsPng(string path); // 0x0000000181991400-0x00000001819915C0
		public void ExportSplatmapAsPng(string path, int textureIdx); // 0x0000000181990DF0-0x0000000181991030
		public void ExportGrassmapAsPng(string path); // 0x0000000181990190-0x0000000181990560
		public void ExportNormalmapAsPng(string path); // 0x0000000181990AC0-0x0000000181990B50
		public void ExportNormalmapAsPng1(string path); // 0x0000000181990560-0x0000000181990AC0
		public void ExportWaterflowMapAsPng(int iterations, string path); // 0x0000000181991030-0x0000000181991400
		public void ExportShorelineMask(string path, float shoreHeightWU, float shoreWidthWU); // 0x0000000181990B50-0x0000000181990DF0
		private void MakeMask(Vector3 positionTU, float shoreHeightNU, float maskSizeTU, HeightMap waterMask); // 0x00000001819946A0-0x0000000181994970
		public bool InBoundsWU(Vector3 positionWU); // 0x0000000181992B80-0x0000000181992BD0
		public bool InBoundsTU(Vector3 positionTU); // 0x0000000181992B30-0x0000000181992B80
		public bool InBoundsNU(Vector3 positionNU); // 0x0000000181992AD0-0x0000000181992B30
		public Vector3 WUtoTU(Vector3 positionWU); // 0x0000000181998950-0x0000000181998A10
		public Vector3 WUtoNU(Vector3 positionWU); // 0x0000000181998650-0x0000000181998710
		public Vector3 WUtoPTI(Vector3 positionWU); // 0x0000000181998710-0x0000000181998800
		public Vector3 WUtoPTO(Vector3 positionWU); // 0x0000000181998800-0x0000000181998950
		public Vector3 TUtoWU(Vector3 positionTU); // 0x00000001819954D0-0x0000000181995590
		public Vector3 TUtoNU(Vector3 positionTU); // 0x0000000181995320-0x00000001819953E0
		public void TUtoPTI(ref Vector3 positionTU); // 0x00000001819953E0-0x0000000181995450
		public void TUtoPTO(ref Vector3 positionTU); // 0x0000000181995450-0x00000001819954D0
		public Vector3 NUtoWU(Vector3 positionNU); // 0x0000000181994B80-0x0000000181994C40
		public Vector3 NUtoTU(Vector3 positionNU); // 0x0000000181994AC0-0x0000000181994B80
		public void NUtoPTI(ref Vector3 positionNU); // 0x0000000181994970-0x0000000181994A30
		public void NUtoPTO(ref Vector3 positionNU); // 0x0000000181994A30-0x0000000181994AC0
		public Vector3 Ceil(Vector3 source); // 0x00000001819900D0-0x0000000181990190
		public Vector3 Floor(Vector3 source); // 0x00000001819917C0-0x0000000181991880
		public void Test(); // 0x0000000181995A00-0x0000000181998650
		public void TestBlobWU(Vector3 positionWU, int widthWU, float height); // 0x0000000181995790-0x0000000181995A00
		public void TestBlobTU(Vector3 positionTU, int widthWU, float height); // 0x0000000181995590-0x0000000181995790
	}
}
