/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LitJson;
using UniRx.Async;
using UniRx.Async.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class SanctuaryLookItemComponent : InfoItemComponent<SanctuaryInfo> // TypeDefIndex: 10533
{
	// Fields
	[NonSerialized]
	private SanctuaryClassDefComponent _classDefComponent; // 0x28

	// Properties
	public bool IsPrimaryLook { get; } // 0x0000000181362EA0-0x0000000181362EF0 
	public bool IsEmpty { get; } // 0x0000000181362E30-0x0000000181362EA0 
	public string Name { get; set; } // 0x0000000181362EF0-0x0000000181362F50 0x0000000181362F50-0x0000000181362FE0
	public SanctuaryClassDefComponent ClassDefComponent { get; } // 0x0000000181362D70-0x0000000181362E30 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <SaveLookToSlot>d__15 : IAsyncStateMachine // TypeDefIndex: 10534
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
		public SanctuaryLookItemComponent <>4__this; // 0x18
		public SanctuaryLookItemComponent inTargetSlot; // 0x20
		public string inSaveSlotName; // 0x28
		private TaskAwaiter<SanctuaryXtHandler.SanctuaryLookSaveResponse> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180213730-0x0000000180213740
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0500-0x00000001801F0510
	}

	// Constructors
	public SanctuaryLookItemComponent(); // 0x0000000181362D30-0x0000000181362D70

	// Methods
	public override ItemComponent ParseJsonOverride(JsonData jsonData); // 0x0000000181362A60-0x0000000181362B80
	protected override JsonData ToJsonOverride(); // 0x0000000181362C40-0x0000000181362D30
	public void CopyOver(SanctuaryLookItemComponent otherItem); // 0x0000000181362810-0x0000000181362940
	public HouseItemComponent GetHouseItem(); // 0x0000000181362940-0x00000001813629D0
	public IslandItemComponent GetIslandItem(); // 0x00000001813629D0-0x0000000181362A60
	[AsyncStateMachine] // 0x000000018012F590-0x000000018012F5E0
	public UniTask SaveLookToSlot(SanctuaryLookItemComponent inTargetSlot, string inSaveSlotName); // 0x0000000181362B80-0x0000000181362C40
}

