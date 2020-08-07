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
public static class ApiSrvHandler // TypeDefIndex: 12495
{
	// Properties
	public static string Host { get; } // 0x00000001821566E0-0x0000000182156740 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestToken>d__2 : IAsyncStateMachine // TypeDefIndex: 12496
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<APIRequestTokenResponse>> <>t__builder; // 0x08
		private TaskAwaiter<WWWResponse<APIRequestTokenResponse>> <>u__1; // 0x20

		// Methods
		private void MoveNext(); // 0x000000018031D190-0x000000018031D1A0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018031D1A0-0x000000018031D1F0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestAuthenticate>d__3 : IAsyncStateMachine // TypeDefIndex: 12497
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<APIClientAuthenticateResponse>> <>t__builder; // 0x08
		public string clientId; // 0x20
		public string answer; // 0x28
		private TaskAwaiter<WWWResponse<APIClientAuthenticateResponse>> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x000000018031D010-0x000000018031D020
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018031D020-0x000000018031D070
	}

	// Methods
	[AsyncStateMachine] // 0x00000001801D7BF0-0x00000001801D7C40
	public static Task<WWWResponse<APIRequestTokenResponse>> RequestToken(); // 0x0000000182156610-0x00000001821566E0
	[AsyncStateMachine] // 0x00000001801D7E90-0x00000001801D7EE0
	public static Task<WWWResponse<APIClientAuthenticateResponse>> RequestAuthenticate(string clientId, string answer); // 0x0000000182156520-0x0000000182156610
}

