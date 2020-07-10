/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using UniRx.Async.CompilerServices;

// Image 68: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8376-8739

namespace UniRx.Async
{
	public static class UniTaskExtensions // TypeDefIndex: 8584
	{
		// Nested types
		private class ToCoroutineEnumerator : IEnumerator // TypeDefIndex: 8585
		{
			// Fields
			private bool completed; // 0x10
			private UniTask task; // 0x18
			private Action<Exception> exceptionHandler; // 0x20
			private bool isStarted; // 0x28
			private ExceptionDispatchInfo exception; // 0x30
	
			// Properties
			public object Current { get; } // 0x000000018035FCC0-0x000000018035FCD0 
	
			// Nested types
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask>d__6 : IAsyncStateMachine // TypeDefIndex: 8586
			{
				// Fields
				public int <>1__state; // 0x00
				public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x08
				public UniTask task; // 0x10
				public ToCoroutineEnumerator <>4__this; // 0x18
				private UniTask.Awaiter <>u__1; // 0x20
	
				// Methods
				private void MoveNext(); // 0x0000000180321CF0-0x0000000180321D00
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0500-0x00000001801F0510
			}
	
			// Constructors
			public ToCoroutineEnumerator(UniTask task, Action<Exception> exceptionHandler); // 0x00000001820DFC60-0x00000001820E1300
	
			// Methods
			[AsyncStateMachine] // 0x0000000180114FA0-0x0000000180114FF0
			private UniTaskVoid RunTask(UniTask task); // 0x00000001820DFBC0-0x00000001820DFC60
			public bool MoveNext(); // 0x00000001820DFAC0-0x00000001820DFBC0
			public void Reset(); // 0x00000001803581E0-0x00000001803581F0
		}
	
		private class ToCoroutineEnumerator<T> : IEnumerator // TypeDefIndex: 8587
		{
			// Fields
			private bool completed;
			private Action<T> resultHandler;
			private Action<Exception> exceptionHandler;
			private bool isStarted;
			private UniTask<T> task;
			private object current;
			private ExceptionDispatchInfo exception;
	
			// Properties
			public object Current { get; }
	
			// Nested types
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask>d__8 : IAsyncStateMachine // TypeDefIndex: 8588
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T> task;
				public ToCoroutineEnumerator<T> <>4__this;
				private UniTask<T> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public ToCoroutineEnumerator(UniTask<T> task, Action<T> resultHandler, Action<Exception> exceptionHandler);
	
