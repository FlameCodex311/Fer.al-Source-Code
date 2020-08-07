/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public static class UI_LoadingBlockerExtensions // TypeDefIndex: 14263
{
	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <BlockInputFor>d__0 : IAsyncStateMachine // TypeDefIndex: 14264
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public UI_LoadingBlocker loadingBlocker; // 0x20
		public Func<Task> action; // 0x28
		private TaskAwaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001800024F0-0x0000000180002500
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
	}

	// Extension methods
	[AsyncStateMachine] // 0x00000001801FF220-0x00000001801FF290
	public static Task BlockInputFor(this UI_LoadingBlocker loadingBlocker, Func<Task> action); // 0x00000001803C9390-0x00000001803C9470
}

