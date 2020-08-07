/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Stage_House : UI_Stage // TypeDefIndex: 13848
{
	// Fields
	public static UI_Stage_House instance; // 0x00
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private StageCameraSetting _cameraSetting_Default; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _spinTarget; // 0x40
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _itemParent; // 0x48
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _houseScale; // 0x50
	public Action<SanctuaryLookItemComponent> OnCurrentHouseChanged; // 0x58
	private Item _item; // 0x60
	private SanctuaryLookItemComponent _sanctuaryLook; // 0x68
	private List<GameObject> _spawnedItemObjects; // 0x70
	private Renderer _spawnedItemRenderer; // 0x78

	// Properties
	public override StageCameraSetting ActiveCameraSetting { get; } // 0x00000001803743D0-0x00000001803743E0 
	public override Transform SpinTarget { get; } // 0x00000001803C7290-0x00000001803C72A0 
	public Item Item { get; } // 0x0000000180418970-0x0000000180418980 
	public HouseItemComponent HouseItemComponent { get; } // 0x00000001804D1C70-0x00000001804D1C90 
	public SanctuaryLookItemComponent SanctuaryLook { get; } // 0x00000001803765E0-0x00000001803765F0 
	public Renderer SpawnedItemRenderer { get; } // 0x0000000180418A40-0x0000000180418A50 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <Setup>d__25 : IAsyncStateMachine // TypeDefIndex: 13849
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public Item inItem; // 0x28
		public UI_Stage_House <>4__this; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001800059E0-0x00000001800059F0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <SetupWithDef>d__26 : IAsyncStateMachine // TypeDefIndex: 13850
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Stage_House <>4__this; // 0x28
		public BaseDef inDef; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x0000000180005A10-0x0000000180005A20
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <SetItem>d__28 : IAsyncStateMachine // TypeDefIndex: 13851
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public UI_Stage_House <>4__this; // 0x20
		public Item inItem; // 0x28
		private TaskAwaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180005990-0x00000001800059A0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <SetItemWithDef>d__29 : IAsyncStateMachine // TypeDefIndex: 13852
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public BaseDef inDef; // 0x20
		public UI_Stage_House <>4__this; // 0x28
		private TaskAwaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001800059B0-0x00000001800059C0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass31_0 // TypeDefIndex: 13853
	{
		// Fields
		public QRoutine routine; // 0x10

		// Constructors
		public <>c__DisplayClass31_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <SpawnItem>b__1(); // 0x00000001804C3130-0x00000001804C3180
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <SpawnItem>d__31 : IAsyncStateMachine // TypeDefIndex: 13854
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public UI_Stage_House <>4__this; // 0x20
		private TaskAwaiter <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x0000000180005A40-0x0000000180005A50
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
	}

	// Constructors
	public UI_Stage_House(); // 0x00000001804D1C00-0x00000001804D1C70

	// Methods
	protected override void Start(); // 0x00000001804D1AB0-0x00000001804D1B60
	protected virtual void SendLoadedMessage(); // 0x00000001804D1620-0x00000001804D16A0
	protected override void OnDestroy(); // 0x00000001804D1500-0x00000001804D15A0
	[AsyncStateMachine] // 0x00000001802189C0-0x0000000180218A10
	public void Setup(Item inItem = null); // 0x00000001804D1920-0x00000001804D19E0
	[AsyncStateMachine] // 0x0000000180218CA0-0x0000000180218CF0
	public void SetupWithDef(BaseDef inDef); // 0x00000001804D1860-0x00000001804D1920
	protected virtual void SendInitializedMessage(); // 0x00000001804D15A0-0x00000001804D1620
	[AsyncStateMachine] // 0x0000000180218F10-0x0000000180218F60
	public Task SetItem(Item inItem); // 0x00000001804D1780-0x00000001804D1860
	[AsyncStateMachine] // 0x0000000180219130-0x0000000180219180
	public Task SetItemWithDef(BaseDef inDef); // 0x00000001804D16A0-0x00000001804D1780
	public override void RemoveScene(); // 0x00000001804D0F00-0x00000001804D0F60
	[AsyncStateMachine] // 0x0000000180219520-0x0000000180219570
	private Task SpawnItem(); // 0x00000001804D19E0-0x00000001804D1AB0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <SpawnItem>b__31_0(List<GameObject> spawnedObjects); // 0x00000001804D1B60-0x00000001804D1C00
}

