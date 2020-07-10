/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public static class UI_LoadingBlockerExtensions // TypeDefIndex: 12694
{
	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <BlockInputFor>d__0 : IAsyncStateMachine // TypeDefIndex: 12695
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public UI_LoadingBlocker loadingBlocker; // 0x20
		public Func<Task> action; // 0x28
		private TaskAwaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F0680-0x00000001801F0690
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
	}

	// Extension methods
	[AsyncStateMachine] // 0x0000000180110F40-0x0000000180110FB0
	public static Task BlockInputFor(this UI_LoadingBlocker loadingBlocker, Func<Task> action); // 0x0000000180E7FA00-0x0000000180E7FAE0
}

