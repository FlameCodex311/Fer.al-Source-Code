/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;
using UniRx.Async.CompilerServices;
using WW.Debug;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class StoreSrvHandler // TypeDefIndex: 11024
{
	// Properties
	public static string Host { get; } // 0x000000018135E280-0x000000018135E2E0 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestIAPs>d__2 : IAsyncStateMachine // TypeDefIndex: 11025
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder<ListIAPsResponse> <>t__builder; // 0x08
		private TaskAwaiter<WWWResponse> <>u__1; // 0x20

		// Methods
		private void MoveNext(); // 0x0000000180213400-0x0000000180213410
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180213410-0x0000000180213460
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <DEBUG_RequestIAPs>d__3 : IAsyncStateMachine // TypeDefIndex: 11026
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		private UniTask<ListIAPsResponse> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001802133F0-0x0000000180213400
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public StoreSrvHandler(); // 0x000000018036B6C0-0x000000018036B6D0

	// Methods
	[AsyncStateMachine] // 0x0000000180106720-0x0000000180106770
	public static UniTask<ListIAPsResponse> RequestIAPs(); // 0x000000018135E1C0-0x000000018135E280
	[AsyncStateMachine] // 0x0000000180106A70-0x0000000180106B10
	[DebugButton] // 0x0000000180106A70-0x0000000180106B10
	public static void DEBUG_RequestIAPs(); // 0x000000018135E120-0x000000018135E1C0
}

