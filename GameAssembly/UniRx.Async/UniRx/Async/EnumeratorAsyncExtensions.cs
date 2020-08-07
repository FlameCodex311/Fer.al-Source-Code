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

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async
{
	public static class EnumeratorAsyncExtensions // TypeDefIndex: 8552
	{
		// Nested types
		private class EnumeratorAwaiter : IAwaiter, IPlayerLoopItem // TypeDefIndex: 8553
		{
			// Fields
			private IEnumerator innerEnumerator; // 0x10
			private CancellationToken cancellationToken; // 0x18
			private Action continuation; // 0x20
			private AwaiterStatus status; // 0x28
			private ExceptionDispatchInfo exception; // 0x30
			private static readonly FieldInfo waitForSeconds_Seconds; // 0x00
	
			// Properties
			public bool IsCompleted { get; } // 0x0000000180DFF8C0-0x0000000180DFF8D0 
			public AwaiterStatus Status { get; } // 0x000000018043C680-0x000000018043C690 
	
			// Nested types
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class <ConsumeEnumerator>d__15 : IEnumerator<object> // TypeDefIndex: 8554
			{
				// Fields
				private int <>1__state; // 0x10
				private object <>2__current; // 0x18
				public IEnumerator enumerator; // 0x20
				private IEnumerator <e2>5__2; // 0x28
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
				object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
				// Constructors
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				public <ConsumeEnumerator>d__15(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
				// Methods
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
				private bool MoveNext(); // 0x0000000180E1E250-0x0000000180E1E650
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IEnumerator.Reset(); // 0x0000000180E1E650-0x0000000180E1E6A0
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class <UnwrapWaitCustomYieldInstruction>d__16 : IEnumerator<object> // TypeDefIndex: 8555
			{
				// Fields
				private int <>1__state; // 0x10
				private object <>2__current; // 0x18
				public CustomYieldInstruction yieldInstruction; // 0x20
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
				object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
				// Constructors
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				public <UnwrapWaitCustomYieldInstruction>d__16(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
				// Methods
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
				private bool MoveNext(); // 0x0000000180E1E9E0-0x0000000180E1EA40
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IEnumerator.Reset(); // 0x0000000180E1EA40-0x0000000180E1EA90
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class <UnwrapWaitForSeconds>d__18 : IEnumerator<object> // TypeDefIndex: 8556
			{
				// Fields
				private int <>1__state; // 0x10
				private object <>2__current; // 0x18
				public WaitForSeconds waitForSeconds; // 0x20
				private float <second>5__2; // 0x28
				private DateTimeOffset <startTime>5__3; // 0x30
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
				object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
				// Constructors
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				public <UnwrapWaitForSeconds>d__18(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
				// Methods
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
				private bool MoveNext(); // 0x0000000180E1EA90-0x0000000180E1EC30
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IEnumerator.Reset(); // 0x0000000180E1EC30-0x0000000180E1EC80
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class <UnwrapWaitAsyncOperation>d__19 : IEnumerator<object> // TypeDefIndex: 8557
			{
				// Fields
				private int <>1__state; // 0x10
				private object <>2__current; // 0x18
				public AsyncOperation asyncOperation; // 0x20
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
				object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
				// Constructors
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				public <UnwrapWaitAsyncOperation>d__19(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
				// Methods
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
				private bool MoveNext(); // 0x0000000180E1E930-0x0000000180E1E990
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IEnumerator.Reset(); // 0x0000000180E1E990-0x0000000180E1E9E0
			}
	
			// Constructors
			public EnumeratorAwaiter(IEnumerator innerEnumerator, CancellationToken cancellationToken); // 0x0000000180E18A80-0x0000000180E18B70
			static EnumeratorAwaiter(); // 0x0000000180E189E0-0x0000000180E18A80
	
			// Methods
			public void GetResult(); // 0x0000000180E18690-0x0000000180E186E0
			public bool MoveNext(); // 0x0000000180E18770-0x0000000180E18840
			private void InvokeContinuation(AwaiterStatus status); // 0x0000000180E186E0-0x0000000180E18770
			public void OnCompleted(Action continuation); // 0x0000000180E18840-0x0000000180E188C0
			public void UnsafeOnCompleted(Action continuation); // 0x0000000180E18840-0x0000000180E188C0
			[IteratorStateMachine] // 0x000000018023BA60-0x000000018023BAB0
			private static IEnumerator ConsumeEnumerator(IEnumerator enumerator); // 0x0000000180E18630-0x0000000180E18690
			[IteratorStateMachine] // 0x000000018023BBA0-0x000000018023BBF0
			private static IEnumerator UnwrapWaitCustomYieldInstruction(CustomYieldInstruction yieldInstruction); // 0x0000000180E18920-0x0000000180E18980
			[IteratorStateMachine] // 0x000000018023D060-0x000000018023D0B0
			private static IEnumerator UnwrapWaitForSeconds(WaitForSeconds waitForSeconds); // 0x0000000180E18980-0x0000000180E189E0
			[IteratorStateMachine] // 0x000000018023D280-0x000000018023D2D0
			private static IEnumerator UnwrapWaitAsyncOperation(AsyncOperation asyncOperation); // 0x0000000180E188C0-0x0000000180E18920
		}
	
		// Extension methods
		public static IAwaiter GetAwaiter(this IEnumerator enumerator); // 0x0000000180E184D0-0x0000000180E18580
		public static UniTask ToUniTask(this IEnumerator enumerator); // 0x0000000180E18580-0x0000000180E18630
		public static UniTask ConfigureAwait(this IEnumerator enumerator, PlayerLoopTiming timing = PlayerLoopTiming.Update /* Metadata: 0x0077801B */, CancellationToken cancellationToken = default); // 0x0000000180E18440-0x0000000180E184D0
	}
}
