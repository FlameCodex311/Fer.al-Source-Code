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

public class FCCrowIdle : MonoBehaviour // TypeDefIndex: 11534
{
	// Fields
	public Animator animator; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string[] parameterNames; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float blendSpeed; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float minChangeTime; // 0x34
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float maxChangeTime; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject wings; // 0x40
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject branchParent; // 0x48
	private float timer; // 0x50
	private float randomWait; // 0x54
	private float[] previousValues; // 0x58
	private float[] destinationValues; // 0x60
	private bool lostGame; // 0x68
	private bool _crowShown; // 0x69

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <LoseGame>d__16 : IEnumerator<object> // TypeDefIndex: 11535
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public FCCrowIdle <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <LoseGame>d__16(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018086AD70-0x000000018086AEE0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018086AEE0-0x000000018086AF30
	}

	// Constructors
	public FCCrowIdle(); // 0x00000001808617E0-0x0000000180861810

	// Methods
	private void Start(); // 0x00000001808612C0-0x0000000180861470
	private void ResetIdleTimes(); // 0x0000000180861280-0x00000001808612B0
	private void Update(); // 0x00000001808617C0-0x00000001808617E0
	private void UpdateIdle(); // 0x0000000180861470-0x00000001808617C0
	[IteratorStateMachine] // 0x0000000180217230-0x0000000180217280
	public IEnumerator LoseGame(); // 0x0000000180861030-0x0000000180861090
	public void ResetCrow(); // 0x0000000180861210-0x0000000180861280
	private void PickNewIdle(); // 0x0000000180861090-0x0000000180861210
	internal void ShowCrow(bool inShow); // 0x00000001808612B0-0x00000001808612C0
}

