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
public static class AuthenticatorSrvHandler // TypeDefIndex: 10975
{
	// Properties
	public static string Host { get; } // 0x000000018103E770-0x000000018103E7D0 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <Authenticate>d__2 : IAsyncStateMachine // TypeDefIndex: 10976
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<AuthenticateResponse>> <>t__builder; // 0x08
		public string username; // 0x20
		public string password; // 0x28
		public string clientAuth; // 0x30
		private TaskAwaiter<WWWResponse<AuthenticateResponse>> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F7EB0-0x00000001801F7EC0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F7EC0-0x00000001801F7F10
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <AuthenticateWithToken>d__3 : IAsyncStateMachine // TypeDefIndex: 10977
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<AuthenticateResponse>> <>t__builder; // 0x08
		public string authToken; // 0x20
		private TaskAwaiter<WWWResponse<AuthenticateResponse>> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001801F7F10-0x00000001801F7F20
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F7F20-0x00000001801F7F70
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <ResetPassword>d__4 : IAsyncStateMachine // TypeDefIndex: 10978
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<PasswordResetResponse>> <>t__builder; // 0x08
		public string email; // 0x20
		public string clientAuth; // 0x28
		private TaskAwaiter<WWWResponse<PasswordResetResponse>> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F81D0-0x00000001801F81E0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F81E0-0x00000001801F8230
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <GetAuthToken>d__5 : IAsyncStateMachine // TypeDefIndex: 10979
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<AuthenticateResponse>> <>t__builder; // 0x08
		public string refreshToken; // 0x20
		private TaskAwaiter<WWWResponse<AuthenticateResponse>> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001801F7F80-0x00000001801F7F90
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F7F90-0x00000001801F7FE0
	}

	// Methods
	[AsyncStateMachine] // 0x00000001800FF060-0x00000001800FF0B0
	public static Task<WWWResponse<AuthenticateResponse>> Authenticate(string username, string password, string clientAuth); // 0x000000018103E490-0x000000018103E5A0
	[AsyncStateMachine] // 0x00000001800FF3D0-0x00000001800FF420
	public static Task<WWWResponse<AuthenticateResponse>> AuthenticateWithToken(string authToken); // 0x000000018103E3B0-0x000000018103E490
	[AsyncStateMachine] // 0x00000001800FF6B0-0x00000001800FF700
	public static Task<WWWResponse<PasswordResetResponse>> ResetPassword(string email, string clientAuth); // 0x000000018103E680-0x000000018103E770
	[AsyncStateMachine] // 0x00000001800FF8A0-0x00000001800FF8F0
	public static Task<WWWResponse<AuthenticateResponse>> GetAuthToken(string refreshToken); // 0x000000018103E5A0-0x000000018103E680
}

