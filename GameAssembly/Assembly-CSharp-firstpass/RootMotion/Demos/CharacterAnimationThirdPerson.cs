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
	[RequireComponent] // 0x000000018021CAC0-0x000000018021CB10
	public class CharacterAnimationThirdPerson : CharacterAnimationBase // TypeDefIndex: 9848
	{
		// Fields
		public CharacterThirdPerson characterController; // 0x60
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float turnSensitivity; // 0x68
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float turnSpeed; // 0x6C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float runCycleLegOffset; // 0x70
		[Range] // 0x000000018021D580-0x000000018021D5C0
		[SerializeField] // 0x000000018021D580-0x000000018021D5C0
		private float animSpeedMultiplier; // 0x74
		protected Animator animator; // 0x78
		private Vector3 lastForward; // 0x80
		private const string groundedDirectional = "Grounded Directional"; // Metadata: 0x0077AB59
		private const string groundedStrafe = "Grounded Strafe"; // Metadata: 0x0077AB71
		private float deltaAngle; // 0x8C
	
		// Properties
		public override bool animationGrounded { get; } // 0x000000018136F400-0x000000018136F4F0 
	
		// Constructors
		public CharacterAnimationThirdPerson(); // 0x000000018136EB30-0x000000018136EB60
	
		// Methods
		protected override void Start(); // 0x000000018136ED80-0x000000018136EE10
		public override Vector3 GetPivotPoint(); // 0x000000018136EB60-0x000000018136EBA0
		protected virtual void Update(); // 0x000000018136EE10-0x000000018136F400
		private void OnAnimatorMove(); // 0x000000018136EBA0-0x000000018136ED80
	}
}
