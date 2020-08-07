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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_ChatConversationItem : MonoBehaviour // TypeDefIndex: 13468
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _canvasGroup; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _participantNameText; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _lastChatMessageText; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _lastChatTimeText; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_OnlineStatus _onlineStatus; // 0x40
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _chatTextColorMe; // 0x48
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _chatTextColorOther; // 0x58
	private ChatConversationData _conversationData; // 0x68

	// Properties
	public ChatConversationData ConversationData { get; } // 0x00000001803765E0-0x00000001803765F0 

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 13469
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Predicate<string> <>9__12_0; // 0x08

		// Constructors
		static <>c(); // 0x000000018053DA80-0x000000018053DAE0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <Setup>b__12_0(string id); // 0x000000018039E330-0x000000018039E360
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <Setup>d__12 : IAsyncStateMachine // TypeDefIndex: 13470
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_ChatConversationItem <>4__this; // 0x28
		public ChatConversationData inData; // 0x30
		private string <otherUserId>5__2; // 0x38
		private UniTask<UserInfo> <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x00000001800066F0-0x0000000180006700
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UI_ChatConversationItem(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Start(); // 0x000000018053F940-0x000000018053F9D0
	private void OnDestroy(); // 0x000000018053F680-0x000000018053F710
	[AsyncStateMachine] // 0x00000001802447E0-0x0000000180244830
	public void Setup(ChatConversationData inData); // 0x000000018053F880-0x000000018053F940
	public void SetTextSize(int inTextSize); // 0x000000018053F800-0x000000018053F880
	private void OnChatMessage(ChatConversationMessage inMessage); // 0x000000018053F620-0x000000018053F680
	private void RefreshLastChatEntry(ChatEntry inChatEntry); // 0x000000018053F710-0x000000018053F800
}

