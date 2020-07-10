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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_EditItem : UI_Window // TypeDefIndex: 12452
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_StageSubjectPositioner _stagePositioner; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _itemNameText; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _avatarPreviewToggleBtn; // 0x118
	private bool _isStageOwner; // 0x120
	private UI_Stage_3DItem _itemStage; // 0x128
	private Item _item; // 0x130

	// Properties
	public Item Item { get; } // 0x00000001803BD390-0x00000001803BD3A0 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 12453
	{
		// Fields
		public Item inItemToEdit; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_EditItem window); // 0x0000000180EFEF80-0x0000000180EFEFB0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12454
	{
		// Fields
		public Item inItemToEdit; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180EFF560-0x0000000180EFF630
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <OnStageInitialized>d__15 : IAsyncStateMachine // TypeDefIndex: 12455
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_EditItem <>4__this; // 0x28
		private TaskAwaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F12F0-0x00000001801F1300
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <SetStageFromExisting>d__16 : IAsyncStateMachine // TypeDefIndex: 12456
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_EditItem <>4__this; // 0x28
		public UI_Stage_3DItem inStage; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F1320-0x00000001801F1330
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <ToggleBtnClicked_ShowAvatarPreview>d__17 : IAsyncStateMachine // TypeDefIndex: 12457
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_EditItem <>4__this; // 0x28
		public bool inIsOn; // 0x30
		private UniTask.Awaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F1350-0x00000001801F1360
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public UI_Window_EditItem(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	public static void OpenWindow(Item inItemToEdit); // 0x0000000180F11110-0x0000000180F111D0
	public static void QueueWindow(Item inItemToEdit); // 0x0000000180F111D0-0x0000000180F11290
	public static void CloseWindow(); // 0x0000000180F10CD0-0x0000000180F10D20
	private void Setup(Item inItemToEdit); // 0x0000000180F11350-0x0000000180F11610
	protected override void OnOpen(); // 0x0000000180F10F20-0x0000000180F10FD0
	protected override void OnClose(bool inAnimate); // 0x0000000180F10D20-0x0000000180F10F20
	private void OnStageLoaded(UI3DItemStageLoadedMessage inMessage); // 0x0000000180F11080-0x0000000180F11110
	[AsyncStateMachine] // 0x00000001800B5BD0-0x00000001800B5C20
	private void OnStageInitialized(UI3DItemStageInitializedMessage inMessage); // 0x0000000180F10FD0-0x0000000180F11080
	[AsyncStateMachine] // 0x00000001800B5DB0-0x00000001800B5E00
	private void SetStageFromExisting(UI_Stage_3DItem inStage); // 0x0000000180F11290-0x0000000180F11350
	[AsyncStateMachine] // 0x00000001800B60C0-0x00000001800B6110
	public void ToggleBtnClicked_ShowAvatarPreview(bool inIsOn); // 0x0000000180F11610-0x0000000180F116D0
}

