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
	public struct GaiaSplatPrototype // TypeDefIndex: 9250
	{
		// Fields
		public float metallic; // 0x00
		public Texture2D normalMap; // 0x08
		public float smoothness; // 0x10
		public Texture2D texture; // 0x18
		public Vector2 tileOffset; // 0x20
		public Vector2 tileSize; // 0x28
	
		// Constructors
		public GaiaSplatPrototype(TerrainLayer terrainLayer); // 0x0000000180109440-0x0000000180109500
	
		// Methods
		public TerrainLayer Convert(); // 0x0000000180109430-0x0000000180109440
		public static GaiaSplatPrototype[] GetGaiaSplatPrototypes(Terrain terrain); // 0x000000018198B620-0x000000018198B860
		public static void SetGaiaSplatPrototypes(Terrain terrain, GaiaSplatPrototype[] splats, string terrainName); // 0x000000018198B980-0x000000018198BDD0
		private static TerrainLayer[] LookupTerrainLayerAssetFiles(string terrainName); // 0x000000018198B860-0x000000018198B8C0
		private static TerrainLayer SaveTerrainLayerAsAsset(string terrainName, string layerId, TerrainLayer terrainLayer); // 0x000000018198B910-0x000000018198B980
		private static void RemoveTerrainLayerAssetFiles(string terrainName); // 0x000000018198B8C0-0x000000018198B910
	}
}
