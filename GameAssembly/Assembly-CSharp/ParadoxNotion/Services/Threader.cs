/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace ParadoxNotion.Services
{
	public static class Threader // TypeDefIndex: 15272
	{
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass1_0<T1> // TypeDefIndex: 15273
		{
			// Fields
			public Action<T1> function;
			public T1 parameter1;
	
			// Constructors
			public <>c__DisplayClass1_0();
	
			// Methods
			internal void <StartAction>b__0();
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass2_0<T1, T2> // TypeDefIndex: 15274
		{
			// Fields
			public Action<T1, T2> function;
			public T1 parameter1;
			public T2 parameter2;
	
			// Constructors
			public <>c__DisplayClass2_0();
	
			// Methods
			internal void <StartAction>b__0();
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass3_0<T1, T2, T3> // TypeDefIndex: 15275
		{
			// Fields
			public Action<T1, T2, T3> function;
			public T1 parameter1;
			public T2 parameter2;
			public T3 parameter3;
	
			// Constructors
			public <>c__DisplayClass3_0();
	
			// Methods
			internal void <StartAction>b__0();
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass4_0<TResult> // TypeDefIndex: 15276
		{
			// Fields
			public TResult result;
			public Func<TResult> function;
			public Action<TResult> callback;
	
			// Constructors
			public <>c__DisplayClass4_0();
	
			// Methods
			internal void <StartFunction>b__0();
			internal void <StartFunction>b__1();
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass5_0<TResult, T1> // TypeDefIndex: 15277
		{
			// Fields
			public TResult result;
			public Func<T1, TResult> function;
			public T1 parameter1;
			public Action<TResult> callback;
	
			// Constructors
			public <>c__DisplayClass5_0();
	
			// Methods
			internal void <StartFunction>b__0();
			internal void <StartFunction>b__1();
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass6_0<TResult, T1, T2> // TypeDefIndex: 15278
		{
			// Fields
			public TResult result;
			public Func<T1, T2, TResult> function;
			public T1 parameter1;
			public T2 parameter2;
			public Action<TResult> callback;
	
			// Constructors
			public <>c__DisplayClass6_0();
	
			// Methods
			internal void <StartFunction>b__0();
			internal void <StartFunction>b__1();
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass7_0<TResult, T1, T2, T3> // TypeDefIndex: 15279
		{
			// Fields
			public TResult result;
			public Func<T1, T2, T3, TResult> function;
			public T1 parameter1;
			public T2 parameter2;
			public T3 parameter3;
			public Action<TResult> callback;
	
			// Constructors
			public <>c__DisplayClass7_0();
	
			// Methods
			internal void <StartFunction>b__0();
			internal void <StartFunction>b__1();
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ThreadUpdater>d__9 : IEnumerator<object> // TypeDefIndex: 15280
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Thread thread; // 0x20
			public Action callback; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ThreadUpdater>d__9(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018117A7D0-0x000000018117A870
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018117A870-0x000000018117A8C0
		}
	
		// Methods
		public static Thread StartAction(Action function, Action callback = null); // 0x0000000181177D20-0x0000000181177E40
		public static Thread StartAction<T1>(Action<T1> function, T1 parameter1, Action callback = null);
		public static Thread StartAction<T1, T2>(Action<T1, T2> function, T1 parameter1, T2 parameter2, Action callback = null);
		public static Thread StartAction<T1, T2, T3>(Action<T1, T2, T3> function, T1 parameter1, T2 parameter2, T3 parameter3, Action callback = null);
		public static Thread StartFunction<TResult>(Func<TResult> function, Action<TResult> callback = null);
		public static Thread StartFunction<TResult, T1>(Func<T1, TResult> function, T1 parameter1, Action<TResult> callback = null);
		public static Thread StartFunction<TResult, T1, T2>(Func<T1, T2, TResult> function, T1 parameter1, T2 parameter2, Action<TResult> callback = null);
		public static Thread StartFunction<TResult, T1, T2, T3>(Func<T1, T2, T3, TResult> function, T1 parameter1, T2 parameter2, T3 parameter3, Action<TResult> callback = null);
		private static void Begin(Thread thread, Action callback); // 0x0000000181177C70-0x0000000181177D20
		[IteratorStateMachine] // 0x00000001800C1BF0-0x00000001800C1C40
		private static IEnumerator ThreadUpdater(Thread thread, Action callback); // 0x0000000181177E40-0x0000000181177EB0
	}
}
