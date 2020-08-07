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
	public class BipedIKvsAnimatorIK : UnityEngine.MonoBehaviour // TypeDefIndex: 9786
	{
		// Fields
		[LargeHeader] // 0x0000000180207EE0-0x0000000180207F10
		public Animator animator; // 0x18
		public BipedIK bipedIK; // 0x20
		[LargeHeader] // 0x0000000180208140-0x0000000180208170
		public Transform lookAtTargetBiped; // 0x28
		public Transform lookAtTargetAnimator; // 0x30
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float lookAtWeight; // 0x38
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float lookAtBodyWeight; // 0x3C
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float lookAtHeadWeight; // 0x40
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float lookAtEyesWeight; // 0x44
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float lookAtClampWeight; // 0x48
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float lookAtClampWeightHead; // 0x4C
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float lookAtClampWeightEyes; // 0x50
		[LargeHeader] // 0x0000000180208FB0-0x0000000180208FE0
		public Transform footTargetBiped; // 0x58
		public Transform footTargetAnimator; // 0x60
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float footPositionWeight; // 0x68
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float footRotationWeight; // 0x6C
		[LargeHeader] // 0x0000000180209440-0x0000000180209470
		public Transform handTargetBiped; // 0x70
		public Transform handTargetAnimator; // 0x78
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float handPositionWeight; // 0x80
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float handRotationWeight; // 0x84
	
		// Constructors
		public BipedIKvsAnimatorIK(); // 0x0000000181368320-0x0000000181368360
	
		// Methods
		private void OnAnimatorIK(int layer); // 0x0000000181367A80-0x0000000181368320
	}
}
