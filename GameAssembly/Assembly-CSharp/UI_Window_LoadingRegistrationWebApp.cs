/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_LoadingRegistrationWebApp : UI_Window // TypeDefIndex: 14113
{
	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 14114
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_LoadingRegistrationWebApp> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10

		// Constructors
		static <>c(); // 0x00000001803E2910-0x00000001803E2970
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_LoadingRegistrationWebApp window); // 0x00000001803E0F50-0x00000001803E0F70
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x00000001803E11A0-0x00000001803E1250
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <Setup>d__3 : IAsyncStateMachine // TypeDefIndex: 14115
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_LoadingRegistrationWebApp <>4__this; // 0x28
		private UniTask.Awaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001800026C0-0x00000001800026D0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UI_Window_LoadingRegistrationWebApp(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	public static void OpenWindow(); // 0x00000001803EBEF0-0x00000001803EBFF0
	public static void QueueWindow(); // 0x00000001803EBFF0-0x00000001803EC0F0
	public static void CloseWindow(); // 0x00000001803EBEA0-0x00000001803EBEF0
	[AsyncStateMachine] // 0x0000000180287150-0x00000001802871A0
	private void Setup(); // 0x00000001803EC0F0-0x00000001803EC1A0
	protected override void OnOpen(); // 0x00000001803B4570-0x00000001803B4580
	protected override void OnClose(bool inAnimate); // 0x00000001803B4560-0x00000001803B4570
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
}

