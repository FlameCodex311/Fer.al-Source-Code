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
	[RequireComponent] // 0x000000018021D8A0-0x000000018021D920
	[RequireComponent] // 0x000000018021D8A0-0x000000018021D920
	public abstract class CharacterBase : UnityEngine.MonoBehaviour // TypeDefIndex: 9849
	{
		// Fields
		[Header] // 0x000000018021DC10-0x000000018021DC70
		[Tooltip] // 0x000000018021DC10-0x000000018021DC70
		public Transform gravityTarget; // 0x18
		[SerializeField] // 0x000000018021DF80-0x000000018021DFD0
		[Tooltip] // 0x000000018021DF80-0x000000018021DFD0
		protected float gravityMultiplier; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected float airborneThreshold; // 0x24
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float slopeStartAngle; // 0x28
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float slopeEndAngle; // 0x2C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float spherecastRadius; // 0x30
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private LayerMask groundLayers; // 0x34
		private PhysicMaterial zeroFrictionMaterial; // 0x38
		private PhysicMaterial highFrictionMaterial; // 0x40
		protected Rigidbody r; // 0x48
		protected const float half = 0.5f; // Metadata: 0x0077AB84
		protected float originalHeight; // 0x50
		protected Vector3 originalCenter; // 0x54
		protected CapsuleCollider capsule; // 0x60
	
		// Constructors
		protected CharacterBase(); // 0x0000000181370280-0x00000001813702B0
	
		// Methods
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);
		protected Vector3 GetGravity(); // 0x000000018136F5B0-0x000000018136F790
		protected virtual void Start(); // 0x0000000181370080-0x0000000181370250
		protected virtual RaycastHit GetSpherecastHit(); // 0x000000018136F8A0-0x000000018136FC00
		public float GetAngleFromForward(Vector3 worldDirection); // 0x000000018136F4F0-0x000000018136F5B0
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle); // 0x000000018136FC30-0x000000018136FE50
		protected void ScaleCapsule(float mlp); // 0x000000018136FE50-0x0000000181370080
		protected void HighFriction(); // 0x000000018136FC00-0x000000018136FC30
		protected void ZeroFriction(); // 0x0000000181370250-0x0000000181370280
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal); // 0x000000018136F790-0x000000018136F8A0
	}
}
