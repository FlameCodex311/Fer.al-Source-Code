/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_OnlineStatus : MonoBehaviour // TypeDefIndex: 13698
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _groupOnline; // 0x20
	private string _userUUID; // 0x28
	private float _timeLastRefreshed; // 0x30

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <Setup>d__3 : IAsyncStateMachine // TypeDefIndex: 13699
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_OnlineStatus <>4__this; // 0x28
		public string inUserUUID; // 0x30
		private TaskAwaiter<bool> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x0000000180002540-0x0000000180002630
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UI_OnlineStatus(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	[AsyncStateMachine] // 0x00000001801D9870-0x00000001801D98C0
	public void Setup(string inUserUUID); // 0x00000001803CE3B0-0x00000001803CE470
	private void SetStatus(bool inStatus); // 0x00000001803CE2A0-0x00000001803CE3B0
	private void Awake(); // 0x00000001803CE0D0-0x00000001803CE1B0
	private void OnDestroy(); // 0x00000001803CE1B0-0x00000001803CE240
	private void Update(); // 0x00000001803CE510-0x00000001803CE610
	private void OnUserOnlineStatusChanged(UserOnlineStatusMessage inMessage); // 0x00000001803CE240-0x00000001803CE2A0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <SetStatus>b__4_0(); // 0x00000001803CE470-0x00000001803CE510
}

