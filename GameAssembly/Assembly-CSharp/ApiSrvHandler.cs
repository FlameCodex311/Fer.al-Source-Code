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
public static class ApiSrvHandler // TypeDefIndex: 10972
{
	// Properties
	public static string Host { get; } // 0x000000018103D680-0x000000018103D6E0 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestToken>d__2 : IAsyncStateMachine // TypeDefIndex: 10973
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<APIRequestTokenResponse>> <>t__builder; // 0x08
		private TaskAwaiter<WWWResponse<APIRequestTokenResponse>> <>u__1; // 0x20

		// Methods
		private void MoveNext(); // 0x00000001801F8170-0x00000001801F8180
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F8180-0x00000001801F81D0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestAuthenticate>d__3 : IAsyncStateMachine // TypeDefIndex: 10974
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<APIClientAuthenticateResponse>> <>t__builder; // 0x08
		public string clientId; // 0x20
		public string answer; // 0x28
		private TaskAwaiter<WWWResponse<APIClientAuthenticateResponse>> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F7FF0-0x00000001801F8000
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F8000-0x00000001801F8050
	}

	// Methods
	[AsyncStateMachine] // 0x00000001800FE6E0-0x00000001800FE730
	public static Task<WWWResponse<APIRequestTokenResponse>> RequestToken(); // 0x000000018103D5B0-0x000000018103D680
	[AsyncStateMachine] // 0x00000001800FE950-0x00000001800FE9A0
	public static Task<WWWResponse<APIClientAuthenticateResponse>> RequestAuthenticate(string clientId, string answer); // 0x000000018103D4C0-0x000000018103D5B0
}

