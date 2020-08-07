/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;
using UniRx.Async.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class PaymentsSrvHandler // TypeDefIndex: 12516
{
	// Properties
	public static string Host { get; } // 0x00000001804DFA90-0x00000001804DFAF0 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestStorePageURL>d__2 : IAsyncStateMachine // TypeDefIndex: 12517
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder<WWWResponse<StorePageURLResponse>> <>t__builder; // 0x08
		public string inIAPItemId; // 0x20
		private TaskAwaiter<WWWResponse<StorePageURLResponse>> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x0000000180005CA0-0x0000000180005CB0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180005CB0-0x0000000180005F40
	}

	// Constructors
	public PaymentsSrvHandler(); // 0x0000000180373240-0x0000000180373250

	// Methods
	[AsyncStateMachine] // 0x00000001801DBCA0-0x00000001801DBCF0
	public static UniTask<WWWResponse<StorePageURLResponse>> RequestStorePageURL(string inIAPItemId); // 0x00000001804DF9B0-0x00000001804DFA90
}

