/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_SaveSanctuaryLook : UI_Window // TypeDefIndex: 14180
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyItemList_SanctuaryLookSaving _itemList; // 0x108
	private SanctuaryLookItemComponent _lookToSave; // 0x110

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 14181
	{
		// Fields
		public SanctuaryLookItemComponent inLookToSave; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_SaveSanctuaryLook window); // 0x00000001803B2D50-0x00000001803B2E30
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 14182
	{
		// Fields
		public SanctuaryLookItemComponent inLookToSave; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x00000001803B3490-0x00000001803B3610
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <SaveLook>d__9 : IAsyncStateMachine // TypeDefIndex: 14183
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public SanctuaryLookItemComponent inTargetSlot; // 0x28
		public UI_Window_SaveSanctuaryLook <>4__this; // 0x30
		public string inName; // 0x38
		private UniTask.Awaiter <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x00000001800023C0-0x00000001800023D0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UI_Window_SaveSanctuaryLook(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	public static void OpenWindow(SanctuaryLookItemComponent inLookToSave); // 0x00000001803BC100-0x00000001803BC1C0
	public static void QueueWindow(SanctuaryLookItemComponent inLookToSave); // 0x00000001803BC1C0-0x00000001803BC280
	public static void CloseWindow(); // 0x00000001803BC0B0-0x00000001803BC100
	private void Setup(SanctuaryLookItemComponent inLookToSave); // 0x00000001803BC350-0x00000001803BC420
	protected override void OnOpen(); // 0x00000001803B4570-0x00000001803B4580
	protected override void OnClose(bool inAnimate); // 0x00000001803B4560-0x00000001803B4570
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	[AsyncStateMachine] // 0x00000001801D8030-0x00000001801D8080
	public void SaveLook(SanctuaryLookItemComponent inTargetSlot, string inName); // 0x00000001803BC280-0x00000001803BC350
}

