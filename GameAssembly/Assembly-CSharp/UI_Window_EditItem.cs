/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UniRx.Async;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_EditItem : UI_Window // TypeDefIndex: 14051
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_StageSubjectPositioner _stagePositioner; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _itemNameText; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _avatarPreviewToggleBtn; // 0x118
	private bool _isStageOwner; // 0x120
	private UI_Stage_3DItem _itemStage; // 0x128
	private Item _item; // 0x130

	// Properties
	public Item Item { get; } // 0x0000000180383C00-0x0000000180383C10 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 14052
	{
		// Fields
		public Item inItemToEdit; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_EditItem window); // 0x000000018047E850-0x000000018047E880
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 14053
	{
		// Fields
		public Item inItemToEdit; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x000000018047EED0-0x000000018047EFA0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <OnStageInitialized>d__15 : IAsyncStateMachine // TypeDefIndex: 14054
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_EditItem <>4__this; // 0x28
		private TaskAwaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180004A60-0x0000000180004A70
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <SetStageFromExisting>d__16 : IAsyncStateMachine // TypeDefIndex: 14055
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_EditItem <>4__this; // 0x28
		public UI_Stage_3DItem inStage; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x0000000180004A90-0x0000000180004AA0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <ToggleBtnClicked_ShowAvatarPreview>d__17 : IAsyncStateMachine // TypeDefIndex: 14056
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_EditItem <>4__this; // 0x28
		public bool inIsOn; // 0x30
		private UniTask.Awaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x0000000180004AB0-0x0000000180004D00
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UI_Window_EditItem(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	public static void OpenWindow(Item inItemToEdit); // 0x000000018048F1E0-0x000000018048F2A0
	public static void QueueWindow(Item inItemToEdit); // 0x000000018048F2A0-0x000000018048F360
	public static void CloseWindow(); // 0x000000018048EDA0-0x000000018048EDF0
	private void Setup(Item inItemToEdit); // 0x000000018048F420-0x000000018048F6E0
	protected override void OnOpen(); // 0x000000018048EFF0-0x000000018048F0A0
	protected override void OnClose(bool inAnimate); // 0x000000018048EDF0-0x000000018048EFF0
	private void OnStageLoaded(UI3DItemStageLoadedMessage inMessage); // 0x000000018048F150-0x000000018048F1E0
	[AsyncStateMachine] // 0x000000018026C1C0-0x000000018026C210
	private void OnStageInitialized(UI3DItemStageInitializedMessage inMessage); // 0x000000018048F0A0-0x000000018048F150
	[AsyncStateMachine] // 0x000000018026C5A0-0x000000018026C5F0
	private void SetStageFromExisting(UI_Stage_3DItem inStage); // 0x000000018048F360-0x000000018048F420
	[AsyncStateMachine] // 0x000000018026C800-0x000000018026C850
	public void ToggleBtnClicked_ShowAvatarPreview(bool inIsOn); // 0x000000018048F6E0-0x000000018048F7A0
}

