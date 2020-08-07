/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace FIMSpace.Basics
{
	public class FBasic_TPPCameraBehaviour : UnityEngine.MonoBehaviour // TypeDefIndex: 10355
	{
		// Fields
		[Header] // 0x00000001801E78B0-0x00000001801E78E0
		public Transform ToFollow; // 0x18
		[Header] // 0x00000001801E8DD0-0x00000001801E8E00
		public Vector3 FollowingOffset; // 0x20
		[Header] // 0x00000001801E90C0-0x00000001801E90F0
		public Vector3 FollowingOffsetDirection; // 0x2C
		[Header] // 0x00000001801E91F0-0x00000001801E9220
		public Vector2 DistanceRanges; // 0x38
		private float targetDistance; // 0x40
		private float animatedDistance; // 0x44
		public Vector2 RotationRanges; // 0x48
		private Vector2 targetSphericRotation; // 0x50
		private Vector2 animatedSphericRotation; // 0x58
		[Space] // 0x00000001801E9410-0x00000001801E9460
		[Tooltip] // 0x00000001801E9410-0x00000001801E9460
		public float RotationSensitivity; // 0x60
		[Header] // 0x00000001801E9610-0x00000001801E9670
		[Range] // 0x00000001801E9610-0x00000001801E9670
		public float RotationSpeed; // 0x64
		[Header] // 0x00000001801E98C0-0x00000001801E9920
		[Range] // 0x00000001801E98C0-0x00000001801E9920
		public float HardFollowValue; // 0x68
		[Header] // 0x00000001801E9BF0-0x00000001801E9C20
		public bool LockCursor; // 0x6C
		private bool rotateCamera; // 0x6D
		private RaycastHit sightObstacleHit; // 0x70
		[Header] // 0x00000001801E9EF0-0x00000001801E9F20
		public LayerMask SightLayerMask; // 0x9C
		private Vector3 targetPosition; // 0xA0
		[Header] // 0x00000001801EA080-0x00000001801EA0B0
		public float CollisionOffset; // 0xAC
		public EFUpdateClock UpdateClock; // 0xB0
	
		// Constructors
		public FBasic_TPPCameraBehaviour(); // 0x00000001817297F0-0x0000000181729960
	
		// Methods
		private void Start(); // 0x0000000181729350-0x0000000181729410
		private void UpdateMethods(); // 0x0000000181729480-0x00000001817296A0
		private void LateUpdate(); // 0x0000000181728DC0-0x0000000181728DE0
		private void Update(); // 0x00000001817296A0-0x00000001817296C0
		private void FixedUpdate(); // 0x0000000181728820-0x0000000181728840
		private void InputCalculations(); // 0x0000000181728D20-0x0000000181728DC0
		private void ZoomCalculations(); // 0x00000001817296C0-0x00000001817297F0
		private void FollowCalculations(); // 0x0000000181728840-0x0000000181728C30
		private void RaycastCalculations(); // 0x0000000181728DE0-0x0000000181729350
		private void SwitchCalculations(); // 0x0000000181729410-0x0000000181729480
		private float HelperClampAngle(float angle, float min, float max); // 0x0000000181728C30-0x0000000181728CD0
		private void HelperSwitchCursor(); // 0x0000000181728CD0-0x0000000181728D20
	}
}
