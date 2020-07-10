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
	[RequireComponent] // 0x00000001800E2460-0x00000001800E24E0
	[RequireComponent] // 0x00000001800E2460-0x00000001800E24E0
	public abstract class CharacterBase : UnityEngine.MonoBehaviour // TypeDefIndex: 9562
	{
		// Fields
		[Header] // 0x00000001800E27C0-0x00000001800E2820
		[Tooltip] // 0x00000001800E27C0-0x00000001800E2820
		public Transform gravityTarget; // 0x18
		[SerializeField] // 0x00000001800E29D0-0x00000001800E2A20
		[Tooltip] // 0x00000001800E29D0-0x00000001800E2A20
		protected float gravityMultiplier; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected float airborneThreshold; // 0x24
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float slopeStartAngle; // 0x28
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float slopeEndAngle; // 0x2C
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float spherecastRadius; // 0x30
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private LayerMask groundLayers; // 0x34
		private PhysicMaterial zeroFrictionMaterial; // 0x38
		private PhysicMaterial highFrictionMaterial; // 0x40
		protected Rigidbody r; // 0x48
		protected const float half = 0.5f; // Metadata: 0x0074520F
		protected float originalHeight; // 0x50
		protected Vector3 originalCenter; // 0x54
		protected CapsuleCollider capsule; // 0x60
	
		// Constructors
		protected CharacterBase(); // 0x00000001816497E0-0x0000000181649810
	
		// Methods
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);
		protected Vector3 GetGravity(); // 0x0000000181648AE0-0x0000000181648CC0
		protected virtual void Start(); // 0x00000001816495D0-0x00000001816497B0
		protected virtual RaycastHit GetSpherecastHit(); // 0x0000000181648DD0-0x0000000181649140
		public float GetAngleFromForward(Vector3 worldDirection); // 0x0000000181648A20-0x0000000181648AE0
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle); // 0x0000000181649170-0x0000000181649390
		protected void ScaleCapsule(float mlp); // 0x0000000181649390-0x00000001816495D0
		protected void HighFriction(); // 0x0000000181649140-0x0000000181649170
		protected void ZeroFriction(); // 0x00000001816497B0-0x00000001816497E0
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal); // 0x0000000181648CC0-0x0000000181648DD0
	}
}
