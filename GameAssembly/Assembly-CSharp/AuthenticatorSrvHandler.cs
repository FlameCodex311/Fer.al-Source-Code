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
public static class AuthenticatorSrvHandler // TypeDefIndex: 12498
{
	// Properties
	public static string Host { get; } // 0x00000001821577D0-0x0000000182157830 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <Authenticate>d__2 : IAsyncStateMachine // TypeDefIndex: 12499
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<AuthenticateResponse>> <>t__builder; // 0x08
		public string username; // 0x20
		public string password; // 0x28
		public string clientAuth; // 0x30
		private TaskAwaiter<WWWResponse<AuthenticateResponse>> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x000000018031CED0-0x000000018031CEE0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018031CEE0-0x000000018031CF30
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <AuthenticateWithToken>d__3 : IAsyncStateMachine // TypeDefIndex: 12500
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<AuthenticateResponse>> <>t__builder; // 0x08
		public string authToken; // 0x20
		private TaskAwaiter<WWWResponse<AuthenticateResponse>> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x000000018031CF30-0x000000018031CF40
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018031CF40-0x000000018031CF90
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <ResetPassword>d__4 : IAsyncStateMachine // TypeDefIndex: 12501
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<PasswordResetResponse>> <>t__builder; // 0x08
		public string email; // 0x20
		public string clientAuth; // 0x28
		private TaskAwaiter<WWWResponse<PasswordResetResponse>> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x000000018031D1F0-0x000000018031D200
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018031D200-0x000000018031D250
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <GetAuthToken>d__5 : IAsyncStateMachine // TypeDefIndex: 12502
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<AuthenticateResponse>> <>t__builder; // 0x08
		public string refreshToken; // 0x20
		private TaskAwaiter<WWWResponse<AuthenticateResponse>> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x000000018031CFA0-0x000000018031CFB0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018031CFB0-0x000000018031D000
	}

	// Methods
	[AsyncStateMachine] // 0x00000001801D8C10-0x00000001801D8C60
	public static Task<WWWResponse<AuthenticateResponse>> Authenticate(string username, string password, string clientAuth); // 0x00000001821574F0-0x0000000182157600
	[AsyncStateMachine] // 0x00000001801D8EE0-0x00000001801D8F30
	public static Task<WWWResponse<AuthenticateResponse>> AuthenticateWithToken(string authToken); // 0x0000000182157410-0x00000001821574F0
	[AsyncStateMachine] // 0x00000001801D90C0-0x00000001801D9110
	public static Task<WWWResponse<PasswordResetResponse>> ResetPassword(string email, string clientAuth); // 0x00000001821576E0-0x00000001821577D0
	[AsyncStateMachine] // 0x00000001801D9310-0x00000001801D9360
	public static Task<WWWResponse<AuthenticateResponse>> GetAuthToken(string refreshToken); // 0x0000000182157600-0x00000001821576E0
}

