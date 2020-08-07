/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class DecreeBoard_Interactable : Interactable // TypeDefIndex: 11885
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private MeshRenderer _sign; // 0x1A0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _cycleTimer; // 0x1A8
	private Material _shaderMaterial; // 0x1B0
	private List<string> _imageDefIds; // 0x1B8

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <GetDecrees>d__6 : IAsyncStateMachine // TypeDefIndex: 11886
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public DecreeBoard_Interactable <>4__this; // 0x28
		private UniTask<ListDecreesResponse> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180006910-0x0000000180006920
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <CycleImages>d__7 : IEnumerator<object> // TypeDefIndex: 11887
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public DecreeBoard_Interactable <>4__this; // 0x20
		private int <ii>5__2; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <CycleImages>d__7(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180563AF0-0x0000000180563D40
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180563D40-0x0000000180563D90
	}

	// Constructors
	public DecreeBoard_Interactable(); // 0x000000018055F3F0-0x000000018055F460

	// Methods
	public override bool ContinuousHarvest(); // 0x0000000180380950-0x0000000180380960
	public override void MStart(); // 0x000000018055F0D0-0x000000018055F340
	[AsyncStateMachine] // 0x00000001801D95F0-0x00000001801D9640
	private void GetDecrees(); // 0x000000018055F020-0x000000018055F0D0
	[IteratorStateMachine] // 0x00000001801D9820-0x00000001801D9870
	private IEnumerator CycleImages(); // 0x000000018055EFC0-0x000000018055F020
	public override void RequestInteraction(EInteractableMessage inInteractableMessage); // 0x000000018055F340-0x000000018055F370
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <CycleImages>b__7_0(Texture t); // 0x000000018055F370-0x000000018055F3F0
}

