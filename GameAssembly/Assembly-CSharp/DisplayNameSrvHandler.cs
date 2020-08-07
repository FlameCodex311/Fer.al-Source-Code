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
public static class DisplayNameSrvHandler // TypeDefIndex: 12511
{
	// Properties
	public static string Host { get; } // 0x0000000180855D10-0x0000000180855D70 

	// Nested types
	[Serializable]
	public struct RenameDisplayNameRequestBody // TypeDefIndex: 12512
	{
		// Fields
		public string new_display_name; // 0x00
		public string cached_action_key; // 0x08
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <Validate>d__2 : IAsyncStateMachine // TypeDefIndex: 12513
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<ValidateDisplayNameResponse>> <>t__builder; // 0x08
		public string username; // 0x20
		public string clientAuth; // 0x28
		private TaskAwaiter<WWWResponse<ValidateDisplayNameResponse>> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x000000018001C460-0x000000018001C470
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018001C470-0x000000018001C6E0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <Rename>d__3 : IAsyncStateMachine // TypeDefIndex: 12514
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<RenameDisplayNameResponse>> <>t__builder; // 0x08
		public string inNewDisplayName; // 0x20
		public string inRenameRequiredKey; // 0x28
		private TaskAwaiter<WWWResponse<RenameDisplayNameResponse>> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x000000018001C340-0x000000018001C350
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018001C350-0x000000018001C3A0
	}

	// Methods
	[AsyncStateMachine] // 0x00000001801DB040-0x00000001801DB090
	public static Task<WWWResponse<ValidateDisplayNameResponse>> Validate(string username, string clientAuth); // 0x0000000180855C20-0x0000000180855D10
	[AsyncStateMachine] // 0x00000001801DB360-0x00000001801DB3B0
	public static Task<WWWResponse<RenameDisplayNameResponse>> Rename(string inNewDisplayName, string inRenameRequiredKey); // 0x0000000180855B30-0x0000000180855C20
}

