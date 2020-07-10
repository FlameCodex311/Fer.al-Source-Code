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

[ManagedBehaviourManager] // 0x0000000180106CD0-0x0000000180106D00
public class SanctuaryTwiggleWorker : SanctuaryTwiggle // TypeDefIndex: 11856
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _fxAppearPrefab; // 0x60
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _fxTeleportPrefab; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _minTime; // 0x70
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _maxTime; // 0x74
	private float _timer; // 0x78
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _gizmoColor; // 0x7C
	private List<GameObject> _twigglePerchPoints; // 0x90
	private int _lastPositionIndex; // 0x98
	private bool _initialized; // 0x9C

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <InitWait>d__9 : IEnumerator<object> // TypeDefIndex: 11857
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SanctuaryTwiggleWorker <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <InitWait>d__9(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001813762A0-0x00000001813764D0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001813764D0-0x0000000181377AF0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <SetTwiggleActive>d__15 : IEnumerator<object> // TypeDefIndex: 11858
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SanctuaryTwiggleWorker <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <SetTwiggleActive>d__15(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181377AF0-0x00000001813781C0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001813781C0-0x0000000181378210
	}

	// Constructors
	public SanctuaryTwiggleWorker(); // 0x00000001813704C0-0x0000000181370540

	// Methods
	[IteratorStateMachine] // 0x000000018013C490-0x000000018013C4E0
	protected override IEnumerator InitWait(); // 0x000000018136F990-0x000000018136F9F0
	public override void MUpdate(); // 0x000000018136F9F0-0x000000018136FAB0
	private void SetTwigglePerchPoint(); // 0x000000018136FCF0-0x0000000181370180
	private int GetRandomPerchPoint(); // 0x000000018136F910-0x000000018136F990
	private void SpawnAppearFx(); // 0x0000000181370180-0x0000000181370320
	private void SpawnMoveFx(); // 0x0000000181370320-0x00000001813704C0
	[IteratorStateMachine] // 0x000000018013C610-0x000000018013C660
	private IEnumerator SetTwiggleActive(); // 0x000000018136FC90-0x000000018136FCF0
	private void SetRandomTime(); // 0x000000018136FC60-0x000000018136FC90
	private void OnDrawGizmos(); // 0x000000018136FAB0-0x000000018136FC60
}

