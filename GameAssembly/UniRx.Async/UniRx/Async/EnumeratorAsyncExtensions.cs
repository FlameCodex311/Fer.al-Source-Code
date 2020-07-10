/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Threading;
using UnityEngine;

// Image 68: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8376-8739

namespace UniRx.Async
{
	public static class EnumeratorAsyncExtensions // TypeDefIndex: 8386
	{
		// Nested types
		private class EnumeratorAwaiter : IAwaiter, IPlayerLoopItem // TypeDefIndex: 8387
		{
			// Fields
			private IEnumerator innerEnumerator; // 0x10
			private CancellationToken cancellationToken; // 0x18
			private Action continuation; // 0x20
			private AwaiterStatus status; // 0x28
			private ExceptionDispatchInfo exception; // 0x30
			private static readonly FieldInfo waitForSeconds_Seconds; // 0x00
	
			// Properties
			public bool IsCompleted { get; } // 0x0000000180B9E950-0x0000000180B9E960 
			public AwaiterStatus Status { get; } // 0x000000018038E0E0-0x000000018038E0F0 
	
			// Nested types
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class <ConsumeEnumerator>d__15 : IEnumerator<object> // TypeDefIndex: 8388
			{
				// Fields
				private int <>1__state; // 0x10
				private object <>2__current; // 0x18
				public IEnumerator enumerator; // 0x20
				private IEnumerator <e2>5__2; // 0x28
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
				object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
				// Constructors
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				public <ConsumeEnumerator>d__15(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
				// Methods
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
				private bool MoveNext(); // 0x0000000181671870-0x0000000181671C80
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IEnumerator.Reset(); // 0x0000000181671C80-0x0000000181671CD0
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class <UnwrapWaitCustomYieldInstruction>d__16 : IEnumerator<object> // TypeDefIndex: 8389
			{
				// Fields
				private int <>1__state; // 0x10
				private object <>2__current; // 0x18
				public CustomYieldInstruction yieldInstruction; // 0x20
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
				object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
				// Constructors
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				public <UnwrapWaitCustomYieldInstruction>d__16(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
				// Methods
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
				private bool MoveNext(); // 0x0000000181672010-0x0000000181672070
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IEnumerator.Reset(); // 0x0000000181672070-0x00000001816720C0
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class <UnwrapWaitForSeconds>d__18 : IEnumerator<object> // TypeDefIndex: 8390
			{
				// Fields
				private int <>1__state; // 0x10
				private object <>2__current; // 0x18
				public WaitForSeconds waitForSeconds; // 0x20
				private float <second>5__2; // 0x28
				private DateTimeOffset <startTime>5__3; // 0x30
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
				object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
				// Constructors
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				public <UnwrapWaitForSeconds>d__18(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
				// Methods
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
				private bool MoveNext(); // 0x00000001816720C0-0x0000000181672270
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IEnumerator.Reset(); // 0x0000000181672270-0x00000001816722C0
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class <UnwrapWaitAsyncOperation>d__19 : IEnumerator<object> // TypeDefIndex: 8391
			{
				// Fields
				private int <>1__state; // 0x10
				private object <>2__current; // 0x18
				public AsyncOperation asyncOperation; // 0x20
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
				object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
				// Constructors
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				public <UnwrapWaitAsyncOperation>d__19(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
				// Methods
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
				private bool MoveNext(); // 0x0000000181671F60-0x0000000181671FC0
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IEnumerator.Reset(); // 0x0000000181671FC0-0x0000000181672010
			}
	
			// Constructors
			public EnumeratorAwaiter(IEnumerator innerEnumerator, CancellationToken cancellationToken); // 0x000000018166BD30-0x000000018166BE20
			static EnumeratorAwaiter(); // 0x000000018166BC90-0x000000018166BD30
	
			// Methods
			public void GetResult(); // 0x000000018166B940-0x000000018166B990
			public bool MoveNext(); // 0x000000018166BA20-0x000000018166BAF0
			private void InvokeContinuation(AwaiterStatus status); // 0x000000018166B990-0x000000018166BA20
			public void OnCompleted(Action continuation); // 0x000000018166BAF0-0x000000018166BB70
			public void UnsafeOnCompleted(Action continuation); // 0x000000018166BAF0-0x000000018166BB70
			[IteratorStateMachine] // 0x00000001800DD510-0x00000001800DD560
			private static IEnumerator ConsumeEnumerator(IEnumerator enumerator); // 0x000000018166B8E0-0x000000018166B940
			[IteratorStateMachine] // 0x00000001800DD940-0x00000001800DD990
			private static IEnumerator UnwrapWaitCustomYieldInstruction(CustomYieldInstruction yieldInstruction); // 0x000000018166BBD0-0x000000018166BC30
			[IteratorStateMachine] // 0x00000001800DDC20-0x00000001800DDC70
			private static IEnumerator UnwrapWaitForSeconds(WaitForSeconds waitForSeconds); // 0x000000018166BC30-0x000000018166BC90
			[IteratorStateMachine] // 0x00000001800DE030-0x00000001800DE080
			private static IEnumerator UnwrapWaitAsyncOperation(AsyncOperation asyncOperation); // 0x000000018166BB70-0x000000018166BBD0
		}
	
		// Extension methods
		public static IAwaiter GetAwaiter(this IEnumerator enumerator); // 0x000000018166B780-0x000000018166B830
		public static UniTask ToUniTask(this IEnumerator enumerator); // 0x000000018166B830-0x000000018166B8E0
		public static UniTask ConfigureAwait(this IEnumerator enumerator, PlayerLoopTiming timing = PlayerLoopTiming.Update /* Metadata: 0x0074332D */, CancellationToken cancellationToken = default); // 0x000000018166B6F0-0x000000018166B780
	}
}
