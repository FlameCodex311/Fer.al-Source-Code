/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public static class ChatUtils // TypeDefIndex: 11721
{
	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <Private>d__3 : IAsyncStateMachine // TypeDefIndex: 11722
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public string inText; // 0x28
		private int <ii>5__2; // 0x30
		private UniTask<UserInfo> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x0000000180006630-0x0000000180006640
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <Block>d__8 : IAsyncStateMachine // TypeDefIndex: 11723
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public string inText; // 0x28
		public bool inBlock; // 0x30
		private TaskAwaiter<RelationshipFollowingFindPlayerUUIDResponse> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001800064F0-0x0000000180006500
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <Favorite>d__9 : IAsyncStateMachine // TypeDefIndex: 11724
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public string inText; // 0x28
		public bool inFavorite; // 0x30
		private TaskAwaiter<RelationshipFollowingFindPlayerUUIDResponse> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x0000000180006500-0x0000000180006510
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <Follow>d__10 : IAsyncStateMachine // TypeDefIndex: 11725
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public string inText; // 0x28
		public bool inFollow; // 0x30
		private TaskAwaiter<RelationshipFollowingFindPlayerUUIDResponse> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x0000000180006510-0x0000000180006520
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <Sanctuary>d__11 : IAsyncStateMachine // TypeDefIndex: 11726
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public string inText; // 0x28
		private TaskAwaiter<RelationshipFollowingFindPlayerUUIDResponse> <>u__1; // 0x30
		private TaskAwaiter<bool> <>u__2; // 0x38

		// Methods
		private void MoveNext(); // 0x0000000180006640-0x0000000180006650
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Methods
	public static void Action(string inChatText); // 0x0000000180520D40-0x0000000180521560
	private static bool ParseAction(string inChatText, string inAction, out string outText); // 0x00000001805217A0-0x0000000180521840
	private static void Help(); // 0x00000001803774A0-0x00000001803774B0
	[AsyncStateMachine] // 0x0000000180247710-0x0000000180247760
	private static void Private(string inText); // 0x0000000180521840-0x00000001805218F0
	private static void Party(string inText); // 0x00000001803774A0-0x00000001803774B0
	private static void GiveMe(string inText); // 0x00000001803774A0-0x00000001803774B0
	private static void GiveMeLikes(string inText); // 0x00000001803774A0-0x00000001803774B0
	private static void GiveMeAll(string inText); // 0x00000001803774A0-0x00000001803774B0
	[AsyncStateMachine] // 0x00000001802478F0-0x0000000180247940
	private static void Block(string inText, bool inBlock); // 0x0000000180521560-0x0000000180521620
	[AsyncStateMachine] // 0x0000000180247C50-0x0000000180247CA0
	private static void Favorite(string inText, bool inFavorite); // 0x0000000180521620-0x00000001805216E0
	[AsyncStateMachine] // 0x0000000180247E50-0x0000000180247EA0
	private static void Follow(string inText, bool inFollow); // 0x00000001805216E0-0x00000001805217A0
	[AsyncStateMachine] // 0x0000000180247FF0-0x0000000180248040
	private static void Sanctuary(string inText); // 0x00000001805218F0-0x00000001805219A0
	private static void Goto(string inText); // 0x00000001803774A0-0x00000001803774B0
}

