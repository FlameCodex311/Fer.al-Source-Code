/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 57: Beautify.dll - Assembly: Beautify, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7239-7251

namespace BeautifyEffect
{
	public class FreeCameraMove : UnityEngine.MonoBehaviour // TypeDefIndex: 7244
	{
		// Fields
		public float cameraSensitivity; // 0x18
		public float climbSpeed; // 0x1C
		public float normalMoveSpeed; // 0x20
		public float slowMoveFactor; // 0x24
		public float fastMoveFactor; // 0x28
		private float rotationX; // 0x2C
		private float rotationY; // 0x30
		private Quaternion originalRotation; // 0x34
	
		// Constructors
		public FreeCameraMove(); // 0x0000000182276A50-0x0000000182276A80
	
		// Methods
		private void Start(); // 0x0000000182275C10-0x0000000182275C70
		private void Update(); // 0x0000000182275C70-0x0000000182276A50
	}
}
