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
	public class Scanner : UnityEngine.MonoBehaviour // TypeDefIndex: 9053
	{
		// Fields
		[Tooltip] // 0x00000001800E1170-0x00000001800E11A0
		public string m_featureName; // 0x18
		[Tooltip] // 0x00000001800E13B0-0x00000001800E13E0
		public GaiaConstants.FeatureType m_featureType; // 0x20
		[Range] // 0x00000001800E1510-0x00000001800E1560
		[Tooltip] // 0x00000001800E1510-0x00000001800E1560
		public float m_baseLevel; // 0x24
		[HideInInspector] // 0x00000001800E1900-0x00000001800E1960
		[Range] // 0x00000001800E1900-0x00000001800E1960
		[Tooltip] // 0x00000001800E1900-0x00000001800E1960
		public float m_scanResolution; // 0x28
		[Tooltip] // 0x00000001800E1AD0-0x00000001800E1B00
		public Material m_previewMaterial; // 0x30
		private HeightMap m_scanMap; // 0x38
		private Bounds m_scanBounds; // 0x40
		private int m_scanWidth; // 0x58
		private int m_scanDepth; // 0x5C
		private int m_scanHeight; // 0x60
		private Vector3 m_groundOffset; // 0x64
		private Vector3 m_groundSize; // 0x70
	
		// Constructors
		public Scanner(); // 0x0000000181795E70-0x0000000181795F70
	
		// Methods
		private void OnEnable(); // 0x00000001817955D0-0x0000000181795720
		private void Awake(); // 0x0000000180E816A0-0x0000000180E816D0
		public void Reset(); // 0x0000000181795720-0x0000000181795910
		public void LoadRawFile(string path, GaiaConstants.RawByteOrder byteOrder, ref GaiaConstants.RawBitDepth bitDepth, ref int resolution); // 0x00000001817943C0-0x00000001817948D0
		public void LoadTextureFile(Texture2D texture); // 0x0000000181794DF0-0x00000001817952E0
		public void LoadTerain(Terrain terrain); // 0x00000001817948D0-0x0000000181794DF0
		public void LoadGameObject(GameObject go); // 0x00000001817937D0-0x00000001817943C0
		public string SaveScan(); // 0x0000000181795910-0x0000000181795D20
		private void UpdateScanner(); // 0x0000000181795D20-0x0000000181795E70
		private void OnDrawGizmosSelected(); // 0x00000001817952E0-0x00000001817955D0
	}
}
