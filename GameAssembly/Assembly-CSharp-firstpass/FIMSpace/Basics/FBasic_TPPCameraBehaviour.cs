/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace FIMSpace.Basics
{
	public class FBasic_TPPCameraBehaviour : UnityEngine.MonoBehaviour // TypeDefIndex: 9901
	{
		// Fields
		[Header] // 0x00000001801066F0-0x0000000180106720
		public Transform ToFollow; // 0x18
		[Header] // 0x0000000180106970-0x00000001801069A0
		public Vector3 FollowingOffset; // 0x20
		[Header] // 0x0000000180106B60-0x0000000180106B90
		public Vector3 FollowingOffsetDirection; // 0x2C
		[Header] // 0x0000000180106D00-0x0000000180106D30
		public Vector2 DistanceRanges; // 0x38
		private float targetDistance; // 0x40
		private float animatedDistance; // 0x44
		public Vector2 RotationRanges; // 0x48
		private Vector2 targetSphericRotation; // 0x50
		private Vector2 animatedSphericRotation; // 0x58
		[Space] // 0x0000000180106D90-0x0000000180106DE0
		[Tooltip] // 0x0000000180106D90-0x0000000180106DE0
		public float RotationSensitivity; // 0x60
		[Header] // 0x0000000180106EC0-0x0000000180106F20
		[Range] // 0x0000000180106EC0-0x0000000180106F20
		public float RotationSpeed; // 0x64
		[Header] // 0x0000000180107120-0x0000000180107180
		[Range] // 0x0000000180107120-0x0000000180107180
		public float HardFollowValue; // 0x68
		[Header] // 0x00000001801073B0-0x00000001801073E0
		public bool LockCursor; // 0x6C
		private bool rotateCamera; // 0x6D
		private RaycastHit sightObstacleHit; // 0x70
		[Header] // 0x00000001801075E0-0x0000000180107610
		public LayerMask SightLayerMask; // 0x9C
		private Vector3 targetPosition; // 0xA0
		[Header] // 0x00000001801076E0-0x0000000180107710
		public float CollisionOffset; // 0xAC
		public EFUpdateClock UpdateClock; // 0xB0
	
		// Constructors
		public FBasic_TPPCameraBehaviour(); // 0x00000001815DA240-0x00000001815DA3B0
	
		// Methods
		private void Start(); // 0x00000001815D9DA0-0x00000001815D9E60
		private void UpdateMethods(); // 0x00000001815D9ED0-0x00000001815DA0F0
		private void LateUpdate(); // 0x00000001815D9800-0x00000001815D9820
		private void Update(); // 0x00000001815DA0F0-0x00000001815DA110
		private void FixedUpdate(); // 0x00000001815D9260-0x00000001815D9280
		private void InputCalculations(); // 0x00000001815D9760-0x00000001815D9800
		private void ZoomCalculations(); // 0x00000001815DA110-0x00000001815DA240
		private void FollowCalculations(); // 0x00000001815D9280-0x00000001815D9670
		private void RaycastCalculations(); // 0x00000001815D9820-0x00000001815D9DA0
		private void SwitchCalculations(); // 0x00000001815D9E60-0x00000001815D9ED0
		private float HelperClampAngle(float angle, float min, float max); // 0x00000001815D9670-0x00000001815D9710
		private void HelperSwitchCursor(); // 0x00000001815D9710-0x00000001815D9760
	}
}
