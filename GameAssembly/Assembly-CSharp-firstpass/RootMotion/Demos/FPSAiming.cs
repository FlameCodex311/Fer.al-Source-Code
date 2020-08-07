/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion;
using RootMotion.FinalIK;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.Demos
{
	public class FPSAiming : UnityEngine.MonoBehaviour // TypeDefIndex: 9806
	{
		// Fields
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float aimWeight; // 0x18
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float sightWeight; // 0x1C
		[Range] // 0x000000018020FC30-0x000000018020FC50
		public float maxAngle; // 0x20
		public Vector3 aimOffset; // 0x24
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool animatePhysics; // 0x30
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Transform gun; // 0x38
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Transform gunTarget; // 0x40
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private FullBodyBipedIK ik; // 0x48
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private AimIK gunAim; // 0x50
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private CameraControllerFPS cam; // 0x58
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Recoil recoil; // 0x60
		[Range] // 0x000000018020DD00-0x000000018020DD40
		[SerializeField] // 0x000000018020DD00-0x000000018020DD40
		private float cameraRecoilWeight; // 0x68
		private Vector3 gunTargetDefaultLocalPosition; // 0x6C
		private Quaternion gunTargetDefaultLocalRotation; // 0x78
		private Vector3 camDefaultLocalPosition; // 0x88
		private Vector3 camRelativeToGunTarget; // 0x94
		private bool updateFrame; // 0xA0
	
		// Constructors
		public FPSAiming(); // 0x0000000181377EE0-0x0000000181377F10
	
		// Methods
		private void Start(); // 0x0000000181377D20-0x0000000181377EE0
		private void FixedUpdate(); // 0x00000001813768E0-0x00000001813768F0
		private void LateUpdate(); // 0x00000001813768F0-0x0000000181376A40
		private void Aiming(); // 0x0000000181376580-0x00000001813768E0
		private void LookDownTheSight(); // 0x0000000181376A40-0x00000001813779B0
		private void RotateCharacter(); // 0x00000001813779B0-0x0000000181377D20
	}
}
