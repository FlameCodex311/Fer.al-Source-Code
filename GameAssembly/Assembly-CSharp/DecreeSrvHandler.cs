/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;
using UniRx.Async.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public static class DecreeSrvHandler // TypeDefIndex: 12503
{
	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestDecrees>d__0 : IAsyncStateMachine // TypeDefIndex: 12504
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder<ListDecreesResponse> <>t__builder; // 0x08
		private UniTask.Awaiter <>u__1; // 0x20

		// Methods
		private void MoveNext(); // 0x0000000180006920-0x0000000180006930
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180006930-0x0000000180006980
	}

	// Methods
	[AsyncStateMachine] // 0x00000001801DA010-0x00000001801DA060
	public static UniTask<ListDecreesResponse> RequestDecrees(); // 0x000000018055F4C0-0x000000018055F580
}

