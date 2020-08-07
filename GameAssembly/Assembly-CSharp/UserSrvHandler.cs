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
public static class UserSrvHandler // TypeDefIndex: 12555
{
	// Properties
	public static string Host { get; } // 0x000000018066BCB0-0x000000018066BD10 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <Register>d__2 : IAsyncStateMachine // TypeDefIndex: 12556
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<RegisterUserResponse>> <>t__builder; // 0x08
		public RegisterAccountInfo info; // 0x20
		public string clientAuth; // 0x28
		private TaskAwaiter<WWWResponse<RegisterUserResponse>> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x000000018000A420-0x000000018000A430
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000A430-0x000000018000A480
	}

	// Methods
	[AsyncStateMachine] // 0x00000001801E4480-0x00000001801E44D0
	public static Task<WWWResponse<RegisterUserResponse>> Register(RegisterAccountInfo info, string clientAuth); // 0x000000018066BBC0-0x000000018066BCB0
}

