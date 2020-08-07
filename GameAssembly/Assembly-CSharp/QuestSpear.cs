/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class QuestSpear : MonoBehaviour // TypeDefIndex: 13205
{
	// Fields
	public QuestSpearSettings questSpearSettings; // 0x20
	public GameObject movingFX; // 0x28
	public GameObject basicImpactFX; // 0x30
	public Transform returnRotater; // 0x38
	public Vector3 attachRotation; // 0x40
	public FeralAudioInfo spearLaunch; // 0x50
	public FeralAudioInfo spearReturn; // 0x58
	public FeralAudioInfo spearMiss; // 0x60
	public FeralAudioInfo spearImpact; // 0x68
	public FeralAudioInfo spearImpactMudBall; // 0x70
	public FeralAudioInfo spearImpactMudMonster; // 0x78
	public FeralAudioInfo spearPickup; // 0x80
	internal Transform playerTransform; // 0x88
	private bool canLaunch; // 0x90
	private Vector3[] _returnArchPointList; // 0x98
	private Transform _attachTransform; // 0xA0
	private Vector3 _targetPosition; // 0xA8
	private Coroutine moveCoroutine; // 0xB8
	private Coroutine returnCoroutine; // 0xC0
	private Coroutine returnRotateCoroutine; // 0xC8
	private Transform _originalLocation; // 0xD0
	private Interaction _interaction; // 0xD8
	private Collider _collider; // 0xE0
	private Animator _playerAnimator; // 0xE8
	private Animator _spearAnimator; // 0xF0
	private GameSettingsManager.ControlSetting _controlSetting; // 0xF8
	private GameObject _spearSpot; // 0x100
	private const string _attachTransformName = "OffsetTransform"; // Metadata: 0x007BA23F

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <AttachToPlayer>d__33 : IEnumerator<object> // TypeDefIndex: 13206
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QuestSpear <>4__this; // 0x20
		private Vector3 <startPos>5__2; // 0x28
		private Quaternion <startRot>5__3; // 0x34
		private Quaternion <endRot>5__4; // 0x44
		private float <t>5__5; // 0x54

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <AttachToPlayer>d__33(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001806586B0-0x0000000180658A80
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180658A80-0x0000000180658D10
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <MoveToTarget>d__37 : IEnumerator<object> // TypeDefIndex: 13207
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QuestSpear <>4__this; // 0x20
		private Vector3 <startPosition>5__2; // 0x28
		private float <speedUp>5__3; // 0x34
		private float <t>5__4; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <MoveToTarget>d__37(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018065A060-0x000000018065AA30
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018065AA30-0x000000018065AA80
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <ReturnToPlayer>d__39 : IEnumerator<object> // TypeDefIndex: 13208
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public float inDelay; // 0x20
		public QuestSpear <>4__this; // 0x28
		private Vector3 <startPoint>5__2; // 0x30
		private Vector3 <cachedReturnPoint>5__3; // 0x3C
		private int <_currentPointIndex>5__4; // 0x48
		private float <t>5__5; // 0x4C

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <ReturnToPlayer>d__39(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018065BE80-0x000000018065C510
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018065C510-0x000000018065C560
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <ReturnRotate>d__40 : IEnumerator<object> // TypeDefIndex: 13209
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QuestSpear <>4__this; // 0x20
		private Quaternion <startRot>5__2; // 0x28
		private GameObject <go>5__3; // 0x38
		private float <t>5__4; // 0x40

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <ReturnRotate>d__40(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018065B350-0x000000018065BBB0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018065BBB0-0x000000018065BC00
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <ReturnToOriginalLocation>d__44 : IEnumerator<object> // TypeDefIndex: 13210
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QuestSpear <>4__this; // 0x20
		public bool inComplete; // 0x28
		private float <t>5__2; // 0x2C

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <ReturnToOriginalLocation>d__44(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018065BC00-0x000000018065BE30
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018065BE30-0x000000018065BE80
	}

	// Constructors
	public QuestSpear(); // 0x0000000180654AA0-0x0000000180654B30

	// Methods
	private void Start(); // 0x00000001803D3840-0x00000001803D3870
	private void OnDestroy(); // 0x0000000180653A90-0x0000000180653B70
	private void Update(); // 0x0000000180654960-0x0000000180654AA0
	public void PickedUp(); // 0x0000000180654240-0x0000000180654740
	private Transform FindAttachPoint(Transform inTrans); // 0x00000001806534A0-0x00000001806535A0
	[IteratorStateMachine] // 0x00000001801D2370-0x00000001801D23C0
	internal IEnumerator AttachToPlayer(); // 0x0000000180653430-0x0000000180653490
	private void Launch(); // 0x0000000180653940-0x0000000180653A30
	internal void CanLaunch(bool inCanLaunch); // 0x0000000180653490-0x00000001806534A0
	private void OnDrawGizmos(); // 0x0000000180653B70-0x0000000180653E70
	[IteratorStateMachine] // 0x00000001801D2760-0x00000001801D27B0
	internal IEnumerator MoveToTarget(); // 0x0000000180653A30-0x0000000180653A90
	private Vector3[] GetReturnPointList(Vector3 inStartPoint); // 0x00000001806535A0-0x00000001806538D0
	[IteratorStateMachine] // 0x00000001801D2A70-0x00000001801D2AC0
	internal IEnumerator ReturnToPlayer(float inDelay); // 0x00000001806548F0-0x0000000180654960
	[IteratorStateMachine] // 0x00000001801D3040-0x00000001801D3090
	internal IEnumerator ReturnRotate(); // 0x0000000180654820-0x0000000180654880
	private void OnTriggerEnter(Collider other); // 0x0000000180653E70-0x0000000180654240
	internal void ImpactComplete(); // 0x00000001806538D0-0x0000000180653940
	public void ResetToRack(bool inComplete = true /* Metadata: 0x007BA23E */); // 0x0000000180654740-0x0000000180654820
	[IteratorStateMachine] // 0x00000001801D32A0-0x00000001801D32F0
	private IEnumerator ReturnToOriginalLocation(bool inComplete); // 0x0000000180654880-0x00000001806548F0
}

