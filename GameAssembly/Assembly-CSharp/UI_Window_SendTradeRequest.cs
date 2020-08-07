/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UniRx.Async;
using UnityEngine;
using WW.Debug;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_SendTradeRequest : UI_Window // TypeDefIndex: 13804
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _nameText; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyItemList_ReadonlyItemList _itemList; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _groupNoItems; // 0x118
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _noItemsText; // 0x120
	private UserInfo _targetUser; // 0x128

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 13805
	{
		// Fields
		public string inTargetUUID; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_SendTradeRequest window); // 0x00000001803B2C50-0x00000001803B2C80
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 13806
	{
		// Fields
		public string inTargetUUID; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x00000001803B36E0-0x00000001803B37B0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <Setup>d__8 : IAsyncStateMachine // TypeDefIndex: 13807
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public string inTargetUUID; // 0x28
		public UI_Window_SendTradeRequest <>4__this; // 0x30
		private UniTask<UserInfo> <>u__1; // 0x38
		private TaskAwaiter<TradeListResponse> <>u__2; // 0x48

		// Methods
		private void MoveNext(); // 0x00000001800023F0-0x00000001800024F0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UI_Window_SendTradeRequest(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	[DebugButton] // 0x0000000180206BA0-0x0000000180206C00
	public static void OpenWindow(string inTargetUUID); // 0x00000001803C3180-0x00000001803C3240
	public static void QueueWindow(string inTargetUUID); // 0x00000001803C3240-0x00000001803C3300
	public static void CloseWindow(); // 0x00000001803C2F80-0x00000001803C2FD0
	[AsyncStateMachine] // 0x0000000180206E90-0x0000000180206EE0
	public void Setup(string inTargetUUID); // 0x00000001803C3300-0x00000001803C33C0
	protected override void OnOpen(); // 0x00000001803C30B0-0x00000001803C3180
	protected override void OnClose(bool inAnimate); // 0x00000001803C2FD0-0x00000001803C30B0
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	public void BtnClicked_InviteToTrade(); // 0x00000001803C2E30-0x00000001803C2F80
	private void OnTradeStarted(TradeStartedMessage inMessage); // 0x00000001803B58D0-0x00000001803B58E0
}

