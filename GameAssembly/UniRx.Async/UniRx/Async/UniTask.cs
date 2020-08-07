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

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async
{
	[AsyncMethodBuilder] // 0x000000018023FF80-0x000000018023FFD0
	public struct UniTask : IEquatable<UniRx.Async.UniTask> // TypeDefIndex: 8585
	{
		// Fields
		private static readonly UniTask CanceledUniTask; // 0x00
		private static readonly UniTask<AsyncUnit> DefaultAsyncUnitTask; // 0x08
		private readonly IAwaiter awaiter; // 0x00
	
		// Properties
		public static UniTask CompletedTask { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public AwaiterStatus Status { get; } // 0x000000018010F1B0-0x000000018010F220 
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public bool IsCompleted { get; } // 0x000000018010F160-0x000000018010F1B0 
	
		// Nested types
		private class YieldPromise : PlayerLoopReusablePromiseBase // TypeDefIndex: 8586
		{
			// Constructors
			public YieldPromise(PlayerLoopTiming timing, CancellationToken cancellationToken); // 0x0000000181ACE220-0x0000000181ACE260
	
			// Methods
			protected override void OnRunningStart(); // 0x00000001803774A0-0x00000001803774B0
			public override bool MoveNext(); // 0x0000000181ACE1B0-0x0000000181ACE220
		}
	
		private class DelayFramePromise : PlayerLoopReusablePromiseBase<int> // TypeDefIndex: 8587
		{
			// Fields
			private readonly int delayFrameCount; // 0x48
			private int currentFrameCount; // 0x4C
	
			// Constructors
			public DelayFramePromise(int delayFrameCount, PlayerLoopTiming timing, CancellationToken cancellationToken); // 0x0000000181AC5360-0x0000000181AC53E0
	
			// Methods
			protected override void OnRunningStart(); // 0x0000000181AC5350-0x0000000181AC5360
			public override bool MoveNext(); // 0x0000000181AC52A0-0x0000000181AC5350
		}
	
		private class DelayPromise : PlayerLoopReusablePromiseBase // TypeDefIndex: 8588
		{
			// Fields
			private readonly float delayFrameTimeSpan; // 0x40
			private float elapsed; // 0x44
	
			// Constructors
			public DelayPromise(TimeSpan delayFrameTimeSpan, PlayerLoopTiming timing, CancellationToken cancellationToken); // 0x0000000181AC5490-0x0000000181AC54E0
	
			// Methods
			protected override void OnRunningStart(); // 0x0000000181AC5480-0x0000000181AC5490
			public override bool MoveNext(); // 0x0000000181AC54E0-0x0000000181AC5580
		}
	
		private class DelayIgnoreTimeScalePromise : PlayerLoopReusablePromiseBase // TypeDefIndex: 8589
		{
			// Fields
			private readonly float delayFrameTimeSpan; // 0x40
			private float elapsed; // 0x44
	
			// Constructors
			public DelayIgnoreTimeScalePromise(TimeSpan delayFrameTimeSpan, PlayerLoopTiming timing, CancellationToken cancellationToken); // 0x0000000181AC5490-0x0000000181AC54E0
	
			// Methods
			protected override void OnRunningStart(); // 0x0000000181AC5480-0x0000000181AC5490
			public override bool MoveNext(); // 0x0000000181AC53E0-0x0000000181AC5480
		}
	
		private static class CanceledUniTaskCache<T> // TypeDefIndex: 8590
		{
			// Fields
			public static readonly UniTask<T> Task;
	
			// Constructors
			static CanceledUniTaskCache();
		}
	
		private class WaitUntilPromise : PlayerLoopReusablePromiseBase // TypeDefIndex: 8591
		{
			// Fields
			private readonly Func<bool> predicate; // 0x40
	
			// Constructors
			public WaitUntilPromise(Func<bool> predicate, PlayerLoopTiming timing, CancellationToken cancellationToken); // 0x0000000181ACDBE0-0x0000000181ACDC20
	
			// Methods
			protected override void OnRunningStart(); // 0x00000001803774A0-0x00000001803774B0
			public override bool MoveNext(); // 0x0000000181ACDAD0-0x0000000181ACDBE0
		}
	
		private class WaitWhilePromise : PlayerLoopReusablePromiseBase // TypeDefIndex: 8592
		{
			// Fields
			private readonly Func<bool> predicate; // 0x40
	
			// Constructors
			public WaitWhilePromise(Func<bool> predicate, PlayerLoopTiming timing, CancellationToken cancellationToken); // 0x0000000181ACDBE0-0x0000000181ACDC20
	
			// Methods
			protected override void OnRunningStart(); // 0x00000001803774A0-0x00000001803774B0
			public override bool MoveNext(); // 0x0000000181ACDC20-0x0000000181ACDD30
		}
	
		private class WaitUntilValueChangedUnityObjectPromise<T, U> : PlayerLoopReusablePromiseBase<U> // TypeDefIndex: 8593
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
	
		private class WaitUntilValueChangedStandardObjectPromise<T, U> : PlayerLoopReusablePromiseBase<U> // TypeDefIndex: 8594
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
	
		private class WhenAllPromise<T1, T2> // TypeDefIndex: 8595
		{
			// Fields
			private const int MaxCount = 2; // Metadata: 0x0077806D
			private T1 result1;
			private T2 result2;
			private ExceptionDispatchInfo exception;
			private int completeCount;
			private Action whenComplete;
	
			// Nested types
			public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8596
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
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask1Async>d__9 : IAsyncStateMachine // TypeDefIndex: 8597
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T1> task;
				public WhenAllPromise<T1, T2> <>4__this;
				private UniTask<T1> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask2Async>d__11 : IAsyncStateMachine // TypeDefIndex: 8598
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T2> task;
				public WhenAllPromise<T1, T2> <>4__this;
				private UniTask<T2> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAllPromise(UniTask<T1> task1, UniTask<T2> task2);
	
			// Methods
			private void TryCallContinuation();
			private void RunTask1(UniTask<T1> task);
			[AsyncStateMachine] // 0x0000000180245D00-0x0000000180245D50
			private UniTaskVoid RunTask1Async(UniTask<T1> task);
			private void RunTask2(UniTask<T2> task);
			[AsyncStateMachine] // 0x0000000180245F00-0x0000000180245F50
			private UniTaskVoid RunTask2Async(UniTask<T2> task);
			public Awaiter GetAwaiter();
		}
	
		private class WhenAllPromise<T1, T2, T3> // TypeDefIndex: 8599
		{
			// Fields
			private const int MaxCount = 3; // Metadata: 0x00778071
			private T1 result1;
			private T2 result2;
			private T3 result3;
			private ExceptionDispatchInfo exception;
			private int completeCount;
			private Action whenComplete;
	
			// Nested types
			public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8600
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
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask1Async>d__10 : IAsyncStateMachine // TypeDefIndex: 8601
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T1> task;
				public WhenAllPromise<T1, T2, T3> <>4__this;
				private UniTask<T1> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask2Async>d__12 : IAsyncStateMachine // TypeDefIndex: 8602
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T2> task;
				public WhenAllPromise<T1, T2, T3> <>4__this;
				private UniTask<T2> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask3Async>d__14 : IAsyncStateMachine // TypeDefIndex: 8603
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T3> task;
				public WhenAllPromise<T1, T2, T3> <>4__this;
				private UniTask<T3> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAllPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3);
	
			// Methods
			private void TryCallContinuation();
			private void RunTask1(UniTask<T1> task);
			[AsyncStateMachine] // 0x0000000180246720-0x0000000180246770
			private UniTaskVoid RunTask1Async(UniTask<T1> task);
			private void RunTask2(UniTask<T2> task);
			[AsyncStateMachine] // 0x0000000180246A20-0x0000000180246A70
			private UniTaskVoid RunTask2Async(UniTask<T2> task);
			private void RunTask3(UniTask<T3> task);
			[AsyncStateMachine] // 0x0000000180246E80-0x0000000180246ED0
			private UniTaskVoid RunTask3Async(UniTask<T3> task);
			public Awaiter GetAwaiter();
		}
	
		private class WhenAllPromise<T1, T2, T3, T4> // TypeDefIndex: 8604
		{
			// Fields
			private const int MaxCount = 4; // Metadata: 0x00778075
			private T1 result1;
			private T2 result2;
			private T3 result3;
			private T4 result4;
			private ExceptionDispatchInfo exception;
			private int completeCount;
			private Action whenComplete;
	
			// Nested types
			public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8605
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
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask1Async>d__11 : IAsyncStateMachine // TypeDefIndex: 8606
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T1> task;
				public WhenAllPromise<T1, T2, T3, T4> <>4__this;
				private UniTask<T1> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask2Async>d__13 : IAsyncStateMachine // TypeDefIndex: 8607
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T2> task;
				public WhenAllPromise<T1, T2, T3, T4> <>4__this;
				private UniTask<T2> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask3Async>d__15 : IAsyncStateMachine // TypeDefIndex: 8608
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T3> task;
				public WhenAllPromise<T1, T2, T3, T4> <>4__this;
				private UniTask<T3> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask4Async>d__17 : IAsyncStateMachine // TypeDefIndex: 8609
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T4> task;
				public WhenAllPromise<T1, T2, T3, T4> <>4__this;
				private UniTask<T4> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAllPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4);
	
			// Methods
			private void TryCallContinuation();
			private void RunTask1(UniTask<T1> task);
			[AsyncStateMachine] // 0x0000000180247810-0x0000000180247860
			private UniTaskVoid RunTask1Async(UniTask<T1> task);
			private void RunTask2(UniTask<T2> task);
			[AsyncStateMachine] // 0x0000000180247BB0-0x0000000180247C00
			private UniTaskVoid RunTask2Async(UniTask<T2> task);
			private void RunTask3(UniTask<T3> task);
			[AsyncStateMachine] // 0x0000000180247D90-0x0000000180247DE0
			private UniTaskVoid RunTask3Async(UniTask<T3> task);
			private void RunTask4(UniTask<T4> task);
			[AsyncStateMachine] // 0x0000000180247FA0-0x0000000180247FF0
			private UniTaskVoid RunTask4Async(UniTask<T4> task);
			public Awaiter GetAwaiter();
		}
	
		private class WhenAllPromise<T1, T2, T3, T4, T5> // TypeDefIndex: 8610
		{
			// Fields
			private const int MaxCount = 5; // Metadata: 0x00778079
			private T1 result1;
			private T2 result2;
			private T3 result3;
			private T4 result4;
			private T5 result5;
			private ExceptionDispatchInfo exception;
			private int completeCount;
			private Action whenComplete;
	
			// Nested types
			public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8611
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
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask1Async>d__12 : IAsyncStateMachine // TypeDefIndex: 8612
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T1> task;
				public WhenAllPromise<T1, T2, T3, T4, T5> <>4__this;
				private UniTask<T1> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask2Async>d__14 : IAsyncStateMachine // TypeDefIndex: 8613
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T2> task;
				public WhenAllPromise<T1, T2, T3, T4, T5> <>4__this;
				private UniTask<T2> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask3Async>d__16 : IAsyncStateMachine // TypeDefIndex: 8614
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T3> task;
				public WhenAllPromise<T1, T2, T3, T4, T5> <>4__this;
				private UniTask<T3> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask4Async>d__18 : IAsyncStateMachine // TypeDefIndex: 8615
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T4> task;
				public WhenAllPromise<T1, T2, T3, T4, T5> <>4__this;
				private UniTask<T4> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask5Async>d__20 : IAsyncStateMachine // TypeDefIndex: 8616
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T5> task;
				public WhenAllPromise<T1, T2, T3, T4, T5> <>4__this;
				private UniTask<T5> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAllPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5);
	
			// Methods
			private void TryCallContinuation();
			private void RunTask1(UniTask<T1> task);
			[AsyncStateMachine] // 0x00000001802487F0-0x0000000180248840
			private UniTaskVoid RunTask1Async(UniTask<T1> task);
			private void RunTask2(UniTask<T2> task);
			[AsyncStateMachine] // 0x0000000180248A70-0x0000000180248AC0
			private UniTaskVoid RunTask2Async(UniTask<T2> task);
			private void RunTask3(UniTask<T3> task);
			[AsyncStateMachine] // 0x0000000180248D20-0x0000000180248D70
			private UniTaskVoid RunTask3Async(UniTask<T3> task);
			private void RunTask4(UniTask<T4> task);
			[AsyncStateMachine] // 0x0000000180248FF0-0x0000000180249040
			private UniTaskVoid RunTask4Async(UniTask<T4> task);
			private void RunTask5(UniTask<T5> task);
			[AsyncStateMachine] // 0x0000000180249280-0x00000001802492D0
			private UniTaskVoid RunTask5Async(UniTask<T5> task);
			public Awaiter GetAwaiter();
		}
	
		private class WhenAllPromise<T1, T2, T3, T4, T5, T6> // TypeDefIndex: 8617
		{
			// Fields
			private const int MaxCount = 6; // Metadata: 0x0077807D
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
			public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8618
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
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask1Async>d__13 : IAsyncStateMachine // TypeDefIndex: 8619
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T1> task;
				public WhenAllPromise<T1, T2, T3, T4, T5, T6> <>4__this;
				private UniTask<T1> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask2Async>d__15 : IAsyncStateMachine // TypeDefIndex: 8620
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T2> task;
				public WhenAllPromise<T1, T2, T3, T4, T5, T6> <>4__this;
				private UniTask<T2> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask3Async>d__17 : IAsyncStateMachine // TypeDefIndex: 8621
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T3> task;
				public WhenAllPromise<T1, T2, T3, T4, T5, T6> <>4__this;
				private UniTask<T3> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask4Async>d__19 : IAsyncStateMachine // TypeDefIndex: 8622
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T4> task;
				public WhenAllPromise<T1, T2, T3, T4, T5, T6> <>4__this;
				private UniTask<T4> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask5Async>d__21 : IAsyncStateMachine // TypeDefIndex: 8623
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T5> task;
				public WhenAllPromise<T1, T2, T3, T4, T5, T6> <>4__this;
				private UniTask<T5> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask6Async>d__23 : IAsyncStateMachine // TypeDefIndex: 8624
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T6> task;
				public WhenAllPromise<T1, T2, T3, T4, T5, T6> <>4__this;
				private UniTask<T6> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAllPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6);
	
			// Methods
			private void TryCallContinuation();
			private void RunTask1(UniTask<T1> task);
			[AsyncStateMachine] // 0x000000018024AF80-0x000000018024AFD0
			private UniTaskVoid RunTask1Async(UniTask<T1> task);
			private void RunTask2(UniTask<T2> task);
			[AsyncStateMachine] // 0x000000018024B080-0x000000018024B0D0
			private UniTaskVoid RunTask2Async(UniTask<T2> task);
			private void RunTask3(UniTask<T3> task);
			[AsyncStateMachine] // 0x000000018024B350-0x000000018024B3A0
			private UniTaskVoid RunTask3Async(UniTask<T3> task);
			private void RunTask4(UniTask<T4> task);
			[AsyncStateMachine] // 0x000000018024B5A0-0x000000018024B5F0
			private UniTaskVoid RunTask4Async(UniTask<T4> task);
			private void RunTask5(UniTask<T5> task);
			[AsyncStateMachine] // 0x000000018024B850-0x000000018024B8A0
			private UniTaskVoid RunTask5Async(UniTask<T5> task);
			private void RunTask6(UniTask<T6> task);
			[AsyncStateMachine] // 0x000000018024BB10-0x000000018024BB60
			private UniTaskVoid RunTask6Async(UniTask<T6> task);
			public Awaiter GetAwaiter();
		}
	
		private class WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> // TypeDefIndex: 8625
		{
			// Fields
			private const int MaxCount = 7; // Metadata: 0x00778081
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
			public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8626
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
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask1Async>d__14 : IAsyncStateMachine // TypeDefIndex: 8627
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T1> task;
				public WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> <>4__this;
				private UniTask<T1> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask2Async>d__16 : IAsyncStateMachine // TypeDefIndex: 8628
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T2> task;
				public WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> <>4__this;
				private UniTask<T2> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask3Async>d__18 : IAsyncStateMachine // TypeDefIndex: 8629
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T3> task;
				public WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> <>4__this;
				private UniTask<T3> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask4Async>d__20 : IAsyncStateMachine // TypeDefIndex: 8630
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T4> task;
				public WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> <>4__this;
				private UniTask<T4> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask5Async>d__22 : IAsyncStateMachine // TypeDefIndex: 8631
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T5> task;
				public WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> <>4__this;
				private UniTask<T5> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask6Async>d__24 : IAsyncStateMachine // TypeDefIndex: 8632
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T6> task;
				public WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> <>4__this;
				private UniTask<T6> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask7Async>d__26 : IAsyncStateMachine // TypeDefIndex: 8633
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T7> task;
				public WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> <>4__this;
				private UniTask<T7> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAllPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7);
	
			// Methods
			private void TryCallContinuation();
			private void RunTask1(UniTask<T1> task);
			[AsyncStateMachine] // 0x000000018024CE40-0x000000018024CE90
			private UniTaskVoid RunTask1Async(UniTask<T1> task);
			private void RunTask2(UniTask<T2> task);
			[AsyncStateMachine] // 0x000000018024CFA0-0x000000018024CFF0
			private UniTaskVoid RunTask2Async(UniTask<T2> task);
			private void RunTask3(UniTask<T3> task);
			[AsyncStateMachine] // 0x000000018024D210-0x000000018024D260
			private UniTaskVoid RunTask3Async(UniTask<T3> task);
			private void RunTask4(UniTask<T4> task);
			[AsyncStateMachine] // 0x000000018024D490-0x000000018024D4E0
			private UniTaskVoid RunTask4Async(UniTask<T4> task);
			private void RunTask5(UniTask<T5> task);
			[AsyncStateMachine] // 0x000000018024D5A0-0x000000018024D5F0
			private UniTaskVoid RunTask5Async(UniTask<T5> task);
			private void RunTask6(UniTask<T6> task);
			[AsyncStateMachine] // 0x000000018024D860-0x000000018024D8B0
			private UniTaskVoid RunTask6Async(UniTask<T6> task);
			private void RunTask7(UniTask<T7> task);
			[AsyncStateMachine] // 0x000000018024DB60-0x000000018024DBB0
			private UniTaskVoid RunTask7Async(UniTask<T7> task);
			public Awaiter GetAwaiter();
		}
	
		private class WhenAllPromise<T> // TypeDefIndex: 8634
		{
			// Fields
			private readonly T[] result;
			private int completeCount;
			private Action whenComplete;
			private ExceptionDispatchInfo exception;
	
			// Nested types
			public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8635
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
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask>d__6 : IAsyncStateMachine // TypeDefIndex: 8636
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
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAllPromise(UniTask<T>[] tasks, int tasksLength);
	
			// Methods
			private void TryCallContinuation();
			[AsyncStateMachine] // 0x000000018024F7F0-0x000000018024F840
			private UniTaskVoid RunTask(UniTask<T> task, int index);
			public Awaiter GetAwaiter();
		}
	
		private class WhenAllPromise // TypeDefIndex: 8637
		{
			// Fields
			private int completeCount; // 0x10
			private int resultLength; // 0x14
			private Action whenComplete; // 0x18
			private ExceptionDispatchInfo exception; // 0x20
	
			// Nested types
			public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8638
			{
				// Fields
				private WhenAllPromise parent; // 0x00
	
				// Properties
				public bool IsCompleted { get; } // 0x000000018010EB40-0x000000018010EB80 
	
				// Constructors
				public Awaiter(WhenAllPromise parent); // 0x000000018001A8F0-0x000000018001A900
	
				// Methods
				public void GetResult(); // 0x000000018010E8E0-0x000000018010E930
				public void OnCompleted(Action continuation); // 0x000000018010EA00-0x000000018010EA10
				public void UnsafeOnCompleted(Action continuation); // 0x000000018010EA30-0x000000018010EA40
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask>d__6 : IAsyncStateMachine // TypeDefIndex: 8639
			{
				// Fields
				public int <>1__state; // 0x00
				public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x08
				public UniTask task; // 0x10
				public WhenAllPromise <>4__this; // 0x18
				private Awaiter <>u__1; // 0x20
	
				// Methods
				private void MoveNext(); // 0x000000018010ED60-0x000000018010ED70
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002020-0x0000000180002030
			}
	
			// Constructors
			public WhenAllPromise(UniTask[] tasks, int tasksLength); // 0x0000000181ACDE00-0x0000000181ACDFC0
	
			// Methods
			private void TryCallContinuation(); // 0x0000000181ACDDD0-0x0000000181ACDE00
			[AsyncStateMachine] // 0x0000000180251310-0x0000000180251360
			private UniTaskVoid RunTask(UniTask task, int index); // 0x0000000181ACDD30-0x0000000181ACDDD0
			public Awaiter GetAwaiter(); // 0x0000000180411160-0x0000000180411170
		}
	
		private class WhenAnyPromise<T0, T1> // TypeDefIndex: 8640
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
			public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8641
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
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask0>d__10 : IAsyncStateMachine // TypeDefIndex: 8642
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T0> task;
				public WhenAnyPromise<T0, T1> <>4__this;
				private UniTask<T0> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask1>d__11 : IAsyncStateMachine // TypeDefIndex: 8643
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T1> task;
				public WhenAnyPromise<T0, T1> <>4__this;
				private UniTask<T1> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAnyPromise(UniTask<T0> task0, UniTask<T1> task1);
	
			// Methods
			private void TryCallContinuation();
			[AsyncStateMachine] // 0x0000000180251A30-0x0000000180251A80
			private UniTaskVoid RunTask0(UniTask<T0> task);
			[AsyncStateMachine] // 0x0000000180251D10-0x0000000180251D60
			private UniTaskVoid RunTask1(UniTask<T1> task);
			public Awaiter GetAwaiter();
		}
	
		private class WhenAnyPromise<T0, T1, T2> // TypeDefIndex: 8644
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
			public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8645
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
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask0>d__11 : IAsyncStateMachine // TypeDefIndex: 8646
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T0> task;
				public WhenAnyPromise<T0, T1, T2> <>4__this;
				private UniTask<T0> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask1>d__12 : IAsyncStateMachine // TypeDefIndex: 8647
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T1> task;
				public WhenAnyPromise<T0, T1, T2> <>4__this;
				private UniTask<T1> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask2>d__13 : IAsyncStateMachine // TypeDefIndex: 8648
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T2> task;
				public WhenAnyPromise<T0, T1, T2> <>4__this;
				private UniTask<T2> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAnyPromise(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2);
	
			// Methods
			private void TryCallContinuation();
			[AsyncStateMachine] // 0x00000001802528C0-0x0000000180252910
			private UniTaskVoid RunTask0(UniTask<T0> task);
			[AsyncStateMachine] // 0x0000000180252BB0-0x0000000180252C00
			private UniTaskVoid RunTask1(UniTask<T1> task);
			[AsyncStateMachine] // 0x0000000180252E50-0x0000000180252EA0
			private UniTaskVoid RunTask2(UniTask<T2> task);
			public Awaiter GetAwaiter();
		}
	
		private class WhenAnyPromise<T0, T1, T2, T3> // TypeDefIndex: 8649
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
			public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8650
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
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask0>d__12 : IAsyncStateMachine // TypeDefIndex: 8651
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T0> task;
				public WhenAnyPromise<T0, T1, T2, T3> <>4__this;
				private UniTask<T0> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask1>d__13 : IAsyncStateMachine // TypeDefIndex: 8652
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T1> task;
				public WhenAnyPromise<T0, T1, T2, T3> <>4__this;
				private UniTask<T1> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask2>d__14 : IAsyncStateMachine // TypeDefIndex: 8653
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T2> task;
				public WhenAnyPromise<T0, T1, T2, T3> <>4__this;
				private UniTask<T2> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask3>d__15 : IAsyncStateMachine // TypeDefIndex: 8654
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T3> task;
				public WhenAnyPromise<T0, T1, T2, T3> <>4__this;
				private UniTask<T3> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAnyPromise(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3);
	
			// Methods
			private void TryCallContinuation();
			[AsyncStateMachine] // 0x0000000180253A80-0x0000000180253AD0
			private UniTaskVoid RunTask0(UniTask<T0> task);
			[AsyncStateMachine] // 0x0000000180253D50-0x0000000180253DA0
			private UniTaskVoid RunTask1(UniTask<T1> task);
			[AsyncStateMachine] // 0x0000000180254020-0x0000000180254070
			private UniTaskVoid RunTask2(UniTask<T2> task);
			[AsyncStateMachine] // 0x0000000180254290-0x00000001802542E0
			private UniTaskVoid RunTask3(UniTask<T3> task);
			public Awaiter GetAwaiter();
		}
	
		private class WhenAnyPromise<T0, T1, T2, T3, T4> // TypeDefIndex: 8655
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
			public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8656
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
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask0>d__13 : IAsyncStateMachine // TypeDefIndex: 8657
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T0> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4> <>4__this;
				private UniTask<T0> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask1>d__14 : IAsyncStateMachine // TypeDefIndex: 8658
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T1> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4> <>4__this;
				private UniTask<T1> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask2>d__15 : IAsyncStateMachine // TypeDefIndex: 8659
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T2> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4> <>4__this;
				private UniTask<T2> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask3>d__16 : IAsyncStateMachine // TypeDefIndex: 8660
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T3> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4> <>4__this;
				private UniTask<T3> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask4>d__17 : IAsyncStateMachine // TypeDefIndex: 8661
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T4> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4> <>4__this;
				private UniTask<T4> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAnyPromise(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4);
	
			// Methods
			private void TryCallContinuation();
			[AsyncStateMachine] // 0x00000001802550F0-0x0000000180255140
			private UniTaskVoid RunTask0(UniTask<T0> task);
			[AsyncStateMachine] // 0x0000000180255290-0x00000001802552E0
			private UniTaskVoid RunTask1(UniTask<T1> task);
			[AsyncStateMachine] // 0x0000000180255510-0x0000000180255560
			private UniTaskVoid RunTask2(UniTask<T2> task);
			[AsyncStateMachine] // 0x0000000180255760-0x00000001802557B0
			private UniTaskVoid RunTask3(UniTask<T3> task);
			[AsyncStateMachine] // 0x0000000180255940-0x0000000180255990
			private UniTaskVoid RunTask4(UniTask<T4> task);
			public Awaiter GetAwaiter();
		}
	
		private class WhenAnyPromise<T0, T1, T2, T3, T4, T5> // TypeDefIndex: 8662
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
			public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8663
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
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask0>d__14 : IAsyncStateMachine // TypeDefIndex: 8664
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T0> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5> <>4__this;
				private UniTask<T0> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask1>d__15 : IAsyncStateMachine // TypeDefIndex: 8665
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T1> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5> <>4__this;
				private UniTask<T1> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask2>d__16 : IAsyncStateMachine // TypeDefIndex: 8666
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T2> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5> <>4__this;
				private UniTask<T2> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask3>d__17 : IAsyncStateMachine // TypeDefIndex: 8667
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T3> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5> <>4__this;
				private UniTask<T3> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask4>d__18 : IAsyncStateMachine // TypeDefIndex: 8668
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T4> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5> <>4__this;
				private UniTask<T4> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask5>d__19 : IAsyncStateMachine // TypeDefIndex: 8669
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T5> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5> <>4__this;
				private UniTask<T5> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAnyPromise(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5);
	
			// Methods
			private void TryCallContinuation();
			[AsyncStateMachine] // 0x00000001802566C0-0x0000000180256710
			private UniTaskVoid RunTask0(UniTask<T0> task);
			[AsyncStateMachine] // 0x0000000180256930-0x0000000180256980
			private UniTaskVoid RunTask1(UniTask<T1> task);
			[AsyncStateMachine] // 0x0000000180256C10-0x0000000180256C60
			private UniTaskVoid RunTask2(UniTask<T2> task);
			[AsyncStateMachine] // 0x0000000180256E20-0x0000000180256E70
			private UniTaskVoid RunTask3(UniTask<T3> task);
			[AsyncStateMachine] // 0x0000000180257130-0x0000000180257180
			private UniTaskVoid RunTask4(UniTask<T4> task);
			[AsyncStateMachine] // 0x0000000180257280-0x00000001802572D0
			private UniTaskVoid RunTask5(UniTask<T5> task);
			public Awaiter GetAwaiter();
		}
	
		private class WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> // TypeDefIndex: 8670
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
			public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8671
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
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask0>d__15 : IAsyncStateMachine // TypeDefIndex: 8672
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T0> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> <>4__this;
				private UniTask<T0> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask1>d__16 : IAsyncStateMachine // TypeDefIndex: 8673
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T1> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> <>4__this;
				private UniTask<T1> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask2>d__17 : IAsyncStateMachine // TypeDefIndex: 8674
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T2> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> <>4__this;
				private UniTask<T2> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask3>d__18 : IAsyncStateMachine // TypeDefIndex: 8675
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T3> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> <>4__this;
				private UniTask<T3> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask4>d__19 : IAsyncStateMachine // TypeDefIndex: 8676
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T4> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> <>4__this;
				private UniTask<T4> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask5>d__20 : IAsyncStateMachine // TypeDefIndex: 8677
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T5> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> <>4__this;
				private UniTask<T5> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask6>d__21 : IAsyncStateMachine // TypeDefIndex: 8678
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T6> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> <>4__this;
				private UniTask<T6> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAnyPromise(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6);
	
			// Methods
			private void TryCallContinuation();
			[AsyncStateMachine] // 0x0000000180258560-0x00000001802585B0
			private UniTaskVoid RunTask0(UniTask<T0> task);
			[AsyncStateMachine] // 0x00000001802588D0-0x0000000180258920
			private UniTaskVoid RunTask1(UniTask<T1> task);
			[AsyncStateMachine] // 0x0000000180258A50-0x0000000180258AA0
			private UniTaskVoid RunTask2(UniTask<T2> task);
			[AsyncStateMachine] // 0x0000000180258D50-0x0000000180258DA0
			private UniTaskVoid RunTask3(UniTask<T3> task);
			[AsyncStateMachine] // 0x0000000180259010-0x0000000180259060
			private UniTaskVoid RunTask4(UniTask<T4> task);
			[AsyncStateMachine] // 0x0000000180259280-0x00000001802592D0
			private UniTaskVoid RunTask5(UniTask<T5> task);
			[AsyncStateMachine] // 0x00000001802595E0-0x0000000180259630
			private UniTaskVoid RunTask6(UniTask<T6> task);
			public Awaiter GetAwaiter();
		}
	
		private class WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> // TypeDefIndex: 8679
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
			public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8680
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
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask0>d__16 : IAsyncStateMachine // TypeDefIndex: 8681
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T0> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> <>4__this;
				private UniTask<T0> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask1>d__17 : IAsyncStateMachine // TypeDefIndex: 8682
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T1> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> <>4__this;
				private UniTask<T1> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask2>d__18 : IAsyncStateMachine // TypeDefIndex: 8683
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T2> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> <>4__this;
				private UniTask<T2> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask3>d__19 : IAsyncStateMachine // TypeDefIndex: 8684
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T3> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> <>4__this;
				private UniTask<T3> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask4>d__20 : IAsyncStateMachine // TypeDefIndex: 8685
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T4> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> <>4__this;
				private UniTask<T4> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask5>d__21 : IAsyncStateMachine // TypeDefIndex: 8686
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T5> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> <>4__this;
				private UniTask<T5> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask6>d__22 : IAsyncStateMachine // TypeDefIndex: 8687
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T6> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> <>4__this;
				private UniTask<T6> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask7>d__23 : IAsyncStateMachine // TypeDefIndex: 8688
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T7> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> <>4__this;
				private UniTask<T7> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAnyPromise(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7);
	
			// Methods
			private void TryCallContinuation();
			[AsyncStateMachine] // 0x000000018025C020-0x000000018025C070
			private UniTaskVoid RunTask0(UniTask<T0> task);
			[AsyncStateMachine] // 0x000000018025C220-0x000000018025C270
			private UniTaskVoid RunTask1(UniTask<T1> task);
			[AsyncStateMachine] // 0x000000018025C570-0x000000018025C5C0
			private UniTaskVoid RunTask2(UniTask<T2> task);
			[AsyncStateMachine] // 0x000000018025C6F0-0x000000018025C740
			private UniTaskVoid RunTask3(UniTask<T3> task);
			[AsyncStateMachine] // 0x000000018025C8D0-0x000000018025C920
			private UniTaskVoid RunTask4(UniTask<T4> task);
			[AsyncStateMachine] // 0x000000018025CA60-0x000000018025CAB0
			private UniTaskVoid RunTask5(UniTask<T5> task);
			[AsyncStateMachine] // 0x000000018025CBA0-0x000000018025CBF0
			private UniTaskVoid RunTask6(UniTask<T6> task);
			[AsyncStateMachine] // 0x000000018025CDF0-0x000000018025CE40
			private UniTaskVoid RunTask7(UniTask<T7> task);
			public Awaiter GetAwaiter();
		}
	
		private class UnitWhenAnyPromise<T0> // TypeDefIndex: 8689
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
			public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8690
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
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask0>d__9 : IAsyncStateMachine // TypeDefIndex: 8691
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask<T0> task;
				public UnitWhenAnyPromise<T0> <>4__this;
				private UniTask<T0> <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask1>d__10 : IAsyncStateMachine // TypeDefIndex: 8692
			{
				// Fields
				public int <>1__state;
				public AsyncUniTaskVoidMethodBuilder <>t__builder;
				public UniTask task;
				public UnitWhenAnyPromise<T0> <>4__this;
				private Awaiter <>u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public UnitWhenAnyPromise(UniTask<T0> task0, UniTask task1);
	
			// Methods
			private void TryCallContinuation();
			[AsyncStateMachine] // 0x000000018025E2B0-0x000000018025E300
			private UniTaskVoid RunTask0(UniTask<T0> task);
			[AsyncStateMachine] // 0x000000018025E520-0x000000018025E570
			private UniTaskVoid RunTask1(UniTask task);
			public Awaiter GetAwaiter();
		}
	
		private class WhenAnyPromise<T> // TypeDefIndex: 8693
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
			public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8694
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
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask>d__8 : IAsyncStateMachine // TypeDefIndex: 8695
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
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAnyPromise(UniTask<T>[] tasks);
	
			// Methods
			[AsyncStateMachine] // 0x000000018025EBF0-0x000000018025EC40
			private UniTaskVoid RunTask(UniTask<T> task, int index);
			private void TryCallContinuation();
			public Awaiter GetAwaiter();
		}
	
		private class WhenAnyPromise // TypeDefIndex: 8696
		{
			// Fields
			private int completeCount; // 0x10
			private int winArgumentIndex; // 0x14
			private Action whenComplete; // 0x18
			private ExceptionDispatchInfo exception; // 0x20
	
			// Properties
			public bool IsComplete { get; } // 0x0000000181ACE180-0x0000000181ACE1B0 
	
			// Nested types
			public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8697
			{
				// Fields
				private WhenAnyPromise parent; // 0x00
	
				// Properties
				public bool IsCompleted { get; } // 0x000000018010EAB0-0x000000018010EAF0 
	
				// Constructors
				public Awaiter(WhenAnyPromise parent); // 0x000000018001A8F0-0x000000018001A900
	
				// Methods
				public int GetResult(); // 0x000000018010E880-0x000000018010E8E0
				public void OnCompleted(Action continuation); // 0x000000018010EA10-0x000000018010EA20
				public void UnsafeOnCompleted(Action continuation); // 0x000000018010EA20-0x000000018010EA30
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private struct <RunTask>d__7 : IAsyncStateMachine // TypeDefIndex: 8698
			{
				// Fields
				public int <>1__state; // 0x00
				public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x08
				public UniTask task; // 0x10
				public WhenAnyPromise <>4__this; // 0x18
				public int index; // 0x20
				private Awaiter <>u__1; // 0x28
	
				// Methods
				private void MoveNext(); // 0x000000018010ED80-0x000000018010ED90
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002020-0x0000000180002030
			}
	
			// Constructors
			public WhenAnyPromise(UniTask[] tasks); // 0x0000000181ACE070-0x0000000181ACE180
	
			// Methods
			[AsyncStateMachine] // 0x000000018025F060-0x000000018025F0B0
			private UniTaskVoid RunTask(UniTask task, int index); // 0x0000000181ACDFC0-0x0000000181ACE070
			private void TryCallContinuation(); // 0x0000000181ACDDD0-0x0000000181ACDE00
			public Awaiter GetAwaiter(); // 0x0000000180411160-0x0000000180411170
		}
	
		private class AsyncUnitAwaiter : IAwaiter<AsyncUnit> // TypeDefIndex: 8699
		{
			// Fields
			private readonly IAwaiter awaiter; // 0x10
	
			// Properties
			public bool IsCompleted { get; } // 0x0000000181AC4910-0x0000000181AC4960 
			public AwaiterStatus Status { get; } // 0x0000000181AC4960-0x0000000181AC49B0 
	
			// Constructors
			public AsyncUnitAwaiter(IAwaiter awaiter); // 0x0000000180400150-0x0000000180400180
	
			// Methods
			public AsyncUnit GetResult(); // 0x0000000181AC4780-0x0000000181AC4800
			public void OnCompleted(Action continuation); // 0x0000000181AC4800-0x0000000181AC4860
			public void UnsafeOnCompleted(Action continuation); // 0x0000000181AC48B0-0x0000000181AC4910
			void IAwaiter.GetResult(); // 0x0000000181AC4860-0x0000000181AC48B0
		}
	
		private class IsCanceledAwaiter : IAwaiter<bool> // TypeDefIndex: 8700
		{
			// Fields
			private readonly IAwaiter awaiter; // 0x10
	
			// Properties
			public bool IsCompleted { get; } // 0x0000000181AC5710-0x0000000181AC5760 
			public AwaiterStatus Status { get; } // 0x0000000181AC5760-0x0000000181AC57B0 
	
			// Constructors
			public IsCanceledAwaiter(IAwaiter awaiter); // 0x0000000180400150-0x0000000180400180
	
			// Methods
			public bool GetResult(); // 0x0000000181AC5580-0x0000000181AC5600
			public void OnCompleted(Action continuation); // 0x0000000181AC5600-0x0000000181AC5660
			public void UnsafeOnCompleted(Action continuation); // 0x0000000181AC56B0-0x0000000181AC5710
			void IAwaiter.GetResult(); // 0x0000000181AC5660-0x0000000181AC56B0
		}
	
		public struct Awaiter : IAwaiter // TypeDefIndex: 8701
		{
			// Fields
			private readonly UniTask task; // 0x00
	
			// Properties
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public bool IsCompleted { get; } // 0x000000018010EAF0-0x000000018010EB40 
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public AwaiterStatus Status { get; } // 0x000000018010EB80-0x000000018010EC10 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public Awaiter(UniTask task); // 0x000000018001A8F0-0x000000018001A900
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public void GetResult(); // 0x000000018010E830-0x000000018010E880
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public void OnCompleted(Action continuation); // 0x000000018010E980-0x000000018010E9F0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public void UnsafeOnCompleted(Action continuation); // 0x000000018010EA40-0x000000018010EAB0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <Run>d__24 : IAsyncStateMachine // TypeDefIndex: 8702
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
			private void MoveNext(); // 0x000000018010ED90-0x000000018010EDA0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002020-0x0000000180002030
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <Run>d__25 : IAsyncStateMachine // TypeDefIndex: 8703
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
			private void MoveNext(); // 0x000000018010EDA0-0x000000018010EDB0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002020-0x0000000180002030
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <Run>d__26<T> : IAsyncStateMachine // TypeDefIndex: 8704
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
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <Run>d__27<T> : IAsyncStateMachine // TypeDefIndex: 8705
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
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <WhenAll>d__39<T1, T2> : IAsyncStateMachine // TypeDefIndex: 8706
		{
			// Fields
			public int <>1__state;
			[TupleElementNames] // 0x0000000180260B10-0x0000000180260B90
			public AsyncUniTaskMethodBuilder<ValueTuple<T1, T2>> <>t__builder;
			public UniTask<T1> task1;
			public UniTask<T2> task2;
			private WhenAllPromise<T1, T2> <>u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <WhenAll>d__40<T1, T2, T3> : IAsyncStateMachine // TypeDefIndex: 8707
		{
			// Fields
			public int <>1__state;
			[TupleElementNames] // 0x0000000180262530-0x00000001802625C0
			public AsyncUniTaskMethodBuilder<ValueTuple<T1, T2, T3>> <>t__builder;
			public UniTask<T1> task1;
			public UniTask<T2> task2;
			public UniTask<T3> task3;
			private WhenAllPromise<T1, T2, T3> <>u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <WhenAll>d__41<T1, T2, T3, T4> : IAsyncStateMachine // TypeDefIndex: 8708
		{
			// Fields
			public int <>1__state;
			[TupleElementNames] // 0x0000000180262E60-0x0000000180262F00
			public AsyncUniTaskMethodBuilder<ValueTuple<T1, T2, T3, T4>> <>t__builder;
			public UniTask<T1> task1;
			public UniTask<T2> task2;
			public UniTask<T3> task3;
			public UniTask<T4> task4;
			private WhenAllPromise<T1, T2, T3, T4> <>u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <WhenAll>d__42<T1, T2, T3, T4, T5> : IAsyncStateMachine // TypeDefIndex: 8709
		{
			// Fields
			public int <>1__state;
			[TupleElementNames] // 0x0000000180264910-0x00000001802649C0
			public AsyncUniTaskMethodBuilder<ValueTuple<T1, T2, T3, T4, T5>> <>t__builder;
			public UniTask<T1> task1;
			public UniTask<T2> task2;
			public UniTask<T3> task3;
			public UniTask<T4> task4;
			public UniTask<T5> task5;
			private WhenAllPromise<T1, T2, T3, T4, T5> <>u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <WhenAll>d__43<T1, T2, T3, T4, T5, T6> : IAsyncStateMachine // TypeDefIndex: 8710
		{
			// Fields
			public int <>1__state;
			[TupleElementNames] // 0x0000000180266500-0x00000001802665C0
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
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <WhenAll>d__44<T1, T2, T3, T4, T5, T6, T7> : IAsyncStateMachine // TypeDefIndex: 8711
		{
			// Fields
			public int <>1__state;
			[TupleElementNames] // 0x0000000180266CA0-0x0000000180266D70
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
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <WhenAll>d__51<T> : IAsyncStateMachine // TypeDefIndex: 8712
		{
			// Fields
			public int <>1__state;
			public AsyncUniTaskMethodBuilder<T[]> <>t__builder;
			public UniTask<T>[] tasks;
			private WhenAllPromise<T> <>u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <WhenAll>d__52<T> : IAsyncStateMachine // TypeDefIndex: 8713
		{
			// Fields
			public int <>1__state;
			public AsyncUniTaskMethodBuilder<T[]> <>t__builder;
			public IEnumerable<UniTask<T>> tasks;
			private WhenAllPromise<T> <>u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <WhenAll>d__53 : IAsyncStateMachine // TypeDefIndex: 8714
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
			public UniTask[] tasks; // 0x18
			private WhenAllPromise.Awaiter <>u__1; // 0x20
	
			// Methods
			private void MoveNext(); // 0x000000018010EE10-0x000000018010EE20
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002020-0x0000000180002030
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <WhenAll>d__54 : IAsyncStateMachine // TypeDefIndex: 8715
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
			public IEnumerable<UniTask> tasks; // 0x18
			private WhenAllPromise.Awaiter <>u__1; // 0x20
	
			// Methods
			private void MoveNext(); // 0x000000018010EE20-0x000000018010EE30
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002020-0x0000000180002030
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <WhenAny>d__57<T0, T1> : IAsyncStateMachine // TypeDefIndex: 8716
		{
			// Fields
			public int <>1__state;
			[TupleElementNames] // 0x0000000180267B00-0x0000000180267BC0
			public AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>>> <>t__builder;
			public UniTask<T0> task0;
			public UniTask<T1> task1;
			private WhenAnyPromise<T0, T1> <>u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <WhenAny>d__58<T0, T1, T2> : IAsyncStateMachine // TypeDefIndex: 8717
		{
			// Fields
			public int <>1__state;
			[TupleElementNames] // 0x0000000180268070-0x0000000180268150
			public AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>>> <>t__builder;
			public UniTask<T0> task0;
			public UniTask<T1> task1;
			public UniTask<T2> task2;
			private WhenAnyPromise<T0, T1, T2> <>u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <WhenAny>d__59<T0, T1, T2, T3> : IAsyncStateMachine // TypeDefIndex: 8718
		{
			// Fields
			public int <>1__state;
			[TupleElementNames] // 0x00000001802687A0-0x00000001802688A0
			public AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>>> <>t__builder;
			public UniTask<T0> task0;
			public UniTask<T1> task1;
			public UniTask<T2> task2;
			public UniTask<T3> task3;
			private WhenAnyPromise<T0, T1, T2, T3> <>u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <WhenAny>d__60<T0, T1, T2, T3, T4> : IAsyncStateMachine // TypeDefIndex: 8719
		{
			// Fields
			public int <>1__state;
			[TupleElementNames] // 0x0000000180269170-0x00000001802692A0
			public AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>>> <>t__builder;
			public UniTask<T0> task0;
			public UniTask<T1> task1;
			public UniTask<T2> task2;
			public UniTask<T3> task3;
			public UniTask<T4> task4;
			private WhenAnyPromise<T0, T1, T2, T3, T4> <>u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <WhenAny>d__61<T0, T1, T2, T3, T4, T5> : IAsyncStateMachine // TypeDefIndex: 8720
		{
			// Fields
			public int <>1__state;
			[TupleElementNames] // 0x0000000180269E50-0x0000000180269FB0
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
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <WhenAny>d__62<T0, T1, T2, T3, T4, T5, T6> : IAsyncStateMachine // TypeDefIndex: 8721
		{
			// Fields
			public int <>1__state;
			[TupleElementNames] // 0x000000018026AA10-0x000000018026ABB0
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
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <WhenAny>d__63<T0, T1, T2, T3, T4, T5, T6, T7> : IAsyncStateMachine // TypeDefIndex: 8722
		{
			// Fields
			public int <>1__state;
			[TupleElementNames] // 0x000000018026B770-0x000000018026B940
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
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <WhenAny>d__71<T0> : IAsyncStateMachine // TypeDefIndex: 8723
		{
			// Fields
			public int <>1__state;
			[TupleElementNames] // 0x000000018026C740-0x000000018026C7C0
			public AsyncUniTaskMethodBuilder<ValueTuple<bool, T0>> <>t__builder;
			public UniTask<T0> task0;
			public UniTask task1;
			private UnitWhenAnyPromise<T0> <>u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <WhenAny>d__72<T> : IAsyncStateMachine // TypeDefIndex: 8724
		{
			// Fields
			public int <>1__state;
			[TupleElementNames] // 0x000000018026CE20-0x000000018026CEA0
			public AsyncUniTaskMethodBuilder<ValueTuple<int, T>> <>t__builder;
			public UniTask<T>[] tasks;
			private WhenAnyPromise<T> <>u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <WhenAny>d__73 : IAsyncStateMachine // TypeDefIndex: 8725
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskMethodBuilder<int> <>t__builder; // 0x08
			public UniTask[] tasks; // 0x20
			private WhenAnyPromise.Awaiter <>u__1; // 0x28
	
			// Methods
			private void MoveNext(); // 0x000000018010EE30-0x000000018010EE40
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018010EE40-0x000000018010EE90
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 8726
		{
			// Fields
			public static readonly <>c <>9; // 0x00
	
			// Constructors
			static <>c(); // 0x0000000181AC7DC0-0x0000000181AC7E20
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal UniTask <.cctor>b__96_0(); // 0x0000000181AC7D50-0x0000000181AC7DC0
		}
	
		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public UniTask(IAwaiter awaiter); // 0x000000018001A8F0-0x000000018001A900
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public UniTask(Func<UniTask> factory); // 0x000000018010F0F0-0x000000018010F160
		static UniTask(); // 0x0000000181ACAC20-0x0000000181ACADE0
	
		// Methods
		public static IEnumerator ToCoroutine(Func<UniTask> taskFactory); // 0x0000000181ACA700-0x0000000181ACA840
		public static YieldAwaitable Yield(PlayerLoopTiming timing = PlayerLoopTiming.Update /* Metadata: 0x0077804B */); // 0x0000000180831220-0x0000000180831570
		public static UniTask Yield(PlayerLoopTiming timing, CancellationToken cancellationToken); // 0x0000000181ACABB0-0x0000000181ACAC20
		public static UniTask<int> DelayFrame(int delayFrameCount, PlayerLoopTiming delayTiming = PlayerLoopTiming.Update /* Metadata: 0x0077804F */, CancellationToken cancellationToken = default); // 0x0000000181AC9E10-0x0000000181AC9F30
		public static UniTask Delay(int millisecondsDelay, bool ignoreTimeScale = false /* Metadata: 0x00778053 */, PlayerLoopTiming delayTiming = PlayerLoopTiming.Update /* Metadata: 0x00778054 */, CancellationToken cancellationToken = default); // 0x0000000181AC9F30-0x0000000181ACA090
		public static UniTask Delay(TimeSpan delayTimeSpan, bool ignoreTimeScale = false /* Metadata: 0x00778058 */, PlayerLoopTiming delayTiming = PlayerLoopTiming.Update /* Metadata: 0x00778059 */, CancellationToken cancellationToken = default); // 0x0000000181ACA090-0x0000000181ACA200
		public static UniTask FromException(Exception ex); // 0x0000000181ACA300-0x0000000181ACA3F0
		public static UniTask<T> FromException<T>(Exception ex);
		public static UniTask<T> FromResult<T>(T value);
		public static UniTask FromCanceled(); // 0x0000000181ACA2A0-0x0000000181ACA300
		public static UniTask<T> FromCanceled<T>();
		public static UniTask FromCanceled(CancellationToken token); // 0x0000000181ACA200-0x0000000181ACA2A0
		public static UniTask<T> FromCanceled<T>(CancellationToken token);
		public static UniTask<T> Lazy<T>(Func<UniTask<T>> factory);
		public static void Void(Func<UniTask> asyncAction); // 0x0000000181ACA840-0x0000000181ACA890
		public static void Void<T>(Func<T, UniTask> asyncAction, T state);
		[AsyncStateMachine] // 0x0000000180240130-0x0000000180240180
		public static UniTask Run(Action action, bool configureAwait = true /* Metadata: 0x0077805D */); // 0x0000000181ACA3F0-0x0000000181ACA4A0
		[AsyncStateMachine] // 0x0000000180240450-0x00000001802404A0
		public static UniTask Run(Action<object> action, object state, bool configureAwait = true /* Metadata: 0x0077805E */); // 0x0000000181ACA4A0-0x0000000181ACA6C0
		[AsyncStateMachine] // 0x00000001802406D0-0x0000000180240720
		public static UniTask<T> Run<T>(Func<T> func, bool configureAwait = true /* Metadata: 0x0077805F */);
		[AsyncStateMachine] // 0x00000001802409C0-0x0000000180240A10
		public static UniTask<T> Run<T>(Func<object, T> func, object state, bool configureAwait = true /* Metadata: 0x00778060 */);
		public static SwitchToMainThreadAwaitable SwitchToMainThread(); // 0x0000000180380950-0x0000000180380960
		public static SwitchToThreadPoolAwaitable SwitchToThreadPool(); // 0x0000000180380950-0x0000000180380960
		public static SwitchToTaskPoolAwaitable SwitchToTaskPool(); // 0x0000000180380950-0x0000000180380960
		public static SwitchToSynchronizationContextAwaitable SwitchToSynchronizationContext(SynchronizationContext syncContext); // 0x0000000181ACA6C0-0x0000000181ACA700
		public static UniTask WaitUntil(Func<bool> predicate, PlayerLoopTiming timing = PlayerLoopTiming.Update /* Metadata: 0x00778061 */, CancellationToken cancellationToken = default); // 0x0000000181ACA890-0x0000000181ACA920
		public static UniTask WaitWhile(Func<bool> predicate, PlayerLoopTiming timing = PlayerLoopTiming.Update /* Metadata: 0x00778065 */, CancellationToken cancellationToken = default); // 0x0000000181ACA920-0x0000000181ACA9B0
		public static UniTask<U> WaitUntilValueChanged<T, U>(T target, Func<T, U> monitorFunction, PlayerLoopTiming monitorTiming = PlayerLoopTiming.Update /* Metadata: 0x00778069 */, IEqualityComparer<U> equalityComparer = null, CancellationToken cancellationToken = default)
			where T : class;
		[AsyncStateMachine] // 0x0000000180240BA0-0x0000000180240BF0
		public static UniTask<ValueTuple<T1, T2>> WhenAll<T1, T2>(UniTask<T1> task1, UniTask<T2> task2);
		[AsyncStateMachine] // 0x0000000180240E90-0x0000000180240EE0
		public static UniTask<ValueTuple<T1, T2, T3>> WhenAll<T1, T2, T3>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3);
		[AsyncStateMachine] // 0x0000000180241190-0x00000001802411E0
		public static UniTask<ValueTuple<T1, T2, T3, T4>> WhenAll<T1, T2, T3, T4>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4);
		[AsyncStateMachine] // 0x0000000180241450-0x00000001802414A0
		public static UniTask<ValueTuple<T1, T2, T3, T4, T5>> WhenAll<T1, T2, T3, T4, T5>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5);
		[AsyncStateMachine] // 0x0000000180241650-0x00000001802416A0
		public static UniTask<ValueTuple<T1, T2, T3, T4, T5, T6>> WhenAll<T1, T2, T3, T4, T5, T6>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6);
		[AsyncStateMachine] // 0x00000001802419F0-0x0000000180241A40
		public static UniTask<ValueTuple<T1, T2, T3, T4, T5, T6, T7>> WhenAll<T1, T2, T3, T4, T5, T6, T7>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7);
		[AsyncStateMachine] // 0x0000000180241D30-0x0000000180241D80
		public static UniTask<T[]> WhenAll<T>(params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ UniTask<T>[] tasks);
		[AsyncStateMachine] // 0x0000000180242140-0x0000000180242190
		public static UniTask<T[]> WhenAll<T>(IEnumerable<UniTask<T>> tasks);
		[AsyncStateMachine] // 0x00000001802423C0-0x0000000180242410
		public static UniTask WhenAll(params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ UniTask[] tasks); // 0x0000000181ACA9B0-0x0000000181ACAA40
		[AsyncStateMachine] // 0x00000001802429A0-0x00000001802429F0
		public static UniTask WhenAll(IEnumerable<UniTask> tasks); // 0x0000000181ACAA40-0x0000000181ACAAD0
		[AsyncStateMachine] // 0x0000000180242BA0-0x0000000180242BF0
		public static UniTask<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>>> WhenAny<T0, T1>(UniTask<T0> task0, UniTask<T1> task1);
		[AsyncStateMachine] // 0x0000000180242DF0-0x0000000180242E40
		public static UniTask<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>>> WhenAny<T0, T1, T2>(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2);
		[AsyncStateMachine] // 0x00000001802442F0-0x0000000180244340
		public static UniTask<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>>> WhenAny<T0, T1, T2, T3>(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3);
		[AsyncStateMachine] // 0x0000000180244500-0x0000000180244550
		public static UniTask<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>>> WhenAny<T0, T1, T2, T3, T4>(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4);
		[AsyncStateMachine] // 0x0000000180244700-0x0000000180244750
		public static UniTask<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>>> WhenAny<T0, T1, T2, T3, T4, T5>(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5);
		[AsyncStateMachine] // 0x00000001802448E0-0x0000000180244930
		public static UniTask<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>, ValueTuple<ValueTuple<bool, T6>>>> WhenAny<T0, T1, T2, T3, T4, T5, T6>(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6);
		[AsyncStateMachine] // 0x0000000180244B60-0x0000000180244BB0
		public static UniTask<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>, ValueTuple<ValueTuple<bool, T6>, ValueTuple<bool, T7>>>> WhenAny<T0, T1, T2, T3, T4, T5, T6, T7>(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7);
		[AsyncStateMachine] // 0x0000000180244DA0-0x0000000180244DF0
		public static UniTask<ValueTuple<bool, T0>> WhenAny<T0>(UniTask<T0> task0, UniTask task1);
		[AsyncStateMachine] // 0x0000000180244F20-0x0000000180244F70
		public static UniTask<ValueTuple<int, T>> WhenAny<T>(params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ UniTask<T>[] tasks);
		[AsyncStateMachine] // 0x0000000180245190-0x00000001802451E0
		public static UniTask<int> WhenAny(params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ UniTask[] tasks); // 0x0000000181ACAAD0-0x0000000181ACABB0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public void GetResult(); // 0x000000018010EEB0-0x000000018010EF00
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public Awaiter GetAwaiter(); // 0x000000018001A8D0-0x000000018001A8E0
		public UniTask<bool> SuppressCancellationThrow(); // 0x000000018010EF00-0x000000018010F050
		public bool Equals(UniTask other); // 0x000000018010EE90-0x000000018010EEB0
		public override int GetHashCode(); // 0x00000001800D22D0-0x00000001800D22F0
		public override string ToString(); // 0x000000018010F050-0x000000018010F0F0
		public static implicit operator UniTask<AsyncUnit>(UniTask task); // 0x0000000181ACADE0-0x0000000181ACAEC0
	}
}
