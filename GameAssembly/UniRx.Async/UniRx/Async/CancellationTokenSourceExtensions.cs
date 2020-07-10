/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UniRx.Async.CompilerServices;
using UnityEngine;

// Image 68: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8376-8739

namespace UniRx.Async
{
	public static class CancellationTokenSourceExtensions // TypeDefIndex: 8381
	{
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <CancelAfterCore>d__2 : IAsyncStateMachine // TypeDefIndex: 8382
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x08
			public UniTask delayTask; // 0x10
			public CancellationTokenSource cts; // 0x18
			private UniTask<bool> <>u__1; // 0x20
	
			// Methods
			private void MoveNext(); // 0x00000001802541F0-0x0000000180254200
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180003310-0x0000000180003870
		}
	
		// Methods
		[AsyncStateMachine] // 0x00000001800DB340-0x00000001800DB390
		private static UniTaskVoid CancelAfterCore(CancellationTokenSource cts, UniTask delayTask); // 0x00000001816690D0-0x0000000181669150
	
		// Extension methods
		public static void CancelAfterSlim(this CancellationTokenSource cts, int millisecondsDelay, bool ignoreTimeScale = false /* Metadata: 0x00743323 */, PlayerLoopTiming delayTiming = PlayerLoopTiming.Update /* Metadata: 0x00743324 */); // 0x0000000181669330-0x0000000181669520
		public static void CancelAfterSlim(this CancellationTokenSource cts, TimeSpan delayTimeSpan, bool ignoreTimeScale = false /* Metadata: 0x00743328 */, PlayerLoopTiming delayTiming = PlayerLoopTiming.Update /* Metadata: 0x00743329 */); // 0x0000000181669150-0x0000000181669330
		public static void RegisterRaiseCancelOnDestroy(this CancellationTokenSource cts, Component component); // 0x0000000181669520-0x00000001816695A0
		public static void RegisterRaiseCancelOnDestroy(this CancellationTokenSource cts, GameObject gameObject); // 0x00000001816695A0-0x0000000181669600
	}
}
