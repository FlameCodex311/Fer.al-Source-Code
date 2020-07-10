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
using UniRx.Async.CompilerServices;
using UniRx.Async.Internal;

// Image 68: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8376-8739

namespace UniRx.Async
{
	[AsyncMethodBuilder] // 0x00000001800E18B0-0x00000001800E1900
	public struct UniTask : IEquatable<UniRx.Async.UniTask> // TypeDefIndex: 8419
	{
		// Fields
		private static readonly UniTask<AsyncUnit> DefaultAsyncUnitTask; // 0x00
		private readonly IAwaiter awaiter; // 0x00
		private static readonly UniTask CanceledUniTask; // 0x10
	
		// Properties
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public AwaiterStatus Status { get; } // 0x0000000180254410-0x000000018025E210 
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public bool IsCompleted { get; } // 0x00000001802543C0-0x0000000180254410 
		public static UniTask CompletedTask { get; } // 0x000000018035FCC0-0x000000018035FCD0 
	
		// Nested types
		private class AsyncUnitAwaiter : IAwaiter<AsyncUnit> // TypeDefIndex: 8420
		{
			// Fields
			private readonly IAwaiter awaiter; // 0x10
	
			// Properties
			public bool IsCompleted { get; } // 0x00000001820DEA80-0x00000001820DEAD0 
			public AwaiterStatus Status { get; } // 0x00000001820DEAD0-0x00000001820DECF0 
	
			// Constructors
			public AsyncUnitAwaiter(IAwaiter awaiter); // 0x000000018037D3F0-0x000000018037D420
	
			// Methods
			public AsyncUnit GetResult(); // 0x00000001820DE8F0-0x00000001820DE970
			public void OnCompleted(Action continuation); // 0x00000001820DE970-0x00000001820DE9D0
			public void UnsafeOnCompleted(Action continuation); // 0x00000001820DEA20-0x00000001820DEA80
			void IAwaiter.GetResult(); // 0x00000001820DE9D0-0x00000001820DEA20
		}
	
		private class IsCanceledAwaiter : IAwaiter<bool> // TypeDefIndex: 8421
		{
			// Fields
			private readonly IAwaiter awaiter; // 0x10
	
			// Properties
			public bool IsCompleted { get; } // 0x00000001820DF160-0x00000001820DF1B0 
			public AwaiterStatus Status { get; } // 0x00000001820DF1B0-0x00000001820DF200 
	
			// Constructors
			public IsCanceledAwaiter(IAwaiter awaiter); // 0x000000018037D3F0-0x000000018037D420
	
			// Methods
			public bool GetResult(); // 0x00000001820DEFD0-0x00000001820DF050
			public void OnCompleted(Action continuation); // 0x00000001820DF050-0x00000001820DF0B0
			public void UnsafeOnCompleted(Action continuation); // 0x00000001820DF100-0x00000001820DF160
			void IAwaiter.GetResult(); // 0x00000001820DF0B0-0x00000001820DF100
		}
	
		public struct Awaiter : IAwaiter // TypeDefIndex: 8422
		{
			// Fields
			private readonly UniTask task; // 0x00
	
			// Properties
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public bool IsCompleted { get; } // 0x0000000180321AD0-0x0000000180321AF0 
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public AwaiterStatus Status { get; } // 0x0000000180321B30-0x0000000180321B90 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public Awaiter(UniTask task); // 0x0000000180004C60-0x0000000180004C90
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public void GetResult(); // 0x0000000180321840-0x0000000180321860
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public void OnCompleted(Action continuation); // 0x0000000180321960-0x00000001803219D0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public void UnsafeOnCompleted(Action continuation); // 0x0000000180321A20-0x0000000180321A90
		}
	
		private class YieldPromise : PlayerLoopReusablePromiseBase // TypeDefIndex: 8423
		{
			// Constructors
			public YieldPromise(PlayerLoopTiming timing, CancellationToken cancellationToken); // 0x00000001820E68F0-0x00000001820E6910
	
			// Methods
			protected override void OnRunningStart(); // 0x00000001803581E0-0x00000001803581F0
			public override bool MoveNext(); // 0x00000001820E6880-0x00000001820E68F0
		}
	
		private class DelayFramePromise : PlayerLoopReusablePromiseBase<int> // TypeDefIndex: 8424
		{
			// Fields
			private readonly int delayFrameCount; // 0x48
			private int currentFrameCount; // 0x4C
	
			// Constructors
			public DelayFramePromise(int delayFrameCount, PlayerLoopTiming timing, CancellationToken cancellationToken); // 0x00000001820DEDB0-0x00000001820DEE30
	
			// Methods
			protected override void OnRunningStart(); // 0x00000001820DEDA0-0x00000001820DEDB0
			public override bool MoveNext(); // 0x00000001820DECF0-0x00000001820DEDA0
		}
	
		private class DelayPromise : PlayerLoopReusablePromiseBase // TypeDefIndex: 8425
		{
			// Fields
			private readonly float delayFrameTimeSpan; // 0x40
			private float elapsed; // 0x44
	
			// Constructors
			public DelayPromise(TimeSpan delayFrameTimeSpan, PlayerLoopTiming timing, CancellationToken cancellationToken); // 0x00000001820DEEE0-0x00000001820DEF30
	
			// Methods
			protected override void OnRunningStart(); // 0x00000001820DEED0-0x00000001820DEEE0
			public override bool MoveNext(); // 0x00000001820DEF30-0x00000001820DEFD0
		}
	
		private class DelayIgnoreTimeScalePromise : PlayerLoopReusablePromiseBase // TypeDefIndex: 8426
		{
			// Fields
			private readonly float delayFrameTimeSpan; // 0x40
			private float elapsed; // 0x44
	
			// Constructors
			public DelayIgnoreTimeScalePromise(TimeSpan delayFrameTimeSpan, PlayerLoopTiming timing, CancellationToken cancellationToken); // 0x00000001820DEEE0-0x00000001820DEF30
	
			// Methods
			protected override void OnRunningStart(); // 0x00000001820DEED0-0x00000001820DEEE0
			public override bool MoveNext(); // 0x00000001820DEE30-0x00000001820DEED0
		}
	
		private static class CanceledUniTaskCache<T> // TypeDefIndex: 8427
		{
			// Fields
			public static readonly UniTask<T> Task;
	
			// Constructors
			static CanceledUniTaskCache();
		}
	
		private class WaitUntilPromise : PlayerLoopReusablePromiseBase // TypeDefIndex: 8428
		{
			// Fields
			private readonly Func<bool> predicate; // 0x40
	
			// Constructors
			public WaitUntilPromise(Func<bool> predicate, PlayerLoopTiming timing, CancellationToken cancellationToken); // 0x00000001820E62C0-0x00000001820E6300
	
			// Methods
			protected override void OnRunningStart(); // 0x00000001803581E0-0x00000001803581F0
			public override bool MoveNext(); // 0x00000001820E61B0-0x00000001820E62C0
		}
	
		private class WaitWhilePromise : PlayerLoopReusablePromiseBase // TypeDefIndex: 8429
		{
			// Fields
			private readonly Func<bool> predicate; // 0x40
	
			// Constructors
			public WaitWhilePromise(Func<bool> predicate, PlayerLoopTiming timing, CancellationToken cancellationToken); // 0x00000001820E62C0-0x00000001820E6300
	
			// Methods
			protected override void OnRunningStart(); // 0x00000001803581E0-0x00000001803581F0
			public override bool MoveNext(); // 0x00000001820E6300-0x00000001820E6410
		}
	
		private class WaitUntilValueChangedUnityObjectPromise<T, U> : PlayerLoopReusablePromiseBase<U> // TypeDefIndex: 8430
		{
			// Fields
			private readonly T target;
			private readonly Func<T, U> monitorFunction;
			private readonly IEqualityComparer<U> equalityComparer;
			private U currentValue;
	
			// Constructors
			public WaitUntilValueChangedUnityObjectPromise(T target, Func<T, U> monitorFunction, IEqualityComparer<U> equalityComparer, PlayerLoopTiming timing, CancellationToken cancellationToken);
	
			// Methods
			protected override void OnRunningStart();
			public override bool MoveNext();
		}
	
		private class WaitUntilValueChangedStandardObjectPromise<T, U> : PlayerLoopReusablePromiseBase<U> // TypeDefIndex: 8431
			where T : class
		{
			// Fields
			private readonly WeakReference<T> target;
			private readonly Func<T, U> monitorFunction;
			private readonly IEqualityComparer<U> equalityComparer;
			private U currentValue;
	
			// Constructors
			public WaitUntilValueChangedStandardObjectPromise(T target, Func<T, U> monitorFunction, IEqualityComparer<U> equalityComparer, PlayerLoopTiming timing, CancellationToken cancellationToken);
	
			// Methods
			protected override void OnRunningStart();
			public override bool MoveNext();
		}
	
		private class WhenAllPromise<T> // TypeDefIndex: 8432
		{
			// Fields
			private readonly T[] result;
			private int completeCount;
			private Action whenComplete;
			private ExceptionDispatchInfo exception;
	
