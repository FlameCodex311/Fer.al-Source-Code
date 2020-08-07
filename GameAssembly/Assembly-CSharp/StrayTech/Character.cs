/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace StrayTech
{
	[RequireComponent] // 0x00000001802483B0-0x0000000180248450
	[RequireComponent] // 0x00000001802483B0-0x0000000180248450
	[RequireComponent] // 0x00000001802483B0-0x0000000180248450
	public class Character : MonoBehaviour // TypeDefIndex: 14513
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float _movingTurnSpeed; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float _stationaryTurnSpeed; // 0x24
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float _jumpPower; // 0x28
		[Range] // 0x0000000180248CA0-0x0000000180248CE0
		[SerializeField] // 0x0000000180248CA0-0x0000000180248CE0
		private float _gravityMultiplier; // 0x2C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float _runCycleLegOffset; // 0x30
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float _moveSpeedMultiplier; // 0x34
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float _animSpeedMultiplier; // 0x38
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
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
		public Character(); // 0x0000000180CB0CE0-0x0000000180CB0D20
	
		// Methods
		private void Start(); // 0x0000000180CB0940-0x0000000180CB0A10
		public void MoveThirdPerson(Vector3 move, bool crouch, bool jump); // 0x0000000180CAFF60-0x0000000180CB0230
		public void MoveFirstPerson(Vector3 move, bool crouch, bool jump); // 0x0000000180CAFDE0-0x0000000180CAFF60
		private void ScaleCapsuleForCrouching(bool crouch); // 0x0000000180CB05D0-0x0000000180CB0940
		private void PreventStandingInLowHeadroom(); // 0x0000000180CB0390-0x0000000180CB05D0
		private void UpdateAnimator(Vector3 move); // 0x0000000180CB0A10-0x0000000180CB0CE0
		private void HandleAirborneMovement(); // 0x0000000180CAFAC0-0x0000000180CAFC10
		private void HandleGroundedMovement(bool crouch, bool jump); // 0x0000000180CAFC10-0x0000000180CAFDE0
		private void ApplyExtraTurnRotation(); // 0x0000000180CAF7D0-0x0000000180CAF8B0
		private void CheckGroundStatus(); // 0x0000000180CAF8B0-0x0000000180CAFAC0
		public void OnAnimatorMove(); // 0x0000000180CB0230-0x0000000180CB0390
	}
}
