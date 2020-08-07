/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.Demos
{
	[RequireComponent] // 0x000000018020B690-0x000000018020B710
	[RequireComponent] // 0x000000018020B690-0x000000018020B710
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson // TypeDefIndex: 9796
	{
		// Fields
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float headLookWeight; // 0x60
		public Vector3 gunHoldOffset; // 0x64
		public Vector3 leftHandOffset; // 0x70
		public Recoil recoil; // 0x80
		private AimIK aim; // 0x88
		private FullBodyBipedIK ik; // 0x90
		private Vector3 headLookAxis; // 0x98
		private Vector3 leftHandPosRelToRightHand; // 0xA4
		private Quaternion leftHandRotRelToRightHand; // 0xB0
		private Vector3 aimTarget; // 0xC0
		private Quaternion rightHandRotation; // 0xCC
	
		// Constructors
		public AnimatorController3rdPersonIK(); // 0x0000000181367290-0x00000001813672C0
	
		// Methods
		protected override void Start(); // 0x0000000181367040-0x0000000181367290
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget); // 0x00000001813667C0-0x00000001813668E0
		private void Read(); // 0x0000000181366E50-0x0000000181367040
		private void AimIK(); // 0x0000000181365EF0-0x0000000181365F60
		private void FBBIK(); // 0x0000000181365F60-0x00000001813664D0
		private void OnPreRead(); // 0x00000001813669F0-0x0000000181366E50
		private void HeadLookAt(Vector3 lookAtTarget); // 0x00000001813664D0-0x00000001813667C0
		private void OnDestroy(); // 0x00000001813668E0-0x00000001813669F0
	}
}
