/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.DeInspektor.Attributes;
using TMPro;
using UniRx.Async;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_CreatureCustomization : UI_Window // TypeDefIndex: 12434
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _mainCanvasGroup; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_TabGroup _sidebarTabGroup; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_CustomizationPageNavigationController _navigationController; // 0x118
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<UI_CustomizationPageInfo> _rootPageInfos; // 0x120
	private bool _ignoreNextTabClick; // 0x128
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_AvatarPositioner _avatarPositioner; // 0x130
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _looksTabBtn; // 0x138
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _saveLookButton; // 0x140
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _switchAvatarTabButton; // 0x148
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _clothingShopButton; // 0x150
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private TMP_InputField _nameInputField; // 0x158
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private TextMeshProUGUI _classNameText; // 0x160
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<GameObject> _designerOnlyObjects; // 0x168
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<GameObject> _userOnlyObjects; // 0x170
	[DeComment] // 0x000000018016B940-0x000000018016B990
	[SerializeField] // 0x000000018016B940-0x000000018016B990
	private GameObject _clothingColorControl; // 0x178
	private UI_Stage_Avatar _avatarStage; // 0x180
	private bool _stageInitializationReceived; // 0x188
	private ActorInfo _lastSavedActorInfo; // 0x190
	private string _lastSavedName; // 0x198
	private float _timeLastSaved; // 0x1A0
	private float _autoSaveInterval; // 0x1A4
	private ActorInfo _infoToDisplay; // 0x1A8
	private bool _isDesignerMode; // 0x1B0
	private string _designerDefID; // 0x1B8
	private int _currentDecalCount; // 0x1C0
	private int _maxDecals; // 0x1C4
	public Action<ActorInfoClothingItem> OnDesignerEditClothingTargetChanged; // 0x1C8
	private ActorInfoClothingItem _designerEditClothingTarget; // 0x1D0
	public Action<int> OnDecalCountChanged; // 0x1D8

	// Properties
	public UI_AvatarPositioner AvatarPositioner { get; } // 0x00000001803BD390-0x00000001803BD3A0 
	public ActorInfo InfoToDisplay { get; } // 0x0000000180F0A740-0x0000000180F0A750 
	public bool IsDesignerMode { get; } // 0x0000000180F0A750-0x0000000180F0A760 
	public string DesignerDefID { get; } // 0x0000000180CB77B0-0x0000000180CB77C0 
	public int CurrentDecalCount { get; private set; } // 0x0000000180F0A720-0x0000000180F0A730 0x0000000180F0A840-0x0000000180F0A8A0
	public int MaxDecals { get; } // 0x0000000180F0A7A0-0x0000000180F0A840 
	public bool MaxDecalsExceeded { get; } // 0x0000000180F0A760-0x0000000180F0A780 
	public bool MaxDecalsMet { get; } // 0x0000000180F0A780-0x0000000180F0A7A0 
	public ActorInfoClothingItem DesignerEditClothingTarget { get; set; } // 0x0000000180F0A730-0x0000000180F0A740 0x0000000180F0A8A0-0x0000000180F0A910

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12435
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_CreatureCustomization> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10

		// Constructors
		static <>c(); // 0x0000000180EFFC20-0x0000000180EFFC80
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_CreatureCustomization window); // 0x0000000180E9D080-0x0000000180E9D0A0
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x0000000180EFEB70-0x0000000180EFEBF0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass57_0 // TypeDefIndex: 12436
	{
		// Fields
		public bool? confirmation; // 0x10

		// Constructors
		public <>c__DisplayClass57_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OnClose>b__0(bool result); // 0x0000000180EFFB00-0x0000000180EFFB60
		internal bool <OnClose>b__1(); // 0x0000000180EFFB60-0x0000000180EFFBA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <OnClose>d__57 : IAsyncStateMachine // TypeDefIndex: 12437
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_CreatureCustomization <>4__this; // 0x28
		private <>c__DisplayClass57_0 <>8__1; // 0x30
		public bool inAnimate; // 0x38
		private UniTask.Awaiter <>u__1; // 0x40
		private TaskAwaiter<TutorialCompleteResponse> <>u__2; // 0x48

		// Methods
		private void MoveNext(); // 0x00000001801F12C0-0x00000001801F12D0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <SaveChanges>d__66 : IAsyncStateMachine // TypeDefIndex: 12438
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_CreatureCustomization <>4__this; // 0x28
		private UniTask.Awaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F1310-0x00000001801F1320
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <OnCurrentLookChanged>d__72 : IAsyncStateMachine // TypeDefIndex: 12439
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_CreatureCustomization <>4__this; // 0x28
		public CreatureCustomizationTarget inInfo; // 0x30
		private TaskAwaiter<AvatarLookSwitchResponse> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F12D0-0x00000001801F12E0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public UI_Window_CreatureCustomization(); // 0x0000000180F0A650-0x0000000180F0A720

	// Methods
	public static void OpenWindow(); // 0x0000000180F09B90-0x0000000180F09C90
	public static void QueueWindow(); // 0x0000000180F09C90-0x0000000180F09D90
	public static void CloseWindow(); // 0x0000000180F08250-0x0000000180F082A0
	public void Setup(); // 0x00000001803581E0-0x00000001803581F0
	public void SetupForDesigner(BaseDef inDef); // 0x0000000180F0A2A0-0x0000000180F0A5A0
	protected override void OnOpen(); // 0x0000000180F08DF0-0x0000000180F09310
	protected override void OnOpenComplete(); // 0x0000000180F08D60-0x0000000180F08DF0
	protected override void DoDelayedOpenAnimation(); // 0x0000000180F082A0-0x0000000180F08340
	[AsyncStateMachine] // 0x000000018016BB70-0x000000018016BBC0
	protected override void OnClose(bool inAnimate); // 0x0000000180F08AC0-0x0000000180F08B80
	protected override void OnHide(); // 0x0000000180F08C40-0x0000000180F08CC0
	protected override void OnShow(); // 0x0000000180F09B10-0x0000000180F09B90
	public override void OnReceiveFocus(); // 0x0000000180F09580-0x0000000180F09620
	public override void OnLoseFocus(); // 0x0000000180F08CC0-0x0000000180F08D60
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
	public override void MUpdate(); // 0x0000000180F084A0-0x0000000180F084F0
	public void BtnToggle_EditName(bool inIsHighlighted); // 0x0000000180F08210-0x0000000180F08250
	public void BtnClicked_SaveLook(); // 0x0000000180F08140-0x0000000180F08210
	[AsyncStateMachine] // 0x000000018016BEB0-0x000000018016BF00
	public void SaveChanges(); // 0x0000000180F0A1F0-0x0000000180F0A2A0
	public void RefreshLastSavedLook(); // 0x0000000180F0A130-0x0000000180F0A1F0
	public void RefreshDecalCount(); // 0x0000000180F09D90-0x0000000180F0A130
	public bool HasChanges(); // 0x0000000180F08340-0x0000000180F084A0
	private void OnAvatarStageLoaded(UIAvatarStageLoadedMessage inMessage); // 0x0000000180F089D0-0x0000000180F08AC0
	private void OnAvatarStageInitialized(UIAvatarStageInitializedMessage inMessage); // 0x0000000180F084F0-0x0000000180F089D0
	[AsyncStateMachine] // 0x000000018016C220-0x000000018016C270
	private void OnCurrentLookChanged(CreatureCustomizationTarget inInfo); // 0x0000000180F08B80-0x0000000180F08C40
	private void OnSectionSelected(int inTabIndex); // 0x0000000180F09620-0x0000000180F09B10
	private void OnPageNavigation(UI_CustomizationPageInfo inPageInfo); // 0x0000000180F09310-0x0000000180F09580
	public void OnNameValueChanged(string inName); // 0x00000001803581E0-0x00000001803581F0
	private void TryCloseWindow(); // 0x0000000180F0A5A0-0x0000000180F0A5E0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <DoDelayedOpenAnimation>b__56_0(); // 0x0000000180F0A5E0-0x0000000180F0A640
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <DoDelayedOpenAnimation>b__56_1(); // 0x00000001809E8060-0x00000001809E8080
	[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
	[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
	private void <>n__0(bool inAnimate); // 0x0000000180E9F690-0x0000000180E9F6A0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnCurrentLookChanged>b__72_0(ActorInfoDecalEntry decal); // 0x0000000180F0A640-0x0000000180F0A650
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnCurrentLookChanged>b__72_1(ActorInfoDecalEntry decal); // 0x0000000180F0A640-0x0000000180F0A650
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnCurrentLookChanged>b__72_2(ActorInfoBodyPart bodyPart); // 0x0000000180F0A640-0x0000000180F0A650
}

