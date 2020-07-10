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
	public class FBIKBoxing : UnityEngine.MonoBehaviour // TypeDefIndex: 9517
	{
		// Fields
		[Tooltip] // 0x00000001800D5D20-0x00000001800D5D50
		public Transform target; // 0x18
		[Tooltip] // 0x00000001800D5EF0-0x00000001800D5F20
		public Transform pin; // 0x20
		[Tooltip] // 0x00000001800D6090-0x00000001800D60C0
		public FullBodyBipedIK ik; // 0x28
		[Tooltip] // 0x00000001800D63B0-0x00000001800D63E0
		public AimIK aim; // 0x30
		[Tooltip] // 0x00000001800C2D70-0x00000001800C2DA0
		public float weight; // 0x38
		[Tooltip] // 0x00000001800D66F0-0x00000001800D6720
		public FullBodyBipedEffector effector; // 0x3C
		[Tooltip] // 0x00000001800D6940-0x00000001800D6970
		public AnimationCurve aimWeight; // 0x40
		private Animator animator; // 0x48
	
		// Constructors
		public FBIKBoxing(); // 0x0000000180407560-0x0000000180407570
	
		// Methods
		private void Start(); // 0x000000018182A4F0-0x000000018182A530
		private void LateUpdate(); // 0x000000018182A260-0x000000018182A4F0
	}
}
