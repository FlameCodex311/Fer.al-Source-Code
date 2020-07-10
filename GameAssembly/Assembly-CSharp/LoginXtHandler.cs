/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Server;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[MessageRouteHandler] // 0x00000001800B36B0-0x00000001800B36C0
public static class LoginXtHandler // TypeDefIndex: 11222
{
	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestCompleteTutorial>d__0 : IAsyncStateMachine // TypeDefIndex: 11223
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<TutorialCompleteResponse> <>t__builder; // 0x08
		public string lookName; // 0x20
		public AvatarLookItemComponent.Gender gender; // 0x28
		public ActorInfo lookAppearanceInfo; // 0x30
		private TaskAwaiter<TutorialCompleteResponse> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x000000018020E860-0x000000018020E870
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018020E870-0x000000018020E8C0
	}

	// Methods
	[AsyncStateMachine] // 0x0000000180131660-0x00000001801316D0
	[MessageSender] // 0x0000000180131660-0x00000001801316D0
	public static Task<TutorialCompleteResponse> RequestCompleteTutorial(string lookName, AvatarLookItemComponent.Gender gender, ActorInfo lookAppearanceInfo); // 0x00000001811E8E30-0x00000001811E8F30
	[MessageRoute] // 0x00000001801318A0-0x00000001801318C0
	public static void HandleTutorialCompleteResponse(TutorialCompleteResponse response); // 0x00000001811E8D50-0x00000001811E8E30
}

