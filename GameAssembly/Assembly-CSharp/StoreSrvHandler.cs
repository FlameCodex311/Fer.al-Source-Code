/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;
using UniRx.Async.CompilerServices;
using WW.Debug;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class StoreSrvHandler // TypeDefIndex: 12549
{
	// Properties
	public static string Host { get; } // 0x0000000180CB9210-0x0000000180CB9270 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestIAPs>d__2 : IAsyncStateMachine // TypeDefIndex: 12550
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder<ListIAPsResponse> <>t__builder; // 0x08
		private TaskAwaiter<WWWResponse> <>u__1; // 0x20

		// Methods
		private void MoveNext(); // 0x000000018006C0F0-0x000000018006C100
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018006C100-0x000000018006C170
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <DEBUG_RequestIAPs>d__3 : IAsyncStateMachine // TypeDefIndex: 12551
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		private UniTask<ListIAPsResponse> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x000000018006C0E0-0x000000018006C0F0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public StoreSrvHandler(); // 0x0000000180373240-0x0000000180373250

	// Methods
	[AsyncStateMachine] // 0x00000001801E3380-0x00000001801E33D0
	public static UniTask<ListIAPsResponse> RequestIAPs(); // 0x0000000180CB9150-0x0000000180CB9210
	[AsyncStateMachine] // 0x00000001801E36C0-0x00000001801E3760
	[DebugButton] // 0x00000001801E36C0-0x00000001801E3760
	public static void DEBUG_RequestIAPs(); // 0x0000000180CB90B0-0x0000000180CB9150
}

