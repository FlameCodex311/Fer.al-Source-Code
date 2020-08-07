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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_ActorBubble : UI_ScreenSpaceTransform // TypeDefIndex: 13859
{
	// Fields
	[DebugField] // 0x000000018021D840-0x000000018021D8A0
	public static bool actorBubblesEnabled; // 0x00
	[Header] // 0x0000000180209C80-0x0000000180209CD0
	[SerializeField] // 0x0000000180209C80-0x0000000180209CD0
	private RectTransform _chatBubbleTransform; // 0xC0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RectTransform _normalChatBubbleGroup; // 0xC8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _chatBubbleText; // 0xD0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private LayoutElement _chatBubbleLayoutElement; // 0xD8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int _charsPerLine; // 0xE0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int _maxLines; // 0xE4
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _ellipseDistance; // 0xE8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RectTransform _emojiBubbleTransform; // 0xF0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _emojiBubbleText; // 0xF8
	[Header] // 0x000000018021EA00-0x000000018021EA50
	[SerializeField] // 0x000000018021EA00-0x000000018021EA50
	private Button _groupTeamJoinButton; // 0x100
	[Header] // 0x000000018021ED10-0x000000018021ED60
	[SerializeField] // 0x000000018021ED10-0x000000018021ED60
	private FeralButton _namebar; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _namebarText; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _localColor; // 0x118
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _networkColor; // 0x128
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
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
	public ActorBase TargetActor { get; set; } // 0x000000018051CED0-0x000000018051D0A0 0x000000018051D9F0-0x000000018051DA00
	private string TargetId { get; } // 0x000000018051D0A0-0x000000018051D100 
	private ChatBubbleState CurrentChatBubbleState { get; set; } // 0x000000018051CEA0-0x000000018051CEB0 0x000000018051D100-0x000000018051D320
	private NamebarState CurrentNamebarState { get; set; } // 0x000000018051CEC0-0x000000018051CED0 0x000000018051D650-0x000000018051D9F0
	private GroupTeamJoinState CurrentGroupTeamJoinState { get; set; } // 0x000000018051CEB0-0x000000018051CEC0 0x000000018051D320-0x000000018051D650

	// Nested types
	public enum ChatBubbleState // TypeDefIndex: 13860
	{
		Off = 0,
		Chat = 1,
		ChatEllipsis = 2
	}

	public enum NamebarState // TypeDefIndex: 13861
	{
		Off = 0,
		Standard = 1
	}

	public enum GroupTeamJoinState // TypeDefIndex: 13862
	{
		Off = 0,
		GroupTeamJoinButton = 1
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <OnChatMessage>d__52 : IAsyncStateMachine // TypeDefIndex: 13863
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public RoomConversationMessage inMessage; // 0x28
		public UI_ActorBubble <>4__this; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180006290-0x00000001800062A0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <TestRoutine>d__58 : IEnumerator<object> // TypeDefIndex: 13864
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public UI_ActorBubble <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <TestRoutine>d__58(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001805167A0-0x00000001805168C0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001805168C0-0x00000001805172B0
	}

	// Constructors
	public UI_ActorBubble(); // 0x000000018051CDB0-0x000000018051CEA0
	static UI_ActorBubble(); // 0x000000018051CD70-0x000000018051CDB0

	// Methods
	public bool IsInChatBubbleState(); // 0x000000018051BB50-0x000000018051BB70
	public void ShowChatBubbleWithText(ChatEntry inChatEntry); // 0x000000018051C990-0x000000018051CA20
	public void SetChatText(ChatEntry inChatEntry); // 0x000000018051C6F0-0x000000018051C990
	public void ShowChatBubble(); // 0x000000018051CA20-0x000000018051CA30
	public void HideChatBubble(); // 0x000000018051BA70-0x000000018051BB30
	public void ShowNamebar(); // 0x000000018051CAC0-0x000000018051CAD0
	public void HideNamebar(); // 0x000000018051BB40-0x000000018051BB50
	public void ShowGroupTeamJoinButton(string inQuestDefId = null); // 0x000000018051CA30-0x000000018051CAC0
	public void ShowQuestNameText(); // 0x000000018051CAD0-0x000000018051CBE0
	public void HideGroupTeamJoinButton(); // 0x000000018051BB30-0x000000018051BB40
	[AsyncStateMachine] // 0x000000018021F740-0x000000018021F790
	private void OnChatMessage(RoomConversationMessage inMessage); // 0x000000018051C3A0-0x000000018051C460
	private void OnOverheadBubbleMessage(OverheadBubbleMessage inMessage); // 0x000000018051C640-0x000000018051C6F0
	private void OnButtonGroupTeamJoin(); // 0x000000018051C300-0x000000018051C3A0
	public void BtnClicked_Namebar(); // 0x000000018051B980-0x000000018051BA70
	public override void MOnDestroy(); // 0x000000018051BB70-0x000000018051BD90
	public override void MStart(); // 0x000000018051BD90-0x000000018051C0F0
	[IteratorStateMachine] // 0x000000018021F9C0-0x000000018021FA10
	private IEnumerator TestRoutine(); // 0x000000018051CBE0-0x000000018051CC40
	public override void MUpdate(); // 0x000000018051C0F0-0x000000018051C300
	protected override void UpdateVisibilityAndAlpha(); // 0x000000018051CCC0-0x000000018051CD70
	protected override void OnDistanceFromCameraChanged(float inDistance); // 0x000000018051C460-0x000000018051C640
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <set_CurrentNamebarState>b__41_0(); // 0x000000018051CC80-0x000000018051CCC0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <set_CurrentGroupTeamJoinState>b__48_0(); // 0x000000018051C300-0x000000018051C3A0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <set_CurrentGroupTeamJoinState>b__48_1(); // 0x000000018051CC40-0x000000018051CC80
}

