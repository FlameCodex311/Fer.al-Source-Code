/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class SeasonPassManager : SingletonManagerBase<SeasonPassManager> // TypeDefIndex: 11877
{
	// Fields
	public ISeasonPass SeasonPass; // 0x60

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <LoadSeasonPass>d__3 : IAsyncStateMachine // TypeDefIndex: 11878
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
		private void MoveNext(); // 0x00000001801F0980-0x00000001801F0990
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public SeasonPassManager(); // 0x0000000180EBD350-0x0000000180EBD390

	// Methods
	public override void Init(); // 0x0000000180EBD1F0-0x0000000180EBD2A0
	public override void Deinit(); // 0x0000000180EBD130-0x0000000180EBD1F0
	[AsyncStateMachine] // 0x0000000180146FA0-0x0000000180146FF0
	private void LoadSeasonPass(); // 0x0000000180EBD2A0-0x0000000180EBD350
	private void OnLoginComplete(LoginCompleteResponse inMessage); // 0x0000000180EBD2A0-0x0000000180EBD350
}

