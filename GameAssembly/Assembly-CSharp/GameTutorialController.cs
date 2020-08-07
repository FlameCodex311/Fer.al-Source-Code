/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public static class GameTutorialController // TypeDefIndex: 13449
{
	// Fields
	private static readonly bool _forceTutorial; // 0x00

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <OnFirstRoom>d__3 : IAsyncStateMachine // TypeDefIndex: 13450
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		private UniTask<int> <>u__1; // 0x28
		private UniTask.Awaiter <>u__2; // 0x38

		// Methods
		private void MoveNext(); // 0x000000018000B320-0x000000018000B330
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <OnSanctuaryEnterMessage>d__5 : IAsyncStateMachine // TypeDefIndex: 13451
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public SanctuaryEnterMessage inMessage; // 0x28
		private string <sKey>5__2; // 0x30
		private UniTask.Awaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x000000018000B340-0x000000018000B350
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <OnEnigmaAcquired>d__16 : IAsyncStateMachine // TypeDefIndex: 13452
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		private UniTask.Awaiter <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x000000018000B310-0x000000018000B320
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	static GameTutorialController(); // 0x00000001803774A0-0x00000001803774B0

	// Methods
	[RuntimeInitializeOnLoadMethod] // 0x00000001801CF2D0-0x00000001801CF2E0
	public static void Init(); // 0x000000018067E8D0-0x000000018067EDF0
	private static void OnLoginWindowOpened(WindowOpenCompleteMessage inMessage); // 0x000000018067F400-0x000000018067F4C0
	[AsyncStateMachine] // 0x000000018023E540-0x000000018023E590
	private static void OnFirstRoom(WindowOpenCompleteMessage inMessage); // 0x000000018067EF40-0x000000018067EFE0
	private static void OnCreatureCustomizationWindowOpened(WindowOpenCompleteMessage inMessage); // 0x000000018067EDF0-0x000000018067EEB0
	[AsyncStateMachine] // 0x000000018023E7B0-0x000000018023E800
	private static void OnSanctuaryEnterMessage(SanctuaryEnterMessage inMessage); // 0x000000018067F5D0-0x000000018067F680
	private static void OnSanctuaryDecorateWindowOpened(WindowOpenCompleteMessage inMessage); // 0x000000018067F510-0x000000018067F5D0
	private static void OnSanctuaryExpansionsWindowOpened(WindowOpenCompleteMessage inMessage); // 0x000000018067F680-0x000000018067F740
	private static void OnSanctuaryRoomToggled(SanctuaryRoomToggleBtnPrssed inMessage); // 0x000000018067F740-0x000000018067F800
	private static void OnInventoryWindowOpened(WindowOpenCompleteMessage inMessage); // 0x000000018067F340-0x000000018067F400
	private static void OnSocialWindowOpened(WindowOpenCompleteMessage inMessage); // 0x000000018067F8C0-0x000000018067F910
	private static void OnPlayerCardWindowOpened(WindowOpenCompleteMessage inMessage); // 0x000000018067F4C0-0x000000018067F510
	private static void OnSocialWindowOrPlayerCardOpened(); // 0x000000018067F910-0x000000018067F9D0
	private static void OnInventoryItemAdded(InventoryItemAddedEvent inMessage); // 0x000000018067F160-0x000000018067F340
	private static void OnInspirationAcquired(); // 0x000000018067EFE0-0x000000018067F0A0
	private static void OnInspirationsWindowOpened(WindowOpenCompleteMessage obj); // 0x000000018067F0A0-0x000000018067F160
	[AsyncStateMachine] // 0x000000018023E960-0x000000018023E9B0
	private static void OnEnigmaAcquired(); // 0x000000018067EEB0-0x000000018067EF40
	private static void OnShopOpened(ShopOpenedMessage inMessage); // 0x000000018067F800-0x000000018067F8C0
	private static bool GetBool(string inKey); // 0x000000018067E7B0-0x000000018067E8D0
	private static void SetBool(string inKey); // 0x000000018067F9D0-0x000000018067FA90
}

