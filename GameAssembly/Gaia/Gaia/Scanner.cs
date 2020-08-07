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
	public class Scanner : UnityEngine.MonoBehaviour // TypeDefIndex: 9219
	{
		// Fields
		[Tooltip] // 0x000000018023F7F0-0x000000018023F820
		public string m_featureName; // 0x18
		[Tooltip] // 0x000000018023F9F0-0x000000018023FA20
		public GaiaConstants.FeatureType m_featureType; // 0x20
		[Range] // 0x000000018023FC80-0x000000018023FCD0
		[Tooltip] // 0x000000018023FC80-0x000000018023FCD0
		public float m_baseLevel; // 0x24
		[HideInInspector] // 0x000000018023FFD0-0x0000000180240030
		[Range] // 0x000000018023FFD0-0x0000000180240030
		[Tooltip] // 0x000000018023FFD0-0x0000000180240030
		public float m_scanResolution; // 0x28
		[Tooltip] // 0x0000000180240230-0x0000000180240260
		public Material m_previewMaterial; // 0x30
		private HeightMap m_scanMap; // 0x38
		private Bounds m_scanBounds; // 0x40
		private int m_scanWidth; // 0x58
		private int m_scanDepth; // 0x5C
		private int m_scanHeight; // 0x60
		private Vector3 m_groundOffset; // 0x64
		private Vector3 m_groundSize; // 0x70
	
		// Constructors
		public Scanner(); // 0x000000018155E9A0-0x000000018155EAA0
	
		// Methods
		private void OnEnable(); // 0x000000018155E2D0-0x000000018155E410
		private void Awake(); // 0x00000001803CAFE0-0x00000001803CB010
		public void Reset(); // 0x000000018155E410-0x000000018155E5F0
		public void LoadRawFile(string path, GaiaConstants.RawByteOrder byteOrder, ref GaiaConstants.RawBitDepth bitDepth, ref int resolution); // 0x000000018155D210-0x000000018155D690
		public void LoadTextureFile(Texture2D texture); // 0x000000018155DB50-0x000000018155DFE0
		public void LoadTerain(Terrain terrain); // 0x000000018155D690-0x000000018155DB50
		public void LoadGameObject(GameObject go); // 0x000000018155C6A0-0x000000018155D210
		public string SaveScan(); // 0x000000018155E5F0-0x000000018155E860
		private void UpdateScanner(); // 0x000000018155E860-0x000000018155E9A0
		private void OnDrawGizmosSelected(); // 0x000000018155DFE0-0x000000018155E2D0
	}
}
