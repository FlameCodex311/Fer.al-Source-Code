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
	public class FrameRateManager : UnityEngine.MonoBehaviour // TypeDefIndex: 9268
	{
		// Fields
		public bool m_showFPS; // 0x18
		public bool m_showGUI; // 0x19
		public bool m_autoQualityManagement; // 0x1A
		public float m_autoCheckInterval; // 0x1C
		public int m_targetFrameRate; // 0x20
		public int m_fontSize; // 0x24
		private float m_autoCheckTimeLeft; // 0x28
		private int m_currentQuality; // 0x2C
		private int m_maxQuality; // 0x30
		private string[] m_qualityNames; // 0x38
		private float m_fpsUpdateInterval; // 0x40
		private float m_fpsAccum; // 0x44
		private int m_fpsFrames; // 0x48
		private float m_fpsTimeLeft; // 0x4C
		private float m_fpsValue; // 0x50
		private string m_fpsValueStr; // 0x58
		private GUIStyle m_fpsStyle; // 0x60
		private GUIStyle m_fpsShadowStyle; // 0x68
		private Rect m_fpsLocation; // 0x70
		private Rect m_fpsShadowLocation; // 0x80
	
		// Constructors
		public FrameRateManager(); // 0x000000018150C800-0x000000018150C950
	
		// Methods
		private void Start(); // 0x000000018150BA00-0x000000018150BBD0
		private void OnGUI(); // 0x000000018150B7F0-0x000000018150BA00
		private void Update(); // 0x000000018150C550-0x000000018150C800
		private void UpdateQuality(); // 0x000000018150BBD0-0x000000018150C550
		private bool IncreaseQuality(); // 0x000000018150B7D0-0x000000018150B7F0
		private bool DecreaseQuality(); // 0x000000018150B7B0-0x000000018150B7D0
	}
}
