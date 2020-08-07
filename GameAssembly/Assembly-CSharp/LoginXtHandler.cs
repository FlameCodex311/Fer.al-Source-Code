/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Server;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[MessageRouteHandler] // 0x00000001801CDAD0-0x00000001801CDAE0
public static class LoginXtHandler // TypeDefIndex: 12748
{
	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestCompleteTutorial>d__0 : IAsyncStateMachine // TypeDefIndex: 12749
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<TutorialCompleteResponse> <>t__builder; // 0x08
		public string lookName; // 0x20
		public AvatarLookItemComponent.Gender gender; // 0x28
		public ActorInfo lookAppearanceInfo; // 0x30
		private TaskAwaiter<TutorialCompleteResponse> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x0000000180006180-0x0000000180006190
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180006190-0x00000001800061E0
	}

	// Methods
	[AsyncStateMachine] // 0x0000000180217990-0x0000000180217A00
	[MessageSender] // 0x0000000180217990-0x0000000180217A00
	public static Task<TutorialCompleteResponse> RequestCompleteTutorial(string lookName, AvatarLookItemComponent.Gender gender, ActorInfo lookAppearanceInfo); // 0x00000001804EFA10-0x00000001804EFB10
	[MessageRoute] // 0x0000000180217C40-0x0000000180217C60
	public static void HandleTutorialCompleteResponse(TutorialCompleteResponse response); // 0x00000001804EF940-0x00000001804EFA10
}

