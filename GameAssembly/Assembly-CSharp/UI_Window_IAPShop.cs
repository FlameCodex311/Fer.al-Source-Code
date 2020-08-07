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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_IAPShop : UI_Window // TypeDefIndex: 14098
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_IAPShopItem _shopItemPrefab; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _shopItemParent; // 0x110
	private List<UI_IAPShopItem> _shopItems; // 0x118
	private CancellationTokenSource _cancellationTokenSource; // 0x120
	private bool _setupCompleted; // 0x128

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 14099
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_IAPShop> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10

		// Constructors
		static <>c(); // 0x00000001803E2850-0x00000001803E28B0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_IAPShop window); // 0x00000001803E0F30-0x00000001803E0F50
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x00000001803E1070-0x00000001803E1120
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <Setup>d__8 : IAsyncStateMachine // TypeDefIndex: 14100
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_IAPShop <>4__this; // 0x28
		private UniTask.Awaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001800026E0-0x00000001800026F0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <DoDelayedOpenAnimation>d__9 : IAsyncStateMachine // TypeDefIndex: 14101
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_IAPShop <>4__this; // 0x28
		private UniTask.Awaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180002670-0x0000000180002680
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <SpawnShopItems>d__12 : IAsyncStateMachine // TypeDefIndex: 14102
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
		public UI_Window_IAPShop <>4__this; // 0x18
		private UniTask<ListIAPsResponse> <>u__1; // 0x20
		private UniTask.Awaiter <>u__2; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180002710-0x00000001800029D0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002020-0x0000000180002030
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <SpawnShopItem>d__13 : IAsyncStateMachine // TypeDefIndex: 14103
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
		public UI_Window_IAPShop <>4__this; // 0x18
		public IAPItem inIAPItem; // 0x20
		public CancellationToken inCancellationToken; // 0x28
		private UniTask.Awaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180002700-0x0000000180002710
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002020-0x0000000180002030
	}

	// Constructors
	public UI_Window_IAPShop(); // 0x00000001803E93E0-0x00000001803E9450

	// Methods
	public static void OpenWindow(); // 0x00000001803E56F0-0x00000001803E57F0
	public static void QueueWindow(); // 0x00000001803E90C0-0x00000001803E91C0
	public static void CloseWindow(); // 0x00000001803E8B90-0x00000001803E8BE0
	[AsyncStateMachine] // 0x0000000180281270-0x00000001802812C0
	private void Setup(); // 0x00000001803E91C0-0x00000001803E9270
	[AsyncStateMachine] // 0x00000001802815A0-0x00000001802815F0
	protected override void DoDelayedOpenAnimation(); // 0x00000001803E8BE0-0x00000001803E8C90
	protected override void OnOpen(); // 0x00000001803E8EB0-0x00000001803E90C0
	protected override void OnClose(bool inAnimate); // 0x00000001803E8C90-0x00000001803E8EB0
	[AsyncStateMachine] // 0x0000000180281800-0x0000000180281850
	private UniTask SpawnShopItems(); // 0x00000001803E9330-0x00000001803E93D0
	[AsyncStateMachine] // 0x0000000180281940-0x0000000180281990
	private UniTask SpawnShopItem(IAPItem inIAPItem, CancellationToken inCancellationToken); // 0x00000001803E9270-0x00000001803E9330
	private void OnDetailWindowOpened(WindowOpenedMessage inMessage); // 0x00000001803E83B0-0x00000001803E83C0
	private void OnDetailWindowClosed(WindowClosedMessage inMessage); // 0x00000001803E83A0-0x00000001803E83B0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <DoDelayedOpenAnimation>b__9_0(); // 0x00000001803E93D0-0x00000001803E93E0
}

