/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.FinalIK
{
	public class IKExecutionOrder : UnityEngine.MonoBehaviour // TypeDefIndex: 9893
	{
		// Fields
		[Tooltip] // 0x000000018023A400-0x000000018023A430
		public IK[] IKComponents; // 0x18
		[Tooltip] // 0x000000018023A540-0x000000018023A570
		public Animator animator; // 0x20
		private bool fixedFrame; // 0x28
	
		// Properties
		private bool animatePhysics { get; } // 0x00000001819E3460-0x00000001819E34F0 
	
		// Constructors
		public IKExecutionOrder(); // 0x0000000180568C50-0x0000000180569020
	
		// Methods
		private void Start(); // 0x00000001819E33A0-0x00000001819E3430
		private void Update(); // 0x00000001819E3430-0x00000001819E3460
		private void FixedUpdate(); // 0x00000001819E3240-0x00000001819E3270
		private void LateUpdate(); // 0x00000001819E3270-0x00000001819E33A0
		private void FixTransforms(); // 0x00000001819E3150-0x00000001819E3240
	}
}
