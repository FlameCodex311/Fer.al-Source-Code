/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;
using UniRx.Async.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class AvatarLookItemComponent : InfoItemComponent<ActorInfo> // TypeDefIndex: 10508
{
	// Fields
	public Gender gender; // 0x28

	// Properties
	public bool IsPrimaryLook { get; } // 0x000000018103F010-0x000000018103F060 
	public bool IsEmpty { get; } // 0x000000018103EFA0-0x000000018103F010 
	public string Name { get; set; } // 0x000000018103F060-0x000000018103F0C0 0x000000018103F0C0-0x000000018103F150

	// Nested types
	public enum Gender // TypeDefIndex: 10509
	{
		Male = 0,
		Female = 1,
		Neutral = 2
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <SaveAndApply>d__9 : IAsyncStateMachine // TypeDefIndex: 10510
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
		public AvatarLookItemComponent <>4__this; // 0x18
		private TaskAwaiter<AvatarLookCustomizeResponse> <>u__1; // 0x20

		// Methods
		private void MoveNext(); // 0x00000001801F8230-0x00000001801F8240
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0500-0x00000001801F0510
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <SaveLookToSlot>d__10 : IAsyncStateMachine // TypeDefIndex: 10511
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
		public AvatarLookItemComponent <>4__this; // 0x18
		public AvatarLookItemComponent inTargetSlot; // 0x20
		public string inSaveSlotName; // 0x28
		private TaskAwaiter<AvatarLookCustomizeResponse> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F8240-0x00000001801F8250
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0500-0x00000001801F0510
	}

	// Constructors
	public AvatarLookItemComponent(); // 0x000000018103EF60-0x000000018103EFA0

	// Methods
	[AsyncStateMachine] // 0x000000018012C280-0x000000018012C2D0
	public UniTask SaveAndApply(); // 0x000000018103EE10-0x000000018103EEA0
	[AsyncStateMachine] // 0x000000018012C6D0-0x000000018012C720
	public UniTask SaveLookToSlot(AvatarLookItemComponent inTargetSlot, string inSaveSlotName); // 0x000000018103EEA0-0x000000018103EF60
}

