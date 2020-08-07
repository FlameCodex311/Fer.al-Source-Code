/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UniRx.Async;
using UniRx.Async.Internal;
using UnityEngine;

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async.Triggers
{
	public abstract class AsyncTriggerBase : UnityEngine.MonoBehaviour // TypeDefIndex: 8843
	{
		// Fields
		private static readonly Action<object> Callback; // 0x00
		private bool calledAwake; // 0x18
		private bool destroyCalled; // 0x19
		private CancellationTokenRegistration[] registeredCancellations; // 0x20
		private int registeredCancellationsCount; // 0x28
	
		// Nested types
		private class AwakeMonitor : IPlayerLoopItem // TypeDefIndex: 8844
		{
			// Fields
			private readonly AsyncTriggerBase trigger; // 0x10
	
			// Constructors
			public AwakeMonitor(AsyncTriggerBase trigger); // 0x0000000180400150-0x0000000180400180
	
			// Methods
			public bool MoveNext(); // 0x0000000180E15210-0x0000000180E152B0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Concat>d__6 : IEnumerable<ICancelablePromise>, IEnumerator<ICancelablePromise> // TypeDefIndex: 8845
		{
			// Fields
			private int <>1__state; // 0x10
			private ICancelablePromise <>2__current; // 0x18
			private int <>l__initialThreadId; // 0x20
			private ICancelablePromise p1; // 0x28
			public ICancelablePromise <>3__p1; // 0x30
			private IEnumerable<ICancelablePromise> p1s; // 0x38
			public IEnumerable<ICancelablePromise> <>3__p1s; // 0x40
			private IEnumerator<ICancelablePromise> <>7__wrap1; // 0x48
	
			// Properties
			ICancelablePromise IEnumerator<UniRx.Async.Triggers.ICancelablePromise>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Concat>d__6(int <>1__state); // 0x00000001806301B0-0x00000001806301E0
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x0000000180E1CD20-0x0000000180E1CDD0
			private bool MoveNext(); // 0x0000000180E1CAB0-0x0000000180E1CC30
			private void <>m__Finally1(); // 0x0000000180E1CDD0-0x0000000180E1CE20
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E1CCD0-0x0000000180E1CD20
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<ICancelablePromise> IEnumerable<ICancelablePromise>.GetEnumerator(); // 0x0000000180E1CC30-0x0000000180E1CCD0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180E1CC30-0x0000000180E1CCD0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Concat>d__7 : IEnumerable<ICancelablePromise>, IEnumerator<ICancelablePromise> // TypeDefIndex: 8846
		{
			// Fields
			private int <>1__state; // 0x10
			private ICancelablePromise <>2__current; // 0x18
			private int <>l__initialThreadId; // 0x20
			private ICancelablePromise p1; // 0x28
			public ICancelablePromise <>3__p1; // 0x30
			private IEnumerable<ICancelablePromise> p1s; // 0x38
			public IEnumerable<ICancelablePromise> <>3__p1s; // 0x40
			private ICancelablePromise p2; // 0x48
			public ICancelablePromise <>3__p2; // 0x50
			private IEnumerable<ICancelablePromise> p2s; // 0x58
			public IEnumerable<ICancelablePromise> <>3__p2s; // 0x60
			private IEnumerator<ICancelablePromise> <>7__wrap1; // 0x68
	
			// Properties
			ICancelablePromise IEnumerator<UniRx.Async.Triggers.ICancelablePromise>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Concat>d__7(int <>1__state); // 0x00000001806301B0-0x00000001806301E0
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x0000000180E1D170-0x0000000180E1D2C0
			private bool MoveNext(); // 0x0000000180E1CE20-0x0000000180E1D070
			private void <>m__Finally1(); // 0x0000000180E1D2C0-0x0000000180E1D310
			private void <>m__Finally2(); // 0x0000000180E1D310-0x0000000180E1D360
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E1D120-0x0000000180E1D170
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<ICancelablePromise> IEnumerable<ICancelablePromise>.GetEnumerator(); // 0x0000000180E1D070-0x0000000180E1D120
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180E1D070-0x0000000180E1D120
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Concat>d__8 : IEnumerable<ICancelablePromise>, IEnumerator<ICancelablePromise> // TypeDefIndex: 8847
		{
			// Fields
			private int <>1__state; // 0x10
			private ICancelablePromise <>2__current; // 0x18
			private int <>l__initialThreadId; // 0x20
			private ICancelablePromise p1; // 0x28
			public ICancelablePromise <>3__p1; // 0x30
			private IEnumerable<ICancelablePromise> p1s; // 0x38
			public IEnumerable<ICancelablePromise> <>3__p1s; // 0x40
			private ICancelablePromise p2; // 0x48
			public ICancelablePromise <>3__p2; // 0x50
			private IEnumerable<ICancelablePromise> p2s; // 0x58
			public IEnumerable<ICancelablePromise> <>3__p2s; // 0x60
			private ICancelablePromise p3; // 0x68
			public ICancelablePromise <>3__p3; // 0x70
			private IEnumerable<ICancelablePromise> p3s; // 0x78
			public IEnumerable<ICancelablePromise> <>3__p3s; // 0x80
			private IEnumerator<ICancelablePromise> <>7__wrap1; // 0x88
	
			// Properties
			ICancelablePromise IEnumerator<UniRx.Async.Triggers.ICancelablePromise>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Concat>d__8(int <>1__state); // 0x00000001806301B0-0x00000001806301E0
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x0000000180E1D770-0x0000000180E1D960
			private bool MoveNext(); // 0x0000000180E1D360-0x0000000180E1D660
			private void <>m__Finally1(); // 0x0000000180E1D960-0x0000000180E1D9B0
			private void <>m__Finally2(); // 0x0000000180E1D9B0-0x0000000180E1DA00
			private void <>m__Finally3(); // 0x0000000180E1DA00-0x0000000180E1DA50
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E1D720-0x0000000180E1D770
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<ICancelablePromise> IEnumerable<ICancelablePromise>.GetEnumerator(); // 0x0000000180E1D660-0x0000000180E1D720
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180E1D660-0x0000000180E1D720
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Concat>d__9 : IEnumerable<ICancelablePromise>, IEnumerator<ICancelablePromise> // TypeDefIndex: 8848
		{
			// Fields
			private int <>1__state; // 0x10
			private ICancelablePromise <>2__current; // 0x18
			private int <>l__initialThreadId; // 0x20
			private ICancelablePromise p1; // 0x28
			public ICancelablePromise <>3__p1; // 0x30
			private IEnumerable<ICancelablePromise> p1s; // 0x38
			public IEnumerable<ICancelablePromise> <>3__p1s; // 0x40
			private ICancelablePromise p2; // 0x48
			public ICancelablePromise <>3__p2; // 0x50
			private IEnumerable<ICancelablePromise> p2s; // 0x58
			public IEnumerable<ICancelablePromise> <>3__p2s; // 0x60
			private ICancelablePromise p3; // 0x68
			public ICancelablePromise <>3__p3; // 0x70
			private IEnumerable<ICancelablePromise> p3s; // 0x78
			public IEnumerable<ICancelablePromise> <>3__p3s; // 0x80
			private ICancelablePromise p4; // 0x88
			public ICancelablePromise <>3__p4; // 0x90
			private IEnumerable<ICancelablePromise> p4s; // 0x98
			public IEnumerable<ICancelablePromise> <>3__p4s; // 0xA0
			private IEnumerator<ICancelablePromise> <>7__wrap1; // 0xA8
	
			// Properties
			ICancelablePromise IEnumerator<UniRx.Async.Triggers.ICancelablePromise>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Concat>d__9(int <>1__state); // 0x00000001806301B0-0x00000001806301E0
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x0000000180E1DF50-0x0000000180E1E110
			private bool MoveNext(); // 0x0000000180E1DA50-0x0000000180E1DE20
			private void <>m__Finally1(); // 0x0000000180E1E110-0x0000000180E1E160
			private void <>m__Finally2(); // 0x0000000180E1E160-0x0000000180E1E1B0
			private void <>m__Finally3(); // 0x0000000180E1E1B0-0x0000000180E1E200
			private void <>m__Finally4(); // 0x0000000180E1E200-0x0000000180E1E250
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E1DF00-0x0000000180E1DF50
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<ICancelablePromise> IEnumerable<ICancelablePromise>.GetEnumerator(); // 0x0000000180E1DE20-0x0000000180E1DF00
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180E1DE20-0x0000000180E1DF00
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Concat>d__10 : IEnumerable<ICancelablePromise>, IEnumerator<ICancelablePromise> // TypeDefIndex: 8849
		{
			// Fields
			private int <>1__state; // 0x10
			private ICancelablePromise <>2__current; // 0x18
			private int <>l__initialThreadId; // 0x20
			private object[] promises; // 0x28
			public object[] <>3__promises; // 0x30
			private object[] <>7__wrap1; // 0x38
			private int <>7__wrap2; // 0x40
			private IEnumerator<ICancelablePromise> <>7__wrap3; // 0x48
	
			// Properties
			ICancelablePromise IEnumerator<UniRx.Async.Triggers.ICancelablePromise>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Concat>d__10(int <>1__state); // 0x00000001806301B0-0x00000001806301E0
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x0000000180E1C9B0-0x0000000180E1CA60
			private bool MoveNext(); // 0x0000000180E1C6C0-0x0000000180E1C8C0
			private void <>m__Finally1(); // 0x0000000180E1CA60-0x0000000180E1CAB0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E1C960-0x0000000180E1C9B0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<ICancelablePromise> IEnumerable<ICancelablePromise>.GetEnumerator(); // 0x0000000180E1C8C0-0x0000000180E1C960
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180E1C8C0-0x0000000180E1C960
		}
	
		// Constructors
		protected AsyncTriggerBase(); // 0x0000000180568C50-0x0000000180569020
		static AsyncTriggerBase(); // 0x0000000180E12680-0x0000000180E126E0
	
		// Methods
		protected abstract IEnumerable<ICancelablePromise> GetPromises();
		[IteratorStateMachine] // 0x000000018028F040-0x000000018028F090
		protected static IEnumerable<ICancelablePromise> Concat(ICancelablePromise p1, IEnumerable<ICancelablePromise> p1s); // 0x0000000180E12140-0x0000000180E121C0
		[IteratorStateMachine] // 0x000000018028F290-0x000000018028F2E0
		protected static IEnumerable<ICancelablePromise> Concat(ICancelablePromise p1, IEnumerable<ICancelablePromise> p1s, ICancelablePromise p2, IEnumerable<ICancelablePromise> p2s); // 0x0000000180E12030-0x0000000180E120D0
		[IteratorStateMachine] // 0x000000018028F490-0x000000018028F4E0
		protected static IEnumerable<ICancelablePromise> Concat(ICancelablePromise p1, IEnumerable<ICancelablePromise> p1s, ICancelablePromise p2, IEnumerable<ICancelablePromise> p2s, ICancelablePromise p3, IEnumerable<ICancelablePromise> p3s); // 0x0000000180E121C0-0x0000000180E12270
		[IteratorStateMachine] // 0x000000018028F750-0x000000018028F7A0
		protected static IEnumerable<ICancelablePromise> Concat(ICancelablePromise p1, IEnumerable<ICancelablePromise> p1s, ICancelablePromise p2, IEnumerable<ICancelablePromise> p2s, ICancelablePromise p3, IEnumerable<ICancelablePromise> p3s, ICancelablePromise p4, IEnumerable<ICancelablePromise> p4s); // 0x0000000180E12270-0x0000000180E12340
		[IteratorStateMachine] // 0x000000018028F970-0x000000018028F9C0
		protected static IEnumerable<ICancelablePromise> Concat(params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ object[] promises); // 0x0000000180E120D0-0x0000000180E12140
		protected UniTask<T> GetOrAddPromise<T>(ref AsyncTriggerPromise<T> promise, ref AsyncTriggerPromiseDictionary<T> promises, CancellationToken cancellationToken);
		private static void CancelCallback(object state); // 0x0000000180E11E70-0x0000000180E12030
		protected void TrySetResult<T>(ReusablePromise<T> promise, AsyncTriggerPromiseDictionary<T> promises, T value);
		private void Awake(); // 0x0000000180B32300-0x0000000180B32310
		private void OnDestroy(); // 0x0000000180E12340-0x0000000180E12680
	}
}
