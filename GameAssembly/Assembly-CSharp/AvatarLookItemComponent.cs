/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;
using UniRx.Async.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class AvatarLookItemComponent : InfoItemComponent<ActorInfo> // TypeDefIndex: 11996
{
	// Fields
	public Gender gender; // 0x28

	// Properties
	public bool IsPrimaryLook { get; } // 0x0000000182158040-0x0000000182158090 
	public bool IsEmpty { get; } // 0x0000000182157FD0-0x0000000182158040 
	public string Name { get; set; } // 0x0000000182158090-0x00000001821580F0 0x00000001821580F0-0x0000000182158170

	// Nested types
	public enum Gender // TypeDefIndex: 11997
	{
		Male = 0,
		Female = 1,
		Neutral = 2
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <SaveAndApply>d__9 : IAsyncStateMachine // TypeDefIndex: 11998
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
		public AvatarLookItemComponent <>4__this; // 0x18
		private TaskAwaiter<AvatarLookCustomizeResponse> <>u__1; // 0x20

		// Methods
		private void MoveNext(); // 0x000000018031D250-0x000000018031D260
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002020-0x0000000180002030
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <SaveLookToSlot>d__10 : IAsyncStateMachine // TypeDefIndex: 11999
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
		public AvatarLookItemComponent <>4__this; // 0x18
		public AvatarLookItemComponent inTargetSlot; // 0x20
		public string inSaveSlotName; // 0x28
		private TaskAwaiter<AvatarLookCustomizeResponse> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x000000018031D260-0x000000018031D270
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002020-0x0000000180002030
	}

	// Constructors
	public AvatarLookItemComponent(); // 0x0000000182157F90-0x0000000182157FD0

	// Methods
	[AsyncStateMachine] // 0x0000000180200510-0x0000000180200560
	public UniTask SaveAndApply(); // 0x0000000182157E40-0x0000000182157ED0
	[AsyncStateMachine] // 0x0000000180200790-0x00000001802007E0
	public UniTask SaveLookToSlot(AvatarLookItemComponent inTargetSlot, string inSaveSlotName); // 0x0000000182157ED0-0x0000000182157F90
}

