﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.Demos
{
	public class CharacterThirdPerson : CharacterBase // TypeDefIndex: 9850
	{
		// Fields
		[Header] // 0x000000018021E970-0x000000018021E9A0
		public CharacterAnimationBase characterAnimation; // 0x68
		public UserControlThirdPerson userControl; // 0x70
		public CameraController cam; // 0x78
		[Header] // 0x000000018021EB60-0x000000018021EB90
		public MoveMode moveMode; // 0x80
		public bool smoothPhysics; // 0x84
		public float smoothAccelerationTime; // 0x88
		public float linearAccelerationSpeed; // 0x8C
		public float platformFriction; // 0x90
		public float groundStickyEffect; // 0x94
		public float maxVerticalVelocityOnGround; // 0x98
		public float velocityToGroundTangentWeight; // 0x9C
		[Header] // 0x00000001801E7730-0x00000001801E7760
		public bool lookInCameraDirection; // 0xA0
		public float turnSpeed; // 0xA4
		public float stationaryTurnSpeedMlp; // 0xA8
		[Header] // 0x000000018021F110-0x000000018021F140
		public float airSpeed; // 0xAC
		public float airControl; // 0xB0
		public float jumpPower; // 0xB4
		public float jumpRepeatDelayTime; // 0xB8
		public bool doubleJumpEnabled; // 0xBC
		public float doubleJumpPowerMlp; // 0xC0
		[Header] // 0x000000018021F260-0x000000018021F2B0
		[SerializeField] // 0x000000018021F260-0x000000018021F2B0
		private LayerMask wallRunLayers; // 0xC4
		public float wallRunMaxLength; // 0xC8
		public float wallRunMinMoveMag; // 0xCC
		public float wallRunMinVelocityY; // 0xD0
		public float wallRunRotationSpeed; // 0xD4
		public float wallRunMaxRotationAngle; // 0xD8
		public float wallRunWeightSpeed; // 0xDC
		[Header] // 0x000000018021F570-0x000000018021F5A0
		public float crouchCapsuleScaleMlp; // 0xE0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <onGround>k__BackingField; // 0xE4
		public AnimState animState; // 0xE8
		protected Vector3 moveDirection; // 0x100
		private Animator animator; // 0x110
		private Vector3 normal; // 0x118
		private Vector3 platformVelocity; // 0x124
		private Vector3 platformAngularVelocity; // 0x130
		private RaycastHit hit; // 0x13C
		private float jumpLeg; // 0x168
		private float jumpEndTime; // 0x16C
		private float forwardMlp; // 0x170
		private float groundDistance; // 0x174
		private float lastAirTime; // 0x178
		private float stickyForce; // 0x17C
		private Vector3 wallNormal; // 0x180
		private Vector3 moveDirectionVelocity; // 0x18C
		private float wallRunWeight; // 0x198
		private float lastWallRunWeight; // 0x19C
		private Vector3 fixedDeltaPosition; // 0x1A0
		private Quaternion fixedDeltaRotation; // 0x1AC
		private bool fixedFrame; // 0x1BC
		private float wallRunEndTime; // 0x1C0
		private Vector3 gravity; // 0x1C4
		private Vector3 verticalVelocity; // 0x1D0
		private float velocityY; // 0x1DC
		private bool doubleJumped; // 0x1E0
		private bool jumpReleased; // 0x1E1
	
		// Properties
		public bool onGround { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180D13850-0x0000000180D13860 0x0000000181373D80-0x0000000181373D90
	
		// Nested types
		[Serializable]
		public enum MoveMode // TypeDefIndex: 9851
		{
			Directional = 0,
			Strafe = 1
		}
	
		public struct AnimState // TypeDefIndex: 9852
		{
			// Fields
			public Vector3 moveDirection; // 0x00
			public bool jump; // 0x0C
			public bool crouch; // 0x0D
			public bool onGround; // 0x0E
			public bool isStrafing; // 0x0F
			public float yVelocity; // 0x10
			public bool doubleJump; // 0x14
		}
	
		// Constructors
		public CharacterThirdPerson(); // 0x0000000181373BF0-0x0000000181373D80
	
		// Methods
		protected override void Start(); // 0x0000000181373000-0x0000000181373180
		private void OnAnimatorMove(); // 0x0000000181372980-0x0000000181372A20
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation); // 0x0000000181372850-0x0000000181372980
		private void FixedUpdate(); // 0x0000000181370890-0x0000000181371270
		protected virtual void Update(); // 0x0000000181373180-0x0000000181373280
		protected virtual void LateUpdate(); // 0x00000001813720A0-0x0000000181372190
		private void MoveFixed(Vector3 deltaPosition); // 0x0000000181372190-0x0000000181372850
		private void WallRun(); // 0x0000000181373280-0x0000000181373BF0
		private bool CanWallRun(); // 0x0000000181370800-0x0000000181370890
		private Vector3 GetMoveDirection(); // 0x0000000181371500-0x00000001813718D0
		protected virtual void Rotate(); // 0x0000000181372A20-0x0000000181373000
		private Vector3 GetForwardDirection(); // 0x0000000181371270-0x0000000181371500
		protected virtual bool Jump(); // 0x0000000181371E30-0x00000001813720A0
		private void GroundCheck(); // 0x00000001813718D0-0x0000000181371E30
	}
}
