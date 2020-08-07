/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Events;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class GiftManager : SingletonManagerBase<GiftManager> // TypeDefIndex: 12189
{
	// Fields
	private bool _firstRoomJoin; // 0x60

	// Nested types
	private class GiftDisplayQueue // TypeDefIndex: 12190
	{
		// Fields
		private GiftPushMessage _giftMessage; // 0x10
		private int _currentGiftIndex; // 0x18

		// Constructors
		public GiftDisplayQueue(GiftPushMessage giftPushMessage); // 0x0000000180680EF0-0x0000000180680F30

		// Methods
		private void Clear(); // 0x0000000180680BC0-0x0000000180680C60
		private void OnPopupClosed(UI_Window inWindow); // 0x0000000180680C60-0x0000000180680D00
		private void ShowNextGift(); // 0x0000000180680D00-0x0000000180680EF0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <OnRoomJoinSuccess>d__3 : IAsyncStateMachine // TypeDefIndex: 12191
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public GiftManager <>4__this; // 0x28
		private TaskAwaiter<WindowOpenCompleteMessage> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x000000018000B330-0x000000018000B340
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass5_0 // TypeDefIndex: 12192
	{
		// Fields
		public bool isPremium; // 0x10
		public Action inExtraButtonCallback; // 0x18
		public string inExtraButtonText; // 0x20
		public UnityAction<UI_Window> inOnWindowClosed; // 0x28

		// Constructors
		public <>c__DisplayClass5_0(); // 0x0000000180373240-0x0000000180373250
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass5_1 // TypeDefIndex: 12193
	{
		// Fields
		public BundlePackDefComponent packDef; // 0x10
		public <>c__DisplayClass5_0 CS$<>8__locals1; // 0x18

		// Constructors
		public <>c__DisplayClass5_1(); // 0x0000000180373240-0x0000000180373250
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass5_2 // TypeDefIndex: 12194
	{
		// Fields
		[TupleElementNames] // 0x000000018024C770-0x000000018024C7F0
		public List<ValueTuple<BaseDef, int>> items; // 0x10
		public <>c__DisplayClass5_1 CS$<>8__locals2; // 0x18

		// Constructors
		public <>c__DisplayClass5_2(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenItemUI>b__1(UI_Window inWindow); // 0x000000018068E500-0x000000018068E740
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass5_3 // TypeDefIndex: 12195
	{
		// Fields
		public string title; // 0x10
		public string button; // 0x18
		public BaseDef defToDisplay; // 0x20
		public int quantity; // 0x28
		public <>c__DisplayClass5_0 CS$<>8__locals3; // 0x30

		// Constructors
		public <>c__DisplayClass5_3(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenItemUI>b__2(UI_Window inWindow); // 0x000000018068E740-0x000000018068E8C0
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 12196
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		[TupleElementNames] // 0x000000018024CDC0-0x000000018024CE40
		public static Comparison<ValueTuple<BaseDef, int>> <>9__5_0; // 0x08

		// Constructors
		static <>c(); // 0x000000018068EA90-0x000000018068EAF0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal int <OpenItemUI>b__5_0([TupleElementNames] /* 0x000000018024D0A0-0x000000018024D120 */ ValueTuple<BaseDef, int> a, [TupleElementNames] /* 0x000000018024D410-0x000000018024D490 */ ValueTuple<BaseDef, int> b); // 0x000000018068E120-0x000000018068E270
	}

	// Constructors
	public GiftManager(); // 0x0000000180681CE0-0x0000000180681D20

	// Methods
	public override void Init(); // 0x0000000180681340-0x0000000180681420
	public override void Deinit(); // 0x0000000180681260-0x0000000180681340
	[AsyncStateMachine] // 0x000000018024BE10-0x000000018024BE60
	private void OnRoomJoinSuccess(RoomJoinSuccessMessage inMessage); // 0x0000000180681640-0x00000001806816F0
	private void OnGiftPush(GiftPushMessage inMessage); // 0x0000000180681420-0x0000000180681640
	private static void OpenItemUI(GiftItemComponent inGift, UnityAction<UI_Window> inOnWindowClosed = null, Action inExtraButtonCallback = null, string inExtraButtonText = null); // 0x00000001806816F0-0x0000000180681CE0
}

