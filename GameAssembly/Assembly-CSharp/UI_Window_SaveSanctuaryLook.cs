/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_SaveSanctuaryLook : UI_Window // TypeDefIndex: 12578
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyItemList_SanctuaryLookSaving _itemList; // 0x108
	private SanctuaryLookItemComponent _lookToSave; // 0x110

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 12579
	{
		// Fields
		public SanctuaryLookItemComponent inLookToSave; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_SaveSanctuaryLook window); // 0x0000000180E9D950-0x0000000180E9DA40
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12580
	{
		// Fields
		public SanctuaryLookItemComponent inLookToSave; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180E9E340-0x0000000180E9E4D0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <SaveLook>d__9 : IAsyncStateMachine // TypeDefIndex: 12581
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public SanctuaryLookItemComponent inTargetSlot; // 0x28
		public UI_Window_SaveSanctuaryLook <>4__this; // 0x30
		public string inName; // 0x38
		private UniTask.Awaiter <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x00000001801F07D0-0x00000001801F07E0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public UI_Window_SaveSanctuaryLook(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	public static void OpenWindow(SanctuaryLookItemComponent inLookToSave); // 0x0000000180EA69F0-0x0000000180EA6AB0
	public static void QueueWindow(SanctuaryLookItemComponent inLookToSave); // 0x0000000180EA6AB0-0x0000000180EA6B70
	public static void CloseWindow(); // 0x0000000180EA69A0-0x0000000180EA69F0
	private void Setup(SanctuaryLookItemComponent inLookToSave); // 0x0000000180EA6C40-0x0000000180EA6D10
	protected override void OnOpen(); // 0x0000000180E9F6A0-0x0000000180E9F6B0
	protected override void OnClose(bool inAnimate); // 0x0000000180E9F690-0x0000000180E9F6A0
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
	[AsyncStateMachine] // 0x00000001800E9840-0x00000001800E9890
	public void SaveLook(SanctuaryLookItemComponent inTargetSlot, string inName); // 0x0000000180EA6B70-0x0000000180EA6C40
}

