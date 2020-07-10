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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_SendTradeRequest : UI_Window // TypeDefIndex: 12254
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _nameText; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyItemList_ReadonlyItemList _itemList; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _groupNoItems; // 0x118
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _noItemsText; // 0x120
	private UserInfo _targetUser; // 0x128

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 12255
	{
		// Fields
		public string inTargetUUID; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_SendTradeRequest window); // 0x0000000180E9D830-0x0000000180E9D860
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12256
	{
		// Fields
		public string inTargetUUID; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180E9E5A0-0x0000000180E9E670
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <Setup>d__8 : IAsyncStateMachine // TypeDefIndex: 12257
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public string inTargetUUID; // 0x28
		public UI_Window_SendTradeRequest <>4__this; // 0x30
		private UniTask<UserInfo> <>u__1; // 0x38
		private TaskAwaiter<TradeListResponse> <>u__2; // 0x48

		// Methods
		private void MoveNext(); // 0x00000001801F07F0-0x00000001801F08F0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public UI_Window_SendTradeRequest(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	[DebugButton] // 0x000000018011E0D0-0x000000018011E130
	public static void OpenWindow(string inTargetUUID); // 0x0000000180EACDC0-0x0000000180EACE80
	public static void QueueWindow(string inTargetUUID); // 0x0000000180EACE80-0x0000000180EACF40
	public static void CloseWindow(); // 0x0000000180EACBC0-0x0000000180EACC10
	[AsyncStateMachine] // 0x000000018011E340-0x000000018011E390
	public void Setup(string inTargetUUID); // 0x0000000180EACF40-0x0000000180EAD000
	protected override void OnOpen(); // 0x0000000180EACCF0-0x0000000180EACDC0
	protected override void OnClose(bool inAnimate); // 0x0000000180EACC10-0x0000000180EACCF0
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
	public void BtnClicked_InviteToTrade(); // 0x0000000180EACA70-0x0000000180EACBC0
	private void OnTradeStarted(TradeStartedMessage inMessage); // 0x0000000180EA0020-0x0000000180EA0030
}

