/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class SeasonSrvHandler // TypeDefIndex: 12542
{
	// Properties
	public static string Host { get; } // 0x00000001803FD8D0-0x00000001803FD940 

	// Nested types
	[Serializable]
	public class RequestSeasonPassResponse // TypeDefIndex: 12543
	{
		// Fields
		public string def_id; // 0x10
		public string uuid; // 0x18
		public int current_level; // 0x20
		public int current_points; // 0x24
		public bool has_pass; // 0x28
		public bool completed; // 0x29

		// Constructors
		public RequestSeasonPassResponse(); // 0x0000000180373240-0x0000000180373250
	}

	[Serializable]
	public class ListChallengesResponse // TypeDefIndex: 12544
	{
		// Fields
		public string error; // 0x10
		public ChallengeItem[] challenges; // 0x18

		// Properties
		public bool IsSuccess { get; } // 0x00000001803F4620-0x00000001803F4630 

		// Nested types
		[Serializable]
		public class ChallengeItem // TypeDefIndex: 12545
		{
			// Fields
			public string def_id; // 0x10
			public int progress_count; // 0x18

			// Constructors
			public ChallengeItem(); // 0x0000000180373240-0x0000000180373250
		}

		// Constructors
		public ListChallengesResponse(); // 0x0000000180373240-0x0000000180373250
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestSeasonPass>d__2 : IAsyncStateMachine // TypeDefIndex: 12546
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<RequestSeasonPassResponse>> <>t__builder; // 0x08
		private TaskAwaiter<WWWResponse<RequestSeasonPassResponse>> <>u__1; // 0x20

		// Methods
		private void MoveNext(); // 0x0000000180002EC0-0x0000000180002ED0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002ED0-0x0000000180002F20
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestChallenges>d__3 : IAsyncStateMachine // TypeDefIndex: 12547
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<ListChallengesResponse>> <>t__builder; // 0x08
		public string inSeasonUUID; // 0x20
		private TaskAwaiter<WWWResponse<ListChallengesResponse>> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x0000000180002C10-0x0000000180002C20
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002C20-0x0000000180002C70
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestCompletedChallenges>d__4 : IAsyncStateMachine // TypeDefIndex: 12548
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<ListChallengesResponse>> <>t__builder; // 0x08
		public string inSeasonUUID; // 0x20
		private TaskAwaiter<WWWResponse<ListChallengesResponse>> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x0000000180002C70-0x0000000180002C80
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002C80-0x0000000180002CD0
	}

	// Constructors
	public SeasonSrvHandler(); // 0x0000000180373240-0x0000000180373250

	// Methods
	[AsyncStateMachine] // 0x00000001801E0FC0-0x00000001801E1010
	public static Task<WWWResponse<RequestSeasonPassResponse>> RequestSeasonPass(); // 0x00000001803FD800-0x00000001803FD8D0
	[AsyncStateMachine] // 0x00000001801E25F0-0x00000001801E2640
	public static Task<WWWResponse<ListChallengesResponse>> RequestChallenges(string inSeasonUUID); // 0x00000001803FD640-0x00000001803FD720
	[AsyncStateMachine] // 0x00000001801E27D0-0x00000001801E2820
	public static Task<WWWResponse<ListChallengesResponse>> RequestCompletedChallenges(string inSeasonUUID); // 0x00000001803FD720-0x00000001803FD800
}

