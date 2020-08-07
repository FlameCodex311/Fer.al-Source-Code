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

[ManagedBehaviourManager] // 0x00000001801E3560-0x00000001801E3590
public class SanctuaryTwiggleWorker : SanctuaryTwiggle // TypeDefIndex: 13392
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _fxAppearPrefab; // 0x60
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _fxTeleportPrefab; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _minTime; // 0x70
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _maxTime; // 0x74
	private float _timer; // 0x78
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _gizmoColor; // 0x7C
	private List<GameObject> _twigglePerchPoints; // 0x90
	private int _lastPositionIndex; // 0x98
	private bool _initialized; // 0x9C

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <InitWait>d__9 : IEnumerator<object> // TypeDefIndex: 13393
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SanctuaryTwiggleWorker <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <InitWait>d__9(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180401D10-0x0000000180401F40
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180401F40-0x0000000180404E90
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <SetTwiggleActive>d__15 : IEnumerator<object> // TypeDefIndex: 13394
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SanctuaryTwiggleWorker <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <SetTwiggleActive>d__15(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180404FB0-0x0000000180405650
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180405650-0x0000000180405960
	}

	// Constructors
	public SanctuaryTwiggleWorker(); // 0x00000001803F91D0-0x00000001803F9250

	// Methods
	[IteratorStateMachine] // 0x0000000180222AC0-0x0000000180222B10
	protected override IEnumerator InitWait(); // 0x00000001803F86B0-0x00000001803F8710
	public override void MUpdate(); // 0x00000001803F8710-0x00000001803F87D0
	private void SetTwigglePerchPoint(); // 0x00000001803F8A10-0x00000001803F8E90
	private int GetRandomPerchPoint(); // 0x00000001803F8630-0x00000001803F86B0
	private void SpawnAppearFx(); // 0x00000001803F8E90-0x00000001803F9030
	private void SpawnMoveFx(); // 0x00000001803F9030-0x00000001803F91D0
	[IteratorStateMachine] // 0x0000000180222C20-0x0000000180222C70
	private IEnumerator SetTwiggleActive(); // 0x00000001803F89B0-0x00000001803F8A10
	private void SetRandomTime(); // 0x00000001803F8980-0x00000001803F89B0
	private void OnDrawGizmos(); // 0x00000001803F87D0-0x00000001803F8980
}

