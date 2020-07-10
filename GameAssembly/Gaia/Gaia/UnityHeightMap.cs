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
	public class UnityHeightMap : HeightMap // TypeDefIndex: 9097
	{
		// Fields
		public Bounds m_boundsWU; // 0x50
	
		// Constructors
		public UnityHeightMap(); // 0x0000000181C08F40-0x0000000181C08F50
		public UnityHeightMap(string path); // 0x0000000181C08D40-0x0000000181C08DB0
		public UnityHeightMap(TextAsset source); // 0x0000000181C08EB0-0x0000000181C08F40
		public UnityHeightMap(UnityHeightMap source); // 0x0000000181C08E60-0x0000000181C08EB0
		public UnityHeightMap(Terrain terrain); // 0x0000000181C08E30-0x0000000181C08E60
		public UnityHeightMap(Bounds bounds, string sourceFile); // 0x0000000181C08DB0-0x0000000181C08DF0
		public UnityHeightMap(Texture2D texture); // 0x0000000181C08DF0-0x0000000181C08E30
	
		// Methods
		public Bounds GetBoundsWU(); // 0x0000000181C081E0-0x0000000181C08200
		public Vector3 GetPositionWU(); // 0x0000000181C08200-0x0000000181C082F0
		public void SetBoundsWU(Bounds bounds); // 0x0000000181C08CE0-0x0000000181C08D00
		public void SetPositionWU(Vector3 position); // 0x0000000181C08D00-0x0000000181C08D40
		public void LoadFromTerrain(Terrain terrain); // 0x0000000181C082F0-0x0000000181C085B0
		public void SaveToTerrain(Terrain terrain); // 0x0000000181C08AD0-0x0000000181C08CE0
		public void LoadFromTexture2D(Texture2D texture); // 0x0000000181C085B0-0x0000000181C08760
		public void ReadRawFromTextAsset(TextAsset asset); // 0x0000000181C08760-0x0000000181C08AD0
		public Texture2D CalculateNormals(); // 0x0000000181C07E50-0x0000000181C081E0
	}
}
