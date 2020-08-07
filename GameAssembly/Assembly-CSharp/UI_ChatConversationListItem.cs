/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Services.Chat;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_ChatConversationListItem : UI_SelectableListItem<ChatConversationData> // TypeDefIndex: 13472
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _usersText; // 0x48

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RefreshUsersText>d__2 : IAsyncStateMachine // TypeDefIndex: 13473
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_ChatConversationListItem <>4__this; // 0x28
		private TaskAwaiter<IdentityDisplayNamesResponse.Identity[]> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001800066C0-0x00000001800066D0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UI_ChatConversationListItem(); // 0x000000018053FD50-0x000000018053FD90

	// Methods
	public override void Setup(ChatConversationData inData, Action<UI_SelectableListItem<ChatConversationData>> inOnClicked, Action<UI_SelectableListItem<ChatConversationData>> inOnLongPressed); // 0x000000018053FC40-0x000000018053FD50
	[AsyncStateMachine] // 0x0000000180245350-0x00000001802453A0
	private void RefreshUsersText(); // 0x000000018053FB90-0x000000018053FC40
	private void OnDestroy(); // 0x000000018053FAC0-0x000000018053FB90
	private void OnChatConversationJoined(ChatConversationJoinedMessage inMessage); // 0x000000018053F9D0-0x000000018053FA50
	private void OnChatConversationLeft(ChatConversationLeftMessage inMessage); // 0x000000018053FA50-0x000000018053FAC0
}

