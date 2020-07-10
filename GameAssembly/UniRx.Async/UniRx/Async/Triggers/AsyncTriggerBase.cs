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

// Image 68: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8376-8739

namespace UniRx.Async.Triggers
{
	public abstract class AsyncTriggerBase : UnityEngine.MonoBehaviour // TypeDefIndex: 8677
	{
		// Fields
		private static readonly Action<object> Callback; // 0x00
		private bool calledAwake; // 0x18
		private bool destroyCalled; // 0x19
		private CancellationTokenRegistration[] registeredCancellations; // 0x20
		private int registeredCancellationsCount; // 0x28
	
		// Nested types
		private class AwakeMonitor : IPlayerLoopItem // TypeDefIndex: 8678
		{
			// Fields
			private readonly AsyncTriggerBase trigger; // 0x10
	
			// Constructors
			public AwakeMonitor(AsyncTriggerBase trigger); // 0x000000018037D3F0-0x000000018037D420
	
			// Methods
			public bool MoveNext(); // 0x00000001816681A0-0x0000000181668240
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Concat>d__6 : IEnumerable<ICancelablePromise>, IEnumerator<ICancelablePromise> // TypeDefIndex: 8679
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
			ICancelablePromise IEnumerator<UniRx.Async.Triggers.ICancelablePromise>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <Concat>d__6(int <>1__state); // 0x000000018094DE20-0x000000018094DE50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001816702F0-0x00000001816703A0
			private bool MoveNext(); // 0x0000000181670070-0x0000000181670200
			private void <>m__Finally1(); // 0x00000001816703A0-0x00000001816703F0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001816702A0-0x00000001816702F0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<ICancelablePromise> IEnumerable<ICancelablePromise>.GetEnumerator(); // 0x0000000181670200-0x00000001816702A0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000181670200-0x00000001816702A0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Concat>d__7 : IEnumerable<ICancelablePromise>, IEnumerator<ICancelablePromise> // TypeDefIndex: 8680
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
			ICancelablePromise IEnumerator<UniRx.Async.Triggers.ICancelablePromise>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <Concat>d__7(int <>1__state); // 0x000000018094DE20-0x000000018094DE50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x0000000181670740-0x0000000181670890
			private bool MoveNext(); // 0x00000001816703F0-0x0000000181670640
			private void <>m__Finally1(); // 0x0000000181670890-0x00000001816708E0
			private void <>m__Finally2(); // 0x00000001816708E0-0x0000000181670930
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001816706F0-0x0000000181670740
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<ICancelablePromise> IEnumerable<ICancelablePromise>.GetEnumerator(); // 0x0000000181670640-0x00000001816706F0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000181670640-0x00000001816706F0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Concat>d__8 : IEnumerable<ICancelablePromise>, IEnumerator<ICancelablePromise> // TypeDefIndex: 8681
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
			ICancelablePromise IEnumerator<UniRx.Async.Triggers.ICancelablePromise>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <Concat>d__8(int <>1__state); // 0x000000018094DE20-0x000000018094DE50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x0000000181670D50-0x0000000181670F50
			private bool MoveNext(); // 0x0000000181670930-0x0000000181670C40
			private void <>m__Finally1(); // 0x0000000181670F50-0x0000000181670FA0
			private void <>m__Finally2(); // 0x0000000181670FA0-0x0000000181670FF0
			private void <>m__Finally3(); // 0x0000000181670FF0-0x0000000181671040
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181670D00-0x0000000181670D50
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<ICancelablePromise> IEnumerable<ICancelablePromise>.GetEnumerator(); // 0x0000000181670C40-0x0000000181670D00
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000181670C40-0x0000000181670D00
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Concat>d__9 : IEnumerable<ICancelablePromise>, IEnumerator<ICancelablePromise> // TypeDefIndex: 8682
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
			ICancelablePromise IEnumerator<UniRx.Async.Triggers.ICancelablePromise>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <Concat>d__9(int <>1__state); // 0x000000018094DE20-0x000000018094DE50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x0000000181671560-0x0000000181671730
			private bool MoveNext(); // 0x0000000181671040-0x0000000181671430
			private void <>m__Finally1(); // 0x0000000181671730-0x0000000181671780
			private void <>m__Finally2(); // 0x0000000181671780-0x00000001816717D0
			private void <>m__Finally3(); // 0x00000001816717D0-0x0000000181671820
			private void <>m__Finally4(); // 0x0000000181671820-0x0000000181671870
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181671510-0x0000000181671560
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<ICancelablePromise> IEnumerable<ICancelablePromise>.GetEnumerator(); // 0x0000000181671430-0x0000000181671510
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000181671430-0x0000000181671510
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Concat>d__10 : IEnumerable<ICancelablePromise>, IEnumerator<ICancelablePromise> // TypeDefIndex: 8683
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
			ICancelablePromise IEnumerator<UniRx.Async.Triggers.ICancelablePromise>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <Concat>d__10(int <>1__state); // 0x000000018094DE20-0x000000018094DE50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x000000018166FF70-0x0000000181670020
			private bool MoveNext(); // 0x000000018166FC70-0x000000018166FE80
			private void <>m__Finally1(); // 0x0000000181670020-0x0000000181670070
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018166FF20-0x000000018166FF70
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<ICancelablePromise> IEnumerable<ICancelablePromise>.GetEnumerator(); // 0x000000018166FE80-0x000000018166FF20
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018166FE80-0x000000018166FF20
		}
	
