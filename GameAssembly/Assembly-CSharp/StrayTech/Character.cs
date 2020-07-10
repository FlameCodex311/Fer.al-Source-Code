/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace StrayTech
{
	[RequireComponent] // 0x000000018011CD60-0x000000018011CE00
	[RequireComponent] // 0x000000018011CD60-0x000000018011CE00
	[RequireComponent] // 0x000000018011CD60-0x000000018011CE00
	public class Character : MonoBehaviour // TypeDefIndex: 13846
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float _movingTurnSpeed; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float _stationaryTurnSpeed; // 0x24
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float _jumpPower; // 0x28
		[Range] // 0x000000018011D3C0-0x000000018011D400
		[SerializeField] // 0x000000018011D3C0-0x000000018011D400
		private float _gravityMultiplier; // 0x2C
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float _runCycleLegOffset; // 0x30
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float _moveSpeedMultiplier; // 0x34
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float _animSpeedMultiplier; // 0x38
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float _groundCheckDistance; // 0x3C
		private Rigidbody _rigidbody; // 0x40
		private Animator _animator; // 0x48
		private bool _isGrounded; // 0x50
		private float _origGroundCheckDistance; // 0x54
		private Vector3 _groundNormal; // 0x58
		private float _turnAmount; // 0x64
		private float _forwardAmount; // 0x68
		private CapsuleCollider _capsule; // 0x70
		private float _capsuleHeight; // 0x78
		private Vector3 _capsuleCenter; // 0x7C
		private bool _crouching; // 0x88
	
		// Constructors
		public Character(); // 0x0000000181352300-0x0000000181352340
	
		// Methods
		private void Start(); // 0x0000000181351F50-0x0000000181352020
		public void MoveThirdPerson(Vector3 move, bool crouch, bool jump); // 0x0000000181351560-0x0000000181351830
		public void MoveFirstPerson(Vector3 move, bool crouch, bool jump); // 0x00000001813513E0-0x0000000181351560
		private void ScaleCapsuleForCrouching(bool crouch); // 0x0000000181351BD0-0x0000000181351F50
		private void PreventStandingInLowHeadroom(); // 0x0000000181351990-0x0000000181351BD0
		private void UpdateAnimator(Vector3 move); // 0x0000000181352020-0x0000000181352300
		private void HandleAirborneMovement(); // 0x00000001813510C0-0x0000000181351210
		private void HandleGroundedMovement(bool crouch, bool jump); // 0x0000000181351210-0x00000001813513E0
		private void ApplyExtraTurnRotation(); // 0x0000000181350DD0-0x0000000181350EB0
		private void CheckGroundStatus(); // 0x0000000181350EB0-0x00000001813510C0
		public void OnAnimatorMove(); // 0x0000000181351830-0x0000000181351990
	}
}
