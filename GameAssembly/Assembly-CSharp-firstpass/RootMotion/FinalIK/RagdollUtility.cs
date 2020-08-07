/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.FinalIK
{
	[RequireComponent] // 0x000000018026BAC0-0x000000018026BB10
	public class RagdollUtility : UnityEngine.MonoBehaviour // TypeDefIndex: 9974
	{
		// Fields
		[Tooltip] // 0x000000018026BCF0-0x000000018026BD20
		public IK ik; // 0x18
		[Tooltip] // 0x000000018026BEE0-0x000000018026BF10
		public float ragdollToAnimationTime; // 0x20
		[Tooltip] // 0x000000018026C0F0-0x000000018026C120
		public bool applyIkOnRagdoll; // 0x24
		[Tooltip] // 0x000000018026C4C0-0x000000018026C4F0
		public float applyVelocity; // 0x28
		[Tooltip] // 0x000000018026C5F0-0x000000018026C620
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
		private bool isRagdoll { get; } // 0x000000018163D280-0x000000018163D300 
		private bool ikUsed { get; } // 0x000000018163D0F0-0x000000018163D280 
	
		// Nested types
		public class Rigidbone // TypeDefIndex: 9975
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
			public Rigidbone(Rigidbody r); // 0x000000018163F980-0x000000018163FB00
	
			// Methods
			public void RecordVelocity(); // 0x000000018163F4C0-0x000000018163F650
			public void WakeUp(float velocityWeight, float angularVelocityWeight); // 0x000000018163F650-0x000000018163F980
		}
	
		public class Child // TypeDefIndex: 9976
		{
			// Fields
			public Transform t; // 0x10
			public Vector3 localPosition; // 0x18
			public Quaternion localRotation; // 0x24
	
			// Constructors
			public Child(Transform transform); // 0x000000018162CCC0-0x000000018162CD40
	
			// Methods
			public void FixTransform(float weight); // 0x000000018162CA20-0x000000018162CC60
			public void StoreLocalState(); // 0x000000018162CC60-0x000000018162CCC0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object> // TypeDefIndex: 9977
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RagdollUtility <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <DisableRagdollSmooth>d__21(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000181648710-0x0000000181648A40
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000181648A40-0x0000000181648A90
		}
	
		// Constructors
		public RagdollUtility(); // 0x000000018163D040-0x000000018163D0F0
	
		// Methods
		public void EnableRagdoll(); // 0x000000018163BD40-0x000000018163BD70
		public void DisableRagdoll(); // 0x000000018163BCB0-0x000000018163BD40
		public void Start(); // 0x000000018163C5D0-0x000000018163CBD0
		[IteratorStateMachine] // 0x000000018026C6F0-0x000000018026C740
		private IEnumerator DisableRagdollSmooth(); // 0x000000018163BC50-0x000000018163BCB0
		private void Update(); // 0x000000018163CC90-0x000000018163D040
		private void FixedUpdate(); // 0x000000018163BDF0-0x000000018163BE30
		private void LateUpdate(); // 0x000000018163BE30-0x000000018163BEE0
		private void AfterLastIK(); // 0x000000018163BC00-0x000000018163BC50
		private void AfterAnimation(); // 0x000000018163BBC0-0x000000018163BC00
		private void OnFinalPose(); // 0x000000018163BFF0-0x000000018163C030
		private void RagdollEnabler(); // 0x000000018163C030-0x000000018163C3B0
		private void RecordVelocities(); // 0x000000018163C3B0-0x000000018163C5D0
		private void StoreLocalState(); // 0x000000018163CBD0-0x000000018163CC90
		private void FixTransforms(float weight); // 0x000000018163BD70-0x000000018163BDF0
		private void OnDestroy(); // 0x000000018163BEE0-0x000000018163BFF0
	}
}