		// Constructors
		protected AsyncTriggerBase(); // 0x0000000180407560-0x0000000180407570
		static AsyncTriggerBase(); // 0x0000000181664F40-0x0000000181664FA0
	
		// Methods
		protected abstract IEnumerable<ICancelablePromise> GetPromises();
		[IteratorStateMachine] // 0x000000018012AAB0-0x000000018012AB00
		protected static IEnumerable<ICancelablePromise> Concat(ICancelablePromise p1, IEnumerable<ICancelablePromise> p1s); // 0x0000000181664A00-0x0000000181664A80
		[IteratorStateMachine] // 0x000000018012C110-0x000000018012C160
		protected static IEnumerable<ICancelablePromise> Concat(ICancelablePromise p1, IEnumerable<ICancelablePromise> p1s, ICancelablePromise p2, IEnumerable<ICancelablePromise> p2s); // 0x00000001816648F0-0x0000000181664990
		[IteratorStateMachine] // 0x000000018012C480-0x000000018012C4D0
		protected static IEnumerable<ICancelablePromise> Concat(ICancelablePromise p1, IEnumerable<ICancelablePromise> p1s, ICancelablePromise p2, IEnumerable<ICancelablePromise> p2s, ICancelablePromise p3, IEnumerable<ICancelablePromise> p3s); // 0x0000000181664A80-0x0000000181664B30
		[IteratorStateMachine] // 0x000000018012C820-0x000000018012C870
		protected static IEnumerable<ICancelablePromise> Concat(ICancelablePromise p1, IEnumerable<ICancelablePromise> p1s, ICancelablePromise p2, IEnumerable<ICancelablePromise> p2s, ICancelablePromise p3, IEnumerable<ICancelablePromise> p3s, ICancelablePromise p4, IEnumerable<ICancelablePromise> p4s); // 0x0000000181664B30-0x0000000181664C00
		[IteratorStateMachine] // 0x000000018012C9D0-0x000000018012CA20
		protected static IEnumerable<ICancelablePromise> Concat(params /* 0x00000001800B36B0-0x00000001800B36C0 */ object[] promises); // 0x0000000181664990-0x0000000181664A00
		protected UniTask<T> GetOrAddPromise<T>(ref AsyncTriggerPromise<T> promise, ref AsyncTriggerPromiseDictionary<T> promises, CancellationToken cancellationToken);
		private static void CancelCallback(object state); // 0x0000000181664730-0x00000001816648F0
		protected void TrySetResult<T>(ReusablePromise<T> promise, AsyncTriggerPromiseDictionary<T> promises, T value);
		private void Awake(); // 0x000000018050A050-0x000000018050A060
		private void OnDestroy(); // 0x0000000181664C00-0x0000000181664F40
	}
}
