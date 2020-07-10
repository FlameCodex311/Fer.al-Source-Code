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
	[RequireComponent] // 0x00000001800E1470-0x00000001800E14C0
	public class CharacterAnimationSimple : CharacterAnimationBase // TypeDefIndex: 9560
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private CharacterThirdPerson characterController; // 0x60
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float pivotOffset; // 0x68
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private AnimationCurve moveSpeed; // 0x70
		private Animator animator; // 0x78
	
		// Constructors
		public CharacterAnimationSimple(); // 0x00000001816475D0-0x00000001816475F0
	
		// Methods
		protected override void Start(); // 0x00000001816477C0-0x0000000181647810
		public override Vector3 GetPivotPoint(); // 0x00000001816475F0-0x00000001816477C0
		private void Update(); // 0x0000000181647810-0x00000001816479F0
	}
}
