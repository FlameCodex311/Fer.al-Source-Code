/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion.Demos
{
	public class MotionAbsorbCharacter : UnityEngine.MonoBehaviour // TypeDefIndex: 9531
	{
		// Fields
		public Animator animator; // 0x18
		public MotionAbsorb motionAbsorb; // 0x20
		public Transform cube; // 0x28
		public float cubeRandomPosition; // 0x30
		public AnimationCurve motionAbsorbWeight; // 0x38
		private Vector3 cubeDefaultPosition; // 0x40
		private AnimatorStateInfo info; // 0x4C
		private Rigidbody cubeRigidbody; // 0x70
	
		// Constructors
		public MotionAbsorbCharacter(); // 0x0000000181835E00-0x0000000181835E10
	
		// Methods
		private void Start(); // 0x0000000181835AB0-0x0000000181835B30
		private void Update(); // 0x0000000181835D30-0x0000000181835E00
		private void SwingStart(); // 0x0000000181835B30-0x0000000181835D30
	}
}
