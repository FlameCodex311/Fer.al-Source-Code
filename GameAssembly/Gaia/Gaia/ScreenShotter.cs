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
	[GaiaScriptOrder] // 0x0000000180252D70-0x0000000180252D90
	public class ScreenShotter : UnityEngine.MonoBehaviour // TypeDefIndex: 9272
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
		public ScreenShotter(); // 0x000000018155FD20-0x000000018155FD80
	
		// Methods
		private void OnEnable(); // 0x000000018155F220-0x000000018155F2F0
		private void OnDisable(); // 0x000000018155F210-0x000000018155F220
		private void Start(); // 0x000000018155FD00-0x000000018155FD20
		public Camera FindCamera(); // 0x000000018155EC80-0x000000018155EE00
		private string ScreenShotName(int width, int height); // 0x000000018155F2F0-0x000000018155FD00
		public void TakeHiResShot(); // 0x000000018096E300-0x000000018096E310
		private void LateUpdate(); // 0x000000018155EE00-0x000000018155F210
		public Texture2D AddWatermark(Texture2D background, Texture2D watermark); // 0x000000018155EAA0-0x000000018155EC80
	}
}
