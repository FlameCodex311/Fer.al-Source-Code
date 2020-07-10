/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class SeasonSrvHandler // TypeDefIndex: 11017
{
	// Properties
	public static string Host { get; } // 0x0000000180EBEF90-0x0000000180EBF000 

	// Nested types
	[Serializable]
	public class RequestSeasonPassResponse // TypeDefIndex: 11018
	{
		// Fields
		public string def_id; // 0x10
		public string uuid; // 0x18
		public int current_level; // 0x20
		public int current_points; // 0x24
		public bool has_pass; // 0x28
		public bool completed; // 0x29

		// Constructors
		public RequestSeasonPassResponse(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[Serializable]
	public class ListChallengesResponse // TypeDefIndex: 11019
	{
		// Fields
		public string error; // 0x10
		public ChallengeItem[] challenges; // 0x18

		// Properties
		public bool IsSuccess { get; } // 0x0000000180EB96D0-0x0000000180EB96E0 

		// Nested types
		[Serializable]
		public class ChallengeItem // TypeDefIndex: 11020
		{
			// Fields
			public string def_id; // 0x10
			public int progress_count; // 0x18

			// Constructors
			public ChallengeItem(); // 0x000000018036B6C0-0x000000018036B6D0
		}

		// Constructors
		public ListChallengesResponse(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestSeasonPass>d__2 : IAsyncStateMachine // TypeDefIndex: 11021
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<RequestSeasonPassResponse>> <>t__builder; // 0x08
		private TaskAwaiter<WWWResponse<RequestSeasonPassResponse>> <>u__1; // 0x20

		// Methods
		private void MoveNext(); // 0x00000001801F0DF0-0x00000001801F0E00
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0E00-0x00000001801F0E50
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestChallenges>d__3 : IAsyncStateMachine // TypeDefIndex: 11022
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<ListChallengesResponse>> <>t__builder; // 0x08
		public string inSeasonUUID; // 0x20
		private TaskAwaiter<WWWResponse<ListChallengesResponse>> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001801F0AF0-0x00000001801F0B00
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0B00-0x00000001801F0B50
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestCompletedChallenges>d__4 : IAsyncStateMachine // TypeDefIndex: 11023
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<ListChallengesResponse>> <>t__builder; // 0x08
		public string inSeasonUUID; // 0x20
		private TaskAwaiter<WWWResponse<ListChallengesResponse>> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001801F0B50-0x00000001801F0B60
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0B60-0x00000001801F0BB0
	}

	// Constructors
	public SeasonSrvHandler(); // 0x000000018036B6C0-0x000000018036B6D0

	// Methods
	[AsyncStateMachine] // 0x0000000180105C90-0x0000000180105CE0
	public static Task<WWWResponse<RequestSeasonPassResponse>> RequestSeasonPass(); // 0x0000000180EBEEC0-0x0000000180EBEF90
	[AsyncStateMachine] // 0x0000000180105F40-0x0000000180105F90
	public static Task<WWWResponse<ListChallengesResponse>> RequestChallenges(string inSeasonUUID); // 0x0000000180EBED00-0x0000000180EBEDE0
	[AsyncStateMachine] // 0x0000000180106140-0x0000000180106190
	public static Task<WWWResponse<ListChallengesResponse>> RequestCompletedChallenges(string inSeasonUUID); // 0x0000000180EBEDE0-0x0000000180EBEEC0
}

