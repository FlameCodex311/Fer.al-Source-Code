/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using TMPro;
using UniRx.Async;
using UniRx.Async.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_IAPDetails : UI_Window // TypeDefIndex: 12488
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _nameText; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _descriptionText; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _priceText; // 0x118
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _iapImage; // 0x120
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _infoBtn; // 0x128
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _descriptionParent; // 0x130
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_IAPDetailItem _detailItemPrefab; // 0x138
	private IAPItem _iapItem; // 0x140
	private List<UI_IAPDetailItem> _detailItems; // 0x148
	private CancellationTokenSource _cancellationTokenSource; // 0x150
	private bool _setupCompleted; // 0x158

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 12489
	{
		// Fields
		public IAPItem inIAPItem; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_IAPDetails window); // 0x0000000180ECE270-0x0000000180ECE2A0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12490
	{
		// Fields
		public IAPItem inIAPItem; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180ECE730-0x0000000180ECE800
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <Setup>d__14 : IAsyncStateMachine // TypeDefIndex: 12491
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_IAPDetails <>4__this; // 0x28
		public IAPItem inIAPItem; // 0x30
		private TaskAwaiter<Sprite> <>u__1; // 0x38
		private UniTask.Awaiter <>u__2; // 0x40

		// Methods
		private void MoveNext(); // 0x00000001801F1040-0x00000001801F1050
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <DoDelayedOpenAnimation>d__15 : IAsyncStateMachine // TypeDefIndex: 12492
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_IAPDetails <>4__this; // 0x28
		private UniTask.Awaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F0FC0-0x00000001801F0FD0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <SpawnDetailItems>d__16 : IAsyncStateMachine // TypeDefIndex: 12493
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
		public UI_Window_IAPDetails <>4__this; // 0x18
		public CancellationToken inCancellationToken; // 0x20
		private UniTask.Awaiter <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001801F1070-0x00000001801F1080
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0500-0x00000001801F0510
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12494
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Comparison<Item> <>9__21_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180ECF7B0-0x0000000180ECF810
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal int <BtnClicked_BundleContents>b__21_0(Item a, Item b); // 0x0000000180ECD2E0-0x0000000180ECD430
	}

	// Constructors
	public UI_Window_IAPDetails(); // 0x0000000180ED5650-0x0000000180ED56C0

	// Methods
	public static void OpenWindow(IAPItem inIAPItem); // 0x0000000180ED5360-0x0000000180ED5420
	public static void QueueWindow(IAPItem inIAPItem); // 0x0000000180ED5420-0x0000000180ED54E0
	public static void CloseWindow(); // 0x0000000180ED4E60-0x0000000180ED4EB0
	[AsyncStateMachine] // 0x00000001800C55B0-0x00000001800C5600
	public void Setup(IAPItem inIAPItem); // 0x0000000180ED54E0-0x0000000180ED55A0
	[AsyncStateMachine] // 0x00000001800C5850-0x00000001800C58A0
	protected override void DoDelayedOpenAnimation(); // 0x0000000180ED4EB0-0x0000000180ED4F60
	[AsyncStateMachine] // 0x00000001800C5B50-0x00000001800C5BA0
	private UniTask SpawnDetailItems(CancellationToken inCancellationToken); // 0x0000000180ED55A0-0x0000000180ED5640
	protected override void OnOpen(); // 0x0000000180ED5180-0x0000000180ED5360
	protected override void OnClose(bool inAnimate); // 0x0000000180ED4F60-0x0000000180ED5160
	private void OnMultiItemPopupOpened(WindowOpenedMessage inMessage); // 0x0000000180ED5170-0x0000000180ED5180
	private void OnMultiItemPopupClosed(WindowClosedMessage inMessage); // 0x0000000180ED5160-0x0000000180ED5170
	public void BtnClicked_BundleContents(); // 0x0000000180ED4920-0x0000000180ED4D10
	public void BtnClicked_Purchase(); // 0x0000000180ED4D10-0x0000000180ED4E60
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <DoDelayedOpenAnimation>b__15_0(); // 0x0000000180ED5640-0x0000000180ED5650
}

