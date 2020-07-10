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
public static class DisplayNameSrvHandler // TypeDefIndex: 10988
{
	// Properties
	public static string Host { get; } // 0x0000000181189000-0x0000000181189060 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <Validate>d__2 : IAsyncStateMachine // TypeDefIndex: 10989
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<ValidateDisplayNameResponse>> <>t__builder; // 0x08
		public string username; // 0x20
		public string clientAuth; // 0x28
		private TaskAwaiter<WWWResponse<ValidateDisplayNameResponse>> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x000000018020D960-0x000000018020D970
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018020D970-0x000000018020DBB0
	}

	// Methods
	[AsyncStateMachine] // 0x0000000180101020-0x0000000180101070
	public static Task<WWWResponse<ValidateDisplayNameResponse>> Validate(string username, string clientAuth); // 0x0000000181188F10-0x0000000181189000
}

