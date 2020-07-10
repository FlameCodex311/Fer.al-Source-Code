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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class MinimapBlipMainQuestNavIndicator : ManagedBehaviour // TypeDefIndex: 10853
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
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <MakePath>d__12 : IEnumerator<object> // TypeDefIndex: 10854
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MinimapBlipMainQuestNavIndicator <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <MakePath>d__12(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001810BCAB0-0x00000001810BCEC0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001810BCEC0-0x00000001810BCF10
	}

	// Constructors
	public MinimapBlipMainQuestNavIndicator(); // 0x00000001810B0A90-0x00000001810B0AF0

	// Methods
	public override void MAwake(); // 0x00000001810B0550-0x00000001810B0660
	internal Vector3 GetIndicatorPosition(); // 0x00000001810B00A0-0x00000001810B0550
	[IteratorStateMachine] // 0x00000001800E60C0-0x00000001800E6110
	private IEnumerator MakePath(); // 0x00000001810B0660-0x00000001810B06C0
	private void OnDrawGizmos(); // 0x00000001810B06C0-0x00000001810B0A90
}

