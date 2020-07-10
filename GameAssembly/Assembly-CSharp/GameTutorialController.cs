/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public static class GameTutorialController // TypeDefIndex: 11913
{
	// Fields
	private static readonly bool _forceTutorial; // 0x00

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <OnFirstRoom>d__3 : IAsyncStateMachine // TypeDefIndex: 11914
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		private UniTask<int> <>u__1; // 0x28
		private UniTask.Awaiter <>u__2; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F8FA0-0x00000001801F8FB0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <OnSanctuaryEnterMessage>d__5 : IAsyncStateMachine // TypeDefIndex: 11915
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public SanctuaryEnterMessage inMessage; // 0x28
		private string <sKey>5__2; // 0x30
		private UniTask.Awaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F8FC0-0x00000001801F8FD0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <OnEnigmaAcquired>d__16 : IAsyncStateMachine // TypeDefIndex: 11916
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		private UniTask.Awaiter <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001801F8F90-0x00000001801F8FA0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	static GameTutorialController(); // 0x00000001803581E0-0x00000001803581F0

	// Methods
	[RuntimeInitializeOnLoadMethod] // 0x00000001800C1340-0x00000001800C1350
	public static void Init(); // 0x00000001810539D0-0x0000000181053F00
	private static void OnLoginWindowOpened(WindowOpenCompleteMessage inMessage); // 0x0000000181054510-0x00000001810545D0
	[AsyncStateMachine] // 0x0000000180159240-0x0000000180159290
	private static void OnFirstRoom(WindowOpenCompleteMessage inMessage); // 0x0000000181054050-0x00000001810540F0
	private static void OnCreatureCustomizationWindowOpened(WindowOpenCompleteMessage inMessage); // 0x0000000181053F00-0x0000000181053FC0
	[AsyncStateMachine] // 0x0000000180159520-0x0000000180159570
	private static void OnSanctuaryEnterMessage(SanctuaryEnterMessage inMessage); // 0x00000001810546E0-0x0000000181054790
	private static void OnSanctuaryDecorateWindowOpened(WindowOpenCompleteMessage inMessage); // 0x0000000181054620-0x00000001810546E0
	private static void OnSanctuaryExpansionsWindowOpened(WindowOpenCompleteMessage inMessage); // 0x0000000181054790-0x0000000181054850
	private static void OnSanctuaryRoomToggled(SanctuaryRoomToggleBtnPrssed inMessage); // 0x0000000181054850-0x0000000181054910
	private static void OnInventoryWindowOpened(WindowOpenCompleteMessage inMessage); // 0x0000000181054450-0x0000000181054510
	private static void OnSocialWindowOpened(WindowOpenCompleteMessage inMessage); // 0x00000001810549D0-0x0000000181054A20
	private static void OnPlayerCardWindowOpened(WindowOpenCompleteMessage inMessage); // 0x00000001810545D0-0x0000000181054620
	private static void OnSocialWindowOrPlayerCardOpened(); // 0x0000000181054A20-0x0000000181054AE0
	private static void OnInventoryItemAdded(InventoryItemAddedEvent inMessage); // 0x0000000181054270-0x0000000181054450
	private static void OnInspirationAcquired(); // 0x00000001810540F0-0x00000001810541B0
	private static void OnInspirationsWindowOpened(WindowOpenCompleteMessage obj); // 0x00000001810541B0-0x0000000181054270
	[AsyncStateMachine] // 0x00000001801598B0-0x0000000180159900
	private static void OnEnigmaAcquired(); // 0x0000000181053FC0-0x0000000181054050
	private static void OnShopOpened(ShopOpenedMessage inMessage); // 0x0000000181054910-0x00000001810549D0
	private static bool GetBool(string inKey); // 0x00000001810538B0-0x00000001810539D0
	private static void SetBool(string inKey); // 0x0000000181054AE0-0x0000000181054BA0
}

