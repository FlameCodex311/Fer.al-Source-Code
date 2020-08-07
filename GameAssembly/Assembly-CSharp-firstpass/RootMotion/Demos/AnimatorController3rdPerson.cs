/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.Demos
{
	[RequireComponent] // 0x000000018020B440-0x000000018020B490
	public class AnimatorController3rdPerson : UnityEngine.MonoBehaviour // TypeDefIndex: 9795
	{
		// Fields
		public float rotateSpeed; // 0x18
		public float blendSpeed; // 0x1C
		public float maxAngle; // 0x20
		public float moveSpeed; // 0x24
		public float rootMotionWeight; // 0x28
		protected Animator animator; // 0x30
		protected Vector3 moveBlend; // 0x38
		protected Vector3 moveInput; // 0x44
		protected Vector3 velocity; // 0x50
	
		// Constructors
		public AnimatorController3rdPerson(); // 0x00000001813678D0-0x0000000181367900
	
		// Methods
		protected virtual void Start(); // 0x0000000181367890-0x00000001813678D0
		private void OnAnimatorMove(); // 0x00000001813675C0-0x0000000181367890
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget); // 0x00000001813672C0-0x00000001813675C0
	}
}
