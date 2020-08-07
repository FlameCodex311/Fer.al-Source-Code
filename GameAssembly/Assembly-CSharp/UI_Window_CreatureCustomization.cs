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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_CreatureCustomization : UI_Window // TypeDefIndex: 14033
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _mainCanvasGroup; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_TabGroup _sidebarTabGroup; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_CustomizationPageNavigationController _navigationController; // 0x118
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<UI_CustomizationPageInfo> _rootPageInfos; // 0x120
	private bool _ignoreNextTabClick; // 0x128
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_AvatarPositioner _avatarPositioner; // 0x130
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _looksTabBtn; // 0x138
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _saveLookButton; // 0x140
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _switchAvatarTabButton; // 0x148
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _clothingShopButton; // 0x150
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private TMP_InputField _nameInputField; // 0x158
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private TextMeshProUGUI _classNameText; // 0x160
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<GameObject> _designerOnlyObjects; // 0x168
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<GameObject> _userOnlyObjects; // 0x170
	[DeComment] // 0x0000000180262C40-0x0000000180262C90
	[SerializeField] // 0x0000000180262C40-0x0000000180262C90
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
	public UI_AvatarPositioner AvatarPositioner { get; } // 0x0000000180383C00-0x0000000180383C10 
	public ActorInfo InfoToDisplay { get; } // 0x0000000180488920-0x0000000180488930 
	public bool IsDesignerMode { get; } // 0x0000000180488930-0x0000000180488940 
	public string DesignerDefID { get; } // 0x0000000180488900-0x0000000180488910 
	public int CurrentDecalCount { get; private set; } // 0x00000001804888F0-0x0000000180488900 0x0000000180488A20-0x0000000180488A80
	public int MaxDecals { get; } // 0x0000000180488980-0x0000000180488A20 
	public bool MaxDecalsExceeded { get; } // 0x0000000180488940-0x0000000180488960 
	public bool MaxDecalsMet { get; } // 0x0000000180488960-0x0000000180488980 
	public ActorInfoClothingItem DesignerEditClothingTarget { get; set; } // 0x0000000180488910-0x0000000180488920 0x0000000180488A80-0x0000000180488AF0

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 14034
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_CreatureCustomization> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10

		// Constructors
		static <>c(); // 0x000000018047F3B0-0x000000018047F410
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_CreatureCustomization window); // 0x00000001803B24A0-0x00000001803B24C0
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x000000018047E4B0-0x000000018047E530
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass57_0 // TypeDefIndex: 14035
	{
		// Fields
		public bool? confirmation; // 0x10

		// Constructors
		public <>c__DisplayClass57_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OnClose>b__0(bool result); // 0x000000018047F290-0x000000018047F2F0
		internal bool <OnClose>b__1(); // 0x000000018047F2F0-0x000000018047F330
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <OnClose>d__57 : IAsyncStateMachine // TypeDefIndex: 14036
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
		private void MoveNext(); // 0x0000000180004A40-0x0000000180004A50
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <SaveChanges>d__66 : IAsyncStateMachine // TypeDefIndex: 14037
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_CreatureCustomization <>4__this; // 0x28
		private UniTask.Awaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180004A80-0x0000000180004A90
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <OnCurrentLookChanged>d__72 : IAsyncStateMachine // TypeDefIndex: 14038
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_CreatureCustomization <>4__this; // 0x28
		public CreatureCustomizationTarget inInfo; // 0x30
		private TaskAwaiter<AvatarLookSwitchResponse> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x0000000180004A50-0x0000000180004A60
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UI_Window_CreatureCustomization(); // 0x0000000180488820-0x00000001804888F0

	// Methods
	public static void OpenWindow(); // 0x0000000180487D90-0x0000000180487E90
	public static void QueueWindow(); // 0x0000000180487E90-0x0000000180487F90
	public static void CloseWindow(); // 0x0000000180486500-0x0000000180486550
	public void Setup(); // 0x00000001803774A0-0x00000001803774B0
	public void SetupForDesigner(BaseDef inDef); // 0x0000000180488480-0x0000000180488770
	protected override void OnOpen(); // 0x0000000180487050-0x0000000180487550
	protected override void OnOpenComplete(); // 0x0000000180486FC0-0x0000000180487050
	protected override void DoDelayedOpenAnimation(); // 0x0000000180486550-0x00000001804865F0
	[AsyncStateMachine] // 0x0000000180262FD0-0x0000000180263020
	protected override void OnClose(bool inAnimate); // 0x0000000180486D40-0x0000000180486E00
	protected override void OnHide(); // 0x0000000180486EC0-0x0000000180486F20
	protected override void OnShow(); // 0x0000000180487D30-0x0000000180487D90
	public override void OnReceiveFocus(); // 0x00000001804877B0-0x0000000180487850
	public override void OnLoseFocus(); // 0x0000000180486F20-0x0000000180486FC0
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	public override void MUpdate(); // 0x0000000180486750-0x00000001804867A0
	public void BtnToggle_EditName(bool inIsHighlighted); // 0x00000001804864C0-0x0000000180486500
	public void BtnClicked_SaveLook(); // 0x0000000180486400-0x00000001804864C0
	[AsyncStateMachine] // 0x0000000180263270-0x00000001802632C0
	public void SaveChanges(); // 0x00000001804883D0-0x0000000180488480
	public void RefreshLastSavedLook(); // 0x0000000180488320-0x00000001804883D0
	public void RefreshDecalCount(); // 0x0000000180487F90-0x0000000180488320
	public bool HasChanges(); // 0x00000001804865F0-0x0000000180486750
	private void OnAvatarStageLoaded(UIAvatarStageLoadedMessage inMessage); // 0x0000000180486C60-0x0000000180486D40
	private void OnAvatarStageInitialized(UIAvatarStageInitializedMessage inMessage); // 0x00000001804867A0-0x0000000180486C60
	[AsyncStateMachine] // 0x00000001802633D0-0x0000000180263420
	private void OnCurrentLookChanged(CreatureCustomizationTarget inInfo); // 0x0000000180486E00-0x0000000180486EC0
	private void OnSectionSelected(int inTabIndex); // 0x0000000180487850-0x0000000180487D30
	private void OnPageNavigation(UI_CustomizationPageInfo inPageInfo); // 0x0000000180487550-0x00000001804877B0
	public void OnNameValueChanged(string inName); // 0x00000001803774A0-0x00000001803774B0
	private void TryCloseWindow(); // 0x0000000180488770-0x00000001804887B0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <DoDelayedOpenAnimation>b__56_0(); // 0x00000001804887B0-0x0000000180488810
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <DoDelayedOpenAnimation>b__56_1(); // 0x00000001803B6890-0x00000001803B68B0
	[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
	[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
	private void <>n__0(bool inAnimate); // 0x00000001803B4560-0x00000001803B4570
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnCurrentLookChanged>b__72_0(ActorInfoDecalEntry decal); // 0x0000000180488810-0x0000000180488820
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnCurrentLookChanged>b__72_1(ActorInfoDecalEntry decal); // 0x0000000180488810-0x0000000180488820
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnCurrentLookChanged>b__72_2(ActorInfoBodyPart bodyPart); // 0x0000000180488810-0x0000000180488820
}

