/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FIMSpace.Basics;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace FIMSpace.FTail
{
	public abstract class FTail_AnimatorBase : UnityEngine.MonoBehaviour // TypeDefIndex: 10316
	{
		// Fields
		[Header] // 0x00000001801D0A50-0x00000001801D0AE0
		[Header] // 0x00000001801D0A50-0x00000001801D0AE0
		[Space] // 0x00000001801D0A50-0x00000001801D0AE0
		public List<Transform> TailTransforms; // 0x18
		[Tooltip] // 0x00000001801D0EF0-0x00000001801D0F20
		public bool RootToParent; // 0x20
		[Tooltip] // 0x00000001801D0FD0-0x00000001801D1000
		public bool AutoGetWithOne; // 0x21
		[Tooltip] // 0x00000001801D1180-0x00000001801D11B0
		public bool InitBeforeAnimator; // 0x22
		protected List<FTail_Point> proceduralPoints; // 0x28
		[Header] // 0x00000001801D12B0-0x00000001801D1330
		[Range] // 0x00000001801D12B0-0x00000001801D1330
		[Tooltip] // 0x00000001801D12B0-0x00000001801D1330
		public float PositionSpeed; // 0x30
		[Range] // 0x00000001801D15B0-0x00000001801D1610
		[Tooltip] // 0x00000001801D15B0-0x00000001801D1610
		public float RotationSpeed; // 0x34
		protected List<Transform> editorGizmoTailList; // 0x38
		[Tooltip] // 0x00000001801D18A0-0x00000001801D18D0
		public bool UseAutoCorrectLookAxis; // 0x40
		public bool FullCorrection; // 0x41
		[Tooltip] // 0x00000001801D1B70-0x00000001801D1BA0
		public bool RolledBones; // 0x42
		public bool AnimateCorrections; // 0x43
		public float StretchMultiplier; // 0x44
		[Space] // 0x00000001801D1DD0-0x00000001801D1E20
		[Tooltip] // 0x00000001801D1DD0-0x00000001801D1E20
		public Vector3 AxisCorrection; // 0x48
		public Vector3 AxisLookBack; // 0x54
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public bool ExtraCorrectionOptions; // 0x60
		public Vector3 ExtraFromDirection; // 0x64
		public Vector3 ExtraToDirection; // 0x70
		[Tooltip] // 0x00000001801D2340-0x00000001801D2370
		public bool AddTailReferences; // 0x7C
		[Tooltip] // 0x00000001801D2590-0x00000001801D25C0
		public EFUpdateClock UpdateClock; // 0x80
		[Tooltip] // 0x00000001801D2810-0x00000001801D2840
		public bool SmoothDeltaTime; // 0x84
		[Tooltip] // 0x00000001801D2AF0-0x00000001801D2B20
		public bool RefreshHelpers; // 0x85
		[Tooltip] // 0x00000001801D3010-0x00000001801D3040
		public bool QueueToLastUpdate; // 0x86
		[Tooltip] // 0x00000001801D31E0-0x00000001801D3210
		public bool UseCollision; // 0x87
		public bool CollideWithOtherTails; // 0x88
		public FTailColliders CollidersType; // 0x8C
		public AnimationCurve CollidersScale; // 0x90
		public float CollidersScaleMul; // 0x98
		public Vector3 BoxesDimensionsMul; // 0x9C
		public List<Collider> IgnoredColliders; // 0xA8
		public bool CollidersSameLayer; // 0xB0
		[Tooltip] // 0x00000001801D3350-0x00000001801D3380
		public bool CollidersAddRigidbody; // 0xB1
		public LayerMask CollidersLayer; // 0xB4
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float DifferenceScaleFactor; // 0xB8
		[Tooltip] // 0x00000001801D3750-0x00000001801D3780
		public Vector2 GravityPower; // 0xBC
		protected bool initialized; // 0xC4
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <IsInitialized>k__BackingField; // 0xC5
		protected List<float> distances; // 0xC8
		protected Transform rootTransform; // 0xD0
		protected List<Vector3> tailLookDirections; // 0xD8
		protected List<Vector3> lookBackDirections; // 0xE0
		protected List<Quaternion> lookBackOffsets; // 0xE8
		protected List<Quaternion> animatedCorrections; // 0xF0
		protected Vector3 firstBoneInitialRotation; // 0xF8
		protected Quaternion firstBoneInitialRotationQ; // 0x104
		protected bool preAutoCorrect; // 0x114
		protected List<Vector3> collisionOffsets; // 0x118
		protected List<float> collisionFlags; // 0x120
		protected List<Collision> collisionContacts; // 0x128
		public bool CollisionLookBack; // 0x130
	
		// Properties
		public bool IsInitialized { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ protected set; } // 0x0000000181740DC0-0x0000000181740DD0 0x0000000181740DD0-0x0000000181740DE0
	
		// Nested types
		public enum FTailColliders // TypeDefIndex: 10317
		{
			Boxes = 0,
			Spheres = 1
		}
	
		protected class FTail_Point // TypeDefIndex: 10318
		{
			// Fields
			public int index; // 0x10
			public Vector3 Position; // 0x14
			public Quaternion Rotation; // 0x20
			public Vector3 InitialPosition; // 0x30
			public Quaternion InitialRotation; // 0x3C
			public Vector3 InitialLossyScale; // 0x4C
	
			// Constructors
			public FTail_Point(); // 0x0000000181744CF0-0x0000000181744DE0
	
			// Methods
			public Vector3 TransformDirection(Vector3 dir); // 0x0000000181744C40-0x0000000181744CF0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <InitInLate>d__60 : IEnumerator<object> // TypeDefIndex: 10319
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public FTail_AnimatorBase <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <InitInLate>d__60(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000181744DE0-0x0000000181744E80
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000181744E80-0x0000000181744ED0
		}
	
		// Constructors
		protected FTail_AnimatorBase(); // 0x0000000181740B20-0x0000000181740DC0
	
		// Methods
		protected virtual void Reset(); // 0x0000000181740550-0x0000000181740560
		protected virtual void Init(); // 0x000000018173F100-0x000000018173F330
		protected virtual void CoputeHelperVariables(); // 0x000000018173D940-0x000000018173E9D0
		protected virtual void ConfigureBonesTransforms(); // 0x000000018173D930-0x000000018173D940
		public void AutoGetTailTransforms(bool editor = false /* Metadata: 0x0077BA8F */); // 0x000000018173C7E0-0x000000018173C9B0
		protected virtual void PrepareTailPoints(); // 0x0000000181740280-0x0000000181740520
		protected void Start(); // 0x0000000181740700-0x0000000181740790
		[IteratorStateMachine] // 0x00000001801D3F70-0x00000001801D3FC0
		protected IEnumerator InitInLate(); // 0x000000018173F0A0-0x000000018173F100
		public virtual void CalculateOffsets(); // 0x000000018037F800-0x000000018037F820
		protected virtual void MotionCalculations(); // 0x000000018173F330-0x0000000181740280
		protected virtual void SetTailTransformsFromPoints(); // 0x0000000181740560-0x0000000181740700
		protected virtual Quaternion CalculateTargetRotation(Vector3 startLookPos, Vector3 currentPos, FTail_Point previousTailPoint = null, FTail_Point currentTailPoint = null, int lookDirectionFixIndex = 0 /* Metadata: 0x0077BA90 */); // 0x000000018173C9B0-0x000000018173D8C0
		protected virtual void OnDestroy(); // 0x00000001803774A0-0x00000001803774B0
		protected void ApplyAutoCorrection(); // 0x000000018173C740-0x000000018173C7E0
		public void QueueComponentToLastUpdate(); // 0x0000000181740520-0x0000000181740550
		public virtual void OnValidate(); // 0x00000001803774A0-0x00000001803774B0
		private void AddColliders(); // 0x000000018173C120-0x000000018173C740
		internal void CollisionDetection(int index, Collision collision); // 0x000000018173D8C0-0x000000018173D930
		internal void ExitCollision(int index); // 0x000000018173E9D0-0x000000018173EA30
		protected void UseCollisionContact(int index); // 0x0000000181740790-0x0000000181740B20
		protected Vector3 GetColliderBoxSizeFor(List<Transform> transforms, int i); // 0x000000018173EA30-0x000000018173EDC0
		protected float GetColliderSphereRadiusFor(List<Transform> transforms, int i); // 0x000000018173EDC0-0x000000018173F0A0
	}
}
