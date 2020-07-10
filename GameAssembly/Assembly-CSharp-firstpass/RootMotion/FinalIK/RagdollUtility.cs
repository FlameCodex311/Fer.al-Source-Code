/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion.FinalIK
{
	[RequireComponent] // 0x000000018016C990-0x000000018016C9E0
	public class RagdollUtility : UnityEngine.MonoBehaviour // TypeDefIndex: 9440
	{
		// Fields
		[Tooltip] // 0x000000018016DEB0-0x000000018016DEE0
		public IK ik; // 0x18
		[Tooltip] // 0x000000018016DFF0-0x000000018016E020
		public float ragdollToAnimationTime; // 0x20
		[Tooltip] // 0x000000018016E250-0x000000018016E280
		public bool applyIkOnRagdoll; // 0x24
		[Tooltip] // 0x000000018016E3D0-0x000000018016E400
		public float applyVelocity; // 0x28
		[Tooltip] // 0x000000018016E5D0-0x000000018016E600
		public float applyAngularVelocity; // 0x2C
		private Animator animator; // 0x30
		private Rigidbone[] rigidbones; // 0x38
		private Child[] children; // 0x40
		private bool enableRagdollFlag; // 0x48
		private AnimatorUpdateMode animatorUpdateMode; // 0x4C
		private IK[] allIKComponents; // 0x50
		private bool[] fixTransforms; // 0x58
		private float ragdollWeight; // 0x60
		private float ragdollWeightV; // 0x64
		private bool fixedFrame; // 0x68
		private bool[] disabledIKComponents; // 0x70
	
		// Properties
		private bool isRagdoll { get; } // 0x0000000181B0C480-0x0000000181B0C510 
		private bool ikUsed { get; } // 0x0000000181B0C2F0-0x0000000181B0C480 
	
		// Nested types
		public class Rigidbone // TypeDefIndex: 9441
		{
			// Fields
			public Rigidbody r; // 0x10
			public Transform t; // 0x18
			public Collider collider; // 0x20
			public Joint joint; // 0x28
			public Rigidbody c; // 0x30
			public bool updateAnchor; // 0x38
			public Vector3 deltaPosition; // 0x3C
			public Quaternion deltaRotation; // 0x48
			public float deltaTime; // 0x58
			public Vector3 lastPosition; // 0x5C
			public Quaternion lastRotation; // 0x68
	
			// Constructors
			public Rigidbone(Rigidbody r); // 0x0000000181B0EBF0-0x0000000181B0ED70
	
			// Methods
			public void RecordVelocity(); // 0x0000000181B0E710-0x0000000181B0E8B0
			public void WakeUp(float velocityWeight, float angularVelocityWeight); // 0x0000000181B0E8B0-0x0000000181B0EBF0
		}
	
		public class Child // TypeDefIndex: 9442
		{
			// Fields
			public Transform t; // 0x10
			public Vector3 localPosition; // 0x18
			public Quaternion localRotation; // 0x24
	
			// Constructors
			public Child(Transform transform); // 0x0000000181AF4140-0x0000000181AF41C0
	
			// Methods
			public void FixTransform(float weight); // 0x0000000181AF3E80-0x0000000181AF40D0
			public void StoreLocalState(); // 0x0000000181AF40D0-0x0000000181AF4140
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object> // TypeDefIndex: 9443
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RagdollUtility <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <DisableRagdollSmooth>d__21(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181B148C0-0x0000000181B14C10
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181B14C10-0x0000000181B14C60
		}
	
		// Constructors
		public RagdollUtility(); // 0x0000000181B0C240-0x0000000181B0C2F0
	
		// Methods
		public void EnableRagdoll(); // 0x0000000181B0AFE0-0x0000000181B0B010
		public void DisableRagdoll(); // 0x0000000181B0AF50-0x0000000181B0AFE0
		public void Start(); // 0x0000000181B0B8B0-0x0000000181B0BD80
		[IteratorStateMachine] // 0x000000018016E830-0x000000018016E880
		private IEnumerator DisableRagdollSmooth(); // 0x0000000181B0AEF0-0x0000000181B0AF50
		private void Update(); // 0x0000000181B0BE50-0x0000000181B0C240
		private void FixedUpdate(); // 0x0000000181B0B090-0x0000000181B0B0D0
		private void LateUpdate(); // 0x0000000181B0B0D0-0x0000000181B0B180
		private void AfterLastIK(); // 0x0000000181B0AEA0-0x0000000181B0AEF0
		private void AfterAnimation(); // 0x0000000181B0AE60-0x0000000181B0AEA0
		private void OnFinalPose(); // 0x0000000181B0B290-0x0000000181B0B2D0
		private void RagdollEnabler(); // 0x0000000181B0B2D0-0x0000000181B0B680
		private void RecordVelocities(); // 0x0000000181B0B680-0x0000000181B0B8B0
		private void StoreLocalState(); // 0x0000000181B0BD80-0x0000000181B0BE50
		private void FixTransforms(float weight); // 0x0000000181B0B010-0x0000000181B0B090
		private void OnDestroy(); // 0x0000000181B0B180-0x0000000181B0B290
	}
}
