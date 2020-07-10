/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion.Demos
{
	public class MechSpider : UnityEngine.MonoBehaviour // TypeDefIndex: 9500
	{
		// Fields
		public LayerMask raycastLayers; // 0x18
		public float scale; // 0x1C
		public Transform body; // 0x20
		public MechSpiderLeg[] legs; // 0x28
		public float legRotationWeight; // 0x30
		public float rootPositionSpeed; // 0x34
		public float rootRotationSpeed; // 0x38
		public float breatheSpeed; // 0x3C
		public float breatheMagnitude; // 0x40
		public float height; // 0x44
		public float minHeight; // 0x48
		public float raycastHeight; // 0x4C
		public float raycastDistance; // 0x50
		private Vector3 lastPosition; // 0x54
		private Vector3 defaultBodyLocalPosition; // 0x60
		private float sine; // 0x6C
		private RaycastHit rootHit; // 0x70
	
		// Constructors
		public MechSpider(); // 0x0000000181835A60-0x0000000181835AB0
	
		// Methods
		private void Update(); // 0x00000001818350E0-0x0000000181835A60
		private Vector3 GetLegCentroid(); // 0x0000000181834980-0x0000000181834BF0
		private Vector3 GetLegsPlaneNormal(); // 0x0000000181834BF0-0x00000001818350E0
	}
}
