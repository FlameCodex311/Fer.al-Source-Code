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
public static class UserSrvHandler // TypeDefIndex: 11031
{
	// Properties
	public static string Host { get; } // 0x000000018121FE60-0x000000018121FEC0 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <Register>d__2 : IAsyncStateMachine // TypeDefIndex: 11032
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<RegisterUserResponse>> <>t__builder; // 0x08
		public RegisterAccountInfo info; // 0x20
		public string clientAuth; // 0x28
		private TaskAwaiter<WWWResponse<RegisterUserResponse>> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x000000018020ECD0-0x000000018020ECE0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018020ECE0-0x000000018020ED30
	}

	// Methods
	[AsyncStateMachine] // 0x0000000180107590-0x00000001801075E0
	public static Task<WWWResponse<RegisterUserResponse>> Register(RegisterAccountInfo info, string clientAuth); // 0x000000018121FD70-0x000000018121FE60
}

