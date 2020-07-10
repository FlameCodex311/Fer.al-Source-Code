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
	public class SimpleAimingSystem : UnityEngine.MonoBehaviour // TypeDefIndex: 9497
	{
		// Fields
		[Tooltip] // 0x00000001800CF410-0x00000001800CF440
		public AimPoser aimPoser; // 0x18
		[Tooltip] // 0x00000001800CF6D0-0x00000001800CF700
		public AimIK aim; // 0x20
		[Tooltip] // 0x00000001800CF800-0x00000001800CF830
		public LookAtIK lookAt; // 0x28
		[Tooltip] // 0x00000001800CFB10-0x00000001800CFB40
		public Animator animator; // 0x30
		[Tooltip] // 0x00000001800CFDE0-0x00000001800CFE10
		public float crossfadeTime; // 0x38
		[Tooltip] // 0x00000001800D0270-0x00000001800D02A0
		public float minAimDistance; // 0x3C
		private AimPoser.Pose aimPose; // 0x40
		private AimPoser.Pose lastPose; // 0x48
	
		// Constructors
		public SimpleAimingSystem(); // 0x000000018183C460-0x000000018183C480
	
		// Methods
		private void Start(); // 0x000000018183C420-0x000000018183C460
		private void LateUpdate(); // 0x000000018183BC30-0x000000018183BD90
		private void Pose(); // 0x000000018183C070-0x000000018183C420
		private void LimitAimTarget(); // 0x000000018183BD90-0x000000018183C070
		private void DirectCrossFade(string state, float target); // 0x000000018183BB30-0x000000018183BC30
	}
}
