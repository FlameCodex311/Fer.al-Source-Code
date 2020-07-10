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
	public abstract class CharacterAnimationBase : UnityEngine.MonoBehaviour // TypeDefIndex: 9559
	{
		// Fields
		public bool smoothFollow; // 0x18
		public float smoothFollowSpeed; // 0x1C
		protected bool animatePhysics; // 0x20
		private Vector3 lastPosition; // 0x24
		private Vector3 localPosition; // 0x30
		private Quaternion localRotation; // 0x3C
		private Quaternion lastRotation; // 0x4C
	
		// Properties
		public virtual bool animationGrounded { get; } // 0x00000001803C29F0-0x00000001803C2A00 
	
		// Constructors
		protected CharacterAnimationBase(); // 0x00000001816475D0-0x00000001816475F0
	
		// Methods
		public virtual Vector3 GetPivotPoint(); // 0x0000000181646F80-0x0000000181646FD0
		public float GetAngleFromForward(Vector3 worldDirection); // 0x0000000181646EC0-0x0000000181646F80
		protected virtual void Start(); // 0x0000000181647300-0x00000001816475D0
		protected virtual void LateUpdate(); // 0x0000000181646FD0-0x0000000181646FE0
		protected virtual void FixedUpdate(); // 0x0000000181646EB0-0x0000000181646EC0
		private void SmoothFollow(); // 0x0000000181646FE0-0x0000000181647300
	}
}
