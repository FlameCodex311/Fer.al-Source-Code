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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_ChatPanel_Room : UI_ChatPanel // TypeDefIndex: 11942
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _inputGroup; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _contentGroup; // 0x58
	private ChatConversationData _conversationData; // 0x60
	private bool _requestingChats; // 0x68

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <SpawnInitialChatItems>d__13 : IAsyncStateMachine // TypeDefIndex: 11943
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_ChatPanel_Room <>4__this; // 0x28
		private int <attemptCount>5__2; // 0x30
		private UniTask<bool> <>u__1; // 0x38
		private UniTask<int> <>u__2; // 0x48

		// Methods
		private void MoveNext(); // 0x00000001801F1440-0x00000001801F1450
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestAdditionalChats>d__14 : IAsyncStateMachine // TypeDefIndex: 11944
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_ChatPanel_Room <>4__this; // 0x28
		public bool inGetOlder; // 0x30
		private UniTask<bool> <>u__1; // 0x38
		private UniTask.Awaiter <>u__2; // 0x48

		// Methods
		private void MoveNext(); // 0x00000001801F13D0-0x00000001801F13E0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <OnChatChacheChanged>d__15 : IAsyncStateMachine // TypeDefIndex: 11945
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
		private void MoveNext(); // 0x00000001801F1370-0x00000001801F1380
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0500-0x00000001801F0510
	}

	// Constructors
	public UI_ChatPanel_Room(); // 0x0000000180F24850-0x0000000180F248C0

	// Methods
	public void Setup(ChatConversationData inData); // 0x0000000180F251A0-0x0000000180F25420
	protected override void Awake(); // 0x0000000180F249A0-0x0000000180F24A30
	protected override void OnDestroy(); // 0x0000000180F24C00-0x0000000180F24DA0
	protected override void OnEnable(); // 0x0000000180F24DA0-0x0000000180F24DD0
	public override void OnScrollPositionChanged(Vector2 inPosition); // 0x0000000180F24E00-0x0000000180F250E0
	protected override void DoChatSubmission(string inChatText); // 0x0000000180F24A30-0x0000000180F24AE0
	private void OnRoomConversationChanged(RoomConversationChangedMessage inMessage); // 0x0000000180F24DD0-0x0000000180F24E00
	private void OnCachedMessageAdded(ChatEntry inChatEntry); // 0x0000000180441E30-0x0000000180441E50
	private void OnCachedMessageRemoved(ChatEntry inChatEntry); // 0x0000000180F24AE0-0x0000000180F24B40
	[AsyncStateMachine] // 0x0000000180164050-0x00000001801640A0
	protected override void SpawnInitialChatItems(); // 0x0000000180F25420-0x0000000180F254D0
	[AsyncStateMachine] // 0x0000000180164250-0x00000001801642A0
	private void RequestAdditionalChats(bool inGetOlder); // 0x0000000180F250E0-0x0000000180F251A0
	[AsyncStateMachine] // 0x0000000180164520-0x0000000180164570
	private UniTask OnChatChacheChanged(bool inGetOlder); // 0x0000000180F24B40-0x0000000180F24C00
}

