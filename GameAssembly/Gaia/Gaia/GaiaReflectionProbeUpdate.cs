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
	[RequireComponent] // 0x0000000180220AF0-0x0000000180220B40
	public class GaiaReflectionProbeUpdate : UnityEngine.MonoBehaviour // TypeDefIndex: 9159
	{
		// Fields
		[Header] // 0x0000000180220D50-0x0000000180220DB0
		[Tooltip] // 0x0000000180220D50-0x0000000180220DB0
		public ReflectionQuality m_probeResolution; // 0x18
		[Tooltip] // 0x0000000180221170-0x00000001802211A0
		public RenderDistanceQuality m_probeRenderDistance; // 0x1C
		[Tooltip] // 0x00000001802212E0-0x0000000180221310
		public bool m_followCamera; // 0x20
		[Tooltip] // 0x00000001802213E0-0x0000000180221410
		public float m_followHeightOffset; // 0x24
		[Tooltip] // 0x0000000180221600-0x0000000180221630
		public bool m_boxProjection; // 0x28
		[Tooltip] // 0x00000001802218F0-0x0000000180221920
		public bool m_useHDR; // 0x29
		private int m_renderID; // 0x2C
		private ReflectionProbe m_reflectionProbe; // 0x30
		private bool m_cameraIsMoving; // 0x38
		private Vector3 m_lastLocation; // 0x3C
		public GameObject m_mainCameraObject; // 0x48
	
		// Nested types
		public enum ReflectionQuality // TypeDefIndex: 9160
		{
			VeryLow = 0,
			Low = 1,
			Medium = 2,
			High = 3,
			VeryHigh = 4,
			Ultra = 5
		}
	
		public enum RenderDistanceQuality // TypeDefIndex: 9161
		{
			Close = 0,
			Near = 1,
			Far = 2,
			VeryFar = 3,
			ExtremelyFar = 4
		}
	
		// Constructors
		public GaiaReflectionProbeUpdate(); // 0x0000000180E3F380-0x0000000180E3F3A0
	
		// Methods
		private void Start(); // 0x0000000180E3F310-0x0000000180E3F380
		private void LateUpdate(); // 0x0000000180E3EBD0-0x0000000180E3EED0
		public void SetProbeSettings(); // 0x0000000180E3EFF0-0x0000000180E3F310
		public void ProbeFollow(); // 0x0000000180E3EED0-0x0000000180E3EFF0
		private static GameObject GetOrCreateMainCamera(); // 0x0000000180E3E950-0x0000000180E3EBD0
	}
}
