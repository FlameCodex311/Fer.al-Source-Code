/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class QuestSpear : MonoBehaviour // TypeDefIndex: 11679
{
	// Fields
	public QuestSpearSettings questSpearSettings; // 0x20
	public GameObject movingFX; // 0x28
	public Transform returnRotater; // 0x30
	public Vector3 attachRotation; // 0x38
	internal Transform playerTransform; // 0x48
	private bool canLaunch; // 0x50
	private Vector3[] _returnArchPointList; // 0x58
	private Transform _attachTransform; // 0x60
	private Vector3 _targetPosition; // 0x68
	private Coroutine moveCoroutine; // 0x78
	private Coroutine returnCoroutine; // 0x80
	private Coroutine returnRotateCoroutine; // 0x88
	private Transform _originalLocation; // 0x90
	private Interaction _interaction; // 0x98
	private const string _attachTransformName = "OffsetTransform"; // Metadata: 0x00782B31

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <AttachToPlayer>d__18 : IEnumerator<object> // TypeDefIndex: 11680
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <AttachToPlayer>d__18(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181014290-0x0000000181014640
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181014640-0x00000001810149B0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <MoveToTarget>d__22 : IEnumerator<object> // TypeDefIndex: 11681
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QuestSpear <>4__this; // 0x20
		private Vector3 <startPosition>5__2; // 0x28
		private float <t>5__3; // 0x34

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <MoveToTarget>d__22(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181016AD0-0x0000000181016EC0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181016EC0-0x0000000181017170
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <ReturnToPlayer>d__24 : IEnumerator<object> // TypeDefIndex: 11682
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <ReturnToPlayer>d__24(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181018E30-0x0000000181019430
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181019430-0x0000000181019690
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <ReturnRotate>d__25 : IEnumerator<object> // TypeDefIndex: 11683
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QuestSpear <>4__this; // 0x20
		private Quaternion <startRot>5__2; // 0x28
		private float <t>5__3; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <ReturnRotate>d__25(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181018810-0x0000000181018B70
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181018B70-0x0000000181018BC0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <ReturnToOriginalLocation>d__30 : IEnumerator<object> // TypeDefIndex: 11684
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QuestSpear <>4__this; // 0x20
		private float <t>5__2; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <ReturnToOriginalLocation>d__30(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181018BC0-0x0000000181018DE0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181018DE0-0x0000000181018E30
	}

	// Constructors
	public QuestSpear(); // 0x000000018100FBE0-0x000000018100FC70

	// Methods
	private void OnDestroy(); // 0x000000018100F030-0x000000018100F120
	public void PickedUp(); // 0x000000018100F5D0-0x000000018100F9F0
	private Transform FindAttachPoint(Transform inTrans); // 0x000000018100EA40-0x000000018100EB40
	[IteratorStateMachine] // 0x00000001800F8A10-0x00000001800F8A60
	internal IEnumerator AttachToPlayer(); // 0x000000018100E9E0-0x000000018100EA40
	private void Launch(); // 0x000000018100EEF0-0x000000018100EFD0
	internal void CanLaunch(bool inCanLaunch); // 0x0000000180639DF0-0x0000000180639E00
	private void OnDrawGizmos(); // 0x000000018100F120-0x000000018100F400
	[IteratorStateMachine] // 0x00000001800F8B70-0x00000001800F8BC0
	internal IEnumerator MoveToTarget(); // 0x000000018100EFD0-0x000000018100F030
	private Vector3[] GetReturnPointList(Vector3 inStartPoint); // 0x000000018100EB40-0x000000018100EE80
	[IteratorStateMachine] // 0x00000001800F8E30-0x00000001800F8E80
	internal IEnumerator ReturnToPlayer(float inDelay); // 0x000000018100FB70-0x000000018100FBE0
	[IteratorStateMachine] // 0x00000001800F9180-0x00000001800F91D0
	internal IEnumerator ReturnRotate(); // 0x000000018100FAB0-0x000000018100FB10
	private void OnCollisionEnter(Collision collision); // 0x00000001803581E0-0x00000001803581F0
	private void OnTriggerEnter(Collider other); // 0x000000018100F400-0x000000018100F5D0
	internal void ImpactComplete(); // 0x000000018100EE80-0x000000018100EEF0
	internal void PlayerTrapped(); // 0x000000018100F9F0-0x000000018100FAB0
	[IteratorStateMachine] // 0x00000001800F9310-0x00000001800F9360
	private IEnumerator ReturnToOriginalLocation(); // 0x000000018100FB10-0x000000018100FB70
}

