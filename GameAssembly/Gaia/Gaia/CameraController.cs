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
	public class CameraController : UnityEngine.MonoBehaviour // TypeDefIndex: 9267
	{
		// Fields
		public GameObject target; // 0x18
		public float targetHeight; // 0x20
		public float distance; // 0x24
		public float offsetFromWall; // 0x28
		public float maxDistance; // 0x2C
		public float minDistance; // 0x30
		public float xSpeed; // 0x34
		public float ySpeed; // 0x38
		public float yMinLimit; // 0x3C
		public float yMaxLimit; // 0x40
		public float zoomRate; // 0x44
		public float rotationDampening; // 0x48
		public float zoomDampening; // 0x4C
		public LayerMask collisionLayers; // 0x50
		public bool lockToRearOfTarget; // 0x54
		public bool allowMouseInputX; // 0x55
		public bool allowMouseInputY; // 0x56
		private float xDeg; // 0x58
		private float yDeg; // 0x5C
		private float currentDistance; // 0x60
		private float desiredDistance; // 0x64
		private float correctedDistance; // 0x68
		private bool rotateBehind; // 0x6C
		private bool mouseSideButton; // 0x6D
		private float pbuffer; // 0x70
	
		// Constructors
		public CameraController(); // 0x000000018150AC90-0x000000018150AD10
	
		// Methods
		private void Start(); // 0x000000018150ABB0-0x000000018150AC90
		private void LateUpdate(); // 0x000000018150A150-0x000000018150AA80
		private void RotateBehindTarget(); // 0x000000018150AA80-0x000000018150ABB0
		private float ClampAngle(float angle, float min, float max); // 0x000000018150A0B0-0x000000018150A150
	}
}
