/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_OnlineStatus : MonoBehaviour // TypeDefIndex: 12151
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _groupOnline; // 0x20
	private string _userUUID; // 0x28
	private float _timeLastRefreshed; // 0x30

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <Setup>d__3 : IAsyncStateMachine // TypeDefIndex: 12152
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_OnlineStatus <>4__this; // 0x28
		public string inUserUUID; // 0x30
		private TaskAwaiter<bool> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F0700-0x00000001801F0710
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public UI_OnlineStatus(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	[AsyncStateMachine] // 0x00000001800FD510-0x00000001800FD560
	public void Setup(string inUserUUID); // 0x0000000180E84AF0-0x0000000180E84BB0
	private void SetStatus(bool inStatus); // 0x0000000180E849E0-0x0000000180E84AF0
	private void Awake(); // 0x0000000180E84800-0x0000000180E848F0
	private void OnDestroy(); // 0x0000000180E848F0-0x0000000180E84980
	private void Update(); // 0x0000000180E84BF0-0x0000000180E84C50
	private void OnUserOnlineStatusChanged(UserOnlineStatusMessage inMessage); // 0x0000000180E84980-0x0000000180E849E0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <SetStatus>b__4_0(); // 0x0000000180E84BB0-0x0000000180E84BF0
}

