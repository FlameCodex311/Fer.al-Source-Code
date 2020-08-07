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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_ChatPanel_Private : UI_ChatPanel // TypeDefIndex: 13482
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _inputGroup; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_OnlineStatus _onlineStatus; // 0x58
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _participantNameText; // 0x60
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _contentGroup; // 0x68
	private ChatConversationData _conversationData; // 0x70
	private bool _requestingChats; // 0x78
	private string _otherUserId; // 0x80

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 13483
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Predicate<string> <>9__7_0; // 0x08

		// Constructors
		static <>c(); // 0x000000018053DA20-0x000000018053DA80
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <Setup>b__7_0(string id); // 0x000000018039E330-0x000000018039E360
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <Setup>d__7 : IAsyncStateMachine // TypeDefIndex: 13484
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_ChatPanel_Private <>4__this; // 0x28
		public ChatConversationData inData; // 0x30
		private UniTask<UserInfo> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x0000000180006710-0x0000000180006720
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <SpawnInitialChatItems>d__16 : IAsyncStateMachine // TypeDefIndex: 13485
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_ChatPanel_Private <>4__this; // 0x28
		private int <attemptCount>5__2; // 0x30
		private UniTask<bool> <>u__1; // 0x38
		private UniTask<int> <>u__2; // 0x48

		// Methods
		private void MoveNext(); // 0x0000000180006750-0x00000001800068B0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestAdditionalChats>d__17 : IAsyncStateMachine // TypeDefIndex: 13486
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_ChatPanel_Private <>4__this; // 0x28
		public bool inGetOlder; // 0x30
		private UniTask<bool> <>u__1; // 0x38
		private UniTask.Awaiter <>u__2; // 0x48

		// Methods
		private void MoveNext(); // 0x00000001800066E0-0x00000001800066F0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <OnChatChacheChanged>d__18 : IAsyncStateMachine // TypeDefIndex: 13487
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
		private void MoveNext(); // 0x0000000180006680-0x0000000180006690
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002020-0x0000000180002030
	}

	// Constructors
	public UI_ChatPanel_Private(); // 0x00000001805422E0-0x0000000180542350

	// Methods
	[AsyncStateMachine] // 0x0000000180248BD0-0x0000000180248C20
	public void Setup(ChatConversationData inData); // 0x0000000180542170-0x0000000180542230
	protected override void Awake(); // 0x00000001803774A0-0x00000001803774B0
	protected override void OnDestroy(); // 0x0000000180541AB0-0x0000000180541BF0
	protected override void OnEnable(); // 0x0000000180541D50-0x0000000180541DE0
	protected override void OnDisable(); // 0x0000000180541BF0-0x0000000180541D50
	public override void OnScrollPositionChanged(Vector2 inPosition); // 0x0000000180541DE0-0x00000001805420B0
	protected override void DoChatSubmission(string inChatText); // 0x00000001805418B0-0x0000000180541970
	private void OnCachedMessageAdded(ChatEntry inChatEntry); // 0x0000000180541970-0x0000000180541990
	private void OnCachedMessageRemoved(ChatEntry inChatEntry); // 0x0000000180541990-0x00000001805419F0
	[AsyncStateMachine] // 0x0000000180248F10-0x0000000180248F60
	protected override void SpawnInitialChatItems(); // 0x0000000180542230-0x00000001805422E0
	[AsyncStateMachine] // 0x00000001802491E0-0x0000000180249230
	private void RequestAdditionalChats(bool inGetOlder); // 0x00000001805420B0-0x0000000180542170
	[AsyncStateMachine] // 0x0000000180249360-0x00000001802493B0
	private UniTask OnChatChacheChanged(bool inGetOlder); // 0x00000001805419F0-0x0000000180541AB0
}

