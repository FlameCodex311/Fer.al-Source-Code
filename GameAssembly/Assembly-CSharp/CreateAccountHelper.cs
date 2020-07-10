/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class CreateAccountHelper // TypeDefIndex: 10891
{
	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <CreateAccount>d__0 : IAsyncStateMachine // TypeDefIndex: 10892
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
		private void MoveNext(); // 0x00000001801F1510-0x00000001801F1520
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F1520-0x00000001801F1570
	}

	// Constructors
	public CreateAccountHelper(); // 0x000000018036B6C0-0x000000018036B6D0

	// Methods
	[AsyncStateMachine] // 0x00000001800F47D0-0x00000001800F4820
	public static Task<WWWResponse<RegisterUserResponse>> CreateAccount(string displayName, string emailAddress, string password, DateTime inBirthday, string emailVerificationCode, Action<string> loadingTextCallback); // 0x0000000180F3DF70-0x0000000180F3E090
}

