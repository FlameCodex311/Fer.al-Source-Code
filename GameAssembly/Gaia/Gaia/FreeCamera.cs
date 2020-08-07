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
	public class FreeCamera : UnityEngine.MonoBehaviour // TypeDefIndex: 9269
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
		public FreeCamera(); // 0x000000018150CFC0-0x000000018150CFF0
	
		// Methods
		private void Awake(); // 0x000000018150C950-0x000000018150C960
		private void OnEnable(); // 0x000000018150CA80-0x000000018150CAA0
		private void OnDisable(); // 0x000000018150CA40-0x000000018150CA80
		private void OnValidate(); // 0x000000018150CAA0-0x000000018150CAD0
		private void CaptureInput(); // 0x000000018150C960-0x000000018150CA00
		private void ReleaseInput(); // 0x000000018150CA40-0x000000018150CA80
		private void OnApplicationFocus(bool focus); // 0x000000018150CA00-0x000000018150CA40
		private void Update(); // 0x000000018150CAD0-0x000000018150CFC0
	}
}
