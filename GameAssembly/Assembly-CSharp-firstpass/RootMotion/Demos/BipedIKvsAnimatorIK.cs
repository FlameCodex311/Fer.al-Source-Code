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
	public class BipedIKvsAnimatorIK : UnityEngine.MonoBehaviour // TypeDefIndex: 9499
	{
		// Fields
		[LargeHeader] // 0x00000001800D0590-0x00000001800D05C0
		public Animator animator; // 0x18
		public BipedIK bipedIK; // 0x20
		[LargeHeader] // 0x00000001800D0890-0x00000001800D08C0
		public Transform lookAtTargetBiped; // 0x28
		public Transform lookAtTargetAnimator; // 0x30
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float lookAtWeight; // 0x38
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float lookAtBodyWeight; // 0x3C
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float lookAtHeadWeight; // 0x40
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float lookAtEyesWeight; // 0x44
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float lookAtClampWeight; // 0x48
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float lookAtClampWeightHead; // 0x4C
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float lookAtClampWeightEyes; // 0x50
		[LargeHeader] // 0x00000001800D1840-0x00000001800D1870
		public Transform footTargetBiped; // 0x58
		public Transform footTargetAnimator; // 0x60
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float footPositionWeight; // 0x68
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float footRotationWeight; // 0x6C
		[LargeHeader] // 0x00000001800D1EB0-0x00000001800D1EE0
		public Transform handTargetBiped; // 0x70
		public Transform handTargetAnimator; // 0x78
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float handPositionWeight; // 0x80
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float handRotationWeight; // 0x84
	
		// Constructors
		public BipedIKvsAnimatorIK(); // 0x000000018163BC30-0x000000018163BC70
	
		// Methods
		private void OnAnimatorIK(int layer); // 0x000000018163B350-0x000000018163BC30
	}
}