			// Nested types
			public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8433
			{
				// Fields
				private WhenAllPromise<T> parent;
	
				// Properties
				public bool IsCompleted { get; }
	
				// Constructors
				public Awaiter(WhenAllPromise<T> parent);
	
				// Methods
				public T[] GetResult();
				public void OnCompleted(Action continuation);
				public void UnsafeOnCompleted(Action continuation);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask>d__6 : IAsyncStateMachine // TypeDefIndex: 8434
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T> task;
				public WhenAllPromise<T> <>4__this;
				public int index;
				private UniTask<T> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAllPromise(UniTask<T>[] tasks, int tasksLength);
	
			// Methods
			private void TryCallContinuation();
			[AsyncStateMachine] // 0x00000001800E6E60-0x00000001800E6EB0
			private UniTaskVoid RunTask(UniTask<T> task, int index);
			public Awaiter GetAwaiter();
		}
	
		private class WhenAllPromise // TypeDefIndex: 8435
		{
			// Fields
			private int completeCount; // 0x10
			private int resultLength; // 0x14
			private Action whenComplete; // 0x18
			private ExceptionDispatchInfo exception; // 0x20
	
			// Nested types
			public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8436
			{
				// Fields
				private WhenAllPromise parent; // 0x00
	
				// Properties
				public bool IsCompleted { get; } // 0x0000000180321AF0-0x0000000180321B30 
	
				// Constructors
				public Awaiter(WhenAllPromise parent); // 0x0000000180004C60-0x0000000180004C90
	
				// Methods
				public void GetResult(); // 0x00000001803218C0-0x0000000180321910
				public void OnCompleted(Action continuation); // 0x00000001803219E0-0x00000001803219F0
				public void UnsafeOnCompleted(Action continuation); // 0x0000000180321A10-0x0000000180321A20
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask>d__6 : IAsyncStateMachine // TypeDefIndex: 8437
			{
				// Fields
				public int <>1__state; // 0x00
				public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x08
				public UniTask task; // 0x10
				public WhenAllPromise <>4__this; // 0x18
				private Awaiter <>u__1; // 0x20
	
				// Methods
				private void MoveNext(); // 0x0000000180321CE0-0x0000000180321CF0
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0500-0x00000001801F0510
			}
	
			// Constructors
			public WhenAllPromise(UniTask[] tasks, int tasksLength); // 0x00000001820E64E0-0x00000001820E6680
	
			// Methods
			private void TryCallContinuation(); // 0x00000001820E64B0-0x00000001820E64E0
			[AsyncStateMachine] // 0x00000001800E8860-0x00000001800E88B0
			private UniTaskVoid RunTask(UniTask task, int index); // 0x00000001820E6410-0x00000001820E64B0
			public Awaiter GetAwaiter(); // 0x0000000180362190-0x00000001803621A0
		}
	
		private class WhenAllPromise<T1, T2> // TypeDefIndex: 8438
		{
			// Fields
			private const int MaxCount = 2; // Metadata: 0x0074337F
			private T1 result1;
			private T2 result2;
			private ExceptionDispatchInfo exception;
			private int completeCount;
			private Action whenComplete;
	
			// Nested types
			public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8439
			{
				// Fields
				private WhenAllPromise<T1, T2> parent;
	
				// Properties
				public bool IsCompleted { get; }
	
				// Constructors
				public Awaiter(WhenAllPromise<T1, T2> parent);
	
				// Methods
				public ValueTuple<T1, T2> GetResult();
				public void OnCompleted(Action continuation);
				public void UnsafeOnCompleted(Action continuation);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask1Async>d__9 : IAsyncStateMachine // TypeDefIndex: 8440
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T1> task;
				public WhenAllPromise<T1, T2> <>4__this;
				private UniTask<T1> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask2Async>d__11 : IAsyncStateMachine // TypeDefIndex: 8441
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T2> task;
				public WhenAllPromise<T1, T2> <>4__this;
				private UniTask<T2> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAllPromise(UniTask<T1> task1, UniTask<T2> task2);
	
			// Methods
			private void TryCallContinuation();
			private void RunTask1(UniTask<T1> task);
			[AsyncStateMachine] // 0x00000001800E8BC0-0x00000001800E8C10
			private UniTaskVoid RunTask1Async(UniTask<T1> task);
			private void RunTask2(UniTask<T2> task);
			[AsyncStateMachine] // 0x00000001800E8DA0-0x00000001800E8DF0
			private UniTaskVoid RunTask2Async(UniTask<T2> task);
			public Awaiter GetAwaiter();
		}
	
		private class WhenAllPromise<T1, T2, T3> // TypeDefIndex: 8442
		{
			// Fields
			private const int MaxCount = 3; // Metadata: 0x00743383
			private T1 result1;
			private T2 result2;
			private T3 result3;
			private ExceptionDispatchInfo exception;
			private int completeCount;
			private Action whenComplete;
	
			// Nested types
			public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8443
			{
				// Fields
				private WhenAllPromise<T1, T2, T3> parent;
	
				// Properties
				public bool IsCompleted { get; }
	
				// Constructors
				public Awaiter(WhenAllPromise<T1, T2, T3> parent);
	
				// Methods
				public ValueTuple<T1, T2, T3> GetResult();
				public void OnCompleted(Action continuation);
				public void UnsafeOnCompleted(Action continuation);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask1Async>d__10 : IAsyncStateMachine // TypeDefIndex: 8444
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T1> task;
				public WhenAllPromise<T1, T2, T3> <>4__this;
				private UniTask<T1> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask2Async>d__12 : IAsyncStateMachine // TypeDefIndex: 8445
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T2> task;
				public WhenAllPromise<T1, T2, T3> <>4__this;
				private UniTask<T2> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask3Async>d__14 : IAsyncStateMachine // TypeDefIndex: 8446
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T3> task;
				public WhenAllPromise<T1, T2, T3> <>4__this;
				private UniTask<T3> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAllPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3);
	
			// Methods
			private void TryCallContinuation();
			private void RunTask1(UniTask<T1> task);
			[AsyncStateMachine] // 0x00000001800E9500-0x00000001800E9550
			private UniTaskVoid RunTask1Async(UniTask<T1> task);
			private void RunTask2(UniTask<T2> task);
			[AsyncStateMachine] // 0x00000001800E9650-0x00000001800E96A0
			private UniTaskVoid RunTask2Async(UniTask<T2> task);
			private void RunTask3(UniTask<T3> task);
			[AsyncStateMachine] // 0x00000001800E9A00-0x00000001800E9A50
			private UniTaskVoid RunTask3Async(UniTask<T3> task);
			public Awaiter GetAwaiter();
		}
	
		private class WhenAllPromise<T1, T2, T3, T4> // TypeDefIndex: 8447
		{
			// Fields
			private const int MaxCount = 4; // Metadata: 0x00743387
			private T1 result1;
			private T2 result2;
			private T3 result3;
			private T4 result4;
			private ExceptionDispatchInfo exception;
			private int completeCount;
			private Action whenComplete;
	
			// Nested types
			public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8448
			{
				// Fields
				private WhenAllPromise<T1, T2, T3, T4> parent;
	
				// Properties
				public bool IsCompleted { get; }
	
				// Constructors
				public Awaiter(WhenAllPromise<T1, T2, T3, T4> parent);
	
				// Methods
				public ValueTuple<T1, T2, T3, T4> GetResult();
				public void OnCompleted(Action continuation);
				public void UnsafeOnCompleted(Action continuation);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask1Async>d__11 : IAsyncStateMachine // TypeDefIndex: 8449
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T1> task;
				public WhenAllPromise<T1, T2, T3, T4> <>4__this;
				private UniTask<T1> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask2Async>d__13 : IAsyncStateMachine // TypeDefIndex: 8450
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T2> task;
				public WhenAllPromise<T1, T2, T3, T4> <>4__this;
				private UniTask<T2> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask3Async>d__15 : IAsyncStateMachine // TypeDefIndex: 8451
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T3> task;
				public WhenAllPromise<T1, T2, T3, T4> <>4__this;
				private UniTask<T3> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask4Async>d__17 : IAsyncStateMachine // TypeDefIndex: 8452
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T4> task;
				public WhenAllPromise<T1, T2, T3, T4> <>4__this;
				private UniTask<T4> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAllPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4);
	
			// Methods
			private void TryCallContinuation();
			private void RunTask1(UniTask<T1> task);
			[AsyncStateMachine] // 0x00000001800EA180-0x00000001800EA1D0
			private UniTaskVoid RunTask1Async(UniTask<T1> task);
			private void RunTask2(UniTask<T2> task);
			[AsyncStateMachine] // 0x00000001800EA250-0x00000001800EA2A0
			private UniTaskVoid RunTask2Async(UniTask<T2> task);
			private void RunTask3(UniTask<T3> task);
			[AsyncStateMachine] // 0x00000001800EB6F0-0x00000001800EB740
			private UniTaskVoid RunTask3Async(UniTask<T3> task);
			private void RunTask4(UniTask<T4> task);
			[AsyncStateMachine] // 0x00000001800EB7C0-0x00000001800EB810
			private UniTaskVoid RunTask4Async(UniTask<T4> task);
			public Awaiter GetAwaiter();
		}
	
