/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UniRx.Async.CompilerServices;
using UnityEngine;

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async
{
	public static class CancellationTokenSourceExtensions // TypeDefIndex: 8547
	{
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <CancelAfterCore>d__2 : IAsyncStateMachine // TypeDefIndex: 8548
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x08
			public UniTask delayTask; // 0x10
			public CancellationTokenSource cts; // 0x18
			private UniTask<bool> <>u__1; // 0x20
	
			// Methods
			private void MoveNext(); // 0x00000001800A1BE0-0x00000001800A1C30
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180003FD0-0x00000001800045A0
		}
	
		// Methods
		[AsyncStateMachine] // 0x000000018023A050-0x000000018023A0A0
		private static UniTaskVoid CancelAfterCore(CancellationTokenSource cts, UniTask delayTask); // 0x0000000180E160D0-0x0000000180E16150
	
		// Extension methods
		public static void CancelAfterSlim(this CancellationTokenSource cts, int millisecondsDelay, bool ignoreTimeScale = false /* Metadata: 0x00778011 */, PlayerLoopTiming delayTiming = PlayerLoopTiming.Update /* Metadata: 0x00778012 */); // 0x0000000180E16220-0x0000000180E162F0
		public static void CancelAfterSlim(this CancellationTokenSource cts, TimeSpan delayTimeSpan, bool ignoreTimeScale = false /* Metadata: 0x00778016 */, PlayerLoopTiming delayTiming = PlayerLoopTiming.Update /* Metadata: 0x00778017 */); // 0x0000000180E16150-0x0000000180E16220
		public static void RegisterRaiseCancelOnDestroy(this CancellationTokenSource cts, Component component); // 0x0000000180E162F0-0x0000000180E16370
		public static void RegisterRaiseCancelOnDestroy(this CancellationTokenSource cts, GameObject gameObject); // 0x0000000180E16370-0x0000000180E163D0
	}
}
