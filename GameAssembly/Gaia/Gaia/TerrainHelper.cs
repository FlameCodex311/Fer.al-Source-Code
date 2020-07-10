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
	public class TerrainHelper : UnityEngine.MonoBehaviour // TypeDefIndex: 9095
	{
		// Fields
		[Range] // 0x00000001800F1990-0x00000001800F19E0
		[Tooltip] // 0x00000001800F1990-0x00000001800F19E0
		public int m_smoothIterations; // 0x18
	
		// Constructors
		public TerrainHelper(); // 0x00000001816580E0-0x00000001816580F0
	
		// Methods
		private void Awake(); // 0x0000000180E816A0-0x0000000180E816D0
		public static void Flatten(); // 0x0000000181C02240-0x0000000181C02390
		public static void FlattenTerrain(Terrain terrain); // 0x0000000181C02160-0x0000000181C02240
		public static void FlattenTerrain(Terrain[] terrains); // 0x0000000181C02010-0x0000000181C02160
		public static void Stitch(); // 0x0000000181C03B10-0x0000000181C03B30
		public static void StitchTerrains(Terrain[] terrains); // 0x0000000181C035F0-0x0000000181C03B10
		public void Smooth(); // 0x0000000181C03550-0x0000000181C035F0
		public static void Smooth(int iterations); // 0x0000000181C034B0-0x0000000181C03550
		public static Vector3 GetActiveTerrainCenter(bool flushToGround = true /* Metadata: 0x0074426F */); // 0x0000000181C02390-0x0000000181C02510
		public static Terrain GetActiveTerrain(); // 0x0000000181C02840-0x0000000181C029A0
		public static LayerMask GetActiveTerrainLayer(); // 0x0000000181C02770-0x0000000181C02840
		public static LayerMask GetActiveTerrainLayerAsInt(); // 0x0000000181C02610-0x0000000181C02770
		public static int GetActiveTerrainCount(); // 0x0000000181C02510-0x0000000181C02610
		public static Terrain GetTerrain(Vector3 locationWU); // 0x0000000181C03160-0x0000000181C034B0
		public static bool GetTerrainBounds(Terrain terrain, ref Bounds bounds); // 0x0000000181C02D80-0x0000000181C02F60
		public static bool GetTerrainBounds(Vector3 locationWU, ref Bounds bounds); // 0x0000000181C02F60-0x0000000181C03160
		public static Vector3 GetRandomPositionOnTerrain(Terrain terrain, Vector3 start, float radius); // 0x0000000181C029A0-0x0000000181C02C60
		public static void ClearTrees(); // 0x0000000181C01E10-0x0000000181C02010
		public static void ClearDetails(); // 0x0000000181C01BB0-0x0000000181C01E10
		public static float GetRangeFromTerrain(); // 0x0000000181C02C60-0x0000000181C02D80
	}
}
