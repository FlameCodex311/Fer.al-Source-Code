/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class MinimapBlipMainQuestNavIndicator : ManagedBehaviour // TypeDefIndex: 12363
{
	// Fields
	public bool showDebugIndicatorPath; // 0x50
	public float checkTime; // 0x54
	public float indicatorBlendSpeed; // 0x58
	private float _checkTime; // 0x5C
	private float _indicatorScaler; // 0x60
	private Vector3 _indicatorPosition; // 0x64
	private Vector3 _indicatorOldPosition; // 0x70
	private Vector3 _indicatorNewPosition; // 0x7C
	private NavMeshPath indicatorPath; // 0x88
	private Coroutine MakePathCoroutine; // 0x90

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <MakePath>d__12 : IEnumerator<object> // TypeDefIndex: 12364
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MinimapBlipMainQuestNavIndicator <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <MakePath>d__12(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180C14470-0x0000000180C14870
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180C14870-0x0000000180C148C0
	}

	// Constructors
	public MinimapBlipMainQuestNavIndicator(); // 0x0000000180BFFF80-0x0000000180BFFFE0

	// Methods
	public override void MAwake(); // 0x0000000180BFFA60-0x0000000180BFFB70
	internal Vector3 GetIndicatorPosition(); // 0x0000000180BFF5C0-0x0000000180BFFA60
	[IteratorStateMachine] // 0x0000000180284290-0x00000001802842E0
	private IEnumerator MakePath(); // 0x0000000180BFFB70-0x0000000180BFFBD0
	private void OnDrawGizmos(); // 0x0000000180BFFBD0-0x0000000180BFFF80
}

