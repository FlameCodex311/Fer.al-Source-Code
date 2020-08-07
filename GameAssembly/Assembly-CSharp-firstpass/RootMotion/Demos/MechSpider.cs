/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.Demos
{
	public class MechSpider : UnityEngine.MonoBehaviour // TypeDefIndex: 9787
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
		public MechSpider(); // 0x000000018137C3E0-0x000000018137C430
	
		// Methods
		private void Update(); // 0x000000018137BA80-0x000000018137C3E0
		private Vector3 GetLegCentroid(); // 0x000000018137B340-0x000000018137B5A0
		private Vector3 GetLegsPlaneNormal(); // 0x000000018137B5A0-0x000000018137BA80
	}
}
