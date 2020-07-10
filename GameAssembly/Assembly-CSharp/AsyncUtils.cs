/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public static class AsyncUtils // TypeDefIndex: 13186
{
	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 13187
	{
		// Fields
		public DateTime endTime; // 0x10
		public bool timedOut; // 0x18
		public Predicate<bool> condition; // 0x20

		// Constructors
		public <>c__DisplayClass0_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <WaitFor>b__0(); // 0x000000018104D6B0-0x000000018104D760
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <WaitFor>d__0 : IAsyncStateMachine // TypeDefIndex: 13188
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x08
		public Predicate<bool> condition; // 0x20
		public double timeoutSeconds; // 0x28
		private <>c__DisplayClass0_0 <>8__1; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F8250-0x00000001801F8260
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F8260-0x00000001801F82B0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0<T> // TypeDefIndex: 13189
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

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <WaitForMessage>d__1<T> : IAsyncStateMachine // TypeDefIndex: 13190
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
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine);
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <WaitFor>d__2 : IAsyncStateMachine // TypeDefIndex: 13191
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x08
		public Predicate<bool> condition; // 0x20
		public double timeoutSeconds; // 0x28
		private TaskAwaiter<bool> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F82B0-0x00000001801F82C0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F82C0-0x00000001801F8410
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <WaitForMessage>d__3<T> : IAsyncStateMachine // TypeDefIndex: 13192
		where T : class, IMessage
	{
		// Fields
		public int <>1__state;
		public AsyncTaskMethodBuilder<T> <>t__builder;
		public double timeoutSeconds;
		private TaskAwaiter<T> <>u__1;

		// Methods
		private void MoveNext();
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine);
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <FireAndForget>d__4 : IAsyncStateMachine // TypeDefIndex: 13193
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public Task task; // 0x28
		private TaskAwaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F7F70-0x00000001801F7F80
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Methods
	[AsyncStateMachine] // 0x0000000180106DE0-0x0000000180106E30
	private static Task<bool> WaitFor(Predicate<bool> condition, double timeoutSeconds); // 0x000000018103D950-0x000000018103DA50
	[AsyncStateMachine] // 0x0000000180106F80-0x0000000180106FD0
	private static Task<T> WaitForMessage<T>(double timeoutSeconds)
		where T : class, IMessage;

	// Extension methods
	[AsyncStateMachine] // 0x0000000180107180-0x00000001801071F0
	public static Task<bool> WaitFor(this MonoBehaviour me, Predicate<bool> condition, double timeoutSeconds); // 0x000000018103D850-0x000000018103D950
	[AsyncStateMachine] // 0x0000000180107520-0x0000000180107590
	public static Task<T> WaitForMessage<T>(this MonoBehaviour me, double timeoutSeconds)
		where T : class, IMessage;
	[AsyncStateMachine] // 0x0000000180107710-0x0000000180107780
	public static void FireAndForget(this Task task); // 0x000000018103D7A0-0x000000018103D850
}

