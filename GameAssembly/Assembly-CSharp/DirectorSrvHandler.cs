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
public static class DirectorSrvHandler // TypeDefIndex: 12509
{
	// Properties
	public static string Host { get; } // 0x0000000180854EE0-0x0000000180854FD0 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <GetBestGameServer>d__2 : IAsyncStateMachine // TypeDefIndex: 12510
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<GetBestGameServerResponse>> <>t__builder; // 0x08
		private TaskAwaiter<WWWResponse<GetBestGameServerResponse>> <>u__1; // 0x20

		// Methods
		private void MoveNext(); // 0x000000018001C2E0-0x000000018001C2F0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018001C2F0-0x000000018001C340
	}

	// Methods
	[AsyncStateMachine] // 0x00000001801DA800-0x00000001801DA850
	public static Task<WWWResponse<GetBestGameServerResponse>> GetBestGameServer(); // 0x0000000180854E10-0x0000000180854EE0
}

