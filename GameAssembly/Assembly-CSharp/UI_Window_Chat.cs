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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_Chat : UI_Window // TypeDefIndex: 13511
{
	// Fields
	public static bool isChatting; // 0x00
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Graphic _opacityTarget; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _body; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _closeTarget; // 0x118
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_ChatPanel_Room _publicChatPanel; // 0x120
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_ChatPanel_Private _privateChatPanel; // 0x128
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_TabGroup _tabGroup; // 0x130
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private TMP_InputField _inputField; // 0x138
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _settingsToggle; // 0x140
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<UI_ChatPositionDragger> _positionDraggers; // 0x148
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_ChatPanel_Conversations _conversationsPanel; // 0x150
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FixedPositionInfo _selfieModeFixedPositionInfo; // 0x158
	private bool _isFirstSetup; // 0x160
	private bool _hasPlayedCloseAnimation; // 0x161
	private FixedPositionInfo _currentFixedPositionInfo; // 0x168

	// Nested types
	[Serializable]
	public class FixedPositionInfo // TypeDefIndex: 13512
	{
		// Fields
		public string saveKey; // 0x10
		public int anchorCornerIndex; // 0x18
		public float defaultWidth; // 0x1C
		public bool allowWidthResize; // 0x20
		public float defaultHeight; // 0x24
		public bool allowHeightResize; // 0x28

		// Constructors
		public FixedPositionInfo(); // 0x000000018047B440-0x000000018047B490
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 13513
	{
		// Fields
		public ChatConversationData inConversation; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_Chat window); // 0x000000018047E7C0-0x000000018047E7F0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 13514
	{
		// Fields
		public ChatConversationData inConversation; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x000000018047E920-0x000000018047E9F0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <OpenConversation>d__3 : IAsyncStateMachine // TypeDefIndex: 13515
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
		public string inUUID; // 0x18
		private UniTask<ChatConversationData> <>u__1; // 0x20

		// Methods
		private void MoveNext(); // 0x0000000180004A70-0x0000000180004A80
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002020-0x0000000180002030
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <MoveToEndOfLine>d__33 : IEnumerator<object> // TypeDefIndex: 13516
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public UI_Window_Chat <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <MoveToEndOfLine>d__33(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018047C660-0x000000018047C6C0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018047C6C0-0x000000018047D5B0
	}

	// Constructors
	public UI_Window_Chat(); // 0x0000000180484190-0x0000000180484200
	static UI_Window_Chat(); // 0x00000001803774A0-0x00000001803774B0

	// Methods
	[DebugButton] // 0x0000000180254940-0x00000001802549A0
	public static void OpenWindow(ChatConversationData inConversation = null); // 0x0000000180482EA0-0x0000000180482F60
	public static void QueueWindow(ChatConversationData inConversation = null); // 0x0000000180483300-0x00000001804833C0
	[DebugButton] // 0x0000000180254C50-0x0000000180254CB0
	public static void CloseWindow(); // 0x0000000180481460-0x00000001804814B0
	[AsyncStateMachine] // 0x0000000180254DC0-0x0000000180254E10
	public static UniTask OpenConversation(string inUUID); // 0x0000000180482D50-0x0000000180482DE0
	private void Setup(ChatConversationData inConversation = null); // 0x0000000180483F70-0x00000001804840A0
	public override void MStart(); // 0x00000001804821E0-0x0000000180482340
	public override void MOnDestroy(); // 0x0000000180481BB0-0x0000000180481D10
	public override void MOnEnable(); // 0x0000000180481F30-0x00000001804821E0
	private void SetMaxChatLength(); // 0x0000000180483D40-0x0000000180483DF0
	public override void MOnDisable(); // 0x0000000180481D10-0x0000000180481F30
	protected override void OnOpen(); // 0x00000001804829B0-0x0000000180482CB0
	protected override void OnOpenComplete(); // 0x0000000180482990-0x00000001804829B0
	protected override void OnClose(bool inAnimate); // 0x00000001804823C0-0x00000001804825E0
	private void OnApplicationQuit(); // 0x00000001804823A0-0x00000001804823C0
	protected override void PlayOpenAnimation(); // 0x00000001804830C0-0x0000000180483300
	protected override void PlayCloseAnimation(); // 0x0000000180482F60-0x00000001804830C0
	private void DeselectWindow(); // 0x00000001804814B0-0x0000000180481600
	public void SelectInputField(); // 0x0000000180483830-0x00000001804838A0
	[IteratorStateMachine] // 0x0000000180254F60-0x0000000180254FB0
	private IEnumerator MoveToEndOfLine(); // 0x0000000180482340-0x00000001804823A0
	public void OnInputFieldSelected(); // 0x00000001804828A0-0x0000000180482990
	public void OnInputFieldDeSelected(); // 0x00000001804827A0-0x00000001804828A0
	public void SetInputFieldActive(); // 0x0000000180483CA0-0x0000000180483D40
	public void RecalculateLayouts(); // 0x00000001804833C0-0x0000000180483410
	public void OpenConversation(ChatConversationData inConversation); // 0x0000000180482DE0-0x0000000180482EA0
	private void OnTabSelected(int inTabIndex); // 0x0000000180482D00-0x0000000180482D50
	private void OnSelect(string inChatText); // 0x00000001804828A0-0x0000000180482990
	private void OnDeSelect(string inChatText); // 0x00000001804825E0-0x00000001804825F0
	private void OnSubmit(string inChatText); // 0x0000000180482CD0-0x0000000180482D00
	private void OnHideHUDCommand(HideHUDCommand inCommand); // 0x00000001804826D0-0x00000001804827A0
	private void OnHUDWindowOpened(WindowOpenedMessage inMessage); // 0x00000001804825F0-0x00000001804826D0
	private void OnSelfieModeOpened(WindowOpenedMessage inMessage); // 0x0000000180482CC0-0x0000000180482CD0
	private void OnSelfieModeClosed(WindowClosedMessage inMessage); // 0x0000000180482CB0-0x0000000180482CC0
	private void ClampWindowPosition(); // 0x0000000180481380-0x0000000180481460
	private void SaveWindowSize(); // 0x0000000180483410-0x0000000180483830
	private void LoadWindowSize(bool inApply, out Vector3 size, out Vector3 pos); // 0x0000000180481600-0x0000000180481BB0
	[DeMethodButton] // 0x00000001802551A0-0x0000000180255200
	private void SetSelfieMode(); // 0x0000000180482CC0-0x0000000180482CD0
	[DeMethodButton] // 0x0000000180255590-0x00000001802555F0
	private void SetNormalMode(); // 0x0000000180482CB0-0x0000000180482CC0
	public void SetOpacity(int inPercentage); // 0x0000000180483DF0-0x0000000180483F20
	public void SetTextSize(int inTextSize); // 0x0000000180483F20-0x0000000180483F70
	public void SetFixedPositionInfo(FixedPositionInfo inInfo); // 0x00000001804838A0-0x0000000180483CA0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <SelectInputField>b__32_0(); // 0x00000001804840A0-0x0000000180484190
}

