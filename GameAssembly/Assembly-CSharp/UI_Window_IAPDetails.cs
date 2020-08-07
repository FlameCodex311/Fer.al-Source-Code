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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_IAPDetails : UI_Window // TypeDefIndex: 14087
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _nameText; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _descriptionText; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _priceText; // 0x118
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _iapImage; // 0x120
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _infoBtn; // 0x128
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _descriptionParent; // 0x130
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_IAPDetailItem _detailItemPrefab; // 0x138
	private IAPItem _iapItem; // 0x140
	private List<UI_IAPDetailItem> _detailItems; // 0x148
	private CancellationTokenSource _cancellationTokenSource; // 0x150
	private bool _setupCompleted; // 0x158

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 14088
	{
		// Fields
		public IAPItem inIAPItem; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_IAPDetails window); // 0x00000001803E1830-0x00000001803E1860
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 14089
	{
		// Fields
		public IAPItem inIAPItem; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x00000001803E1BD0-0x00000001803E1CA0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <Setup>d__14 : IAsyncStateMachine // TypeDefIndex: 14090
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_IAPDetails <>4__this; // 0x28
		public IAPItem inIAPItem; // 0x30
		private TaskAwaiter<Sprite> <>u__1; // 0x38
		private UniTask.Awaiter <>u__2; // 0x40

		// Methods
		private void MoveNext(); // 0x00000001800026B0-0x00000001800026C0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <DoDelayedOpenAnimation>d__15 : IAsyncStateMachine // TypeDefIndex: 14091
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_IAPDetails <>4__this; // 0x28
		private UniTask.Awaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180002660-0x0000000180002670
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <SpawnDetailItems>d__16 : IAsyncStateMachine // TypeDefIndex: 14092
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
		public UI_Window_IAPDetails <>4__this; // 0x18
		public CancellationToken inCancellationToken; // 0x20
		private UniTask.Awaiter <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001800026F0-0x0000000180002700
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002020-0x0000000180002030
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 14093
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Comparison<Item> <>9__21_0; // 0x08

		// Constructors
		static <>c(); // 0x00000001803E2AF0-0x00000001803E2B50
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal int <BtnClicked_BundleContents>b__21_0(Item a, Item b); // 0x00000001803E0820-0x00000001803E0970
	}

	// Constructors
	public UI_Window_IAPDetails(); // 0x00000001803E8890-0x00000001803E8900

	// Methods
	public static void OpenWindow(IAPItem inIAPItem); // 0x00000001803E85A0-0x00000001803E8660
	public static void QueueWindow(IAPItem inIAPItem); // 0x00000001803E8660-0x00000001803E8720
	public static void CloseWindow(); // 0x00000001803E80A0-0x00000001803E80F0
	[AsyncStateMachine] // 0x000000018027E0C0-0x000000018027E110
	public void Setup(IAPItem inIAPItem); // 0x00000001803E8720-0x00000001803E87E0
	[AsyncStateMachine] // 0x000000018027F5A0-0x000000018027F5F0
	protected override void DoDelayedOpenAnimation(); // 0x00000001803E80F0-0x00000001803E81A0
	[AsyncStateMachine] // 0x000000018027F7E0-0x000000018027F830
	private UniTask SpawnDetailItems(CancellationToken inCancellationToken); // 0x00000001803E87E0-0x00000001803E8880
	protected override void OnOpen(); // 0x00000001803E83C0-0x00000001803E85A0
	protected override void OnClose(bool inAnimate); // 0x00000001803E81A0-0x00000001803E83A0
	private void OnMultiItemPopupOpened(WindowOpenedMessage inMessage); // 0x00000001803E83B0-0x00000001803E83C0
	private void OnMultiItemPopupClosed(WindowClosedMessage inMessage); // 0x00000001803E83A0-0x00000001803E83B0
	public void BtnClicked_BundleContents(); // 0x00000001803E7B80-0x00000001803E7F50
	public void BtnClicked_Purchase(); // 0x00000001803E7F50-0x00000001803E80A0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <DoDelayedOpenAnimation>b__15_0(); // 0x00000001803E8880-0x00000001803E8890
}

