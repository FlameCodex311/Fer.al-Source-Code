/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_AstralShop : UI_Window // TypeDefIndex: 13986
{
	// Fields
	[RootSelector] // 0x0000000180255C20-0x0000000180255CA0
	[SerializeField] // 0x0000000180255C20-0x0000000180255CA0
	private string _shopDefId; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyItemList_AstralShop _itemList; // 0x110
	private CancellationTokenSource _cancellationTokenSource; // 0x118
	private bool _setupCompleted; // 0x120

	// Properties
	public string ShopDefId { get; } // 0x0000000180380B50-0x0000000180380B60 

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 13987
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_AstralShop> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10

		// Constructors
		static <>c(); // 0x0000000180635640-0x00000001806356A0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_AstralShop window); // 0x0000000180634AD0-0x0000000180634AF0
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x0000000180634B70-0x0000000180634C20
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <SetupAsync>d__10 : IAsyncStateMachine // TypeDefIndex: 13988
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_AstralShop <>4__this; // 0x28
		public CancellationToken inToken; // 0x30
		private TaskAwaiter<ShopListResponse> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x0000000180009FC0-0x0000000180009FD0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <OnItemBuy>d__15 : IAsyncStateMachine // TypeDefIndex: 13989
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public BuyItemResponse inMessage; // 0x28
		public UI_Window_AstralShop <>4__this; // 0x30
		private TaskAwaiter<ShopListResponse> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x0000000180009FB0-0x0000000180009FC0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UI_Window_AstralShop(); // 0x0000000180641DD0-0x0000000180641E20

	// Methods
	public static void OpenWindow(); // 0x00000001806419D0-0x0000000180641AD0
	public static void QueueWindow(); // 0x0000000180641AD0-0x0000000180641BD0
	public static void CloseWindow(); // 0x0000000180641550-0x00000001806415A0
	private void Setup(); // 0x0000000180641C90-0x0000000180641DC0
	[AsyncStateMachine] // 0x0000000180255F50-0x0000000180255FA0
	private void SetupAsync(CancellationToken inToken); // 0x0000000180641BD0-0x0000000180641C90
	protected override void OnOpen(); // 0x0000000180641880-0x00000001806419D0
	protected override void DoDelayedOpenAnimation(); // 0x00000001806415A0-0x0000000180641640
	protected override void OnClose(bool inAnimate); // 0x0000000180641640-0x00000001806417C0
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	[AsyncStateMachine] // 0x00000001802560A0-0x00000001802560F0
	private void OnItemBuy(BuyItemResponse inMessage); // 0x00000001806417C0-0x0000000180641880
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <DoDelayedOpenAnimation>b__12_0(); // 0x0000000180641DC0-0x0000000180641DD0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <DoDelayedOpenAnimation>b__12_1(); // 0x00000001803B6890-0x00000001803B68B0
}

