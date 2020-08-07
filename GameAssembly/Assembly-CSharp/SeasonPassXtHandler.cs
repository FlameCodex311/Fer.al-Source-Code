/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Server;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class SeasonPassXtHandler // TypeDefIndex: 12787
{
	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <PurchaseTierRequest>d__0 : IAsyncStateMachine // TypeDefIndex: 12788
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<SeasonPassPurchaseTierResponse> <>t__builder; // 0x08
		public int tierToPurchase; // 0x20
		public int expectedAuraPointCost; // 0x24
		public int expectedStarFragmentCost; // 0x28
		public string tierDefId; // 0x30
		public string seasonDefId; // 0x38
		private TaskAwaiter<SeasonPassPurchaseTierResponse> <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x0000000180002B50-0x0000000180002B60
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002B60-0x0000000180002BB0
	}

	// Constructors
	public SeasonPassXtHandler(); // 0x0000000180373240-0x0000000180373250

	// Methods
	[AsyncStateMachine] // 0x0000000180223F90-0x0000000180224000
	[MessageSender] // 0x0000000180223F90-0x0000000180224000
	public static Task<SeasonPassPurchaseTierResponse> PurchaseTierRequest(int tierToPurchase, int expectedStarFragmentCost, int expectedAuraPointCost, string tierDefId, string seasonDefId); // 0x00000001803FC040-0x00000001803FC170
}

