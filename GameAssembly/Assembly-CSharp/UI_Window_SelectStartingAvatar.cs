/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_SelectStartingAvatar : UI_Window // TypeDefIndex: 14202
{
	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 14203
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_SelectStartingAvatar> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10
		public static Action<bool> <>9__7_0; // 0x18

		// Constructors
		static <>c(); // 0x00000001803B3F80-0x00000001803B3FE0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_SelectStartingAvatar window); // 0x00000001803B24A0-0x00000001803B24C0
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x00000001803B2930-0x00000001803B29B0
		internal void <BtnClicked_Quit>b__7_0(bool inResult); // 0x00000001803B2300-0x00000001803B2310
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass10_0 // TypeDefIndex: 14204
	{
		// Fields
		public string actorClassDefId; // 0x10

		// Constructors
		public <>c__DisplayClass10_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <DoAvatarSelection>b__0(AvatarLookItemComponent look); // 0x00000001803B2FB0-0x00000001803B3000
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <DoAvatarSelection>d__10 : IAsyncStateMachine // TypeDefIndex: 14205
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
		private void MoveNext(); // 0x0000000180002380-0x0000000180002390
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UI_Window_SelectStartingAvatar(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	public static void OpenWindow(); // 0x00000001803C1280-0x00000001803C1380
	public static void QueueWindow(); // 0x00000001803C1380-0x00000001803C1480
	public static void CloseWindow(); // 0x00000001803C1110-0x00000001803C1160
	private void Setup(); // 0x00000001803774A0-0x00000001803774B0
	protected override void OnOpen(); // 0x00000001803C1220-0x00000001803C1280
	protected override void OnClose(bool inAnimate); // 0x00000001803B4560-0x00000001803B4570
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	public void BtnClicked_Quit(); // 0x00000001803C0FC0-0x00000001803C1100
	public void BtnClicked_Kitsune(); // 0x00000001803C0FB0-0x00000001803C0FC0
	public void BtnClicked_Senri(); // 0x00000001803C1100-0x00000001803C1110
	[AsyncStateMachine] // 0x00000001801E0BE0-0x00000001801E0C30
	private void DoAvatarSelection(int inAvatarIndex); // 0x00000001803C1160-0x00000001803C1220
}