		private class WhenAllPromise<T1, T2, T3, T4, T5> // TypeDefIndex: 8453
		{
			// Fields
			private const int MaxCount = 5; // Metadata: 0x0074338B
			private T1 result1;
			private T2 result2;
			private T3 result3;
			private T4 result4;
			private T5 result5;
			private ExceptionDispatchInfo exception;
			private int completeCount;
			private Action whenComplete;
	
			// Nested types
			public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8454
			{
				// Fields
				private WhenAllPromise<T1, T2, T3, T4, T5> parent;
	
				// Properties
				public bool IsCompleted { get; }
	
				// Constructors
				public Awaiter(WhenAllPromise<T1, T2, T3, T4, T5> parent);
	
				// Methods
				public ValueTuple<T1, T2, T3, T4, T5> GetResult();
				public void OnCompleted(Action continuation);
				public void UnsafeOnCompleted(Action continuation);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask1Async>d__12 : IAsyncStateMachine // TypeDefIndex: 8455
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T1> task;
				public WhenAllPromise<T1, T2, T3, T4, T5> <>4__this;
				private UniTask<T1> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask2Async>d__14 : IAsyncStateMachine // TypeDefIndex: 8456
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T2> task;
				public WhenAllPromise<T1, T2, T3, T4, T5> <>4__this;
				private UniTask<T2> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask3Async>d__16 : IAsyncStateMachine // TypeDefIndex: 8457
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T3> task;
				public WhenAllPromise<T1, T2, T3, T4, T5> <>4__this;
				private UniTask<T3> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask4Async>d__18 : IAsyncStateMachine // TypeDefIndex: 8458
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T4> task;
				public WhenAllPromise<T1, T2, T3, T4, T5> <>4__this;
				private UniTask<T4> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask5Async>d__20 : IAsyncStateMachine // TypeDefIndex: 8459
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T5> task;
				public WhenAllPromise<T1, T2, T3, T4, T5> <>4__this;
				private UniTask<T5> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAllPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5);
	
			// Methods
			private void TryCallContinuation();
			private void RunTask1(UniTask<T1> task);
			[AsyncStateMachine] // 0x00000001800EC1B0-0x00000001800EC200
			private UniTaskVoid RunTask1Async(UniTask<T1> task);
			private void RunTask2(UniTask<T2> task);
			[AsyncStateMachine] // 0x00000001800EC3F0-0x00000001800EC440
			private UniTaskVoid RunTask2Async(UniTask<T2> task);
			private void RunTask3(UniTask<T3> task);
			[AsyncStateMachine] // 0x00000001800EC5C0-0x00000001800EC610
			private UniTaskVoid RunTask3Async(UniTask<T3> task);
			private void RunTask4(UniTask<T4> task);
			[AsyncStateMachine] // 0x00000001800EC8C0-0x00000001800EC910
			private UniTaskVoid RunTask4Async(UniTask<T4> task);
			private void RunTask5(UniTask<T5> task);
			[AsyncStateMachine] // 0x00000001800ECAA0-0x00000001800ECAF0
			private UniTaskVoid RunTask5Async(UniTask<T5> task);
			public Awaiter GetAwaiter();
		}
	
		private class WhenAllPromise<T1, T2, T3, T4, T5, T6> // TypeDefIndex: 8460
		{
			// Fields
			private const int MaxCount = 6; // Metadata: 0x0074338F
			private T1 result1;
			private T2 result2;
			private T3 result3;
			private T4 result4;
			private T5 result5;
			private T6 result6;
			private ExceptionDispatchInfo exception;
			private int completeCount;
			private Action whenComplete;
	
			// Nested types
			public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8461
			{
				// Fields
				private WhenAllPromise<T1, T2, T3, T4, T5, T6> parent;
	
				// Properties
				public bool IsCompleted { get; }
	
				// Constructors
				public Awaiter(WhenAllPromise<T1, T2, T3, T4, T5, T6> parent);
	
				// Methods
				public ValueTuple<T1, T2, T3, T4, T5, T6> GetResult();
				public void OnCompleted(Action continuation);
				public void UnsafeOnCompleted(Action continuation);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask1Async>d__13 : IAsyncStateMachine // TypeDefIndex: 8462
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T1> task;
				public WhenAllPromise<T1, T2, T3, T4, T5, T6> <>4__this;
				private UniTask<T1> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask2Async>d__15 : IAsyncStateMachine // TypeDefIndex: 8463
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T2> task;
				public WhenAllPromise<T1, T2, T3, T4, T5, T6> <>4__this;
				private UniTask<T2> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask3Async>d__17 : IAsyncStateMachine // TypeDefIndex: 8464
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T3> task;
				public WhenAllPromise<T1, T2, T3, T4, T5, T6> <>4__this;
				private UniTask<T3> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask4Async>d__19 : IAsyncStateMachine // TypeDefIndex: 8465
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T4> task;
				public WhenAllPromise<T1, T2, T3, T4, T5, T6> <>4__this;
				private UniTask<T4> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask5Async>d__21 : IAsyncStateMachine // TypeDefIndex: 8466
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T5> task;
				public WhenAllPromise<T1, T2, T3, T4, T5, T6> <>4__this;
				private UniTask<T5> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask6Async>d__23 : IAsyncStateMachine // TypeDefIndex: 8467
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T6> task;
				public WhenAllPromise<T1, T2, T3, T4, T5, T6> <>4__this;
				private UniTask<T6> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAllPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6);
	
			// Methods
			private void TryCallContinuation();
			private void RunTask1(UniTask<T1> task);
			[AsyncStateMachine] // 0x00000001800ED7E0-0x00000001800ED830
			private UniTaskVoid RunTask1Async(UniTask<T1> task);
			private void RunTask2(UniTask<T2> task);
			[AsyncStateMachine] // 0x00000001800ED990-0x00000001800ED9E0
			private UniTaskVoid RunTask2Async(UniTask<T2> task);
			private void RunTask3(UniTask<T3> task);
			[AsyncStateMachine] // 0x00000001800EDC30-0x00000001800EDC80
			private UniTaskVoid RunTask3Async(UniTask<T3> task);
			private void RunTask4(UniTask<T4> task);
			[AsyncStateMachine] // 0x00000001800EDE80-0x00000001800EDED0
			private UniTaskVoid RunTask4Async(UniTask<T4> task);
			private void RunTask5(UniTask<T5> task);
			[AsyncStateMachine] // 0x00000001800EE070-0x00000001800EE0C0
			private UniTaskVoid RunTask5Async(UniTask<T5> task);
			private void RunTask6(UniTask<T6> task);
			[AsyncStateMachine] // 0x00000001800EE380-0x00000001800EE3D0
			private UniTaskVoid RunTask6Async(UniTask<T6> task);
			public Awaiter GetAwaiter();
		}
	
		private class WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> // TypeDefIndex: 8468
		{
			// Fields
			private const int MaxCount = 7; // Metadata: 0x00743393
			private T1 result1;
			private T2 result2;
			private T3 result3;
			private T4 result4;
			private T5 result5;
			private T6 result6;
			private T7 result7;
			private ExceptionDispatchInfo exception;
			private int completeCount;
			private Action whenComplete;
	
			// Nested types
			public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8469
			{
				// Fields
				private WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> parent;
	
				// Properties
				public bool IsCompleted { get; }
	
				// Constructors
				public Awaiter(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> parent);
	
				// Methods
				public ValueTuple<T1, T2, T3, T4, T5, T6, T7> GetResult();
				public void OnCompleted(Action continuation);
				public void UnsafeOnCompleted(Action continuation);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask1Async>d__14 : IAsyncStateMachine // TypeDefIndex: 8470
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T1> task;
				public WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> <>4__this;
				private UniTask<T1> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask2Async>d__16 : IAsyncStateMachine // TypeDefIndex: 8471
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T2> task;
				public WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> <>4__this;
				private UniTask<T2> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask3Async>d__18 : IAsyncStateMachine // TypeDefIndex: 8472
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T3> task;
				public WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> <>4__this;
				private UniTask<T3> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask4Async>d__20 : IAsyncStateMachine // TypeDefIndex: 8473
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T4> task;
				public WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> <>4__this;
				private UniTask<T4> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask5Async>d__22 : IAsyncStateMachine // TypeDefIndex: 8474
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T5> task;
				public WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> <>4__this;
				private UniTask<T5> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask6Async>d__24 : IAsyncStateMachine // TypeDefIndex: 8475
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T6> task;
				public WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> <>4__this;
				private UniTask<T6> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask7Async>d__26 : IAsyncStateMachine // TypeDefIndex: 8476
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T7> task;
				public WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> <>4__this;
				private UniTask<T7> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAllPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7);
	
