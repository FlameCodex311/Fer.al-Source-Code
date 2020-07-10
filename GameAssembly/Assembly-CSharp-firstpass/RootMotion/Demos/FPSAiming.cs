/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion;
using RootMotion.FinalIK;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion.Demos
{
	public class FPSAiming : UnityEngine.MonoBehaviour // TypeDefIndex: 9519
	{
		// Fields
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float aimWeight; // 0x18
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float sightWeight; // 0x1C
		[Range] // 0x00000001800D6F30-0x00000001800D6F50
		public float maxAngle; // 0x20
		public Vector3 aimOffset; // 0x24
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool animatePhysics; // 0x30
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Transform gun; // 0x38
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Transform gunTarget; // 0x40
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private FullBodyBipedIK ik; // 0x48
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private AimIK gunAim; // 0x50
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private CameraControllerFPS cam; // 0x58
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Recoil recoil; // 0x60
		[Range] // 0x00000001800B5F40-0x00000001800B5F80
		[SerializeField] // 0x00000001800B5F40-0x00000001800B5F80
		private float cameraRecoilWeight; // 0x68
		private Vector3 gunTargetDefaultLocalPosition; // 0x6C
		private Quaternion gunTargetDefaultLocalRotation; // 0x78
		private Vector3 camDefaultLocalPosition; // 0x88
		private Vector3 camRelativeToGunTarget; // 0x94
		private bool updateFrame; // 0xA0
	
		// Constructors
		public FPSAiming(); // 0x0000000181831430-0x0000000181831460
	
		// Methods
		private void Start(); // 0x0000000181831260-0x0000000181831430
		private void FixedUpdate(); // 0x000000018182FDA0-0x000000018182FDB0
		private void LateUpdate(); // 0x000000018182FDB0-0x000000018182FF00
		private void Aiming(); // 0x000000018182FA30-0x000000018182FDA0
		private void LookDownTheSight(); // 0x000000018182FF00-0x0000000181830EE0
		private void RotateCharacter(); // 0x0000000181830EE0-0x0000000181831260
	}
}
