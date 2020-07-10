/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;
using UniRx.Async.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public static class DecreeSrvHandler // TypeDefIndex: 10980
{
	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestDecrees>d__0 : IAsyncStateMachine // TypeDefIndex: 10981
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder<ListDecreesResponse> <>t__builder; // 0x08
		private UniTask.Awaiter <>u__1; // 0x20

		// Methods
		private void MoveNext(); // 0x000000018020D900-0x000000018020D910
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018020D910-0x000000018020D960
	}

	// Methods
	[AsyncStateMachine] // 0x0000000180100470-0x00000001801004C0
	public static UniTask<ListDecreesResponse> RequestDecrees(); // 0x0000000181183C00-0x0000000181183CC0
}

