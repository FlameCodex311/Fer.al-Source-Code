/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Services.Chat;
using UniRx.Async;
using UniRx.Async.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_ChatPanel_Room : UI_ChatPanel // TypeDefIndex: 13488
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _inputGroup; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _contentGroup; // 0x58
	private ChatConversationData _conversationData; // 0x60
	private bool _requestingChats; // 0x68

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <SpawnInitialChatItems>d__13 : IAsyncStateMachine // TypeDefIndex: 13489
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_ChatPanel_Room <>4__this; // 0x28
		private int <attemptCount>5__2; // 0x30
		private UniTask<bool> <>u__1; // 0x38
		private UniTask<int> <>u__2; // 0x48

		// Methods
		private void MoveNext(); // 0x0000000180006740-0x0000000180006750
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestAdditionalChats>d__14 : IAsyncStateMachine // TypeDefIndex: 13490
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_ChatPanel_Room <>4__this; // 0x28
		public bool inGetOlder; // 0x30
		private UniTask<bool> <>u__1; // 0x38
		private UniTask.Awaiter <>u__2; // 0x48

		// Methods
		private void MoveNext(); // 0x00000001800066D0-0x00000001800066E0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <OnChatChacheChanged>d__15 : IAsyncStateMachine // TypeDefIndex: 13491
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
		public UI_ChatPanel_Room <>4__this; // 0x18
		public bool inGetOlder; // 0x20
		private UniTask.Awaiter <>u__1; // 0x28
		private int <attemptCount>5__2; // 0x30
		private UniTask<int> <>u__2; // 0x38

		// Methods
		private void MoveNext(); // 0x0000000180006670-0x0000000180006680
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002020-0x0000000180002030
	}

	// Constructors
	public UI_ChatPanel_Room(); // 0x00000001805422E0-0x0000000180542350

	// Methods
	public void Setup(ChatConversationData inData); // 0x0000000180542C10-0x0000000180542E90
	protected override void Awake(); // 0x0000000180542420-0x00000001805424B0
	protected override void OnDestroy(); // 0x0000000180542680-0x0000000180542820
	protected override void OnEnable(); // 0x0000000180542820-0x0000000180542850
	public override void OnScrollPositionChanged(Vector2 inPosition); // 0x0000000180542880-0x0000000180542B50
	protected override void DoChatSubmission(string inChatText); // 0x00000001805424B0-0x0000000180542560
	private void OnRoomConversationChanged(RoomConversationChangedMessage inMessage); // 0x0000000180542850-0x0000000180542880
	private void OnCachedMessageAdded(ChatEntry inChatEntry); // 0x0000000180541970-0x0000000180541990
	private void OnCachedMessageRemoved(ChatEntry inChatEntry); // 0x0000000180542560-0x00000001805425C0
	[AsyncStateMachine] // 0x000000018024B110-0x000000018024B160
	protected override void SpawnInitialChatItems(); // 0x0000000180542E90-0x0000000180542F40
	[AsyncStateMachine] // 0x000000018024B410-0x000000018024B460
	private void RequestAdditionalChats(bool inGetOlder); // 0x0000000180542B50-0x0000000180542C10
	[AsyncStateMachine] // 0x000000018024B700-0x000000018024B750
	private UniTask OnChatChacheChanged(bool inGetOlder); // 0x00000001805425C0-0x0000000180542680
}

