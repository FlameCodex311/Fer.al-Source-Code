/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Services.Chat;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using WW.Debug;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_ActorBubble : UI_ScreenSpaceTransform // TypeDefIndex: 12275
{
	// Fields
	[DebugField] // 0x0000000180124DC0-0x0000000180124E20
	public static bool actorBubblesEnabled; // 0x00
	[Header] // 0x0000000180122120-0x0000000180122170
	[SerializeField] // 0x0000000180122120-0x0000000180122170
	private RectTransform _chatBubbleTransform; // 0xC0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RectTransform _normalChatBubbleGroup; // 0xC8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _chatBubbleText; // 0xD0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private LayoutElement _chatBubbleLayoutElement; // 0xD8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private int _charsPerLine; // 0xE0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private int _maxLines; // 0xE4
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _ellipseDistance; // 0xE8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RectTransform _emojiBubbleTransform; // 0xF0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _emojiBubbleText; // 0xF8
	[Header] // 0x0000000180127000-0x0000000180127050
	[SerializeField] // 0x0000000180127000-0x0000000180127050
	private Button _groupTeamJoinButton; // 0x100
	[Header] // 0x00000001801271C0-0x0000000180127210
	[SerializeField] // 0x00000001801271C0-0x0000000180127210
	private FeralButton _namebar; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _namebarText; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _localColor; // 0x118
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _networkColor; // 0x128
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _npcColor; // 0x138
	private ActorBase _targetActor; // 0x148
	private string _targetId; // 0x150
	private float? _chatBubbleTimer; // 0x158
	private ChatBubbleState _currentChatBubbleState; // 0x160
	private List<string> _currentChats; // 0x168
	private StringBuilder _chatStringBuilder; // 0x170
	private string _partyQuestDefId; // 0x178
	private NamebarState _currentNamebarState; // 0x180
	private GroupTeamJoinState _currentGroupTeamJoinState; // 0x184

	// Properties
	public ActorBase TargetActor { get; set; } // 0x0000000180FB8020-0x0000000180FB81F0 0x00000001803BE580-0x00000001803BE590
	private string TargetId { get; } // 0x0000000180FB81F0-0x0000000180FB8250 
	private ChatBubbleState CurrentChatBubbleState { get; set; } // 0x000000018081D990-0x000000018081D9A0 0x0000000180FB8250-0x0000000180FB8470
	private NamebarState CurrentNamebarState { get; set; } // 0x0000000180FB8010-0x0000000180FB8020 0x0000000180FB87B0-0x0000000180FB8B50
	private GroupTeamJoinState CurrentGroupTeamJoinState { get; set; } // 0x0000000180FB8000-0x0000000180FB8010 0x0000000180FB8470-0x0000000180FB87B0

	// Nested types
	public enum ChatBubbleState // TypeDefIndex: 12276
	{
		Off = 0,
		Chat = 1,
		ChatEllipsis = 2
	}

	public enum NamebarState // TypeDefIndex: 12277
	{
		Off = 0,
		Standard = 1
	}

	public enum GroupTeamJoinState // TypeDefIndex: 12278
	{
		Off = 0,
		GroupTeamJoinButton = 1
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <OnChatMessage>d__52 : IAsyncStateMachine // TypeDefIndex: 12279
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public RoomConversationMessage inMessage; // 0x28
		public UI_ActorBubble <>4__this; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F19F0-0x00000001801F1A00
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <TestRoutine>d__58 : IEnumerator<object> // TypeDefIndex: 12280
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public UI_ActorBubble <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <TestRoutine>d__58(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180FB1790-0x0000000180FB18B0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180FB18B0-0x0000000180FB22B0
	}

	// Constructors
	public UI_ActorBubble(); // 0x0000000180FB7F10-0x0000000180FB8000
	static UI_ActorBubble(); // 0x0000000180FB7ED0-0x0000000180FB7F10

	// Methods
	public bool IsInChatBubbleState(); // 0x0000000180FB6C90-0x0000000180FB6CB0
	public void ShowChatBubbleWithText(ChatEntry inChatEntry); // 0x0000000180FB7AF0-0x0000000180FB7B80
	public void SetChatText(ChatEntry inChatEntry); // 0x0000000180FB7840-0x0000000180FB7AF0
	public void ShowChatBubble(); // 0x0000000180FB7B80-0x0000000180FB7B90
	public void HideChatBubble(); // 0x0000000180FB6BB0-0x0000000180FB6C70
	public void ShowNamebar(); // 0x0000000180FB7C20-0x0000000180FB7C30
	public void HideNamebar(); // 0x0000000180FB6C80-0x0000000180FB6C90
	public void ShowGroupTeamJoinButton(string inQuestDefId = null); // 0x0000000180FB7B90-0x0000000180FB7C20
	public void ShowQuestNameText(); // 0x0000000180FB7C30-0x0000000180FB7D40
	public void HideGroupTeamJoinButton(); // 0x0000000180FB6C70-0x0000000180FB6C80
	[AsyncStateMachine] // 0x0000000180127A40-0x0000000180127A90
	private void OnChatMessage(RoomConversationMessage inMessage); // 0x0000000180FB74F0-0x0000000180FB75B0
	private void OnOverheadBubbleMessage(OverheadBubbleMessage inMessage); // 0x0000000180FB7790-0x0000000180FB7840
	private void OnButtonGroupTeamJoin(); // 0x0000000180FB7450-0x0000000180FB74F0
	public void BtnClicked_Namebar(); // 0x0000000180FB6AC0-0x0000000180FB6BB0
	public override void MOnDestroy(); // 0x0000000180FB6CB0-0x0000000180FB6ED0
	public override void MStart(); // 0x0000000180FB6ED0-0x0000000180FB7240
	[IteratorStateMachine] // 0x0000000180127DB0-0x0000000180127E00
	private IEnumerator TestRoutine(); // 0x0000000180FB7D40-0x0000000180FB7DA0
	public override void MUpdate(); // 0x0000000180FB7240-0x0000000180FB7450
	protected override void UpdateVisibilityAndAlpha(); // 0x0000000180FB7E20-0x0000000180FB7ED0
	protected override void OnDistanceFromCameraChanged(float inDistance); // 0x0000000180FB75B0-0x0000000180FB7790
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <set_CurrentNamebarState>b__41_0(); // 0x0000000180FB7DE0-0x0000000180FB7E20
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <set_CurrentGroupTeamJoinState>b__48_0(); // 0x0000000180FB7450-0x0000000180FB74F0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <set_CurrentGroupTeamJoinState>b__48_1(); // 0x0000000180FB7DA0-0x0000000180FB7DE0
}

