/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion
{
	public class CameraControllerFPS : UnityEngine.MonoBehaviour // TypeDefIndex: 9757
	{
		// Fields
		public float rotationSensitivity; // 0x18
		public float yMinLimit; // 0x1C
		public float yMaxLimit; // 0x20
		private float x; // 0x24
		private float y; // 0x28
	
		// Constructors
		public CameraControllerFPS(); // 0x000000018136CAF0-0x000000018136CB10
	
		// Methods
		private void Awake(); // 0x000000018136C7D0-0x000000018136C820
		public void LateUpdate(); // 0x000000018136C8C0-0x000000018136CAF0
		private float ClampAngle(float angle, float min, float max); // 0x000000018136C820-0x000000018136C8C0
	}
}
