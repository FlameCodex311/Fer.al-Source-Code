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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class DecreeBoard_Interactable : Interactable // TypeDefIndex: 10397
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private MeshRenderer _sign; // 0x1A0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _cycleTimer; // 0x1A8
	private Material _shaderMaterial; // 0x1B0
	private List<string> _imageDefIds; // 0x1B8

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <GetDecrees>d__5 : IAsyncStateMachine // TypeDefIndex: 10398
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public DecreeBoard_Interactable <>4__this; // 0x28
		private UniTask<ListDecreesResponse> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x000000018020D8F0-0x000000018020D900
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <CycleImages>d__6 : IEnumerator<object> // TypeDefIndex: 10399
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public DecreeBoard_Interactable <>4__this; // 0x20
		private int <ii>5__2; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <CycleImages>d__6(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x000000018119B1F0-0x000000018119B440
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018119B440-0x000000018119B490
	}

	// Constructors
	public DecreeBoard_Interactable(); // 0x0000000181183B30-0x0000000181183BA0

	// Methods
	public override void MStart(); // 0x0000000181183880-0x0000000181183A80
	[AsyncStateMachine] // 0x000000018010AB80-0x000000018010ABD0
	private void GetDecrees(); // 0x00000001811837D0-0x0000000181183880
	[IteratorStateMachine] // 0x000000018010AF60-0x000000018010AFB0
	private IEnumerator CycleImages(); // 0x0000000181183770-0x00000001811837D0
	public override void RequestInteraction(EInteractableMessage inInteractableMessage); // 0x0000000181183A80-0x0000000181183AB0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <CycleImages>b__6_0(Texture t); // 0x0000000181183AB0-0x0000000181183B30
}

