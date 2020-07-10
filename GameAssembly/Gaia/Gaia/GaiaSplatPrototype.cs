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
	public struct GaiaSplatPrototype // TypeDefIndex: 9084
	{
		// Fields
		public float metallic; // 0x00
		public Texture2D normalMap; // 0x08
		public float smoothness; // 0x10
		public Texture2D texture; // 0x18
		public Vector2 tileOffset; // 0x20
		public Vector2 tileSize; // 0x28
	
		// Constructors
		public GaiaSplatPrototype(TerrainLayer terrainLayer); // 0x000000018022E310-0x000000018022E550
	
		// Methods
		public TerrainLayer Convert(); // 0x000000018022E300-0x000000018022E310
		public static GaiaSplatPrototype[] GetGaiaSplatPrototypes(Terrain terrain); // 0x00000001815975F0-0x0000000181597840
		public static void SetGaiaSplatPrototypes(Terrain terrain, GaiaSplatPrototype[] splats, string terrainName); // 0x0000000181597960-0x0000000181597DC0
		private static TerrainLayer[] LookupTerrainLayerAssetFiles(string terrainName); // 0x0000000181597840-0x00000001815978A0
		private static TerrainLayer SaveTerrainLayerAsAsset(string terrainName, string layerId, TerrainLayer terrainLayer); // 0x00000001815978F0-0x0000000181597960
		private static void RemoveTerrainLayerAssetFiles(string terrainName); // 0x00000001815978A0-0x00000001815978F0
	}
}
