/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public static class IdentityService // TypeDefIndex: 12563
{
	// Properties
	public static string Host { get; } // 0x0000000180623A60-0x0000000180623AC0 

	// Nested types
	[Serializable]
	private class GetPlayerNamesParams // TypeDefIndex: 12564
	{
		// Fields
		public List<string> uuids; // 0x10

		// Constructors
		public GetPlayerNamesParams(); // 0x0000000180373240-0x0000000180373250
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <GetDisplayName>d__3 : IAsyncStateMachine // TypeDefIndex: 12565
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<string> <>t__builder; // 0x08
		public string uuid; // 0x20
		public string clientAuth; // 0x28
		private TaskAwaiter <>u__1; // 0x30
		private TaskAwaiter<WWWResponse<IdentityDisplayNamesResponse>> <>u__2; // 0x38

		// Methods
		private void MoveNext(); // 0x0000000180009E60-0x0000000180009E70
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180009E70-0x0000000180009EC0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <GetDisplayNames>d__4 : IAsyncStateMachine // TypeDefIndex: 12566
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<IdentityDisplayNamesResponse>> <>t__builder; // 0x08
		public List<string> uuids; // 0x20
		public string clientAuth; // 0x28
		private TaskAwaiter <>u__1; // 0x30
		private TaskAwaiter<WWWResponse<IdentityDisplayNamesResponse>> <>u__2; // 0x38

		// Methods
		private void MoveNext(); // 0x0000000180009EC0-0x0000000180009ED0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180009ED0-0x0000000180009F20
	}

	// Methods
	[AsyncStateMachine] // 0x00000001801E4EC0-0x00000001801E4F10
	public static Task<string> GetDisplayName(string uuid, string clientAuth); // 0x0000000180623880-0x0000000180623970
	[AsyncStateMachine] // 0x00000001801E5180-0x00000001801E51D0
	public static Task<WWWResponse<IdentityDisplayNamesResponse>> GetDisplayNames(List<string> uuids, string clientAuth); // 0x0000000180623970-0x0000000180623A60
}

