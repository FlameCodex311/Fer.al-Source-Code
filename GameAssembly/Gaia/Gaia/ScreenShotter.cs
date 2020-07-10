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
	[GaiaScriptOrder] // 0x00000001800F31D0-0x00000001800F31F0
	public class ScreenShotter : UnityEngine.MonoBehaviour // TypeDefIndex: 9106
	{
		// Fields
		public KeyCode m_screenShotKey; // 0x18
		public GaiaConstants.StorageFormat m_imageFormat; // 0x1C
		public string m_targetDirectory; // 0x20
		public int m_targetWidth; // 0x28
		public int m_targetHeight; // 0x2C
		public bool m_useScreenSize; // 0x30
		public Camera m_mainCamera; // 0x38
		private bool m_takeShot; // 0x40
		private bool m_refreshAssetDB; // 0x41
		public Texture2D m_watermark; // 0x48
	
		// Constructors
		public ScreenShotter(); // 0x0000000181797270-0x00000001817972D0
	
		// Methods
		private void OnEnable(); // 0x0000000181796700-0x00000001817967D0
		private void OnDisable(); // 0x00000001817966F0-0x0000000181796700
		private void Start(); // 0x0000000181797250-0x0000000181797270
		public Camera FindCamera(); // 0x0000000181796150-0x00000001817962E0
		private string ScreenShotName(int width, int height); // 0x00000001817967D0-0x0000000181797250
		public void TakeHiResShot(); // 0x0000000181129050-0x0000000181129060
		private void LateUpdate(); // 0x00000001817962E0-0x00000001817966F0
		public Texture2D AddWatermark(Texture2D background, Texture2D watermark); // 0x0000000181795F70-0x0000000181796150
	}
}
