/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ParadoxNotion.Services
{
	public static class Threader // TypeDefIndex: 15858
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static bool <applicationIsPlaying>k__BackingField; // 0x00
	
		// Properties
		public static bool applicationIsPlaying { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001804E91F0-0x00000001804E9250 0x00000001804E9280-0x00000001804E92E0
		public static bool isMainThread { get; } // 0x00000001804E9250-0x00000001804E9280 
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass7_0 // TypeDefIndex: 15859
		{
			// Fields
			public Action function; // 0x10
	
			// Constructors
			public <>c__DisplayClass7_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void <StartAction>b__0(); // 0x00000001804ED330-0x00000001804ED350
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass8_0<T1> // TypeDefIndex: 15860
		{
			// Fields
			public Action<T1> function;
			public T1 parameter1;
	
			// Constructors
			public <>c__DisplayClass8_0();
	
			// Methods
			internal void <StartAction>b__0();
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass9_0<T1, T2> // TypeDefIndex: 15861
		{
			// Fields
			public Action<T1, T2> function;
			public T1 parameter1;
			public T2 parameter2;
	
			// Constructors
			public <>c__DisplayClass9_0();
	
			// Methods
			internal void <StartAction>b__0();
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass10_0<T1, T2, T3> // TypeDefIndex: 15862
		{
			// Fields
			public Action<T1, T2, T3> function;
			public T1 parameter1;
			public T2 parameter2;
			public T3 parameter3;
	
			// Constructors
			public <>c__DisplayClass10_0();
	
			// Methods
			internal void <StartAction>b__0();
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass11_0<TResult> // TypeDefIndex: 15863
		{
			// Fields
			public TResult result;
			public Func<TResult> function;
			public Action<TResult> callback;
	
			// Constructors
			public <>c__DisplayClass11_0();
	
			// Methods
			internal void <StartFunction>b__0();
			internal void <StartFunction>b__1();
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass12_0<TResult, T1> // TypeDefIndex: 15864
		{
			// Fields
			public TResult result;
			public Func<T1, TResult> function;
			public T1 parameter1;
			public Action<TResult> callback;
	
			// Constructors
			public <>c__DisplayClass12_0();
	
			// Methods
			internal void <StartFunction>b__0();
			internal void <StartFunction>b__1();
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass13_0<TResult, T1, T2> // TypeDefIndex: 15865
		{
			// Fields
			public TResult result;
			public Func<T1, T2, TResult> function;
			public T1 parameter1;
			public T2 parameter2;
			public Action<TResult> callback;
	
			// Constructors
			public <>c__DisplayClass13_0();
	
			// Methods
			internal void <StartFunction>b__0();
			internal void <StartFunction>b__1();
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass14_0<TResult, T1, T2, T3> // TypeDefIndex: 15866
		{
			// Fields
			public TResult result;
			public Func<T1, T2, T3, TResult> function;
			public T1 parameter1;
			public T2 parameter2;
			public T3 parameter3;
			public Action<TResult> callback;
	
			// Constructors
			public <>c__DisplayClass14_0();
	
			// Methods
			internal void <StartFunction>b__0();
			internal void <StartFunction>b__1();
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ThreadMonitor>d__16 : IEnumerator<object> // TypeDefIndex: 15867
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Thread thread; // 0x20
			public Action callback; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ThreadMonitor>d__16(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001804EC050-0x00000001804EC110
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001804EC110-0x00000001804EC160
		}
	
		// Constructors
		static Threader(); // 0x00000001804E9190-0x00000001804E91F0
	
		// Methods
		public static Thread StartAction(Thread thread, Action function, Action callback = null); // 0x00000001804E8F70-0x00000001804E9120
		public static Thread StartAction<T1>(Thread thread, Action<T1> function, T1 parameter1, Action callback = null);
		public static Thread StartAction<T1, T2>(Thread thread, Action<T1, T2> function, T1 parameter1, T2 parameter2, Action callback = null);
		public static Thread StartAction<T1, T2, T3>(Thread thread, Action<T1, T2, T3> function, T1 parameter1, T2 parameter2, T3 parameter3, Action callback = null);
		public static Thread StartFunction<TResult>(Thread thread, Func<TResult> function, Action<TResult> callback = null);
		public static Thread StartFunction<TResult, T1>(Thread thread, Func<T1, TResult> function, T1 parameter1, Action<TResult> callback = null);
		public static Thread StartFunction<TResult, T1, T2>(Thread thread, Func<T1, T2, TResult> function, T1 parameter1, T2 parameter2, Action<TResult> callback = null);
		public static Thread StartFunction<TResult, T1, T2, T3>(Thread thread, Func<T1, T2, T3, TResult> function, T1 parameter1, T2 parameter2, T3 parameter3, Action<TResult> callback = null);
		private static void Begin(Thread thread, Action callback); // 0x00000001804E8E80-0x00000001804E8F70
		[IteratorStateMachine] // 0x0000000180258430-0x0000000180258480
		private static IEnumerator ThreadMonitor(Thread thread, Action callback); // 0x00000001804E9120-0x00000001804E9190
	}
}
