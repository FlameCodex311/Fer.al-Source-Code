/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Services.Chat;
using TMPro;
using UniRx.Async;
using UniRx.Async.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_ChatPanel_Private : UI_ChatPanel // TypeDefIndex: 11936
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _inputGroup; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_OnlineStatus _onlineStatus; // 0x58
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _participantNameText; // 0x60
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _contentGroup; // 0x68
	private ChatConversationData _conversationData; // 0x70
	private bool _requestingChats; // 0x78
	private string _otherUserId; // 0x80

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 11937
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Predicate<string> <>9__7_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180F1FAE0-0x0000000180F1FB40
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <Setup>b__7_0(string id); // 0x0000000180E5A740-0x0000000180E5A780
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <Setup>d__7 : IAsyncStateMachine // TypeDefIndex: 11938
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_ChatPanel_Private <>4__this; // 0x28
		public ChatConversationData inData; // 0x30
		private UniTask<UserInfo> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F1410-0x00000001801F1420
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <SpawnInitialChatItems>d__16 : IAsyncStateMachine // TypeDefIndex: 11939
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_ChatPanel_Private <>4__this; // 0x28
		private int <attemptCount>5__2; // 0x30
		private UniTask<bool> <>u__1; // 0x38
		private UniTask<int> <>u__2; // 0x48

		// Methods
		private void MoveNext(); // 0x00000001801F1450-0x00000001801F1510
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestAdditionalChats>d__17 : IAsyncStateMachine // TypeDefIndex: 11940
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_ChatPanel_Private <>4__this; // 0x28
		public bool inGetOlder; // 0x30
		private UniTask<bool> <>u__1; // 0x38
		private UniTask.Awaiter <>u__2; // 0x48

		// Methods
		private void MoveNext(); // 0x00000001801F13E0-0x00000001801F13F0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <OnChatChacheChanged>d__18 : IAsyncStateMachine // TypeDefIndex: 11941
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
		public UI_ChatPanel_Private <>4__this; // 0x18
		public bool inGetOlder; // 0x20
		private UniTask.Awaiter <>u__1; // 0x28
		private int <attemptCount>5__2; // 0x30
		private UniTask<int> <>u__2; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F1380-0x00000001801F1390
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0500-0x00000001801F0510
	}

	// Constructors
	public UI_ChatPanel_Private(); // 0x0000000180F24850-0x0000000180F248C0

	// Methods
	[AsyncStateMachine] // 0x0000000180162120-0x0000000180162170
	public void Setup(ChatConversationData inData); // 0x0000000180F246E0-0x0000000180F247A0
	protected override void Awake(); // 0x00000001803581E0-0x00000001803581F0
	protected override void OnDestroy(); // 0x0000000180F24010-0x0000000180F24150
	protected override void OnEnable(); // 0x0000000180F242B0-0x0000000180F24340
	protected override void OnDisable(); // 0x0000000180F24150-0x0000000180F242B0
	public override void OnScrollPositionChanged(Vector2 inPosition); // 0x0000000180F24340-0x0000000180F24620
	protected override void DoChatSubmission(string inChatText); // 0x0000000180F23E30-0x0000000180F23EF0
	private void OnCachedMessageAdded(ChatEntry inChatEntry); // 0x0000000180441E30-0x0000000180441E50
	private void OnCachedMessageRemoved(ChatEntry inChatEntry); // 0x0000000180F23EF0-0x0000000180F23F50
	[AsyncStateMachine] // 0x0000000180162500-0x0000000180162550
	protected override void SpawnInitialChatItems(); // 0x0000000180F247A0-0x0000000180F24850
	[AsyncStateMachine] // 0x00000001801628A0-0x00000001801628F0
	private void RequestAdditionalChats(bool inGetOlder); // 0x0000000180F24620-0x0000000180F246E0
	[AsyncStateMachine] // 0x0000000180162C10-0x0000000180162C60
	private UniTask OnChatChacheChanged(bool inGetOlder); // 0x0000000180F23F50-0x0000000180F24010
}

