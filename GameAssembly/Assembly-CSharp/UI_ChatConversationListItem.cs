/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Services.Chat;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_ChatConversationListItem : UI_SelectableListItem<ChatConversationData> // TypeDefIndex: 11926
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _usersText; // 0x48

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RefreshUsersText>d__2 : IAsyncStateMachine // TypeDefIndex: 11927
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_ChatConversationListItem <>4__this; // 0x28
		private TaskAwaiter<IdentityDisplayNamesResponse.Identity[]> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F13C0-0x00000001801F13D0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public UI_ChatConversationListItem(); // 0x0000000180F222D0-0x0000000180F22310

	// Methods
	public override void Setup(ChatConversationData inData, Action<UI_SelectableListItem<ChatConversationData>> inOnClicked, Action<UI_SelectableListItem<ChatConversationData>> inOnLongPressed); // 0x0000000180F221C0-0x0000000180F222D0
	[AsyncStateMachine] // 0x000000018015CB20-0x000000018015CB70
	private void RefreshUsersText(); // 0x0000000180F22110-0x0000000180F221C0
	private void OnDestroy(); // 0x0000000180F22040-0x0000000180F22110
	private void OnChatConversationJoined(ChatConversationJoinedMessage inMessage); // 0x0000000180F21F30-0x0000000180F21FC0
	private void OnChatConversationLeft(ChatConversationLeftMessage inMessage); // 0x0000000180F21FC0-0x0000000180F22040
}

