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
	[RequireComponent] // 0x00000001800E1BD0-0x00000001800E1C20
	public class CharacterAnimationThirdPerson : CharacterAnimationBase // TypeDefIndex: 9561
	{
		// Fields
		public CharacterThirdPerson characterController; // 0x60
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float turnSensitivity; // 0x68
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float turnSpeed; // 0x6C
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float runCycleLegOffset; // 0x70
		[Range] // 0x00000001800E2270-0x00000001800E22B0
		[SerializeField] // 0x00000001800E2270-0x00000001800E22B0
		private float animSpeedMultiplier; // 0x74
		protected Animator animator; // 0x78
		private Vector3 lastForward; // 0x80
		private const string groundedDirectional = "Grounded Directional"; // Metadata: 0x007451E4
		private const string groundedStrafe = "Grounded Strafe"; // Metadata: 0x007451FC
		private float deltaAngle; // 0x8C
	
		// Properties
		public override bool animationGrounded { get; } // 0x0000000181648930-0x0000000181648A20 
	
		// Constructors
		public CharacterAnimationThirdPerson(); // 0x0000000181648020-0x0000000181648050
	
		// Methods
		protected override void Start(); // 0x0000000181648280-0x0000000181648310
		public override Vector3 GetPivotPoint(); // 0x0000000181648050-0x0000000181648090
		protected virtual void Update(); // 0x0000000181648310-0x0000000181648930
		private void OnAnimatorMove(); // 0x0000000181648090-0x0000000181648280
	}
}