			// Methods
			private void TryCallContinuation();
			private void RunTask1(UniTask<T1> task);
			[AsyncStateMachine] // 0x00000001800EF410-0x00000001800EF460
			private UniTaskVoid RunTask1Async(UniTask<T1> task);
			private void RunTask2(UniTask<T2> task);
			[AsyncStateMachine] // 0x00000001800EF610-0x00000001800EF660
			private UniTaskVoid RunTask2Async(UniTask<T2> task);
			private void RunTask3(UniTask<T3> task);
			[AsyncStateMachine] // 0x00000001800EF840-0x00000001800EF890
			private UniTaskVoid RunTask3Async(UniTask<T3> task);
			private void RunTask4(UniTask<T4> task);
			[AsyncStateMachine] // 0x00000001800EFAA0-0x00000001800EFAF0
			private UniTaskVoid RunTask4Async(UniTask<T4> task);
			private void RunTask5(UniTask<T5> task);
			[AsyncStateMachine] // 0x00000001800EFCD0-0x00000001800EFD20
			private UniTaskVoid RunTask5Async(UniTask<T5> task);
			private void RunTask6(UniTask<T6> task);
			[AsyncStateMachine] // 0x00000001800EFE40-0x00000001800EFE90
			private UniTaskVoid RunTask6Async(UniTask<T6> task);
			private void RunTask7(UniTask<T7> task);
			[AsyncStateMachine] // 0x00000001800EFFD0-0x00000001800F0020
			private UniTaskVoid RunTask7Async(UniTask<T7> task);
			public Awaiter GetAwaiter();
		}
	
		private class UnitWhenAnyPromise<T0> // TypeDefIndex: 8477
		{
			// Fields
			private T0 result0;
			private ExceptionDispatchInfo exception;
			private Action whenComplete;
			private int completeCount;
			private int winArgumentIndex;
	
			// Properties
			private bool IsCompleted { get; }
	
			// Nested types
			public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8478
			{
				// Fields
				private UnitWhenAnyPromise<T0> parent;
	
				// Properties
				public bool IsCompleted { get; }
	
				// Constructors
				public Awaiter(UnitWhenAnyPromise<T0> parent);
	
				// Methods
				public ValueTuple<bool, T0> GetResult();
				public void OnCompleted(Action continuation);
				public void UnsafeOnCompleted(Action continuation);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask0>d__9 : IAsyncStateMachine // TypeDefIndex: 8479
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T0> task;
				public UnitWhenAnyPromise<T0> <>4__this;
				private UniTask<T0> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask1>d__10 : IAsyncStateMachine // TypeDefIndex: 8480
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask task;
				public UnitWhenAnyPromise<T0> <>4__this;
				private Awaiter <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public UnitWhenAnyPromise(UniTask<T0> task0, UniTask task1);
	
			// Methods
			private void TryCallContinuation();
			[AsyncStateMachine] // 0x00000001800F2AC0-0x00000001800F2B10
			private UniTaskVoid RunTask0(UniTask<T0> task);
			[AsyncStateMachine] // 0x00000001800F2DB0-0x00000001800F2E00
			private UniTaskVoid RunTask1(UniTask task);
			public Awaiter GetAwaiter();
		}
	
		private class WhenAnyPromise<T> // TypeDefIndex: 8481
		{
			// Fields
			private T result;
			private int completeCount;
			private int winArgumentIndex;
			private Action whenComplete;
			private ExceptionDispatchInfo exception;
	
			// Properties
			public bool IsComplete { get; }
	
			// Nested types
			public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8482
			{
				// Fields
				private WhenAnyPromise<T> parent;
	
				// Properties
				public bool IsCompleted { get; }
	
				// Constructors
				public Awaiter(WhenAnyPromise<T> parent);
	
				// Methods
				public ValueTuple<int, T> GetResult();
				public void OnCompleted(Action continuation);
				public void UnsafeOnCompleted(Action continuation);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask>d__8 : IAsyncStateMachine // TypeDefIndex: 8483
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T> task;
				public WhenAnyPromise<T> <>4__this;
				public int index;
				private UniTask<T> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAnyPromise(UniTask<T>[] tasks);
	
			// Methods
			[AsyncStateMachine] // 0x00000001800F3610-0x00000001800F3660
			private UniTaskVoid RunTask(UniTask<T> task, int index);
			private void TryCallContinuation();
			public Awaiter GetAwaiter();
		}
	
		private class WhenAnyPromise // TypeDefIndex: 8484
		{
			// Fields
			private int completeCount; // 0x10
			private int winArgumentIndex; // 0x14
			private Action whenComplete; // 0x18
			private ExceptionDispatchInfo exception; // 0x20
	
			// Properties
			public bool IsComplete { get; } // 0x00000001820E6850-0x00000001820E6880 
	
			// Nested types
			public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8485
			{
				// Fields
				private WhenAnyPromise parent; // 0x00
	
				// Properties
				public bool IsCompleted { get; } // 0x0000000180321A90-0x0000000180321AD0 
	
				// Constructors
				public Awaiter(WhenAnyPromise parent); // 0x0000000180004C60-0x0000000180004C90
	
				// Methods
				public int GetResult(); // 0x0000000180321860-0x00000001803218C0
				public void OnCompleted(Action continuation); // 0x00000001803219F0-0x0000000180321A00
				public void UnsafeOnCompleted(Action continuation); // 0x0000000180321A00-0x0000000180321A10
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask>d__7 : IAsyncStateMachine // TypeDefIndex: 8486
			{
				// Fields
				public int <>1__state; // 0x00
				public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x08
				public UniTask task; // 0x10
				public WhenAnyPromise <>4__this; // 0x18
				public int index; // 0x20
				private Awaiter <>u__1; // 0x28
	
				// Methods
				private void MoveNext(); // 0x0000000180321D00-0x0000000180321D10
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0500-0x00000001801F0510
			}
	
			// Constructors
			public WhenAnyPromise(UniTask[] tasks); // 0x00000001820E6730-0x00000001820E6850
	
			// Methods
			[AsyncStateMachine] // 0x00000001800F3C80-0x00000001800F3CD0
			private UniTaskVoid RunTask(UniTask task, int index); // 0x00000001820E6680-0x00000001820E6730
			private void TryCallContinuation(); // 0x00000001820E64B0-0x00000001820E64E0
			public Awaiter GetAwaiter(); // 0x0000000180362190-0x00000001803621A0
		}
	
		private class WhenAnyPromise<T0, T1> // TypeDefIndex: 8487
		{
			// Fields
			private T0 result0;
			private T1 result1;
			private ExceptionDispatchInfo exception;
			private Action whenComplete;
			private int completeCount;
			private int winArgumentIndex;
	
			// Properties
			private bool IsCompleted { get; }
	
			// Nested types
			public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8488
			{
				// Fields
				private WhenAnyPromise<T0, T1> parent;
	
				// Properties
				public bool IsCompleted { get; }
	
				// Constructors
				public Awaiter(WhenAnyPromise<T0, T1> parent);
	
				// Methods
				public ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>> GetResult();
				public void OnCompleted(Action continuation);
				public void UnsafeOnCompleted(Action continuation);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask0>d__10 : IAsyncStateMachine // TypeDefIndex: 8489
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T0> task;
				public WhenAnyPromise<T0, T1> <>4__this;
				private UniTask<T0> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask1>d__11 : IAsyncStateMachine // TypeDefIndex: 8490
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T1> task;
				public WhenAnyPromise<T0, T1> <>4__this;
				private UniTask<T1> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAnyPromise(UniTask<T0> task0, UniTask<T1> task1);
	
			// Methods
			private void TryCallContinuation();
			[AsyncStateMachine] // 0x00000001800F42A0-0x00000001800F42F0
			private UniTaskVoid RunTask0(UniTask<T0> task);
			[AsyncStateMachine] // 0x00000001800F4500-0x00000001800F4550
			private UniTaskVoid RunTask1(UniTask<T1> task);
			public Awaiter GetAwaiter();
		}
	
		private class WhenAnyPromise<T0, T1, T2> // TypeDefIndex: 8491
		{
			// Fields
			private T0 result0;
			private T1 result1;
			private T2 result2;
			private ExceptionDispatchInfo exception;
			private Action whenComplete;
			private int completeCount;
			private int winArgumentIndex;
	
			// Properties
			private bool IsCompleted { get; }
	
			// Nested types
			public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8492
			{
				// Fields
				private WhenAnyPromise<T0, T1, T2> parent;
	
				// Properties
				public bool IsCompleted { get; }
	
				// Constructors
				public Awaiter(WhenAnyPromise<T0, T1, T2> parent);
	
				// Methods
				public ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>> GetResult();
				public void OnCompleted(Action continuation);
				public void UnsafeOnCompleted(Action continuation);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask0>d__11 : IAsyncStateMachine // TypeDefIndex: 8493
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T0> task;
				public WhenAnyPromise<T0, T1, T2> <>4__this;
				private UniTask<T0> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask1>d__12 : IAsyncStateMachine // TypeDefIndex: 8494
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T1> task;
				public WhenAnyPromise<T0, T1, T2> <>4__this;
				private UniTask<T1> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask2>d__13 : IAsyncStateMachine // TypeDefIndex: 8495
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T2> task;
				public WhenAnyPromise<T0, T1, T2> <>4__this;
				private UniTask<T2> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAnyPromise(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2);
	
			// Methods
			private void TryCallContinuation();
			[AsyncStateMachine] // 0x00000001800F4B50-0x00000001800F4BA0
			private UniTaskVoid RunTask0(UniTask<T0> task);
			[AsyncStateMachine] // 0x00000001800F4D30-0x00000001800F4D80
			private UniTaskVoid RunTask1(UniTask<T1> task);
			[AsyncStateMachine] // 0x00000001800F4FA0-0x00000001800F4FF0
			private UniTaskVoid RunTask2(UniTask<T2> task);
			public Awaiter GetAwaiter();
		}
	
