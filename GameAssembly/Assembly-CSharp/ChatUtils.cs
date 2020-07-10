/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public static class ChatUtils // TypeDefIndex: 10230
{
	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <Private>d__3 : IAsyncStateMachine // TypeDefIndex: 10231
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public string inText; // 0x28
		private int <ii>5__2; // 0x30
		private UniTask<UserInfo> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F7CE0-0x00000001801F7CF0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <Block>d__8 : IAsyncStateMachine // TypeDefIndex: 10232
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public string inText; // 0x28
		public bool inBlock; // 0x30
		private TaskAwaiter<RelationshipFollowingFindPlayerUUIDResponse> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F7AE0-0x00000001801F7AF0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <Favorite>d__9 : IAsyncStateMachine // TypeDefIndex: 10233
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public string inText; // 0x28
		public bool inFavorite; // 0x30
		private TaskAwaiter<RelationshipFollowingFindPlayerUUIDResponse> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F7B50-0x00000001801F7B60
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <Follow>d__10 : IAsyncStateMachine // TypeDefIndex: 10234
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public string inText; // 0x28
		public bool inFollow; // 0x30
		private TaskAwaiter<RelationshipFollowingFindPlayerUUIDResponse> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F7B60-0x00000001801F7B70
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <Sanctuary>d__11 : IAsyncStateMachine // TypeDefIndex: 10235
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public string inText; // 0x28
		private TaskAwaiter<RelationshipFollowingFindPlayerUUIDResponse> <>u__1; // 0x30
		private TaskAwaiter<bool> <>u__2; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F7CF0-0x00000001801F7D00
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Methods
	public static void Action(string inChatText); // 0x000000018102BAC0-0x000000018102C360
	private static bool ParseAction(string inChatText, string inAction, out string outText); // 0x000000018102C5A0-0x000000018102C640
	private static void Help(); // 0x00000001803581E0-0x00000001803581F0
	[AsyncStateMachine] // 0x00000001801748A0-0x00000001801748F0
	private static void Private(string inText); // 0x000000018102C640-0x000000018102C6F0
	private static void Party(string inText); // 0x00000001803581E0-0x00000001803581F0
	private static void GiveMe(string inText); // 0x00000001803581E0-0x00000001803581F0
	private static void GiveMeLikes(string inText); // 0x00000001803581E0-0x00000001803581F0
	private static void GiveMeAll(string inText); // 0x00000001803581E0-0x00000001803581F0
	[AsyncStateMachine] // 0x0000000180174AC0-0x0000000180174B10
	private static void Block(string inText, bool inBlock); // 0x000000018102C360-0x000000018102C420
	[AsyncStateMachine] // 0x0000000180174DB0-0x0000000180174E00
	private static void Favorite(string inText, bool inFavorite); // 0x000000018102C420-0x000000018102C4E0
	[AsyncStateMachine] // 0x00000001801751B0-0x0000000180175200
	private static void Follow(string inText, bool inFollow); // 0x000000018102C4E0-0x000000018102C5A0
	[AsyncStateMachine] // 0x0000000180175470-0x00000001801754C0
	private static void Sanctuary(string inText); // 0x000000018102C6F0-0x000000018102C7A0
	private static void Goto(string inText); // 0x00000001803581E0-0x00000001803581F0
}

