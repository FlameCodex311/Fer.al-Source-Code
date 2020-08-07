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
	public abstract class CharacterAnimationBase : UnityEngine.MonoBehaviour // TypeDefIndex: 9846
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
		public virtual bool animationGrounded { get; } // 0x0000000180380B60-0x0000000180380B70 
	
		// Constructors
		protected CharacterAnimationBase(); // 0x000000018136E100-0x000000018136E120
	
		// Methods
		public virtual Vector3 GetPivotPoint(); // 0x000000018136DAE0-0x000000018136DB30
		public float GetAngleFromForward(Vector3 worldDirection); // 0x000000018136DA20-0x000000018136DAE0
		protected virtual void Start(); // 0x000000018136DE40-0x000000018136E100
		protected virtual void LateUpdate(); // 0x000000018136DB30-0x000000018136DB40
		protected virtual void FixedUpdate(); // 0x000000018136DA10-0x000000018136DA20
		private void SmoothFollow(); // 0x000000018136DB40-0x000000018136DE40
	}
}
