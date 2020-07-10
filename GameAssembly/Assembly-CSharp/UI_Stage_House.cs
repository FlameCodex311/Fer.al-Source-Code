/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Stage_House : UI_Stage // TypeDefIndex: 12658
{
	// Fields
	public static UI_Stage_House instance; // 0x00
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private StageCameraSetting _cameraSetting_Default; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _spinTarget; // 0x40
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _itemParent; // 0x48
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _houseScale; // 0x50
	public Action<SanctuaryLookItemComponent> OnCurrentHouseChanged; // 0x58
	private Item _item; // 0x60
	private SanctuaryLookItemComponent _sanctuaryLook; // 0x68
	private List<GameObject> _spawnedItemObjects; // 0x70
	private Renderer _spawnedItemRenderer; // 0x78

	// Properties
	public override StageCameraSetting ActiveCameraSetting { get; } // 0x0000000180369BB0-0x0000000180369BC0 
	public override Transform SpinTarget { get; } // 0x0000000180369B30-0x0000000180369B40 
	public Item Item { get; } // 0x0000000180369B40-0x0000000180369B50 
	public HouseItemComponent HouseItemComponent { get; } // 0x0000000180F91660-0x0000000180F91680 
	public SanctuaryLookItemComponent SanctuaryLook { get; } // 0x0000000180358970-0x0000000180358980 
	public Renderer SpawnedItemRenderer { get; } // 0x0000000180369C70-0x0000000180369C80 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <Setup>d__25 : IAsyncStateMachine // TypeDefIndex: 12659
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public Item inItem; // 0x28
		public UI_Stage_House <>4__this; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F1910-0x00000001801F1920
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <SetupWithDef>d__26 : IAsyncStateMachine // TypeDefIndex: 12660
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Stage_House <>4__this; // 0x28
		public BaseDef inDef; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F1920-0x00000001801F1930
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <SetItem>d__28 : IAsyncStateMachine // TypeDefIndex: 12661
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public UI_Stage_House <>4__this; // 0x20
		public Item inItem; // 0x28
		private TaskAwaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F18E0-0x00000001801F18F0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <SetItemWithDef>d__29 : IAsyncStateMachine // TypeDefIndex: 12662
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public BaseDef inDef; // 0x20
		public UI_Stage_House <>4__this; // 0x28
		private TaskAwaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F18F0-0x00000001801F1900
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass31_0 // TypeDefIndex: 12663
	{
		// Fields
		public QRoutine routine; // 0x10

		// Constructors
		public <>c__DisplayClass31_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <SpawnItem>b__1(); // 0x0000000180EE1900-0x0000000180EE1950
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <SpawnItem>d__31 : IAsyncStateMachine // TypeDefIndex: 12664
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public UI_Stage_House <>4__this; // 0x20
		private TaskAwaiter <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001801F1940-0x00000001801F1950
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
	}

	// Constructors
	public UI_Stage_House(); // 0x0000000180F915F0-0x0000000180F91660

	// Methods
	protected override void Start(); // 0x0000000180F914A0-0x0000000180F91550
	protected virtual void SendLoadedMessage(); // 0x0000000180F91010-0x0000000180F91090
	protected override void OnDestroy(); // 0x0000000180F90EF0-0x0000000180F90F90
	[AsyncStateMachine] // 0x0000000180105290-0x00000001801052E0
	public void Setup(Item inItem = null); // 0x0000000180F91310-0x0000000180F913D0
	[AsyncStateMachine] // 0x0000000180105460-0x00000001801054B0
	public void SetupWithDef(BaseDef inDef); // 0x0000000180F91250-0x0000000180F91310
	protected virtual void SendInitializedMessage(); // 0x0000000180F90F90-0x0000000180F91010
	[AsyncStateMachine] // 0x00000001801055A0-0x00000001801055F0
	public Task SetItem(Item inItem); // 0x0000000180F91170-0x0000000180F91250
	[AsyncStateMachine] // 0x0000000180105680-0x00000001801056D0
	public Task SetItemWithDef(BaseDef inDef); // 0x0000000180F91090-0x0000000180F91170
	public override void RemoveScene(); // 0x0000000180F908D0-0x0000000180F90930
	[AsyncStateMachine] // 0x0000000180105880-0x00000001801058D0
	private Task SpawnItem(); // 0x0000000180F913D0-0x0000000180F914A0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <SpawnItem>b__31_0(List<GameObject> spawnedObjects); // 0x0000000180F91550-0x0000000180F915F0
}