		private class WhenAnyPromise<T0, T1, T2, T3> // TypeDefIndex: 8496
		{
			// Fields
			private T0 result0;
			private T1 result1;
			private T2 result2;
			private T3 result3;
			private ExceptionDispatchInfo exception;
			private Action whenComplete;
			private int completeCount;
			private int winArgumentIndex;
	
			// Properties
			private bool IsCompleted { get; }
	
			// Nested types
			public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8497
			{
				// Fields
				private WhenAnyPromise<T0, T1, T2, T3> parent;
	
				// Properties
				public bool IsCompleted { get; }
	
				// Constructors
				public Awaiter(WhenAnyPromise<T0, T1, T2, T3> parent);
	
				// Methods
				public ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>> GetResult();
				public void OnCompleted(Action continuation);
				public void UnsafeOnCompleted(Action continuation);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask0>d__12 : IAsyncStateMachine // TypeDefIndex: 8498
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T0> task;
				public WhenAnyPromise<T0, T1, T2, T3> <>4__this;
				private UniTask<T0> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask1>d__13 : IAsyncStateMachine // TypeDefIndex: 8499
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T1> task;
				public WhenAnyPromise<T0, T1, T2, T3> <>4__this;
				private UniTask<T1> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask2>d__14 : IAsyncStateMachine // TypeDefIndex: 8500
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T2> task;
				public WhenAnyPromise<T0, T1, T2, T3> <>4__this;
				private UniTask<T2> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask3>d__15 : IAsyncStateMachine // TypeDefIndex: 8501
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T3> task;
				public WhenAnyPromise<T0, T1, T2, T3> <>4__this;
				private UniTask<T3> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAnyPromise(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3);
	
			// Methods
			private void TryCallContinuation();
			[AsyncStateMachine] // 0x00000001800F5B60-0x00000001800F5BB0
			private UniTaskVoid RunTask0(UniTask<T0> task);
			[AsyncStateMachine] // 0x00000001800F5F30-0x00000001800F5F80
			private UniTaskVoid RunTask1(UniTask<T1> task);
			[AsyncStateMachine] // 0x00000001800F61D0-0x00000001800F6220
			private UniTaskVoid RunTask2(UniTask<T2> task);
			[AsyncStateMachine] // 0x00000001800F6600-0x00000001800F6650
			private UniTaskVoid RunTask3(UniTask<T3> task);
			public Awaiter GetAwaiter();
		}
	
		private class WhenAnyPromise<T0, T1, T2, T3, T4> // TypeDefIndex: 8502
		{
			// Fields
			private T0 result0;
			private T1 result1;
			private T2 result2;
			private T3 result3;
			private T4 result4;
			private ExceptionDispatchInfo exception;
			private Action whenComplete;
			private int completeCount;
			private int winArgumentIndex;
	
			// Properties
			private bool IsCompleted { get; }
	
			// Nested types
			public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8503
			{
				// Fields
				private WhenAnyPromise<T0, T1, T2, T3, T4> parent;
	
				// Properties
				public bool IsCompleted { get; }
	
				// Constructors
				public Awaiter(WhenAnyPromise<T0, T1, T2, T3, T4> parent);
	
				// Methods
				public ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>> GetResult();
				public void OnCompleted(Action continuation);
				public void UnsafeOnCompleted(Action continuation);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask0>d__13 : IAsyncStateMachine // TypeDefIndex: 8504
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T0> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4> <>4__this;
				private UniTask<T0> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask1>d__14 : IAsyncStateMachine // TypeDefIndex: 8505
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T1> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4> <>4__this;
				private UniTask<T1> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask2>d__15 : IAsyncStateMachine // TypeDefIndex: 8506
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T2> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4> <>4__this;
				private UniTask<T2> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask3>d__16 : IAsyncStateMachine // TypeDefIndex: 8507
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T3> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4> <>4__this;
				private UniTask<T3> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask4>d__17 : IAsyncStateMachine // TypeDefIndex: 8508
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T4> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4> <>4__this;
				private UniTask<T4> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAnyPromise(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4);
	
			// Methods
			private void TryCallContinuation();
			[AsyncStateMachine] // 0x00000001800F7610-0x00000001800F7660
			private UniTaskVoid RunTask0(UniTask<T0> task);
			[AsyncStateMachine] // 0x00000001800F7950-0x00000001800F79A0
			private UniTaskVoid RunTask1(UniTask<T1> task);
			[AsyncStateMachine] // 0x00000001800F7C10-0x00000001800F7C60
			private UniTaskVoid RunTask2(UniTask<T2> task);
			[AsyncStateMachine] // 0x00000001800F7E50-0x00000001800F7EA0
			private UniTaskVoid RunTask3(UniTask<T3> task);
			[AsyncStateMachine] // 0x00000001800F7FC0-0x00000001800F8010
			private UniTaskVoid RunTask4(UniTask<T4> task);
			public Awaiter GetAwaiter();
		}
	
		private class WhenAnyPromise<T0, T1, T2, T3, T4, T5> // TypeDefIndex: 8509
		{
			// Fields
			private T0 result0;
			private T1 result1;
			private T2 result2;
			private T3 result3;
			private T4 result4;
			private T5 result5;
			private ExceptionDispatchInfo exception;
			private Action whenComplete;
			private int completeCount;
			private int winArgumentIndex;
	
			// Properties
			private bool IsCompleted { get; }
	
			// Nested types
			public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8510
			{
				// Fields
				private WhenAnyPromise<T0, T1, T2, T3, T4, T5> parent;
	
				// Properties
				public bool IsCompleted { get; }
	
				// Constructors
				public Awaiter(WhenAnyPromise<T0, T1, T2, T3, T4, T5> parent);
	
				// Methods
				public ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>> GetResult();
				public void OnCompleted(Action continuation);
				public void UnsafeOnCompleted(Action continuation);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask0>d__14 : IAsyncStateMachine // TypeDefIndex: 8511
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T0> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5> <>4__this;
				private UniTask<T0> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask1>d__15 : IAsyncStateMachine // TypeDefIndex: 8512
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T1> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5> <>4__this;
				private UniTask<T1> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask2>d__16 : IAsyncStateMachine // TypeDefIndex: 8513
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T2> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5> <>4__this;
				private UniTask<T2> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask3>d__17 : IAsyncStateMachine // TypeDefIndex: 8514
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T3> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5> <>4__this;
				private UniTask<T3> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask4>d__18 : IAsyncStateMachine // TypeDefIndex: 8515
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T4> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5> <>4__this;
				private UniTask<T4> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask5>d__19 : IAsyncStateMachine // TypeDefIndex: 8516
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T5> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5> <>4__this;
				private UniTask<T5> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAnyPromise(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5);
	
			// Methods
			private void TryCallContinuation();
			[AsyncStateMachine] // 0x00000001800F90B0-0x00000001800F9100
			private UniTaskVoid RunTask0(UniTask<T0> task);
			[AsyncStateMachine] // 0x00000001800F9290-0x00000001800F92E0
			private UniTaskVoid RunTask1(UniTask<T1> task);
			[AsyncStateMachine] // 0x00000001800F9560-0x00000001800F95B0
			private UniTaskVoid RunTask2(UniTask<T2> task);
			[AsyncStateMachine] // 0x00000001800F9700-0x00000001800F9750
			private UniTaskVoid RunTask3(UniTask<T3> task);
			[AsyncStateMachine] // 0x00000001800F9930-0x00000001800F9980
			private UniTaskVoid RunTask4(UniTask<T4> task);
			[AsyncStateMachine] // 0x00000001800F9AF0-0x00000001800F9B40
			private UniTaskVoid RunTask5(UniTask<T5> task);
			public Awaiter GetAwaiter();
		}
	
		private class WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> // TypeDefIndex: 8517
		{
			// Fields
			private T0 result0;
			private T1 result1;
			private T2 result2;
			private T3 result3;
			private T4 result4;
			private T5 result5;
			private T6 result6;
			private ExceptionDispatchInfo exception;
			private Action whenComplete;
			private int completeCount;
			private int winArgumentIndex;
	
			// Properties
			private bool IsCompleted { get; }
	
