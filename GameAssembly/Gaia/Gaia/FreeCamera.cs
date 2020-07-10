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
	public class FreeCamera : UnityEngine.MonoBehaviour // TypeDefIndex: 9103
	{
		// Fields
		public bool enableInputCapture; // 0x18
		public bool lockAndHideCursor; // 0x19
		public bool holdRightMouseCapture; // 0x1A
		public float lookSpeed; // 0x1C
		public float moveSpeed; // 0x20
		public float sprintSpeed; // 0x24
		private bool m_inputCaptured; // 0x28
		private float m_yaw; // 0x2C
		private float m_pitch; // 0x30
	
		// Constructors
		public FreeCamera(); // 0x00000001818E5D50-0x00000001818E5D80
	
		// Methods
		private void Awake(); // 0x00000001818E56D0-0x00000001818E56E0
		private void OnEnable(); // 0x00000001818E5800-0x00000001818E5820
		private void OnDisable(); // 0x00000001818E57C0-0x00000001818E5800
		private void OnValidate(); // 0x00000001818E5820-0x00000001818E5850
		private void CaptureInput(); // 0x00000001818E56E0-0x00000001818E5780
		private void ReleaseInput(); // 0x00000001818E57C0-0x00000001818E5800
		private void OnApplicationFocus(bool focus); // 0x00000001818E5780-0x00000001818E57C0
		private void Update(); // 0x00000001818E5850-0x00000001818E5D50
	}
}
