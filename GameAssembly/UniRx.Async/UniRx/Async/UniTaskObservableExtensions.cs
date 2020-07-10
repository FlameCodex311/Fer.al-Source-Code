/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UniRx.Async.CompilerServices;
using UniRx.Async.Internal;

// Image 68: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8376-8739

namespace UniRx.Async
{
	public static class UniTaskObservableExtensions // TypeDefIndex: 8612
	{
		// Nested types
		private class ToUniTaskObserver<T> : IObserver<T> // TypeDefIndex: 8613
		{
			// Fields
			private static readonly Action<object> callback;
			private readonly UniTaskCompletionSource<T> promise;
			private readonly SingleAssignmentDisposable disposable;
			private readonly CancellationToken cancellationToken;
			private readonly CancellationTokenRegistration registration;
			private bool hasValue;
			private T latestValue;
	
			// Constructors
			public ToUniTaskObserver(UniTaskCompletionSource<T> promise, SingleAssignmentDisposable disposable, CancellationToken cancellationToken);
			static ToUniTaskObserver();
	
			// Methods
			private static void OnCanceled(object state);
			public void OnNext(T value);
			public void OnError(Exception error);
			public void OnCompleted();
		}
	
		private class FirstValueToUniTaskObserver<T> : IObserver<T> // TypeDefIndex: 8614
		{
			// Fields
			private static readonly Action<object> callback;
			private readonly UniTaskCompletionSource<T> promise;
			private readonly SingleAssignmentDisposable disposable;
			private readonly CancellationToken cancellationToken;
			private readonly CancellationTokenRegistration registration;
			private bool hasValue;
	
			// Constructors
			public FirstValueToUniTaskObserver(UniTaskCompletionSource<T> promise, SingleAssignmentDisposable disposable, CancellationToken cancellationToken);
			static FirstValueToUniTaskObserver();
	
			// Methods
			private static void OnCanceled(object state);
			public void OnNext(T value);
			public void OnError(Exception error);
			public void OnCompleted();
		}
	
		private class ReturnObservable<T> : IObservable<T> // TypeDefIndex: 8615
		{
			// Fields
			private readonly T value;
	
			// Constructors
			public ReturnObservable(T value);
	
			// Methods
			public IDisposable Subscribe(IObserver<T> observer);
		}
	
		private class ThrowObservable<T> : IObservable<T> // TypeDefIndex: 8616
		{
			// Fields
			private readonly Exception value;
	
			// Constructors
			public ThrowObservable(Exception value);
	
			// Methods
			public IDisposable Subscribe(IObserver<T> observer);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <Fire>d__3<T> : IAsyncStateMachine // TypeDefIndex: 8617
		{
			// Fields
			public int <>1__state;
			public AsyncUniTaskVoidMethodBuilder <>t__builder;
			public UniTask<T> task;
			public AsyncSubject<T> subject;
			private UniTask<T> <>u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <Fire>d__4 : IAsyncStateMachine // TypeDefIndex: 8618
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x08
			public UniTask task; // 0x10
			public AsyncSubject<object> subject; // 0x18
			private UniTask.Awaiter <>u__1; // 0x20
	
			// Methods
			private void MoveNext(); // 0x0000000180321CB0-0x0000000180321CC0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0500-0x00000001801F0510
		}
	
		// Methods
		[AsyncStateMachine] // 0x000000018011DEA0-0x000000018011DEF0
		private static UniTaskVoid Fire<T>(AsyncSubject<T> subject, UniTask<T> task);
		[AsyncStateMachine] // 0x000000018011E130-0x000000018011E180
		private static UniTaskVoid Fire(AsyncSubject<object> subject, UniTask task); // 0x00000001820E2C00-0x00000001820E2CA0
	
		// Extension methods
		public static UniTask<T> ToUniTask<T>(this IObservable<T> source, CancellationToken cancellationToken = default, bool useFirstValue = false /* Metadata: 0x007433CF */);
		public static IObservable<T> ToObservable<T>(this UniTask<T> task);
		public static IObservable<AsyncUnit> ToObservable(this UniTask task); // 0x00000001820E2CA0-0x00000001820E2DF0
	}
}
