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
	public class TerrainHelper : UnityEngine.MonoBehaviour // TypeDefIndex: 9261
	{
		// Fields
		[Range] // 0x000000018024FBC0-0x000000018024FC10
		[Tooltip] // 0x000000018024FBC0-0x000000018024FC10
		public int m_smoothIterations; // 0x18
	
		// Constructors
		public TerrainHelper(); // 0x0000000180D2BD60-0x0000000180D2BD70
	
		// Methods
		private void Awake(); // 0x00000001803CAFE0-0x00000001803CB010
		public static void Flatten(); // 0x00000001816F7F70-0x00000001816F80C0
		public static void FlattenTerrain(Terrain terrain); // 0x00000001816F7E90-0x00000001816F7F70
		public static void FlattenTerrain(Terrain[] terrains); // 0x00000001816F7D40-0x00000001816F7E90
		public static void Stitch(); // 0x00000001816F97E0-0x00000001816F9800
		public static void StitchTerrains(Terrain[] terrains); // 0x00000001816F92F0-0x00000001816F97E0
		public void Smooth(); // 0x00000001816F9250-0x00000001816F92F0
		public static void Smooth(int iterations); // 0x00000001816F91B0-0x00000001816F9250
		public static Vector3 GetActiveTerrainCenter(bool flushToGround = true /* Metadata: 0x00778F5D */); // 0x00000001816F80C0-0x00000001816F8240
		public static Terrain GetActiveTerrain(); // 0x00000001816F8550-0x00000001816F86B0
		public static LayerMask GetActiveTerrainLayer(); // 0x00000001816F8490-0x00000001816F8550
		public static LayerMask GetActiveTerrainLayerAsInt(); // 0x00000001816F8330-0x00000001816F8490
		public static int GetActiveTerrainCount(); // 0x00000001816F8240-0x00000001816F8330
		public static Terrain GetTerrain(Vector3 locationWU); // 0x00000001816F8E70-0x00000001816F91B0
		public static bool GetTerrainBounds(Terrain terrain, ref Bounds bounds); // 0x00000001816F8A90-0x00000001816F8C70
		public static bool GetTerrainBounds(Vector3 locationWU, ref Bounds bounds); // 0x00000001816F8C70-0x00000001816F8E70
		public static Vector3 GetRandomPositionOnTerrain(Terrain terrain, Vector3 start, float radius); // 0x00000001816F86B0-0x00000001816F8970
		public static void ClearTrees(); // 0x00000001816F7B60-0x00000001816F7D40
		public static void ClearDetails(); // 0x00000001816F7920-0x00000001816F7B60
		public static float GetRangeFromTerrain(); // 0x00000001816F8970-0x00000001816F8A90
	}
}
