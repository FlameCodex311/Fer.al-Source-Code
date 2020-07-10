/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public static class IdentityService // TypeDefIndex: 11038
{
	// Properties
	public static string Host { get; } // 0x0000000180F5A590-0x0000000180F5A5F0 

	// Nested types
	[Serializable]
	private class GetPlayerNamesParams // TypeDefIndex: 11039
	{
		// Fields
		public List<string> uuids; // 0x10

		// Constructors
		public GetPlayerNamesParams(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <GetDisplayName>d__3 : IAsyncStateMachine // TypeDefIndex: 11040
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<string> <>t__builder; // 0x08
		public string uuid; // 0x20
		public string clientAuth; // 0x28
		private TaskAwaiter <>u__1; // 0x30
		private TaskAwaiter<WWWResponse<IdentityDisplayNamesResponse>> <>u__2; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F15E0-0x00000001801F15F0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F15F0-0x00000001801F1640
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <GetDisplayNames>d__4 : IAsyncStateMachine // TypeDefIndex: 11041
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<IdentityDisplayNamesResponse>> <>t__builder; // 0x08
		public List<string> uuids; // 0x20
		public string clientAuth; // 0x28
		private TaskAwaiter <>u__1; // 0x30
		private TaskAwaiter<WWWResponse<IdentityDisplayNamesResponse>> <>u__2; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F1640-0x00000001801F1650
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F1650-0x00000001801F16A0
	}

	// Methods
	[AsyncStateMachine] // 0x0000000180107920-0x0000000180107970
	public static Task<string> GetDisplayName(string uuid, string clientAuth); // 0x0000000180F5A3B0-0x0000000180F5A4A0
	[AsyncStateMachine] // 0x0000000180107B30-0x0000000180107B80
	public static Task<WWWResponse<IdentityDisplayNamesResponse>> GetDisplayNames(List<string> uuids, string clientAuth); // 0x0000000180F5A4A0-0x0000000180F5A590
}

