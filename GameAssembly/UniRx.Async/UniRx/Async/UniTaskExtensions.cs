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

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async
{
	public static class UniTaskExtensions // TypeDefIndex: 8750
	{
		// Nested types
		private class ToCoroutineEnumerator : IEnumerator // TypeDefIndex: 8751
		{
			// Fields
			private bool completed; // 0x10
			private UniTask task; // 0x18
			private Action<Exception> exceptionHandler; // 0x20
			private bool isStarted; // 0x28
			private ExceptionDispatchInfo exception; // 0x30
	
			// Properties
			public object Current { get; } // 0x000000018037DDC0-0x000000018037DDD0 
	
			// Nested types
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask>d__6 : IAsyncStateMachine // TypeDefIndex: 8752
			{
				// Fields
				public int <>1__state; // 0x00
				public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x08
				public UniTask task; // 0x10
				public ToCoroutineEnumerator <>4__this; // 0x18
				private UniTask.Awaiter <>u__1; // 0x20
	
				// Methods
				private void MoveNext(); // 0x000000018010ED70-0x000000018010ED80
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002020-0x0000000180002030
			}
	
			// Constructors
			public ToCoroutineEnumerator(UniTask task, Action<Exception> exceptionHandler); // 0x0000000181AC6210-0x0000000181AC7BE0
	
			// Methods
			[AsyncStateMachine] // 0x000000018027C860-0x000000018027C8B0
			private UniTaskVoid RunTask(UniTask task); // 0x0000000181AC6170-0x0000000181AC6210
			public bool MoveNext(); // 0x0000000181AC6070-0x0000000181AC6170
			public void Reset(); // 0x00000001803774A0-0x00000001803774B0
		}
	
		private class ToCoroutineEnumerator<T> : IEnumerator // TypeDefIndex: 8753
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
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask>d__8 : IAsyncStateMachine // TypeDefIndex: 8754
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T> task;
				public ToCoroutineEnumerator<T> <>4__this;
				private UniTask<T> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public ToCoroutineEnumerator(UniTask<T> task, Action<T> resultHandler, Action<Exception> exceptionHandler);
	
			// Methods
			[AsyncStateMachine] // 0x000000018027CDC0-0x000000018027CE10
			private UniTaskVoid RunTask(UniTask<T> task);
			public bool MoveNext();
			public void Reset();
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__9<T> // TypeDefIndex: 8755
		{
			// Fields
			public static readonly <>c__9<T> <>9;
			public static Action<Task<T>, object> <>9__9_0;
	
			// Constructors
			static <>c__9();
			public <>c__9();
	
			// Methods
			internal void <AsUniTask>b__9_0(Task<T> x, object state);
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 8756
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Action<Task, object> <>9__10_0; // 0x08
	
			// Constructors
			static <>c(); // 0x0000000181AC7E20-0x0000000181AC8420
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void <AsUniTask>b__10_0(Task x, object state); // 0x0000000181AC7BE0-0x0000000181AC7D50
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <Timeout>d__14<T> : IAsyncStateMachine // TypeDefIndex: 8757
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
			[TupleElementNames] // 0x000000018027D800-0x000000018027D8A0
			private UniTask<ValueTuple<bool, ValueTuple<bool, T>>> <>u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <TimeoutWithoutException>d__15 : IAsyncStateMachine // TypeDefIndex: 8758
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskMethodBuilder<bool> <>t__builder; // 0x08
			public UniTask task; // 0x20
			public TimeSpan timeout; // 0x28
			public bool ignoreTimeScale; // 0x30
			public PlayerLoopTiming timeoutCheckTiming; // 0x34
			public CancellationTokenSource taskCancellationTokenSource; // 0x38
			[TupleElementNames] // 0x000000018027DFC0-0x000000018027E040
			private UniTask<ValueTuple<bool, AsyncUnit>> <>u__1; // 0x40
	
			// Methods
			private void MoveNext(); // 0x000000018010EDB0-0x000000018010EDC0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018010EDC0-0x000000018010EE10
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <TimeoutWithoutException>d__16<T> : IAsyncStateMachine // TypeDefIndex: 8759
		{
			// Fields
			public int <>1__state;
			[TupleElementNames] // 0x000000018027FC90-0x000000018027FD10
			public AsyncUniTaskMethodBuilder<ValueTuple<bool, T>> <>t__builder;
			public TimeSpan timeout;
			public bool ignoreTimeScale;
			public PlayerLoopTiming timeoutCheckTiming;
			public UniTask<T> task;
			public CancellationTokenSource taskCancellationTokenSource;
			private CancellationTokenSource <delayCancellationTokenSource>5__2;
			[TupleElementNames] // 0x000000018027FF50-0x000000018027FFF0
			private UniTask<ValueTuple<bool, ValueTuple<bool, T>>> <>u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <ForgetCore>d__19 : IAsyncStateMachine // TypeDefIndex: 8760
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x08
			public UniTask task; // 0x10
			private UniTask.Awaiter <>u__1; // 0x18
	
			// Methods
			private void MoveNext(); // 0x000000018010ED40-0x000000018010ED50
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002020-0x0000000180002030
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <ForgetCoreWithCatch>d__20 : IAsyncStateMachine // TypeDefIndex: 8761
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
			private void MoveNext(); // 0x000000018010ED50-0x000000018010ED60
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002020-0x0000000180002030
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <ForgetCore>d__23<T> : IAsyncStateMachine // TypeDefIndex: 8762
		{
			// Fields
			public int <>1__state;
			public AsyncUniTaskVoidMethodBuilder <>t__builder;
			public UniTask<T> task;
			private UniTask<T> <>u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <ForgetCoreWithCatch>d__24<T> : IAsyncStateMachine // TypeDefIndex: 8763
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
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <ContinueWith>d__25<T> : IAsyncStateMachine // TypeDefIndex: 8764
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
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <ContinueWith>d__26<T> : IAsyncStateMachine // TypeDefIndex: 8765
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
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <ContinueWith>d__27<T, TR> : IAsyncStateMachine // TypeDefIndex: 8766
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
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <ContinueWith>d__28<T, TR> : IAsyncStateMachine // TypeDefIndex: 8767
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
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <ContinueWith>d__29 : IAsyncStateMachine // TypeDefIndex: 8768
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
			public UniTask task; // 0x18
			public Action continuationFunction; // 0x20
			private UniTask.Awaiter <>u__1; // 0x28
	
			// Methods
			private void MoveNext(); // 0x000000018010ED10-0x000000018010ED20
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002020-0x0000000180002030
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <ContinueWith>d__30 : IAsyncStateMachine // TypeDefIndex: 8769
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
			public UniTask task; // 0x18
			public Func<UniTask> continuationFunction; // 0x20
			private UniTask.Awaiter <>u__1; // 0x28
	
			// Methods
			private void MoveNext(); // 0x000000018010ED20-0x000000018010ED30
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002020-0x0000000180002030
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <ContinueWith>d__31<T> : IAsyncStateMachine // TypeDefIndex: 8770
		{
			// Fields
			public int <>1__state;
			public AsyncUniTaskMethodBuilder<T> <>t__builder;
			public UniTask task;
			public Func<T> continuationFunction;
			private UniTask.Awaiter <>u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <ContinueWith>d__32<T> : IAsyncStateMachine // TypeDefIndex: 8771
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
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <ConfigureAwait>d__33 : IAsyncStateMachine // TypeDefIndex: 8772
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
			public Task task; // 0x18
			public PlayerLoopTiming timing; // 0x20
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x28
			private YieldAwaitable.Awaiter <>u__2; // 0x38
	
			// Methods
			private void MoveNext(); // 0x000000018010ECF0-0x000000018010ED00
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002020-0x0000000180002030
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <ConfigureAwait>d__34<T> : IAsyncStateMachine // TypeDefIndex: 8773
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
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <ConfigureAwait>d__35 : IAsyncStateMachine // TypeDefIndex: 8774
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
			public UniTask task; // 0x18
			public PlayerLoopTiming timing; // 0x20
			private UniTask.Awaiter <>u__1; // 0x28
			private YieldAwaitable.Awaiter <>u__2; // 0x30
	
			// Methods
			private void MoveNext(); // 0x000000018010ED00-0x000000018010ED10
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002020-0x0000000180002030
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <ConfigureAwait>d__36<T> : IAsyncStateMachine // TypeDefIndex: 8775
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
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <Unwrap>d__37<T> : IAsyncStateMachine // TypeDefIndex: 8776
		{
			// Fields
			public int <>1__state;
			public AsyncUniTaskMethodBuilder<T> <>t__builder;
			public UniTask<UniTask<T>> task;
			private UniTask<UniTask<T>> <>u__1;
			private UniTask<T> <>u__2;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <Unwrap>d__38<T> : IAsyncStateMachine // TypeDefIndex: 8777
		{
			// Fields
			public int <>1__state;
			public AsyncUniTaskMethodBuilder <>t__builder;
			public UniTask<UniTask> task;
			private UniTask<UniTask> <>u__1;
			private UniTask.Awaiter <>u__2;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Methods
		[AsyncStateMachine] // 0x0000000180278290-0x00000001802782E0
		private static UniTaskVoid ForgetCore(UniTask task); // 0x0000000181AC9040-0x0000000181AC90C0
		[AsyncStateMachine] // 0x0000000180278530-0x0000000180278580
		private static UniTaskVoid ForgetCoreWithCatch(UniTask task, Action<Exception> exceptionHandler, bool handleExceptionOnMainThread); // 0x0000000181AC8F80-0x0000000181AC9040
		[AsyncStateMachine] // 0x0000000180278A80-0x0000000180278AD0
		private static UniTaskVoid ForgetCore<T>(UniTask<T> task);
		[AsyncStateMachine] // 0x0000000180278DB0-0x0000000180278E00
		private static UniTaskVoid ForgetCoreWithCatch<T>(UniTask<T> task, Action<Exception> exceptionHandler, bool handleExceptionOnMainThread);
	
		// Extension methods
		public static UniTask.Awaiter GetAwaiter(this IEnumerable<UniTask> tasks); // 0x0000000181AC91B0-0x0000000181AC9280
		public static UniTask<T[]> GetAwaiter<T>(this IEnumerable<UniTask<T>> tasks);
		public static UniTask<ValueTuple<T1, T2>> GetAwaiter<T1, T2>([TupleElementNames] /* 0x0000000180271B80-0x0000000180271C00 */ this ValueTuple<UniTask<T1>, UniTask<T2>> tasks);
		public static UniTask<ValueTuple<T1, T2, T3>> WhenAll<T1, T2, T3>([TupleElementNames] /* 0x0000000180272360-0x00000001802723F0 */ this ValueTuple<UniTask<T1>, UniTask<T2>, UniTask<T3>> tasks);
		public static UniTask<ValueTuple<T1, T2, T3, T4>> WhenAll<T1, T2, T3, T4>([TupleElementNames] /* 0x0000000180273C40-0x0000000180273CE0 */ this ValueTuple<UniTask<T1>, UniTask<T2>, UniTask<T3>, UniTask<T4>> tasks);
		public static UniTask<ValueTuple<T1, T2, T3, T4, T5>> WhenAll<T1, T2, T3, T4, T5>([TupleElementNames] /* 0x0000000180274350-0x0000000180274400 */ this ValueTuple<UniTask<T1>, UniTask<T2>, UniTask<T3>, UniTask<T4>, UniTask<T5>> tasks);
		public static UniTask<ValueTuple<T1, T2, T3, T4, T5, T6>> WhenAll<T1, T2, T3, T4, T5, T6>([TupleElementNames] /* 0x00000001802747B0-0x0000000180274870 */ this ValueTuple<UniTask<T1>, UniTask<T2>, UniTask<T3>, UniTask<T4>, UniTask<T5>, UniTask<T6>> tasks);
		public static UniTask<ValueTuple<T1, T2, T3, T4, T5, T6, T7>> WhenAll<T1, T2, T3, T4, T5, T6, T7>([TupleElementNames] /* 0x00000001802763B0-0x0000000180276480 */ this ValueTuple<UniTask<T1>, UniTask<T2>, UniTask<T3>, UniTask<T4>, UniTask<T5>, UniTask<T6>, UniTask<T7>> tasks);
		public static UniTask<AsyncUnit> AsAsyncUnitUniTask(this UniTask task); // 0x0000000181AC8AF0-0x0000000181AC8B60
		public static UniTask<T> AsUniTask<T>(this Task<T> task, bool useCurrentSynchronizationContext = true /* Metadata: 0x007780A5 */);
		public static UniTask AsUniTask(this Task task, bool useCurrentSynchronizationContext = true /* Metadata: 0x007780A6 */); // 0x0000000181AC8B60-0x0000000181AC8CE0
		public static IEnumerator ToCoroutine<T>(this UniTask<T> task, Action<T> resultHandler = null, Action<Exception> exceptionHandler = null);
		public static IEnumerator ToCoroutine(this UniTask task, Action<Exception> exceptionHandler = null); // 0x0000000181AC9490-0x0000000181AC9500
		public static UniTask Timeout(this UniTask task, TimeSpan timeout, bool ignoreTimeScale = true /* Metadata: 0x007780A7 */, PlayerLoopTiming timeoutCheckTiming = PlayerLoopTiming.Update /* Metadata: 0x007780A8 */, CancellationTokenSource taskCancellationTokenSource = null); // 0x0000000181AC9390-0x0000000181AC9490
		[AsyncStateMachine] // 0x00000001802774C0-0x0000000180277530
		public static UniTask<T> Timeout<T>(this UniTask<T> task, TimeSpan timeout, bool ignoreTimeScale = true /* Metadata: 0x007780AC */, PlayerLoopTiming timeoutCheckTiming = PlayerLoopTiming.Update /* Metadata: 0x007780AD */, CancellationTokenSource taskCancellationTokenSource = null);
		[AsyncStateMachine] // 0x00000001802778A0-0x0000000180277910
		public static UniTask<bool> TimeoutWithoutException(this UniTask task, TimeSpan timeout, bool ignoreTimeScale = true /* Metadata: 0x007780B1 */, PlayerLoopTiming timeoutCheckTiming = PlayerLoopTiming.Update /* Metadata: 0x007780B2 */, CancellationTokenSource taskCancellationTokenSource = null); // 0x0000000181AC9280-0x0000000181AC9390
		[AsyncStateMachine] // 0x0000000180277D20-0x0000000180277D90
		public static UniTask<ValueTuple<bool, T>> TimeoutWithoutException<T>(this UniTask<T> task, TimeSpan timeout, bool ignoreTimeScale = true /* Metadata: 0x007780B6 */, PlayerLoopTiming timeoutCheckTiming = PlayerLoopTiming.Update /* Metadata: 0x007780B7 */, CancellationTokenSource taskCancellationTokenSource = null);
		public static void Forget(this UniTask task); // 0x0000000181AC91A0-0x0000000181AC91B0
		public static void Forget(this UniTask task, Action<Exception> exceptionHandler, bool handleExceptionOnMainThread = true /* Metadata: 0x007780BB */); // 0x0000000181AC90C0-0x0000000181AC91A0
		public static void Forget<T>(this UniTask<T> task);
		public static void Forget<T>(this UniTask<T> task, Action<Exception> exceptionHandler, bool handleExceptionOnMainThread = true /* Metadata: 0x007780BC */);
		[AsyncStateMachine] // 0x0000000180278FE0-0x0000000180279050
		public static UniTask ContinueWith<T>(this UniTask<T> task, Action<T> continuationFunction);
		[AsyncStateMachine] // 0x0000000180279300-0x0000000180279370
		public static UniTask ContinueWith<T>(this UniTask<T> task, Func<T, UniTask> continuationFunction);
		[AsyncStateMachine] // 0x0000000180279520-0x0000000180279590
		public static UniTask<TR> ContinueWith<T, TR>(this UniTask<T> task, Func<T, TR> continuationFunction);
		[AsyncStateMachine] // 0x00000001802797F0-0x0000000180279860
		public static UniTask<TR> ContinueWith<T, TR>(this UniTask<T> task, Func<T, UniTask<TR>> continuationFunction);
		[AsyncStateMachine] // 0x0000000180279C00-0x0000000180279C70
		public static UniTask ContinueWith(this UniTask task, Action continuationFunction); // 0x0000000181AC8E40-0x0000000181AC8EE0
		[AsyncStateMachine] // 0x000000018027B160-0x000000018027B1D0
		public static UniTask ContinueWith(this UniTask task, Func<UniTask> continuationFunction); // 0x0000000181AC8EE0-0x0000000181AC8F80
		[AsyncStateMachine] // 0x000000018027B260-0x000000018027B2D0
		public static UniTask<T> ContinueWith<T>(this UniTask task, Func<T> continuationFunction);
		[AsyncStateMachine] // 0x000000018027B550-0x000000018027B5C0
		public static UniTask<T> ContinueWith<T>(this UniTask task, Func<UniTask<T>> continuationFunction);
		[AsyncStateMachine] // 0x000000018027B760-0x000000018027B7D0
		public static UniTask ConfigureAwait(this Task task, PlayerLoopTiming timing); // 0x0000000181AC8CE0-0x0000000181AC8D90
		[AsyncStateMachine] // 0x000000018027BA20-0x000000018027BA90
		public static UniTask<T> ConfigureAwait<T>(this Task<T> task, PlayerLoopTiming timing);
		[AsyncStateMachine] // 0x000000018027BBE0-0x000000018027BC50
		public static UniTask ConfigureAwait(this UniTask task, PlayerLoopTiming timing); // 0x0000000181AC8D90-0x0000000181AC8E40
		[AsyncStateMachine] // 0x000000018027BF10-0x000000018027BF80
		public static UniTask<T> ConfigureAwait<T>(this UniTask<T> task, PlayerLoopTiming timing);
		[AsyncStateMachine] // 0x000000018027C140-0x000000018027C1B0
		public static UniTask<T> Unwrap<T>(this UniTask<UniTask<T>> task);
		[AsyncStateMachine] // 0x000000018027C550-0x000000018027C5C0
		public static UniTask Unwrap<T>(this UniTask<UniTask> task);
	}
}
