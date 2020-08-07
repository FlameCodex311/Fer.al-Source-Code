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
	public class UnityHeightMap : HeightMap // TypeDefIndex: 9263
	{
		// Fields
		public Bounds m_boundsWU; // 0x50
	
		// Constructors
		public UnityHeightMap(); // 0x00000001816FE100-0x00000001816FE110
		public UnityHeightMap(string path); // 0x00000001816FDF00-0x00000001816FDF70
		public UnityHeightMap(TextAsset source); // 0x00000001816FE070-0x00000001816FE100
		public UnityHeightMap(UnityHeightMap source); // 0x00000001816FE020-0x00000001816FE070
		public UnityHeightMap(Terrain terrain); // 0x00000001816FDFF0-0x00000001816FE020
		public UnityHeightMap(Bounds bounds, string sourceFile); // 0x00000001816FDF70-0x00000001816FDFB0
		public UnityHeightMap(Texture2D texture); // 0x00000001816FDFB0-0x00000001816FDFF0
	
		// Methods
		public Bounds GetBoundsWU(); // 0x00000001816FD3D0-0x00000001816FD3F0
		public Vector3 GetPositionWU(); // 0x00000001816FD3F0-0x00000001816FD4E0
		public void SetBoundsWU(Bounds bounds); // 0x00000001816FDEA0-0x00000001816FDEC0
		public void SetPositionWU(Vector3 position); // 0x00000001816FDEC0-0x00000001816FDF00
		public void LoadFromTerrain(Terrain terrain); // 0x00000001816FD4E0-0x00000001816FD790
		public void SaveToTerrain(Terrain terrain); // 0x00000001816FDCA0-0x00000001816FDEA0
		public void LoadFromTexture2D(Texture2D texture); // 0x00000001816FD790-0x00000001816FD940
		public void ReadRawFromTextAsset(TextAsset asset); // 0x00000001816FD940-0x00000001816FDCA0
		public Texture2D CalculateNormals(); // 0x00000001816FD050-0x00000001816FD3D0
	}
}
