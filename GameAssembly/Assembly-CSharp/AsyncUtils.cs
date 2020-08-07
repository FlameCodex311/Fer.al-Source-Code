/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public static class AsyncUtils // TypeDefIndex: 10852
{
	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 10853
	{
		// Fields
		public DateTime endTime; // 0x10
		public bool timedOut; // 0x18
		public Predicate<bool> condition; // 0x20

		// Constructors
		public <>c__DisplayClass0_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <WaitFor>b__0(); // 0x0000000182160330-0x00000001821603E0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <WaitFor>d__0 : IAsyncStateMachine // TypeDefIndex: 10854
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x08
		public Predicate<bool> condition; // 0x20
		public double timeoutSeconds; // 0x28
		private <>c__DisplayClass0_0 <>8__1; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x000000018031D270-0x000000018031D280
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018031D280-0x000000018031D2D0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0<T> // TypeDefIndex: 10855
		where T : class, IMessage
	{
		// Fields
		public T message;

		// Constructors
		public <>c__DisplayClass1_0();

		// Methods
		internal void <WaitForMessage>b__0(T m);
		internal bool <WaitForMessage>b__1(bool b);
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <WaitForMessage>d__1<T> : IAsyncStateMachine // TypeDefIndex: 10856
		where T : class, IMessage
	{
		// Fields
		public int <>1__state;
		public AsyncTaskMethodBuilder<T> <>t__builder;
		public double timeoutSeconds;
		private <>c__DisplayClass1_0<T> <>8__1;
		private Action<T> <action>5__2;
		private TaskAwaiter<bool> <>u__1;

		// Methods
		private void MoveNext();
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine);
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <WaitFor>d__2 : IAsyncStateMachine // TypeDefIndex: 10857
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x08
		public Predicate<bool> condition; // 0x20
		public double timeoutSeconds; // 0x28
		private TaskAwaiter<bool> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x000000018031D2D0-0x000000018031D2E0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018031D2E0-0x000000018031D3D0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <WaitForMessage>d__3<T> : IAsyncStateMachine // TypeDefIndex: 10858
		where T : class, IMessage
	{
		// Fields
		public int <>1__state;
		public AsyncTaskMethodBuilder<T> <>t__builder;
		public double timeoutSeconds;
		private TaskAwaiter<T> <>u__1;

		// Methods
		private void MoveNext();
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine);
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <FireAndForget>d__4 : IAsyncStateMachine // TypeDefIndex: 10859
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public Task task; // 0x28
		private TaskAwaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x000000018031CF90-0x000000018031CFA0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Methods
	[AsyncStateMachine] // 0x00000001801DAEE0-0x00000001801DAF30
	private static Task<bool> WaitFor(Predicate<bool> condition, double timeoutSeconds); // 0x00000001821569B0-0x0000000182156AB0
	[AsyncStateMachine] // 0x00000001801DB310-0x00000001801DB360
	private static Task<T> WaitForMessage<T>(double timeoutSeconds)
		where T : class, IMessage;

	// Extension methods
	[AsyncStateMachine] // 0x00000001801DB610-0x00000001801DB680
	public static Task<bool> WaitFor(this MonoBehaviour me, Predicate<bool> condition, double timeoutSeconds); // 0x00000001821568B0-0x00000001821569B0
	[AsyncStateMachine] // 0x00000001801DB780-0x00000001801DB7F0
	public static Task<T> WaitForMessage<T>(this MonoBehaviour me, double timeoutSeconds)
		where T : class, IMessage;
	[AsyncStateMachine] // 0x00000001801DB9B0-0x00000001801DBA20
	public static void FireAndForget(this Task task); // 0x0000000182156800-0x00000001821568B0
}