			// Nested types
			public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8518
			{
				// Fields
				private WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> parent;
	
				// Properties
				public bool IsCompleted { get; }
	
				// Constructors
				public Awaiter(WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> parent);
	
				// Methods
				public ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>, ValueTuple<ValueTuple<bool, T6>>> GetResult();
				public void OnCompleted(Action continuation);
				public void UnsafeOnCompleted(Action continuation);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask0>d__15 : IAsyncStateMachine // TypeDefIndex: 8519
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T0> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> <>4__this;
				private UniTask<T0> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask1>d__16 : IAsyncStateMachine // TypeDefIndex: 8520
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T1> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> <>4__this;
				private UniTask<T1> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask2>d__17 : IAsyncStateMachine // TypeDefIndex: 8521
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T2> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> <>4__this;
				private UniTask<T2> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask3>d__18 : IAsyncStateMachine // TypeDefIndex: 8522
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T3> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> <>4__this;
				private UniTask<T3> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask4>d__19 : IAsyncStateMachine // TypeDefIndex: 8523
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T4> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> <>4__this;
				private UniTask<T4> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask5>d__20 : IAsyncStateMachine // TypeDefIndex: 8524
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T5> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> <>4__this;
				private UniTask<T5> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask6>d__21 : IAsyncStateMachine // TypeDefIndex: 8525
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T6> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> <>4__this;
				private UniTask<T6> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAnyPromise(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6);
	
			// Methods
			private void TryCallContinuation();
			[AsyncStateMachine] // 0x00000001800FC1D0-0x00000001800FC220
			private UniTaskVoid RunTask0(UniTask<T0> task);
			[AsyncStateMachine] // 0x00000001800FC500-0x00000001800FC550
			private UniTaskVoid RunTask1(UniTask<T1> task);
			[AsyncStateMachine] // 0x00000001800FC820-0x00000001800FC870
			private UniTaskVoid RunTask2(UniTask<T2> task);
			[AsyncStateMachine] // 0x00000001800FCAC0-0x00000001800FCB10
			private UniTaskVoid RunTask3(UniTask<T3> task);
			[AsyncStateMachine] // 0x00000001800FD040-0x00000001800FD090
			private UniTaskVoid RunTask4(UniTask<T4> task);
			[AsyncStateMachine] // 0x00000001800FD220-0x00000001800FD270
			private UniTaskVoid RunTask5(UniTask<T5> task);
			[AsyncStateMachine] // 0x00000001800FD490-0x00000001800FD4E0
			private UniTaskVoid RunTask6(UniTask<T6> task);
			public Awaiter GetAwaiter();
		}
	
		private class WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> // TypeDefIndex: 8526
		{
			// Fields
			private T0 result0;
			private T1 result1;
			private T2 result2;
			private T3 result3;
			private T4 result4;
			private T5 result5;
			private T6 result6;
			private T7 result7;
			private ExceptionDispatchInfo exception;
			private Action whenComplete;
			private int completeCount;
			private int winArgumentIndex;
	
			// Properties
			private bool IsCompleted { get; }
	
