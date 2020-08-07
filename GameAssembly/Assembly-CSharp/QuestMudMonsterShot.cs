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

public class QuestMudMonsterShot : MonoBehaviour // TypeDefIndex: 13201
{
	// Fields
	public Transform visual; // 0x20
	public GameObject mudSplatterHitPlayerFX; // 0x28
	public GameObject mudSplatterHitGroundFX; // 0x30
	public float speed; // 0x38
	public float explodeShrinkTime; // 0x3C
	internal Vector3[] pointList; // 0x40
	private QuestMudMonster _mover; // 0x48
	private int _currentPointIndex; // 0x50
	private bool _hit; // 0x54

	// Properties
	internal QuestMudMonster mover { get; set; } // 0x00000001803743E0-0x00000001803743F0 0x00000001804ADAE0-0x00000001804ADAF0

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <Explode>d__13 : IEnumerator<object> // TypeDefIndex: 13202
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QuestMudMonsterShot <>4__this; // 0x20
		public bool inHitPlayer; // 0x28
		public bool inForceToGround; // 0x29
		private Vector3 <startScale>5__2; // 0x2C
		private Vector3 <startPos>5__3; // 0x38
		private Vector3 <endPosition>5__4; // 0x44
		private float <t>5__5; // 0x50

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <Explode>d__13(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180658E60-0x0000000180659620
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180659620-0x0000000180659670
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <SpearHit>d__15 : IEnumerator<object> // TypeDefIndex: 13203
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QuestMudMonsterShot <>4__this; // 0x20
		public QuestSpear inSpear; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <SpearHit>d__15(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018065C8A0-0x000000018065C950
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018065C950-0x000000018065C9A0
	}

	// Constructors
	public QuestMudMonsterShot(); // 0x000000018064F020-0x000000018064F040

	// Methods
	private void Update(); // 0x000000018064ED10-0x000000018064F020
	[IteratorStateMachine] // 0x00000001801D09D0-0x00000001801D0A20
	internal IEnumerator Explode(bool inHitPlayer, bool inForceToGround = true /* Metadata: 0x007BA23D */); // 0x000000018064EA50-0x000000018064EAD0
	private void OnTriggerEnter(Collider other); // 0x000000018064EAD0-0x000000018064ECA0
	[IteratorStateMachine] // 0x00000001801D0CD0-0x00000001801D0D20
	internal IEnumerator SpearHit(QuestSpear inSpear); // 0x000000018064ECA0-0x000000018064ED10
}

