/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class SeasonPassManager : SingletonManagerBase<SeasonPassManager> // TypeDefIndex: 13413
{
	// Fields
	public ISeasonPass SeasonPass; // 0x60

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <LoadSeasonPass>d__3 : IAsyncStateMachine // TypeDefIndex: 13414
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public SeasonPassManager <>4__this; // 0x28
		private SeasonPass <seasonPass>5__2; // 0x30
		private WWWResponse<SeasonSrvHandler.RequestSeasonPassResponse> <spResponse>5__3; // 0x38
		private WWWResponse<SeasonSrvHandler.ListChallengesResponse> <currentChallengesResponse>5__4; // 0x40
		private TaskAwaiter<WWWResponse<SeasonSrvHandler.RequestSeasonPassResponse>> <>u__1; // 0x48
		private TaskAwaiter<WWWResponse<SeasonSrvHandler.ListChallengesResponse>> <>u__2; // 0x50

		// Methods
		private void MoveNext(); // 0x0000000180002AC0-0x0000000180002AD0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public SeasonPassManager(); // 0x00000001803FBB00-0x00000001803FBB40

	// Methods
	public override void Init(); // 0x00000001803FB9A0-0x00000001803FBA50
	public override void Deinit(); // 0x00000001803FB8E0-0x00000001803FB9A0
	[AsyncStateMachine] // 0x000000018022E9E0-0x000000018022EA30
	private void LoadSeasonPass(); // 0x00000001803FBA50-0x00000001803FBB00
	private void OnLoginComplete(LoginCompleteResponse inMessage); // 0x00000001803FBA50-0x00000001803FBB00
}

