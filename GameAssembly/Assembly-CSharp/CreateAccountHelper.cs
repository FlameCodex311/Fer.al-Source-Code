/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class CreateAccountHelper // TypeDefIndex: 12414
{
	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <CreateAccount>d__0 : IAsyncStateMachine // TypeDefIndex: 12415
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<RegisterUserResponse>> <>t__builder; // 0x08
		public Action<string> loadingTextCallback; // 0x20
		public string displayName; // 0x28
		public string emailAddress; // 0x30
		public string password; // 0x38
		public DateTime inBirthday; // 0x40
		public string emailVerificationCode; // 0x48
		private TaskAwaiter<WWWResponse<RegisterUserResponse>> <>u__1; // 0x50

		// Methods
		private void MoveNext(); // 0x00000001800068B0-0x00000001800068C0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001800068C0-0x0000000180006910
	}

	// Constructors
	public CreateAccountHelper(); // 0x0000000180373240-0x0000000180373250

	// Methods
	[AsyncStateMachine] // 0x00000001801CE890-0x00000001801CE8E0
	public static Task<WWWResponse<RegisterUserResponse>> CreateAccount(string displayName, string emailAddress, string password, DateTime inBirthday, string emailVerificationCode, Action<string> loadingTextCallback); // 0x00000001805505E0-0x0000000180550700
}

