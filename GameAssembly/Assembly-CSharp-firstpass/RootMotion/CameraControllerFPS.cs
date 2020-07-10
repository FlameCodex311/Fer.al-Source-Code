/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion
{
	public class CameraControllerFPS : UnityEngine.MonoBehaviour // TypeDefIndex: 9303
	{
		// Fields
		public float rotationSensitivity; // 0x18
		public float yMinLimit; // 0x1C
		public float yMaxLimit; // 0x20
		private float x; // 0x24
		private float y; // 0x28
	
		// Constructors
		public CameraControllerFPS(); // 0x0000000181645F50-0x0000000181645F70
	
		// Methods
		private void Awake(); // 0x0000000181645C30-0x0000000181645C80
		public void LateUpdate(); // 0x0000000181645D20-0x0000000181645F50
		private float ClampAngle(float angle, float min, float max); // 0x0000000181645C80-0x0000000181645D20
	}
}
