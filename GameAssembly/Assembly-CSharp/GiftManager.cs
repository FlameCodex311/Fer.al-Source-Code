/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class GiftManager : SingletonManagerBase<GiftManager> // TypeDefIndex: 10687
{
	// Fields
	private bool _firstRoomJoin; // 0x60

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <OnRoomJoinSuccess>d__3 : IAsyncStateMachine // TypeDefIndex: 10688
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public GiftManager <>4__this; // 0x28
		private TaskAwaiter<WindowOpenCompleteMessage> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F8FB0-0x00000001801F8FC0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public GiftManager(); // 0x00000001810565C0-0x0000000181056600

	// Methods
	public override void Init(); // 0x0000000181056110-0x00000001810561F0
	public override void Deinit(); // 0x0000000181056030-0x0000000181056110
	[AsyncStateMachine] // 0x000000018016F470-0x000000018016F4C0
	private void OnRoomJoinSuccess(RoomJoinSuccessMessage inMessage); // 0x0000000181056330-0x00000001810563E0
	private void OnGiftPush(GiftPushMessage inMessage); // 0x00000001810561F0-0x0000000181056330
	private void OpenItemUI(GiftItemComponent inGift); // 0x00000001810563E0-0x00000001810565C0
}

