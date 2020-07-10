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
public static class DirectorSrvHandler // TypeDefIndex: 10986
{
	// Properties
	public static string Host { get; } // 0x00000001811882A0-0x00000001811883A0 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <GetBestGameServer>d__2 : IAsyncStateMachine // TypeDefIndex: 10987
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<GetBestGameServerResponse>> <>t__builder; // 0x08
		private TaskAwaiter<WWWResponse<GetBestGameServerResponse>> <>u__1; // 0x20

		// Methods
		private void MoveNext(); // 0x000000018020D890-0x000000018020D8A0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018020D8A0-0x000000018020D8F0
	}

	// Methods
	[AsyncStateMachine] // 0x0000000180100A80-0x0000000180100AD0
	public static Task<WWWResponse<GetBestGameServerResponse>> GetBestGameServer(); // 0x00000001811881D0-0x00000001811882A0
}

