/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;
using UniRx.Async.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class PaymentsSrvHandler // TypeDefIndex: 10991
{
	// Properties
	public static string Host { get; } // 0x0000000181172990-0x00000001811729F0 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestStorePageURL>d__2 : IAsyncStateMachine // TypeDefIndex: 10992
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder<WWWResponse<StorePageURLResponse>> <>t__builder; // 0x08
		public string inIAPItemId; // 0x20
		private TaskAwaiter<WWWResponse<StorePageURLResponse>> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x000000018020D3D0-0x000000018020D3E0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018020D3E0-0x000000018020D430
	}

	// Constructors
	public PaymentsSrvHandler(); // 0x000000018036B6C0-0x000000018036B6D0

	// Methods
	[AsyncStateMachine] // 0x0000000180102870-0x00000001801028C0
	public static UniTask<WWWResponse<StorePageURLResponse>> RequestStorePageURL(string inIAPItemId); // 0x00000001811728B0-0x0000000181172990
}

