/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class SecretCraftEffect : MonoBehaviour // TypeDefIndex: 12220
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _target; // 0x20

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <OnItemCraft>d__4 : IAsyncStateMachine // TypeDefIndex: 12221
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public BuyItemResponse inMessage; // 0x28
		public SecretCraftEffect <>4__this; // 0x30
		private UniTask.Awaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F0A00-0x00000001801F0A10
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public SecretCraftEffect(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Awake(); // 0x0000000180EBF010-0x0000000180EBF040
	private void Start(); // 0x0000000180EBF190-0x0000000180EBF220
	private void OnDestroy(); // 0x0000000180EBF040-0x0000000180EBF0D0
	[AsyncStateMachine] // 0x0000000180115070-0x00000001801150C0
	private void OnItemCraft(BuyItemResponse inMessage); // 0x0000000180EBF0D0-0x0000000180EBF190
}

