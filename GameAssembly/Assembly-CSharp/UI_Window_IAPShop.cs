/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UniRx.Async;
using UniRx.Async.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_IAPShop : UI_Window // TypeDefIndex: 12499
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_IAPShopItem _shopItemPrefab; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _shopItemParent; // 0x110
	private List<UI_IAPShopItem> _shopItems; // 0x118
	private CancellationTokenSource _cancellationTokenSource; // 0x120
	private bool _setupCompleted; // 0x128

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12500
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_IAPShop> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10

		// Constructors
		static <>c(); // 0x0000000180ECF570-0x0000000180ECF5D0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_IAPShop window); // 0x0000000180ECD9F0-0x0000000180ECDA20
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x0000000180ECDB20-0x0000000180ECDBD0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <Setup>d__8 : IAsyncStateMachine // TypeDefIndex: 12501
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_IAPShop <>4__this; // 0x28
		private UniTask.Awaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F1060-0x00000001801F1070
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <DoDelayedOpenAnimation>d__9 : IAsyncStateMachine // TypeDefIndex: 12502
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_IAPShop <>4__this; // 0x28
		private UniTask.Awaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F0FD0-0x00000001801F0FE0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <SpawnShopItems>d__12 : IAsyncStateMachine // TypeDefIndex: 12503
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
		public UI_Window_IAPShop <>4__this; // 0x18
		private UniTask<ListIAPsResponse> <>u__1; // 0x20
		private UniTask.Awaiter <>u__2; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F1090-0x00000001801F10A0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0500-0x00000001801F0510
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <SpawnShopItem>d__13 : IAsyncStateMachine // TypeDefIndex: 12504
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
		public UI_Window_IAPShop <>4__this; // 0x18
		public IAPItem inIAPItem; // 0x20
		public CancellationToken inCancellationToken; // 0x28
		private UniTask.Awaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F1080-0x00000001801F1090
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0500-0x00000001801F0510
	}

	// Constructors
	public UI_Window_IAPShop(); // 0x0000000180ED61A0-0x0000000180ED6210

	// Methods
	public static void OpenWindow(); // 0x0000000180ED2400-0x0000000180ED2500
	public static void QueueWindow(); // 0x0000000180ED5E90-0x0000000180ED5F90
	public static void CloseWindow(); // 0x0000000180ED5950-0x0000000180ED59A0
	[AsyncStateMachine] // 0x00000001800C80C0-0x00000001800C8110
	private void Setup(); // 0x0000000180ED5F90-0x0000000180ED6040
	[AsyncStateMachine] // 0x00000001800C8580-0x00000001800C85D0
	protected override void DoDelayedOpenAnimation(); // 0x0000000180ED59A0-0x0000000180ED5A50
	protected override void OnOpen(); // 0x0000000180ED5C80-0x0000000180ED5E90
	protected override void OnClose(bool inAnimate); // 0x0000000180ED5A50-0x0000000180ED5C80
	[AsyncStateMachine] // 0x00000001800C8960-0x00000001800C89B0
	private UniTask SpawnShopItems(); // 0x0000000180ED6100-0x0000000180ED61A0
	[AsyncStateMachine] // 0x00000001800C8EE0-0x00000001800C8F30
	private UniTask SpawnShopItem(IAPItem inIAPItem, CancellationToken inCancellationToken); // 0x0000000180ED6040-0x0000000180ED6100
	private void OnDetailWindowOpened(WindowOpenedMessage inMessage); // 0x0000000180ED5170-0x0000000180ED5180
	private void OnDetailWindowClosed(WindowClosedMessage inMessage); // 0x0000000180ED5160-0x0000000180ED5170
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <DoDelayedOpenAnimation>b__9_0(); // 0x00000001805B6EE0-0x00000001805B6EF0
}

