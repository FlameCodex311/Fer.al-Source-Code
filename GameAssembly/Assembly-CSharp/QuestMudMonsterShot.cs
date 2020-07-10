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

public class QuestMudMonsterShot : MonoBehaviour // TypeDefIndex: 11675
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
	internal QuestMudMonster mover { get; set; } // 0x0000000180369C40-0x0000000180369C50 0x00000001803A27F0-0x00000001803A2800

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <Explode>d__13 : IEnumerator<object> // TypeDefIndex: 11676
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <Explode>d__13(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001810149B0-0x0000000181015180
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181015180-0x00000001810160C0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <SpearHit>d__15 : IEnumerator<object> // TypeDefIndex: 11677
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QuestMudMonsterShot <>4__this; // 0x20
		public QuestSpear inSpear; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <SpearHit>d__15(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181019690-0x0000000181019740
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181019740-0x0000000181019790
	}

	// Constructors
	public QuestMudMonsterShot(); // 0x000000018100B450-0x000000018100B470

	// Methods
	private void Update(); // 0x000000018100B130-0x000000018100B450
	[IteratorStateMachine] // 0x00000001800F7470-0x00000001800F74C0
	internal IEnumerator Explode(bool inHitPlayer, bool inForceToGround = true /* Metadata: 0x00782B30 */); // 0x000000018100AE70-0x000000018100AEF0
	private void OnTriggerEnter(Collider other); // 0x000000018100AEF0-0x000000018100B0C0
	[IteratorStateMachine] // 0x00000001800F75C0-0x00000001800F7610
	internal IEnumerator SpearHit(QuestSpear inSpear); // 0x000000018100B0C0-0x000000018100B130
}

