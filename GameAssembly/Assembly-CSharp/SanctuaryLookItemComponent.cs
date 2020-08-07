/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LitJson;
using UniRx.Async;
using UniRx.Async.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class SanctuaryLookItemComponent : InfoItemComponent<SanctuaryInfo> // TypeDefIndex: 12021
{
	// Fields
	[NonSerialized]
	private SanctuaryClassDefComponent _classDefComponent; // 0x28

	// Properties
	public bool IsPrimaryLook { get; } // 0x0000000180BEB7A0-0x0000000180BEB7F0 
	public bool IsEmpty { get; } // 0x0000000180BEB730-0x0000000180BEB7A0 
	public string Name { get; set; } // 0x0000000180BEB7F0-0x0000000180BEB850 0x0000000180BEB850-0x0000000180BEB8D0
	public SanctuaryClassDefComponent ClassDefComponent { get; } // 0x0000000180BEB670-0x0000000180BEB730 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <SaveLookToSlot>d__15 : IAsyncStateMachine // TypeDefIndex: 12022
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
		public SanctuaryLookItemComponent <>4__this; // 0x18
		public SanctuaryLookItemComponent inTargetSlot; // 0x20
		public string inSaveSlotName; // 0x28
		private TaskAwaiter<SanctuaryXtHandler.SanctuaryLookSaveResponse> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x000000018005CB50-0x000000018005CC50
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002020-0x0000000180002030
	}

	// Constructors
	public SanctuaryLookItemComponent(); // 0x0000000180BEB630-0x0000000180BEB670

	// Methods
	public override ItemComponent ParseJsonOverride(JsonData jsonData); // 0x0000000180BEB370-0x0000000180BEB480
	protected override JsonData ToJsonOverride(); // 0x0000000180BEB540-0x0000000180BEB630
	public void CopyOver(SanctuaryLookItemComponent otherItem); // 0x0000000180BEB150-0x0000000180BEB270
	public HouseItemComponent GetHouseItem(); // 0x0000000180BEB270-0x0000000180BEB2F0
	public IslandItemComponent GetIslandItem(); // 0x0000000180BEB2F0-0x0000000180BEB370
	[AsyncStateMachine] // 0x0000000180206490-0x00000001802064E0
	public UniTask SaveLookToSlot(SanctuaryLookItemComponent inTargetSlot, string inSaveSlotName); // 0x0000000180BEB480-0x0000000180BEB540
}

