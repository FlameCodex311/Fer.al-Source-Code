/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion.Demos
{
	[RequireComponent] // 0x00000001800D5000-0x00000001800D5080
	[RequireComponent] // 0x00000001800D5000-0x00000001800D5080
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson // TypeDefIndex: 9509
	{
		// Fields
		[Range] // 0x00000001800C20E0-0x00000001800C2100
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
		public AnimatorController3rdPersonIK(); // 0x000000018163A2A0-0x000000018163A2D0
	
		// Methods
		protected override void Start(); // 0x000000018163A050-0x000000018163A2A0
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget); // 0x00000001816397A0-0x00000001816398C0
		private void Read(); // 0x0000000181639E50-0x000000018163A050
		private void AimIK(); // 0x0000000181638EA0-0x0000000181638F10
		private void FBBIK(); // 0x0000000181638F10-0x00000001816394A0
		private void OnPreRead(); // 0x00000001816399E0-0x0000000181639E50
		private void HeadLookAt(Vector3 lookAtTarget); // 0x00000001816394A0-0x00000001816397A0
		private void OnDestroy(); // 0x00000001816398C0-0x00000001816399E0
	}
}
