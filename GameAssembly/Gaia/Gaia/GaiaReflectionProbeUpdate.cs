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
	[RequireComponent] // 0x00000001800C0D50-0x00000001800C0DA0
	public class GaiaReflectionProbeUpdate : UnityEngine.MonoBehaviour // TypeDefIndex: 8993
	{
		// Fields
		[Header] // 0x00000001800C0F90-0x00000001800C0FF0
		[Tooltip] // 0x00000001800C0F90-0x00000001800C0FF0
		public ReflectionQuality m_probeResolution; // 0x18
		[Tooltip] // 0x00000001800C1260-0x00000001800C1290
		public RenderDistanceQuality m_probeRenderDistance; // 0x1C
		[Tooltip] // 0x00000001800C1450-0x00000001800C1480
		public bool m_followCamera; // 0x20
		[Tooltip] // 0x00000001800C1700-0x00000001800C1730
		public float m_followHeightOffset; // 0x24
		[Tooltip] // 0x00000001800C18F0-0x00000001800C1920
		public bool m_boxProjection; // 0x28
		[Tooltip] // 0x00000001800C1B00-0x00000001800C1B30
		public bool m_useHDR; // 0x29
		private int m_renderID; // 0x2C
		private ReflectionProbe m_reflectionProbe; // 0x30
		private bool m_cameraIsMoving; // 0x38
		private Vector3 m_lastLocation; // 0x3C
		public GameObject m_mainCameraObject; // 0x48
	
		// Nested types
		public enum ReflectionQuality // TypeDefIndex: 8994
		{
			VeryLow = 0,
			Low = 1,
			Medium = 2,
			High = 3,
			VeryHigh = 4,
			Ultra = 5
		}
	
		public enum RenderDistanceQuality // TypeDefIndex: 8995
		{
			Close = 0,
			Near = 1,
			Far = 2,
			VeryFar = 3,
			ExtremelyFar = 4
		}
	
		// Constructors
		public GaiaReflectionProbeUpdate(); // 0x00000001815884C0-0x00000001815884E0
	
		// Methods
		private void Start(); // 0x0000000181588450-0x00000001815884C0
		private void LateUpdate(); // 0x0000000181587D10-0x0000000181588010
		public void SetProbeSettings(); // 0x0000000181588130-0x0000000181588450
		public void ProbeFollow(); // 0x0000000181588010-0x0000000181588130
		private static GameObject GetOrCreateMainCamera(); // 0x0000000181587A80-0x0000000181587D10
	}
}