			// Nested types
			public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8527
			{
				// Fields
				private WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> parent;
	
				// Properties
				public bool IsCompleted { get; }
	
				// Constructors
				public Awaiter(WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> parent);
	
				// Methods
				public ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>, ValueTuple<ValueTuple<bool, T6>, ValueTuple<bool, T7>>> GetResult();
				public void OnCompleted(Action continuation);
				public void UnsafeOnCompleted(Action continuation);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask0>d__16 : IAsyncStateMachine // TypeDefIndex: 8528
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T0> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> <>4__this;
				private UniTask<T0> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask1>d__17 : IAsyncStateMachine // TypeDefIndex: 8529
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T1> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> <>4__this;
				private UniTask<T1> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask2>d__18 : IAsyncStateMachine // TypeDefIndex: 8530
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T2> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> <>4__this;
				private UniTask<T2> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask3>d__19 : IAsyncStateMachine // TypeDefIndex: 8531
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T3> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> <>4__this;
				private UniTask<T3> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask4>d__20 : IAsyncStateMachine // TypeDefIndex: 8532
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T4> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> <>4__this;
				private UniTask<T4> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask5>d__21 : IAsyncStateMachine // TypeDefIndex: 8533
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T5> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> <>4__this;
				private UniTask<T5> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask6>d__22 : IAsyncStateMachine // TypeDefIndex: 8534
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T6> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> <>4__this;
				private UniTask<T6> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private struct <RunTask7>d__23 : IAsyncStateMachine // TypeDefIndex: 8535
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T7> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> <>4__this;
				private UniTask<T7> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAnyPromise(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7);
	
			// Methods
			private void TryCallContinuation();
			[AsyncStateMachine] // 0x00000001800FE9A0-0x00000001800FE9F0
			private UniTaskVoid RunTask0(UniTask<T0> task);
			[AsyncStateMachine] // 0x00000001800FEAE0-0x00000001800FEB30
			private UniTaskVoid RunTask1(UniTask<T1> task);
			[AsyncStateMachine] // 0x00000001800FEC30-0x00000001800FEC80
			private UniTaskVoid RunTask2(UniTask<T2> task);
			[AsyncStateMachine] // 0x00000001800FEDE0-0x00000001800FEE30
			private UniTaskVoid RunTask3(UniTask<T3> task);
			[AsyncStateMachine] // 0x00000001800FF010-0x00000001800FF060
			private UniTaskVoid RunTask4(UniTask<T4> task);
			[AsyncStateMachine] // 0x00000001800FF380-0x00000001800FF3D0
			private UniTaskVoid RunTask5(UniTask<T5> task);
			[AsyncStateMachine] // 0x00000001800FF600-0x00000001800FF650
			private UniTaskVoid RunTask6(UniTask<T6> task);
			[AsyncStateMachine] // 0x00000001800FF850-0x00000001800FF8A0
			private UniTaskVoid RunTask7(UniTask<T7> task);
			public Awaiter GetAwaiter();
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <Run>d__42 : IAsyncStateMachine // TypeDefIndex: 8536
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
			public bool configureAwait; // 0x18
			public Action action; // 0x20
			private SwitchToThreadPoolAwaitable.Awaiter <>u__1; // 0x28
			private object <>7__wrap1; // 0x30
			private int <>7__wrap2; // 0x38
			private YieldAwaitable.Awaiter <>u__2; // 0x3C
	
			// Methods
			private void MoveNext(); // 0x0000000180321D10-0x0000000180321D20
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0500-0x00000001801F0510
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <Run>d__43 : IAsyncStateMachine // TypeDefIndex: 8537
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
			public bool configureAwait; // 0x18
			public Action<object> action; // 0x20
			public object state; // 0x28
			private SwitchToThreadPoolAwaitable.Awaiter <>u__1; // 0x30
			private object <>7__wrap1; // 0x38
			private int <>7__wrap2; // 0x40
			private YieldAwaitable.Awaiter <>u__2; // 0x44
	
			// Methods
			private void MoveNext(); // 0x0000000180321D20-0x0000000180321D30
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0500-0x00000001801F0510
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <Run>d__44<T> : IAsyncStateMachine // TypeDefIndex: 8538
		{
			// Fields
			public int <>1__state;
			public AsyncUniTaskMethodBuilder<T> <>t__builder;
			public bool configureAwait;
			public Func<T> func;
			private SwitchToThreadPoolAwaitable.Awaiter <>u__1;
			private object <>7__wrap1;
			private int <>7__wrap2;
			private T <>7__wrap3;
			private YieldAwaitable.Awaiter <>u__2;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <Run>d__45<T> : IAsyncStateMachine // TypeDefIndex: 8539
		{
			// Fields
			public int <>1__state;
			public AsyncUniTaskMethodBuilder<T> <>t__builder;
			public bool configureAwait;
			public Func<object, T> func;
			public object state;
			private SwitchToThreadPoolAwaitable.Awaiter <>u__1;
			private object <>7__wrap1;
			private int <>7__wrap2;
			private T <>7__wrap3;
			private YieldAwaitable.Awaiter <>u__2;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <WhenAll>d__57<T> : IAsyncStateMachine // TypeDefIndex: 8540
		{
			// Fields
			public int <>1__state;
			public AsyncUniTaskMethodBuilder<T[]> <>t__builder;
			public UniTask<T>[] tasks;
			private WhenAllPromise<T> <>u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <WhenAll>d__58<T> : IAsyncStateMachine // TypeDefIndex: 8541
		{
			// Fields
			public int <>1__state;
			public AsyncUniTaskMethodBuilder<T[]> <>t__builder;
			public IEnumerable<UniTask<T>> tasks;
			private WhenAllPromise<T> <>u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <WhenAll>d__59 : IAsyncStateMachine // TypeDefIndex: 8542
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
			public UniTask[] tasks; // 0x18
			private WhenAllPromise.Awaiter <>u__1; // 0x20
	
			// Methods
			private void MoveNext(); // 0x0000000180321D90-0x0000000180321DA0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0500-0x00000001801F0510
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <WhenAll>d__60 : IAsyncStateMachine // TypeDefIndex: 8543
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
			public IEnumerable<UniTask> tasks; // 0x18
			private WhenAllPromise.Awaiter <>u__1; // 0x20
	
			// Methods
			private void MoveNext(); // 0x0000000180321DA0-0x0000000180321DB0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0500-0x00000001801F0510
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <WhenAll>d__63<T1, T2> : IAsyncStateMachine // TypeDefIndex: 8544
		{
			// Fields
			public int <>1__state;
			[TupleElementNames] // 0x0000000180103560-0x00000001801035E0
			public AsyncUniTaskMethodBuilder<ValueTuple<T1, T2>> <>t__builder;
			public UniTask<T1> task1;
			public UniTask<T2> task2;
			private WhenAllPromise<T1, T2> <>u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <WhenAll>d__64<T1, T2, T3> : IAsyncStateMachine // TypeDefIndex: 8545
		{
			// Fields
			public int <>1__state;
			[TupleElementNames] // 0x0000000180103E40-0x0000000180103ED0
			public AsyncUniTaskMethodBuilder<ValueTuple<T1, T2, T3>> <>t__builder;
			public UniTask<T1> task1;
			public UniTask<T2> task2;
			public UniTask<T3> task3;
			private WhenAllPromise<T1, T2, T3> <>u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <WhenAll>d__65<T1, T2, T3, T4> : IAsyncStateMachine // TypeDefIndex: 8546
		{
			// Fields
			public int <>1__state;
			[TupleElementNames] // 0x00000001801046A0-0x0000000180104740
			public AsyncUniTaskMethodBuilder<ValueTuple<T1, T2, T3, T4>> <>t__builder;
			public UniTask<T1> task1;
			public UniTask<T2> task2;
			public UniTask<T3> task3;
			public UniTask<T4> task4;
			private WhenAllPromise<T1, T2, T3, T4> <>u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <WhenAll>d__66<T1, T2, T3, T4, T5> : IAsyncStateMachine // TypeDefIndex: 8547
		{
			// Fields
			public int <>1__state;
			[TupleElementNames] // 0x0000000180104D30-0x0000000180104DE0
			public AsyncUniTaskMethodBuilder<ValueTuple<T1, T2, T3, T4, T5>> <>t__builder;
			public UniTask<T1> task1;
			public UniTask<T2> task2;
			public UniTask<T3> task3;
			public UniTask<T4> task4;
			public UniTask<T5> task5;
			private WhenAllPromise<T1, T2, T3, T4, T5> <>u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <WhenAll>d__67<T1, T2, T3, T4, T5, T6> : IAsyncStateMachine // TypeDefIndex: 8548
		{
			// Fields
			public int <>1__state;
			[TupleElementNames] // 0x0000000180105340-0x0000000180105400
			public AsyncUniTaskMethodBuilder<ValueTuple<T1, T2, T3, T4, T5, T6>> <>t__builder;
			public UniTask<T1> task1;
			public UniTask<T2> task2;
			public UniTask<T3> task3;
			public UniTask<T4> task4;
			public UniTask<T5> task5;
			public UniTask<T6> task6;
			private WhenAllPromise<T1, T2, T3, T4, T5, T6> <>u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <WhenAll>d__68<T1, T2, T3, T4, T5, T6, T7> : IAsyncStateMachine // TypeDefIndex: 8549
		{
			// Fields
			public int <>1__state;
			[TupleElementNames] // 0x0000000180105730-0x0000000180105800
			public AsyncUniTaskMethodBuilder<ValueTuple<T1, T2, T3, T4, T5, T6, T7>> <>t__builder;
			public UniTask<T1> task1;
			public UniTask<T2> task2;
			public UniTask<T3> task3;
			public UniTask<T4> task4;
			public UniTask<T5> task5;
			public UniTask<T6> task6;
			public UniTask<T7> task7;
			private WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> <>u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <WhenAny>d__75<T0> : IAsyncStateMachine // TypeDefIndex: 8550
		{
			// Fields
			public int <>1__state;
			[TupleElementNames] // 0x0000000180105FD0-0x0000000180106050
			public AsyncUniTaskMethodBuilder<ValueTuple<bool, T0>> <>t__builder;
			public UniTask<T0> task0;
			public UniTask task1;
			private UnitWhenAnyPromise<T0> <>u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <WhenAny>d__76<T> : IAsyncStateMachine // TypeDefIndex: 8551
		{
			// Fields
			public int <>1__state;
			[TupleElementNames] // 0x0000000180106400-0x0000000180106480
			public AsyncUniTaskMethodBuilder<ValueTuple<int, T>> <>t__builder;
			public UniTask<T>[] tasks;
			private WhenAnyPromise<T> <>u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <WhenAny>d__77 : IAsyncStateMachine // TypeDefIndex: 8552
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskMethodBuilder<int> <>t__builder; // 0x08
			public UniTask[] tasks; // 0x20
			private WhenAnyPromise.Awaiter <>u__1; // 0x28
	
			// Methods
			private void MoveNext(); // 0x0000000180321DB0-0x0000000180321DC0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180321DC0-0x0000000180321E10
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <WhenAny>d__81<T0, T1> : IAsyncStateMachine // TypeDefIndex: 8553
		{
			// Fields
			public int <>1__state;
			[TupleElementNames] // 0x0000000180106BE0-0x0000000180106CA0
			public AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>>> <>t__builder;
			public UniTask<T0> task0;
			public UniTask<T1> task1;
			private WhenAnyPromise<T0, T1> <>u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <WhenAny>d__82<T0, T1, T2> : IAsyncStateMachine // TypeDefIndex: 8554
		{
			// Fields
			public int <>1__state;
			[TupleElementNames] // 0x0000000180107240-0x0000000180107320
			public AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>>> <>t__builder;
			public UniTask<T0> task0;
			public UniTask<T1> task1;
			public UniTask<T2> task2;
			private WhenAnyPromise<T0, T1, T2> <>u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <WhenAny>d__83<T0, T1, T2, T3> : IAsyncStateMachine // TypeDefIndex: 8555
		{
			// Fields
			public int <>1__state;
			[TupleElementNames] // 0x00000001801079A0-0x0000000180107AA0
			public AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>>> <>t__builder;
			public UniTask<T0> task0;
			public UniTask<T1> task1;
			public UniTask<T2> task2;
			public UniTask<T3> task3;
			private WhenAnyPromise<T0, T1, T2, T3> <>u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <WhenAny>d__84<T0, T1, T2, T3, T4> : IAsyncStateMachine // TypeDefIndex: 8556
		{
			// Fields
			public int <>1__state;
			[TupleElementNames] // 0x0000000180108350-0x0000000180108480
			public AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>>> <>t__builder;
			public UniTask<T0> task0;
			public UniTask<T1> task1;
			public UniTask<T2> task2;
			public UniTask<T3> task3;
			public UniTask<T4> task4;
			private WhenAnyPromise<T0, T1, T2, T3, T4> <>u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <WhenAny>d__85<T0, T1, T2, T3, T4, T5> : IAsyncStateMachine // TypeDefIndex: 8557
		{
			// Fields
			public int <>1__state;
			[TupleElementNames] // 0x0000000180108FF0-0x0000000180109150
			public AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>>> <>t__builder;
			public UniTask<T0> task0;
			public UniTask<T1> task1;
			public UniTask<T2> task2;
			public UniTask<T3> task3;
			public UniTask<T4> task4;
			public UniTask<T5> task5;
			private WhenAnyPromise<T0, T1, T2, T3, T4, T5> <>u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <WhenAny>d__86<T0, T1, T2, T3, T4, T5, T6> : IAsyncStateMachine // TypeDefIndex: 8558
		{
			// Fields
			public int <>1__state;
			[TupleElementNames] // 0x000000018010AC10-0x000000018010ADB0
			public AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>, ValueTuple<ValueTuple<bool, T6>>>> <>t__builder;
			public UniTask<T0> task0;
			public UniTask<T1> task1;
			public UniTask<T2> task2;
			public UniTask<T3> task3;
			public UniTask<T4> task4;
			public UniTask<T5> task5;
			public UniTask<T6> task6;
			private WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> <>u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <WhenAny>d__87<T0, T1, T2, T3, T4, T5, T6, T7> : IAsyncStateMachine // TypeDefIndex: 8559
		{
			// Fields
			public int <>1__state;
			[TupleElementNames] // 0x000000018010B620-0x000000018010B7F0
			public AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>, ValueTuple<ValueTuple<bool, T6>, ValueTuple<bool, T7>>>> <>t__builder;
			public UniTask<T0> task0;
			public UniTask<T1> task1;
			public UniTask<T2> task2;
			public UniTask<T3> task3;
			public UniTask<T4> task4;
			public UniTask<T5> task5;
			public UniTask<T6> task6;
			public UniTask<T7> task7;
			private WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> <>u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 8560
		{
			// Fields
			public static readonly <>c <>9; // 0x00
	
			// Constructors
			static <>c(); // 0x00000001820E14E0-0x00000001820E1540
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal UniTask <.cctor>b__96_0(); // 0x00000001820E1470-0x00000001820E14E0
		}
	
		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public UniTask(IAwaiter awaiter); // 0x0000000180004C60-0x0000000180004C90
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public UniTask(Func<UniTask> factory); // 0x0000000180254350-0x00000001802543C0
		static UniTask(); // 0x0000000181673070-0x0000000181673230
	
		// Methods
		public static IEnumerator ToCoroutine(Func<UniTask> taskFactory); // 0x0000000181672BB0-0x0000000181672CB0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public void GetResult(); // 0x0000000180254240-0x0000000180254290
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public Awaiter GetAwaiter(); // 0x0000000180004C30-0x0000000180004C40
		public UniTask<bool> SuppressCancellationThrow(); // 0x0000000180254290-0x00000001802542B0
		public bool Equals(UniTask other); // 0x0000000180254200-0x0000000180254220
		public override int GetHashCode(); // 0x0000000180254220-0x0000000180254240
		public override string ToString(); // 0x00000001802542B0-0x0000000180254350
		public static implicit operator UniTask<AsyncUnit>(UniTask task); // 0x0000000181673230-0x0000000181673310
		public static YieldAwaitable Yield(PlayerLoopTiming timing = PlayerLoopTiming.Update /* Metadata: 0x0074335D */); // 0x00000001804259C0-0x0000000180425D40
		public static UniTask Yield(PlayerLoopTiming timing, CancellationToken cancellationToken); // 0x0000000181673000-0x0000000181673070
		public static UniTask<int> DelayFrame(int delayFrameCount, PlayerLoopTiming delayTiming = PlayerLoopTiming.Update /* Metadata: 0x00743361 */, CancellationToken cancellationToken = default); // 0x00000001816722C0-0x00000001816723D0
		public static UniTask Delay(int millisecondsDelay, bool ignoreTimeScale = false /* Metadata: 0x00743365 */, PlayerLoopTiming delayTiming = PlayerLoopTiming.Update /* Metadata: 0x00743366 */, CancellationToken cancellationToken = default); // 0x00000001816723D0-0x0000000181672550
		public static UniTask Delay(TimeSpan delayTimeSpan, bool ignoreTimeScale = false /* Metadata: 0x0074336A */, PlayerLoopTiming delayTiming = PlayerLoopTiming.Update /* Metadata: 0x0074336B */, CancellationToken cancellationToken = default); // 0x0000000181672550-0x00000001816726E0
		public static UniTask FromException(Exception ex); // 0x00000001816727E0-0x00000001816728D0
		public static UniTask<T> FromException<T>(Exception ex);
		public static UniTask<T> FromResult<T>(T value);
		public static UniTask FromCanceled(); // 0x0000000181672780-0x00000001816727E0
		public static UniTask<T> FromCanceled<T>();
		public static UniTask FromCanceled(CancellationToken token); // 0x00000001816726E0-0x0000000181672780
		public static UniTask<T> FromCanceled<T>(CancellationToken token);
		public static UniTask<T> Lazy<T>(Func<UniTask<T>> factory);
		public static void Void(Func<UniTask> asyncAction); // 0x0000000181672CB0-0x0000000181672D00
		public static void Void<T>(Func<T, UniTask> asyncAction, T state);
		[AsyncStateMachine] // 0x00000001800E2070-0x00000001800E20C0
		public static UniTask Run(Action action, bool configureAwait = true /* Metadata: 0x0074336F */); // 0x00000001816728D0-0x0000000181672960
		[AsyncStateMachine] // 0x00000001800E2220-0x00000001800E2270
		public static UniTask Run(Action<object> action, object state, bool configureAwait = true /* Metadata: 0x00743370 */); // 0x0000000181672960-0x0000000181672B60
		[AsyncStateMachine] // 0x00000001800E24E0-0x00000001800E2530
		public static UniTask<T> Run<T>(Func<T> func, bool configureAwait = true /* Metadata: 0x00743371 */);
		[AsyncStateMachine] // 0x00000001800E2710-0x00000001800E2760
		public static UniTask<T> Run<T>(Func<object, T> func, object state, bool configureAwait = true /* Metadata: 0x00743372 */);
		public static SwitchToMainThreadAwaitable SwitchToMainThread(); // 0x00000001803C28F0-0x00000001803C2900
		public static SwitchToThreadPoolAwaitable SwitchToThreadPool(); // 0x00000001803C28F0-0x00000001803C2900
		public static SwitchToTaskPoolAwaitable SwitchToTaskPool(); // 0x00000001803C28F0-0x00000001803C2900
		public static SwitchToSynchronizationContextAwaitable SwitchToSynchronizationContext(SynchronizationContext syncContext); // 0x0000000181672B60-0x0000000181672BB0
		public static UniTask WaitUntil(Func<bool> predicate, PlayerLoopTiming timing = PlayerLoopTiming.Update /* Metadata: 0x00743373 */, CancellationToken cancellationToken = default); // 0x0000000181672D00-0x0000000181672D90
		public static UniTask WaitWhile(Func<bool> predicate, PlayerLoopTiming timing = PlayerLoopTiming.Update /* Metadata: 0x00743377 */, CancellationToken cancellationToken = default); // 0x0000000181672D90-0x0000000181672E20
		public static UniTask<U> WaitUntilValueChanged<T, U>(T target, Func<T, U> monitorFunction, PlayerLoopTiming monitorTiming = PlayerLoopTiming.Update /* Metadata: 0x0074337B */, IEqualityComparer<U> equalityComparer = null, CancellationToken cancellationToken = default)
			where T : class;
		[AsyncStateMachine] // 0x00000001800E2980-0x00000001800E29D0
		public static UniTask<T[]> WhenAll<T>(params /* 0x00000001800B36B0-0x00000001800B36C0 */ UniTask<T>[] tasks);
		[AsyncStateMachine] // 0x00000001800E2D00-0x00000001800E2D50
		public static UniTask<T[]> WhenAll<T>(IEnumerable<UniTask<T>> tasks);
		[AsyncStateMachine] // 0x00000001800E2DC0-0x00000001800E2E10
		public static UniTask WhenAll(params /* 0x00000001800B36B0-0x00000001800B36C0 */ UniTask[] tasks); // 0x0000000181672E20-0x0000000181672EA0
		[AsyncStateMachine] // 0x00000001800E30F0-0x00000001800E3140
		public static UniTask WhenAll(IEnumerable<UniTask> tasks); // 0x0000000181672EA0-0x0000000181672F20
		[AsyncStateMachine] // 0x00000001800E32A0-0x00000001800E32F0
		public static UniTask<ValueTuple<T1, T2>> WhenAll<T1, T2>(UniTask<T1> task1, UniTask<T2> task2);
		[AsyncStateMachine] // 0x00000001800E35B0-0x00000001800E3600
		public static UniTask<ValueTuple<T1, T2, T3>> WhenAll<T1, T2, T3>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3);
		[AsyncStateMachine] // 0x00000001800E38C0-0x00000001800E3910
		public static UniTask<ValueTuple<T1, T2, T3, T4>> WhenAll<T1, T2, T3, T4>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4);
		[AsyncStateMachine] // 0x00000001800E3B30-0x00000001800E3B80
		public static UniTask<ValueTuple<T1, T2, T3, T4, T5>> WhenAll<T1, T2, T3, T4, T5>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5);
		[AsyncStateMachine] // 0x00000001800E3E20-0x00000001800E3E70
		public static UniTask<ValueTuple<T1, T2, T3, T4, T5, T6>> WhenAll<T1, T2, T3, T4, T5, T6>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6);
		[AsyncStateMachine] // 0x00000001800E4120-0x00000001800E4170
		public static UniTask<ValueTuple<T1, T2, T3, T4, T5, T6, T7>> WhenAll<T1, T2, T3, T4, T5, T6, T7>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7);
		[AsyncStateMachine] // 0x00000001800E4480-0x00000001800E44D0
		public static UniTask<ValueTuple<bool, T0>> WhenAny<T0>(UniTask<T0> task0, UniTask task1);
		[AsyncStateMachine] // 0x00000001800E4720-0x00000001800E4770
		public static UniTask<ValueTuple<int, T>> WhenAny<T>(params /* 0x00000001800B36B0-0x00000001800B36C0 */ UniTask<T>[] tasks);
		[AsyncStateMachine] // 0x00000001800E4C40-0x00000001800E4C90
		public static UniTask<int> WhenAny(params /* 0x00000001800B36B0-0x00000001800B36C0 */ UniTask[] tasks); // 0x0000000181672F20-0x0000000181673000
		[AsyncStateMachine] // 0x00000001800E5100-0x00000001800E5150
		public static UniTask<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>>> WhenAny<T0, T1>(UniTask<T0> task0, UniTask<T1> task1);
		[AsyncStateMachine] // 0x00000001800E5450-0x00000001800E54A0
		public static UniTask<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>>> WhenAny<T0, T1, T2>(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2);
		[AsyncStateMachine] // 0x00000001800E5910-0x00000001800E5960
		public static UniTask<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>>> WhenAny<T0, T1, T2, T3>(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3);
		[AsyncStateMachine] // 0x00000001800E5B90-0x00000001800E5BE0
		public static UniTask<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>>> WhenAny<T0, T1, T2, T3, T4>(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4);
		[AsyncStateMachine] // 0x00000001800E5E70-0x00000001800E5EC0
		public static UniTask<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>>> WhenAny<T0, T1, T2, T3, T4, T5>(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5);
		[AsyncStateMachine] // 0x00000001800E6110-0x00000001800E6160
		public static UniTask<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>, ValueTuple<ValueTuple<bool, T6>>>> WhenAny<T0, T1, T2, T3, T4, T5, T6>(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6);
		[AsyncStateMachine] // 0x00000001800E6440-0x00000001800E6490
		public static UniTask<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>, ValueTuple<ValueTuple<bool, T6>, ValueTuple<bool, T7>>>> WhenAny<T0, T1, T2, T3, T4, T5, T6, T7>(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7);
	}
}
