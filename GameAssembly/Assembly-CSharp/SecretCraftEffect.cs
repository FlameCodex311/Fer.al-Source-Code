/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class SecretCraftEffect : MonoBehaviour // TypeDefIndex: 13770
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _target; // 0x20

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <OnItemCraft>d__4 : IAsyncStateMachine // TypeDefIndex: 13771
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public BuyItemResponse inMessage; // 0x28
		public SecretCraftEffect <>4__this; // 0x30
		private UniTask.Awaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x0000000180002B40-0x0000000180002B50
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public SecretCraftEffect(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Awake(); // 0x00000001803FD950-0x00000001803FD980
	private void Start(); // 0x00000001803FDAD0-0x00000001803FDB60
	private void OnDestroy(); // 0x00000001803FD980-0x00000001803FDA10
	[AsyncStateMachine] // 0x00000001801FD4B0-0x00000001801FD500
	private void OnItemCraft(BuyItemResponse inMessage); // 0x00000001803FDA10-0x00000001803FDAD0
}

