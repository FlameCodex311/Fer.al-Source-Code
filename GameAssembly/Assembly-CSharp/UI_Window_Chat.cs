/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.DeInspektor.Attributes;
using Services.Chat;
using TMPro;
using UniRx.Async;
using UniRx.Async.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using WW.Debug;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_Chat : UI_Window // TypeDefIndex: 11965
{
	// Fields
	public static bool isChatting; // 0x00
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Graphic _opacityTarget; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _body; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _closeTarget; // 0x118
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_ChatPanel_Room _publicChatPanel; // 0x120
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_ChatPanel_Private _privateChatPanel; // 0x128
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_TabGroup _tabGroup; // 0x130
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private TMP_InputField _inputField; // 0x138
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _settingsToggle; // 0x140
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<UI_ChatPositionDragger> _positionDraggers; // 0x148
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_ChatPanel_Conversations _conversationsPanel; // 0x150
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FixedPositionInfo _selfieModeFixedPositionInfo; // 0x158
	private bool _isFirstSetup; // 0x160
	private bool _hasPlayedCloseAnimation; // 0x161
	private FixedPositionInfo _currentFixedPositionInfo; // 0x168

	// Nested types
	[Serializable]
	public class FixedPositionInfo // TypeDefIndex: 11966
	{
		// Fields
		public string saveKey; // 0x10
		public int anchorCornerIndex; // 0x18
		public float defaultWidth; // 0x1C
		public bool allowWidthResize; // 0x20
		public float defaultHeight; // 0x24
		public bool allowHeightResize; // 0x28

		// Constructors
		public FixedPositionInfo(); // 0x0000000180EFB500-0x0000000180EFB550
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 11967
	{
		// Fields
		public ChatConversationData inConversation; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_Chat window); // 0x0000000180EFEEF0-0x0000000180EFEF20
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 11968
	{
		// Fields
		public ChatConversationData inConversation; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180EFF060-0x0000000180EFF130
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <OpenConversation>d__3 : IAsyncStateMachine // TypeDefIndex: 11969
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
		public string inUUID; // 0x18
		private UniTask<ChatConversationData> <>u__1; // 0x20

		// Methods
		private void MoveNext(); // 0x00000001801F1300-0x00000001801F1310
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0500-0x00000001801F0510
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <MoveToEndOfLine>d__33 : IEnumerator<object> // TypeDefIndex: 11970
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public UI_Window_Chat <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <MoveToEndOfLine>d__33(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180EFC7B0-0x0000000180EFC820
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180EFC820-0x0000000180EFD960
	}

	// Constructors
	public UI_Window_Chat(); // 0x0000000180F06380-0x0000000180F063F0
	static UI_Window_Chat(); // 0x00000001803581E0-0x00000001803581F0

	// Methods
	[DebugButton] // 0x000000018016FB70-0x000000018016FBD0
	public static void OpenWindow(ChatConversationData inConversation = null); // 0x0000000180F05050-0x0000000180F05110
	public static void QueueWindow(ChatConversationData inConversation = null); // 0x0000000180F054B0-0x0000000180F05570
	[DebugButton] // 0x000000018016FEB0-0x000000018016FF10
	public static void CloseWindow(); // 0x0000000180F035B0-0x0000000180F03600
	[AsyncStateMachine] // 0x0000000180170110-0x0000000180170160
	public static UniTask OpenConversation(string inUUID); // 0x0000000180F04F00-0x0000000180F04F90
	private void Setup(ChatConversationData inConversation = null); // 0x0000000180F06160-0x0000000180F06290
	public override void MStart(); // 0x0000000180F04370-0x0000000180F044D0
	public override void MOnDestroy(); // 0x0000000180F03D20-0x0000000180F03E80
	public override void MOnEnable(); // 0x0000000180F040B0-0x0000000180F04370
	private void SetMaxChatLength(); // 0x0000000180F05F20-0x0000000180F05FD0
	public override void MOnDisable(); // 0x0000000180F03E80-0x0000000180F040B0
	protected override void OnOpen(); // 0x0000000180F04B50-0x0000000180F04E60
	protected override void OnOpenComplete(); // 0x0000000180F04B30-0x0000000180F04B50
	protected override void OnClose(bool inAnimate); // 0x0000000180F04550-0x0000000180F04770
	private void OnApplicationQuit(); // 0x0000000180F04530-0x0000000180F04550
	protected override void PlayOpenAnimation(); // 0x0000000180F05270-0x0000000180F054B0
	protected override void PlayCloseAnimation(); // 0x0000000180F05110-0x0000000180F05270
	private void DeselectWindow(); // 0x0000000180F03600-0x0000000180F03750
	public void SelectInputField(); // 0x0000000180F05A00-0x0000000180F05A70
	[IteratorStateMachine] // 0x0000000180170380-0x00000001801703D0
	private IEnumerator MoveToEndOfLine(); // 0x0000000180F044D0-0x0000000180F04530
	public void OnInputFieldSelected(); // 0x0000000180F04A40-0x0000000180F04B30
	public void OnInputFieldDeSelected(); // 0x0000000180F04940-0x0000000180F04A40
	public void SetInputFieldActive(); // 0x0000000180F05E80-0x0000000180F05F20
	public void RecalculateLayouts(); // 0x0000000180F05570-0x0000000180F055C0
	public void OpenConversation(ChatConversationData inConversation); // 0x0000000180F04F90-0x0000000180F05050
	private void OnTabSelected(int inTabIndex); // 0x0000000180F04EB0-0x0000000180F04F00
	private void OnSelect(string inChatText); // 0x0000000180F04A40-0x0000000180F04B30
	private void OnDeSelect(string inChatText); // 0x0000000180F04770-0x0000000180F04780
	private void OnSubmit(string inChatText); // 0x0000000180F04E80-0x0000000180F04EB0
	private void OnHideHUDCommand(HideHUDCommand inCommand); // 0x0000000180F04870-0x0000000180F04940
	private void OnHUDWindowOpened(WindowOpenedMessage inMessage); // 0x0000000180F04780-0x0000000180F04870
	private void OnSelfieModeOpened(WindowOpenedMessage inMessage); // 0x0000000180F04E70-0x0000000180F04E80
	private void OnSelfieModeClosed(WindowClosedMessage inMessage); // 0x0000000180F04E60-0x0000000180F04E70
	private void ClampWindowPosition(); // 0x0000000180F034C0-0x0000000180F035B0
	private void SaveWindowSize(); // 0x0000000180F055C0-0x0000000180F05A00
	private void LoadWindowSize(bool inApply, out Vector3 size, out Vector3 pos); // 0x0000000180F03750-0x0000000180F03D20
	[DeMethodButton] // 0x00000001801706A0-0x0000000180170700
	private void SetSelfieMode(); // 0x0000000180F04E70-0x0000000180F04E80
	[DeMethodButton] // 0x0000000180170DA0-0x0000000180170E00
	private void SetNormalMode(); // 0x0000000180F04E60-0x0000000180F04E70
	public void SetOpacity(int inPercentage); // 0x0000000180F05FD0-0x0000000180F06110
	public void SetTextSize(int inTextSize); // 0x0000000180F06110-0x0000000180F06160
	public void SetFixedPositionInfo(FixedPositionInfo inInfo); // 0x0000000180F05A70-0x0000000180F05E80
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <SelectInputField>b__32_0(); // 0x0000000180F06290-0x0000000180F06380
}