			// Methods
			[AsyncStateMachine] // 0x00000001801154D0-0x0000000180115520
			private UniTaskVoid RunTask(UniTask<T> task);
			public bool MoveNext();
			public void Reset();
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__1<T> // TypeDefIndex: 8589
		{
			// Fields
			public static readonly <>c__1<T> <>9;
			public static Action<Task<T>, object> <>9__1_0;
	
			// Constructors
			static <>c__1();
			public <>c__1();
	
			// Methods
			internal void <AsUniTask>b__1_0(Task<T> x, object state);
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 8590
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Action<Task, object> <>9__2_0; // 0x08
	
			// Constructors
			static <>c(); // 0x00000001820E1540-0x00000001820E1B60
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal void <AsUniTask>b__2_0(Task x, object state); // 0x00000001820E1300-0x00000001820E1470
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <Timeout>d__6<T> : IAsyncStateMachine // TypeDefIndex: 8591
		{
			// Fields
			public int <>1__state;
			public AsyncUniTaskMethodBuilder<T> <>t__builder;
			public TimeSpan timeout;
			public bool ignoreTimeScale;
			public PlayerLoopTiming timeoutCheckTiming;
			public UniTask<T> task;
			public CancellationTokenSource taskCancellationTokenSource;
			private CancellationTokenSource <delayCancellationTokenSource>5__2;
			[TupleElementNames] // 0x0000000180116FE0-0x0000000180117080
			private UniTask<ValueTuple<bool, ValueTuple<bool, T>>> <>u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <TimeoutWithoutException>d__7 : IAsyncStateMachine // TypeDefIndex: 8592
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskMethodBuilder<bool> <>t__builder; // 0x08
			public UniTask task; // 0x20
			public TimeSpan timeout; // 0x28
			public bool ignoreTimeScale; // 0x30
			public PlayerLoopTiming timeoutCheckTiming; // 0x34
			public CancellationTokenSource taskCancellationTokenSource; // 0x38
			[TupleElementNames] // 0x0000000180117A20-0x0000000180117AA0
			private UniTask<ValueTuple<bool, AsyncUnit>> <>u__1; // 0x40
	
			// Methods
			private void MoveNext(); // 0x0000000180321D30-0x0000000180321D40
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180321D40-0x0000000180321D90
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <TimeoutWithoutException>d__8<T> : IAsyncStateMachine // TypeDefIndex: 8593
		{
			// Fields
			public int <>1__state;
			[TupleElementNames] // 0x00000001801191A0-0x0000000180119220
			public AsyncUniTaskMethodBuilder<ValueTuple<bool, T>> <>t__builder;
			public TimeSpan timeout;
			public bool ignoreTimeScale;
			public PlayerLoopTiming timeoutCheckTiming;
			public UniTask<T> task;
			public CancellationTokenSource taskCancellationTokenSource;
			private CancellationTokenSource <delayCancellationTokenSource>5__2;
			[TupleElementNames] // 0x0000000180119490-0x0000000180119530
			private UniTask<ValueTuple<bool, ValueTuple<bool, T>>> <>u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <ForgetCore>d__11 : IAsyncStateMachine // TypeDefIndex: 8594
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x08
			public UniTask task; // 0x10
			private UniTask.Awaiter <>u__1; // 0x18
	
			// Methods
			private void MoveNext(); // 0x0000000180321CC0-0x0000000180321CD0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0500-0x00000001801F0510
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <ForgetCoreWithCatch>d__12 : IAsyncStateMachine // TypeDefIndex: 8595
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x08
			public UniTask task; // 0x10
			public bool handleExceptionOnMainThread; // 0x18
			public Action<Exception> exceptionHandler; // 0x20
			private object <>7__wrap1; // 0x28
			private int <>7__wrap2; // 0x30
			private UniTask.Awaiter <>u__1; // 0x38
			private Exception <ex>5__4; // 0x40
			private SwitchToMainThreadAwaitable.Awaiter <>u__2; // 0x48
	
			// Methods
			private void MoveNext(); // 0x0000000180321CD0-0x0000000180321CE0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0500-0x00000001801F0510
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <ForgetCore>d__15<T> : IAsyncStateMachine // TypeDefIndex: 8596
		{
			// Fields
			public int <>1__state;
			public AsyncUniTaskVoidMethodBuilder <>t__builder;
			public UniTask<T> task;
			private UniTask<T> <>u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <ForgetCoreWithCatch>d__16<T> : IAsyncStateMachine // TypeDefIndex: 8597
		{
			// Fields
			public int <>1__state;
			public AsyncUniTaskVoidMethodBuilder <>t__builder;
			public UniTask<T> task;
			public bool handleExceptionOnMainThread;
			public Action<Exception> exceptionHandler;
			private object <>7__wrap1;
			private int <>7__wrap2;
			private UniTask<T> <>u__1;
			private Exception <ex>5__4;
			private SwitchToMainThreadAwaitable.Awaiter <>u__2;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <ContinueWith>d__17<T> : IAsyncStateMachine // TypeDefIndex: 8598
		{
			// Fields
			public int <>1__state;
			public AsyncUniTaskMethodBuilder <>t__builder;
			public Action<T> continuationFunction;
			public UniTask<T> task;
			private Action<T> <>7__wrap1;
			private UniTask<T> <>u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <ContinueWith>d__18<T> : IAsyncStateMachine // TypeDefIndex: 8599
		{
			// Fields
			public int <>1__state;
			public AsyncUniTaskMethodBuilder <>t__builder;
			public Func<T, UniTask> continuationFunction;
			public UniTask<T> task;
			private Func<T, UniTask> <>7__wrap1;
			private UniTask<T> <>u__1;
			private UniTask.Awaiter <>u__2;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <ContinueWith>d__19<T, TR> : IAsyncStateMachine // TypeDefIndex: 8600
		{
			// Fields
			public int <>1__state;
			public AsyncUniTaskMethodBuilder<TR> <>t__builder;
			public Func<T, TR> continuationFunction;
			public UniTask<T> task;
			private Func<T, TR> <>7__wrap1;
			private UniTask<T> <>u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <ContinueWith>d__20<T, TR> : IAsyncStateMachine // TypeDefIndex: 8601
		{
			// Fields
			public int <>1__state;
			public AsyncUniTaskMethodBuilder<TR> <>t__builder;
			public Func<T, UniTask<TR>> continuationFunction;
			public UniTask<T> task;
			private Func<T, UniTask<TR>> <>7__wrap1;
			private UniTask<T> <>u__1;
			private UniTask<TR> <>u__2;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <ContinueWith>d__21 : IAsyncStateMachine // TypeDefIndex: 8602
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
			public UniTask task; // 0x18
			public Action continuationFunction; // 0x20
			private UniTask.Awaiter <>u__1; // 0x28
	
			// Methods
			private void MoveNext(); // 0x0000000180321C90-0x0000000180321CA0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0500-0x00000001801F0510
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <ContinueWith>d__22 : IAsyncStateMachine // TypeDefIndex: 8603
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
			public UniTask task; // 0x18
			public Func<UniTask> continuationFunction; // 0x20
			private UniTask.Awaiter <>u__1; // 0x28
	
			// Methods
			private void MoveNext(); // 0x0000000180321CA0-0x0000000180321CB0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0500-0x00000001801F0510
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <ContinueWith>d__23<T> : IAsyncStateMachine // TypeDefIndex: 8604
		{
			// Fields
			public int <>1__state;
			public AsyncUniTaskMethodBuilder<T> <>t__builder;
			public UniTask task;
			public Func<T> continuationFunction;
			private UniTask.Awaiter <>u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <ContinueWith>d__24<T> : IAsyncStateMachine // TypeDefIndex: 8605
		{
			// Fields
			public int <>1__state;
			public AsyncUniTaskMethodBuilder<T> <>t__builder;
			public UniTask task;
			public Func<UniTask<T>> continuationFunction;
			private UniTask.Awaiter <>u__1;
			private UniTask<T> <>u__2;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <ConfigureAwait>d__25 : IAsyncStateMachine // TypeDefIndex: 8606
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
			public Task task; // 0x18
			public PlayerLoopTiming timing; // 0x20
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x28
			private YieldAwaitable.Awaiter <>u__2; // 0x38
	
			// Methods
			private void MoveNext(); // 0x0000000180321C70-0x0000000180321C80
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0500-0x00000001801F0510
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <ConfigureAwait>d__26<T> : IAsyncStateMachine // TypeDefIndex: 8607
		{
			// Fields
			public int <>1__state;
			public AsyncUniTaskMethodBuilder<T> <>t__builder;
			public Task<T> task;
			public PlayerLoopTiming timing;
			private T <v>5__2;
			private ConfiguredTaskAwaitable<T> <>u__1;
			private YieldAwaitable.Awaiter <>u__2;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <ConfigureAwait>d__27 : IAsyncStateMachine // TypeDefIndex: 8608
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
			public UniTask task; // 0x18
			public PlayerLoopTiming timing; // 0x20
			private UniTask.Awaiter <>u__1; // 0x28
			private YieldAwaitable.Awaiter <>u__2; // 0x30
	
			// Methods
			private void MoveNext(); // 0x0000000180321C80-0x0000000180321C90
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0500-0x00000001801F0510
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <ConfigureAwait>d__28<T> : IAsyncStateMachine // TypeDefIndex: 8609
		{
			// Fields
			public int <>1__state;
			public AsyncUniTaskMethodBuilder<T> <>t__builder;
			public UniTask<T> task;
			public PlayerLoopTiming timing;
			private T <v>5__2;
			private UniTask<T> <>u__1;
			private YieldAwaitable.Awaiter <>u__2;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <Unwrap>d__29<T> : IAsyncStateMachine // TypeDefIndex: 8610
		{
			// Fields
			public int <>1__state;
			public AsyncUniTaskMethodBuilder<T> <>t__builder;
			public UniTask<UniTask<T>> task;
			private UniTask<UniTask<T>> <>u__1;
			private UniTask<T> <>u__2;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <Unwrap>d__30<T> : IAsyncStateMachine // TypeDefIndex: 8611
		{
			// Fields
			public int <>1__state;
			public AsyncUniTaskMethodBuilder <>t__builder;
			public UniTask<UniTask> task;
			private UniTask<UniTask> <>u__1;
			private UniTask.Awaiter <>u__2;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Methods
		[AsyncStateMachine] // 0x000000018010E3F0-0x000000018010E440
		private static UniTaskVoid ForgetCore(UniTask task); // 0x00000001820E27A0-0x00000001820E2820
		[AsyncStateMachine] // 0x000000018010E700-0x000000018010E750
		private static UniTaskVoid ForgetCoreWithCatch(UniTask task, Action<Exception> exceptionHandler, bool handleExceptionOnMainThread); // 0x00000001820E26E0-0x00000001820E27A0
		[AsyncStateMachine] // 0x000000018010ED10-0x000000018010ED60
		private static UniTaskVoid ForgetCore<T>(UniTask<T> task);
		[AsyncStateMachine] // 0x000000018010EEA0-0x000000018010EEF0
		private static UniTaskVoid ForgetCoreWithCatch<T>(UniTask<T> task, Action<Exception> exceptionHandler, bool handleExceptionOnMainThread);
	
		// Extension methods
		public static UniTask<AsyncUnit> AsAsyncUnitUniTask(this UniTask task); // 0x00000001820E2250-0x00000001820E22C0
		public static UniTask<T> AsUniTask<T>(this Task<T> task, bool useCurrentSynchronizationContext = true /* Metadata: 0x007433B7 */);
		public static UniTask AsUniTask(this Task task, bool useCurrentSynchronizationContext = true /* Metadata: 0x007433B8 */); // 0x00000001820E22C0-0x00000001820E2440
		public static IEnumerator ToCoroutine<T>(this UniTask<T> task, Action<T> resultHandler = null, Action<Exception> exceptionHandler = null);
		public static IEnumerator ToCoroutine(this UniTask task, Action<Exception> exceptionHandler = null); // 0x00000001820E2B90-0x00000001820E2C00
		public static UniTask Timeout(this UniTask task, TimeSpan timeout, bool ignoreTimeScale = true /* Metadata: 0x007433B9 */, PlayerLoopTiming timeoutCheckTiming = PlayerLoopTiming.Update /* Metadata: 0x007433BA */, CancellationTokenSource taskCancellationTokenSource = null); // 0x00000001820E2A90-0x00000001820E2B90
		[AsyncStateMachine] // 0x000000018010D500-0x000000018010D570
		public static UniTask<T> Timeout<T>(this UniTask<T> task, TimeSpan timeout, bool ignoreTimeScale = true /* Metadata: 0x007433BE */, PlayerLoopTiming timeoutCheckTiming = PlayerLoopTiming.Update /* Metadata: 0x007433BF */, CancellationTokenSource taskCancellationTokenSource = null);
		[AsyncStateMachine] // 0x000000018010D8F0-0x000000018010D960
		public static UniTask<bool> TimeoutWithoutException(this UniTask task, TimeSpan timeout, bool ignoreTimeScale = true /* Metadata: 0x007433C3 */, PlayerLoopTiming timeoutCheckTiming = PlayerLoopTiming.Update /* Metadata: 0x007433C4 */, CancellationTokenSource taskCancellationTokenSource = null); // 0x00000001820E2980-0x00000001820E2A90
		[AsyncStateMachine] // 0x000000018010DE30-0x000000018010DEA0
		public static UniTask<ValueTuple<bool, T>> TimeoutWithoutException<T>(this UniTask<T> task, TimeSpan timeout, bool ignoreTimeScale = true /* Metadata: 0x007433C8 */, PlayerLoopTiming timeoutCheckTiming = PlayerLoopTiming.Update /* Metadata: 0x007433C9 */, CancellationTokenSource taskCancellationTokenSource = null);
		public static void Forget(this UniTask task); // 0x00000001820E2900-0x00000001820E2910
		public static void Forget(this UniTask task, Action<Exception> exceptionHandler, bool handleExceptionOnMainThread = true /* Metadata: 0x007433CD */); // 0x00000001820E2820-0x00000001820E2900
		public static void Forget<T>(this UniTask<T> task);
		public static void Forget<T>(this UniTask<T> task, Action<Exception> exceptionHandler, bool handleExceptionOnMainThread = true /* Metadata: 0x007433CE */);
		[AsyncStateMachine] // 0x000000018010F0D0-0x000000018010F140
		public static UniTask ContinueWith<T>(this UniTask<T> task, Action<T> continuationFunction);
		[AsyncStateMachine] // 0x000000018010F3F0-0x000000018010F460
		public static UniTask ContinueWith<T>(this UniTask<T> task, Func<T, UniTask> continuationFunction);
		[AsyncStateMachine] // 0x000000018010F6A0-0x000000018010F710
		public static UniTask<TR> ContinueWith<T, TR>(this UniTask<T> task, Func<T, TR> continuationFunction);
		[AsyncStateMachine] // 0x000000018010FB30-0x000000018010FBA0
		public static UniTask<TR> ContinueWith<T, TR>(this UniTask<T> task, Func<T, UniTask<TR>> continuationFunction);
		[AsyncStateMachine] // 0x000000018010FE00-0x000000018010FE70
		public static UniTask ContinueWith(this UniTask task, Action continuationFunction); // 0x00000001820E25A0-0x00000001820E2640
		[AsyncStateMachine] // 0x0000000180110200-0x0000000180110270
		public static UniTask ContinueWith(this UniTask task, Func<UniTask> continuationFunction); // 0x00000001820E2640-0x00000001820E26E0
		[AsyncStateMachine] // 0x00000001801104F0-0x0000000180110560
		public static UniTask<T> ContinueWith<T>(this UniTask task, Func<T> continuationFunction);
		[AsyncStateMachine] // 0x00000001801108B0-0x0000000180110920
		public static UniTask<T> ContinueWith<T>(this UniTask task, Func<UniTask<T>> continuationFunction);
		[AsyncStateMachine] // 0x0000000180110D10-0x0000000180110D80
		public static UniTask ConfigureAwait(this Task task, PlayerLoopTiming timing); // 0x00000001820E2440-0x00000001820E24F0
		[AsyncStateMachine] // 0x0000000180111130-0x00000001801111A0
		public static UniTask<T> ConfigureAwait<T>(this Task<T> task, PlayerLoopTiming timing);
		[AsyncStateMachine] // 0x0000000180111340-0x00000001801113B0
		public static UniTask ConfigureAwait(this UniTask task, PlayerLoopTiming timing); // 0x00000001820E24F0-0x00000001820E25A0
		[AsyncStateMachine] // 0x00000001801115E0-0x0000000180111650
		public static UniTask<T> ConfigureAwait<T>(this UniTask<T> task, PlayerLoopTiming timing);
		[AsyncStateMachine] // 0x0000000180111840-0x00000001801118B0
		public static UniTask<T> Unwrap<T>(this UniTask<UniTask<T>> task);
		[AsyncStateMachine] // 0x0000000180111AD0-0x0000000180111B40
		public static UniTask Unwrap<T>(this UniTask<UniTask> task);
		public static UniTask.Awaiter GetAwaiter(this IEnumerable<UniTask> tasks); // 0x00000001820E2910-0x00000001820E2980
		public static UniTask<T[]> GetAwaiter<T>(this IEnumerable<UniTask<T>> tasks);
		public static UniTask<ValueTuple<T1, T2>> GetAwaiter<T1, T2>([TupleElementNames] /* 0x0000000180112190-0x0000000180112210 */ this ValueTuple<UniTask<T1>, UniTask<T2>> tasks);
		public static UniTask<ValueTuple<T1, T2, T3>> WhenAll<T1, T2, T3>([TupleElementNames] /* 0x0000000180112790-0x0000000180112820 */ this ValueTuple<UniTask<T1>, UniTask<T2>, UniTask<T3>> tasks);
		public static UniTask<ValueTuple<T1, T2, T3, T4>> WhenAll<T1, T2, T3, T4>([TupleElementNames] /* 0x0000000180112BE0-0x0000000180112C80 */ this ValueTuple<UniTask<T1>, UniTask<T2>, UniTask<T3>, UniTask<T4>> tasks);
		public static UniTask<ValueTuple<T1, T2, T3, T4, T5>> WhenAll<T1, T2, T3, T4, T5>([TupleElementNames] /* 0x00000001801130A0-0x0000000180113150 */ this ValueTuple<UniTask<T1>, UniTask<T2>, UniTask<T3>, UniTask<T4>, UniTask<T5>> tasks);
		public static UniTask<ValueTuple<T1, T2, T3, T4, T5, T6>> WhenAll<T1, T2, T3, T4, T5, T6>([TupleElementNames] /* 0x0000000180113400-0x00000001801134C0 */ this ValueTuple<UniTask<T1>, UniTask<T2>, UniTask<T3>, UniTask<T4>, UniTask<T5>, UniTask<T6>> tasks);
		public static UniTask<ValueTuple<T1, T2, T3, T4, T5, T6, T7>> WhenAll<T1, T2, T3, T4, T5, T6, T7>([TupleElementNames] /* 0x0000000180113970-0x0000000180113A40 */ this ValueTuple<UniTask<T1>, UniTask<T2>, UniTask<T3>, UniTask<T4>, UniTask<T5>, UniTask<T6>, UniTask<T7>> tasks);
	}
}
