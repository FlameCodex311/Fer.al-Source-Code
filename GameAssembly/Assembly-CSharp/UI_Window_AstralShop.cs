/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_AstralShop : UI_Window // TypeDefIndex: 12398
{
	// Fields
	[RootSelector] // 0x000000018015EF20-0x000000018015EFA0
	[SerializeField] // 0x000000018015EF20-0x000000018015EFA0
	private string _shopDefId; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyItemList_AstralShop _itemList; // 0x110
	private CancellationTokenSource _cancellationTokenSource; // 0x118
	private bool _setupCompleted; // 0x120

	// Properties
	public string ShopDefId { get; } // 0x00000001803BD3C0-0x00000001803BD3D0 

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12399
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_AstralShop> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10

		// Constructors
		static <>c(); // 0x0000000180EFFF80-0x0000000180EFFFE0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_AstralShop window); // 0x0000000180EFE780-0x0000000180EFE7B0
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x0000000180EFE910-0x0000000180EFE9C0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <SetupAsync>d__10 : IAsyncStateMachine // TypeDefIndex: 12400
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_AstralShop <>4__this; // 0x28
		public CancellationToken inToken; // 0x30
		private TaskAwaiter<ShopListResponse> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F1330-0x00000001801F1340
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <OnItemBuy>d__15 : IAsyncStateMachine // TypeDefIndex: 12401
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public BuyItemResponse inMessage; // 0x28
		public UI_Window_AstralShop <>4__this; // 0x30
		private TaskAwaiter<ShopListResponse> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F12E0-0x00000001801F12F0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public UI_Window_AstralShop(); // 0x0000000180F01860-0x0000000180F018B0

	// Methods
	public static void OpenWindow(); // 0x0000000180F01470-0x0000000180F01570
	public static void QueueWindow(); // 0x0000000180F01570-0x0000000180F01670
	public static void CloseWindow(); // 0x0000000180F00FE0-0x0000000180F01030
	private void Setup(); // 0x0000000180F01730-0x0000000180F01860
	[AsyncStateMachine] // 0x000000018015F360-0x000000018015F3B0
	private void SetupAsync(CancellationToken inToken); // 0x0000000180F01670-0x0000000180F01730
	protected override void OnOpen(); // 0x0000000180F01310-0x0000000180F01470
	protected override void DoDelayedOpenAnimation(); // 0x0000000180F01030-0x0000000180F010D0
	protected override void OnClose(bool inAnimate); // 0x0000000180F010D0-0x0000000180F01250
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
	[AsyncStateMachine] // 0x000000018015F640-0x000000018015F690
	private void OnItemBuy(BuyItemResponse inMessage); // 0x0000000180F01250-0x0000000180F01310
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <DoDelayedOpenAnimation>b__12_0(); // 0x00000001804E9910-0x00000001804E9920
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <DoDelayedOpenAnimation>b__12_1(); // 0x00000001809E8060-0x00000001809E8080
}

