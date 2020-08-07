/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[MessageRouteHandler] // 0x00000001801CDAD0-0x00000001801CDAE0
public static class NodeHopXtHandler // TypeDefIndex: 12752
{
	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <doNodeHopGo>d__3 : IAsyncStateMachine // TypeDefIndex: 12753
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public string newIssIP; // 0x28
		private TaskAwaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x000000018001BB80-0x000000018001BBE0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Methods
	public static void RequestDrainNodeHop(); // 0x0000000180802020-0x0000000180802080
	[MessageRoute] // 0x00000001802190D0-0x00000001802190F0
	public static void HandleNodeHopDrainGo(NodeHopDrainGoResponse nhdgResponse); // 0x0000000180801FF0-0x0000000180802010
	public static void NodeHopGo(string newIssIP); // 0x0000000180802010-0x0000000180802020
	[AsyncStateMachine] // 0x00000001802192C0-0x0000000180219310
	private static void doNodeHopGo(string newIssIP); // 0x0000000180802080-0x0000000180802130
}

