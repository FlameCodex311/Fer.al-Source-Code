/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[MessageRouteHandler] // 0x00000001800B36B0-0x00000001800B36C0
public static class NodeHopXtHandler // TypeDefIndex: 11226
{
	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <doNodeHopGo>d__3 : IAsyncStateMachine // TypeDefIndex: 11227
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public string newIssIP; // 0x28
		private TaskAwaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F0740-0x00000001801F0750
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Methods
	public static void RequestDrainNodeHop(); // 0x0000000180E93F20-0x0000000180E93F80
	[MessageRoute] // 0x0000000180132D60-0x0000000180132D80
	public static void HandleNodeHopDrainGo(NodeHopDrainGoResponse nhdgResponse); // 0x0000000180E93EF0-0x0000000180E93F10
	public static void NodeHopGo(string newIssIP); // 0x0000000180E93F10-0x0000000180E93F20
	[AsyncStateMachine] // 0x0000000180132FC0-0x0000000180133010
	private static void doNodeHopGo(string newIssIP); // 0x0000000180E93F80-0x0000000180E94030
}

