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

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace FIMSpace.FTail
{
	public abstract class FTail_AnimatorBase : UnityEngine.MonoBehaviour // TypeDefIndex: 9862
	{
		// Fields
		[Header] // 0x00000001800F3140-0x00000001800F31D0
		[Header] // 0x00000001800F3140-0x00000001800F31D0
		[Space] // 0x00000001800F3140-0x00000001800F31D0
		public List<Transform> TailTransforms; // 0x18
		[Tooltip] // 0x00000001800F34D0-0x00000001800F3500
		public bool RootToParent; // 0x20
		[Tooltip] // 0x00000001800F36F0-0x00000001800F3720
		public bool AutoGetWithOne; // 0x21
		[Tooltip] // 0x00000001800F3880-0x00000001800F38B0
		public bool InitBeforeAnimator; // 0x22
		protected List<FTail_Point> proceduralPoints; // 0x28
		[Header] // 0x00000001800F3B60-0x00000001800F3BE0
		[Range] // 0x00000001800F3B60-0x00000001800F3BE0
		[Tooltip] // 0x00000001800F3B60-0x00000001800F3BE0
		public float PositionSpeed; // 0x30
		[Range] // 0x00000001800F3E70-0x00000001800F3ED0
		[Tooltip] // 0x00000001800F3E70-0x00000001800F3ED0
		public float RotationSpeed; // 0x34
		protected List<Transform> editorGizmoTailList; // 0x38
		[Tooltip] // 0x00000001800F41B0-0x00000001800F41E0
		public bool UseAutoCorrectLookAxis; // 0x40
		public bool FullCorrection; // 0x41
		[Tooltip] // 0x00000001800F4320-0x00000001800F4350
		public bool RolledBones; // 0x42
		public bool AnimateCorrections; // 0x43
		public float StretchMultiplier; // 0x44
		[Space] // 0x00000001800F4550-0x00000001800F45A0
		[Tooltip] // 0x00000001800F4550-0x00000001800F45A0
		public Vector3 AxisCorrection; // 0x48
		public Vector3 AxisLookBack; // 0x54
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public bool ExtraCorrectionOptions; // 0x60
		public Vector3 ExtraFromDirection; // 0x64
		public Vector3 ExtraToDirection; // 0x70
		[Tooltip] // 0x00000001800F47A0-0x00000001800F47D0
		public bool AddTailReferences; // 0x7C
		[Tooltip] // 0x00000001800F49D0-0x00000001800F4A00
		public EFUpdateClock UpdateClock; // 0x80
		[Tooltip] // 0x00000001800F4B20-0x00000001800F4B50
		public bool SmoothDeltaTime; // 0x84
		[Tooltip] // 0x00000001800F4C50-0x00000001800F4C80
		public bool RefreshHelpers; // 0x85
		[Tooltip] // 0x00000001800F4E20-0x00000001800F4E50
		public bool QueueToLastUpdate; // 0x86
		[Tooltip] // 0x00000001800F4F70-0x00000001800F4FA0
		public bool UseCollision; // 0x87
		public bool CollideWithOtherTails; // 0x88
		public FTailColliders CollidersType; // 0x8C
		public AnimationCurve CollidersScale; // 0x90
		public float CollidersScaleMul; // 0x98
		public Vector3 BoxesDimensionsMul; // 0x9C
		public List<Collider> IgnoredColliders; // 0xA8
		public bool CollidersSameLayer; // 0xB0
		[Tooltip] // 0x00000001800F5190-0x00000001800F51C0
		public bool CollidersAddRigidbody; // 0xB1
		public LayerMask CollidersLayer; // 0xB4
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float DifferenceScaleFactor; // 0xB8
		[Tooltip] // 0x00000001800F5410-0x00000001800F5440
		public Vector2 GravityPower; // 0xBC
		protected bool initialized; // 0xC4
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
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
		public bool IsInitialized { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ protected set; } // 0x0000000181270DE0-0x0000000181270DF0 0x0000000181270E60-0x0000000181270E70
	
		// Nested types
		public enum FTailColliders // TypeDefIndex: 9863
		{
			Boxes = 0,
			Spheres = 1
		}
	
		protected class FTail_Point // TypeDefIndex: 9864
		{
			// Fields
			public int index; // 0x10
			public Vector3 Position; // 0x14
			public Quaternion Rotation; // 0x20
			public Vector3 InitialPosition; // 0x30
			public Quaternion InitialRotation; // 0x3C
			public Vector3 InitialLossyScale; // 0x4C
	
			// Constructors
			public FTail_Point(); // 0x0000000181B70E50-0x0000000181B70F40
	
			// Methods
			public Vector3 TransformDirection(Vector3 dir); // 0x0000000181B70DA0-0x0000000181B70E50
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <InitInLate>d__60 : IEnumerator<object> // TypeDefIndex: 9865
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public FTail_AnimatorBase <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <InitInLate>d__60(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181B70F40-0x0000000181B70FE0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181B70FE0-0x0000000181B71030
		}
	
		// Constructors
		protected FTail_AnimatorBase(); // 0x0000000181B6CB10-0x0000000181B6CDB0
	
		// Methods
		protected virtual void Reset(); // 0x0000000181B6C510-0x0000000181B6C520
		protected virtual void Init(); // 0x0000000181B6B060-0x0000000181B6B290
		protected virtual void CoputeHelperVariables(); // 0x0000000181B69810-0x0000000181B6A920
		protected virtual void ConfigureBonesTransforms(); // 0x0000000181B69800-0x0000000181B69810
		public void AutoGetTailTransforms(bool editor = false /* Metadata: 0x00745FDD */); // 0x0000000181B68680-0x0000000181B68860
		protected virtual void PrepareTailPoints(); // 0x0000000181B6C230-0x0000000181B6C4E0
		protected void Start(); // 0x0000000181B6C6D0-0x0000000181B6C760
		[IteratorStateMachine] // 0x00000001800F5B10-0x00000001800F5B60
		protected IEnumerator InitInLate(); // 0x0000000181B6B000-0x0000000181B6B060
		public virtual void CalculateOffsets(); // 0x00000001806A3950-0x00000001806A3970
		protected virtual void MotionCalculations(); // 0x0000000181B6B290-0x0000000181B6C230
		protected virtual void SetTailTransformsFromPoints(); // 0x0000000181B6C520-0x0000000181B6C6D0
		protected virtual Quaternion CalculateTargetRotation(Vector3 startLookPos, Vector3 currentPos, FTail_Point previousTailPoint = null, FTail_Point currentTailPoint = null, int lookDirectionFixIndex = 0 /* Metadata: 0x00745FDE */); // 0x0000000181B68860-0x0000000181B69790
		protected virtual void OnDestroy(); // 0x00000001803581E0-0x00000001803581F0
		protected void ApplyAutoCorrection(); // 0x0000000181B685D0-0x0000000181B68680
		public void QueueComponentToLastUpdate(); // 0x0000000181B6C4E0-0x0000000181B6C510
		public virtual void OnValidate(); // 0x00000001803581E0-0x00000001803581F0
		private void AddColliders(); // 0x0000000181B67F80-0x0000000181B685D0
		internal void CollisionDetection(int index, Collision collision); // 0x0000000181B69790-0x0000000181B69800
		internal void ExitCollision(int index); // 0x0000000181B6A920-0x0000000181B6A980
		protected void UseCollisionContact(int index); // 0x0000000181B6C760-0x0000000181B6CB10
		protected Vector3 GetColliderBoxSizeFor(List<Transform> transforms, int i); // 0x0000000181B6A980-0x0000000181B6AD10
		protected float GetColliderSphereRadiusFor(List<Transform> transforms, int i); // 0x0000000181B6AD10-0x0000000181B6B000
	}
}
