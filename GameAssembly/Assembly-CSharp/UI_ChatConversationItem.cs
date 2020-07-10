/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Services.Chat;
using TMPro;
using UniRx.Async;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_ChatConversationItem : MonoBehaviour // TypeDefIndex: 11922
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _canvasGroup; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _participantNameText; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _lastChatMessageText; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _lastChatTimeText; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_OnlineStatus _onlineStatus; // 0x40
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _chatTextColorMe; // 0x48
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _chatTextColorOther; // 0x58
	private ChatConversationData _conversationData; // 0x68

	// Properties
	public ChatConversationData ConversationData { get; } // 0x0000000180358970-0x0000000180358980 

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 11923
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Predicate<string> <>9__12_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180F1FB40-0x0000000180F1FBA0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <Setup>b__12_0(string id); // 0x0000000180E5A740-0x0000000180E5A780
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <Setup>d__12 : IAsyncStateMachine // TypeDefIndex: 11924
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_ChatConversationItem <>4__this; // 0x28
		public ChatConversationData inData; // 0x30
		private string <otherUserId>5__2; // 0x38
		private UniTask<UserInfo> <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x00000001801F13F0-0x00000001801F1400
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public UI_ChatConversationItem(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Start(); // 0x0000000180F21EA0-0x0000000180F21F30
	private void OnDestroy(); // 0x0000000180F21BE0-0x0000000180F21C70
	[AsyncStateMachine] // 0x000000018015B510-0x000000018015B560
	public void Setup(ChatConversationData inData); // 0x0000000180F21DE0-0x0000000180F21EA0
	public void SetTextSize(int inTextSize); // 0x0000000180F21D60-0x0000000180F21DE0
	private void OnChatMessage(ChatConversationMessage inMessage); // 0x0000000180F21B80-0x0000000180F21BE0
	private void RefreshLastChatEntry(ChatEntry inChatEntry); // 0x0000000180F21C70-0x0000000180F21D60
}

