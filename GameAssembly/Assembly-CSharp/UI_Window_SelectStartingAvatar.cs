/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_SelectStartingAvatar : UI_Window // TypeDefIndex: 12600
{
	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12601
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_SelectStartingAvatar> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10
		public static Action<bool> <>9__7_0; // 0x18

		// Constructors
		static <>c(); // 0x0000000180E9F090-0x0000000180E9F0F0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_SelectStartingAvatar window); // 0x0000000180E9D080-0x0000000180E9D0A0
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x0000000180E9D510-0x0000000180E9D590
		internal void <BtnClicked_Quit>b__7_0(bool inResult); // 0x0000000180E9CEE0-0x0000000180E9CEF0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass10_0 // TypeDefIndex: 12602
	{
		// Fields
		public string actorClassDefId; // 0x10

		// Constructors
		public <>c__DisplayClass10_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <DoAvatarSelection>b__0(AvatarLookItemComponent look); // 0x0000000180E9DB90-0x0000000180E9DBF0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <DoAvatarSelection>d__10 : IAsyncStateMachine // TypeDefIndex: 12603
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		private <>c__DisplayClass10_0 <>8__1; // 0x28
		public int inAvatarIndex; // 0x30
		public UI_Window_SelectStartingAvatar <>4__this; // 0x38
		private UniTask.Awaiter <>u__1; // 0x40
		private TaskAwaiter<WindowOpenCompleteMessage> <>u__2; // 0x48

		// Methods
		private void MoveNext(); // 0x00000001801F0780-0x00000001801F0790
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public UI_Window_SelectStartingAvatar(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	public static void OpenWindow(); // 0x0000000180EAAE90-0x0000000180EAAF90
	public static void QueueWindow(); // 0x0000000180EAAF90-0x0000000180EAB090
	public static void CloseWindow(); // 0x0000000180EAAD20-0x0000000180EAAD70
	private void Setup(); // 0x00000001803581E0-0x00000001803581F0
	protected override void OnOpen(); // 0x0000000180EAAE30-0x0000000180EAAE90
	protected override void OnClose(bool inAnimate); // 0x0000000180E9F690-0x0000000180E9F6A0
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
	public void BtnClicked_Quit(); // 0x0000000180EAABD0-0x0000000180EAAD10
	public void BtnClicked_Kitsune(); // 0x0000000180EAABC0-0x0000000180EAABD0
	public void BtnClicked_Senri(); // 0x0000000180EAAD10-0x0000000180EAAD20
	[AsyncStateMachine] // 0x00000001800EFAF0-0x00000001800EFB40
	private void DoAvatarSelection(int inAvatarIndex); // 0x0000000180EAAD70-0x0000000180EAAE30
}

