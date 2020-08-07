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
	public class FBIKBoxing : UnityEngine.MonoBehaviour // TypeDefIndex: 9804
	{
		// Fields
		[Tooltip] // 0x000000018020C340-0x000000018020C370
		public Transform target; // 0x18
		[Tooltip] // 0x000000018020C480-0x000000018020C4B0
		public Transform pin; // 0x20
		[Tooltip] // 0x000000018020C710-0x000000018020C740
		public FullBodyBipedIK ik; // 0x28
		[Tooltip] // 0x000000018020DCD0-0x000000018020DD00
		public AimIK aim; // 0x30
		[Tooltip] // 0x000000018020DFA0-0x000000018020DFD0
		public float weight; // 0x38
		[Tooltip] // 0x000000018020E1A0-0x000000018020E1D0
		public FullBodyBipedEffector effector; // 0x3C
		[Tooltip] // 0x000000018020E340-0x000000018020E370
		public AnimationCurve aimWeight; // 0x40
		private Animator animator; // 0x48
	
		// Constructors
		public FBIKBoxing(); // 0x0000000180568C50-0x0000000180569020
	
		// Methods
		private void Start(); // 0x0000000181375AE0-0x0000000181375B20
		private void LateUpdate(); // 0x0000000181375870-0x0000000181375AE0
	}
}
