/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using DG.DeInspektor.Attributes;
using UniRx.Async;
using UniRx.Async.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Stage_3DItem : UI_Stage // TypeDefIndex: 12642
{
	// Fields
	public static UI_Stage_3DItem instance; // 0x00
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private StageCameraSetting _cameraSetting_Default; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _spinTarget; // 0x40
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _itemParent; // 0x48
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _targetSpriteSize; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private SpriteRenderer _iconSprite; // 0x58
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _targetObjectDiameterMin; // 0x60
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _targetObjectDiameterMax; // 0x64
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _anchorObjectToFloor; // 0x68
	private Item _item; // 0x70
	private GameObject _spawnedItem; // 0x78
	private bool _isSpawningItem; // 0x80
	private List<Renderer> _spawnedItemRenderers; // 0x88
	private ColorableItemComponent _colorableItemComponent; // 0x90
	private bool _isSpawningAvatar; // 0x98
	private ActorBase _spawnedActor; // 0xA0
	private Item _previewedItem; // 0xA8
	private List<ActorInfoClothingItem> _itemsRemovedForPreview; // 0xB0
	private CancellationTokenSource _avatarCancellationSource; // 0xB8

	// Properties
	public override StageCameraSetting ActiveCameraSetting { get; } // 0x0000000180369BB0-0x0000000180369BC0 
	public override Transform SpinTarget { get; } // 0x0000000180369B30-0x0000000180369B40 
	public Item Item { get; } // 0x0000000180369B50-0x0000000180369B60 
	public List<Renderer> SpawnedItemRenderers { get; } // 0x0000000180424200-0x0000000180424210 
	public bool IsShowingAvatar { get; } // 0x0000000180EFAE20-0x0000000180EFAEB0 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <Setup>d__32 : IAsyncStateMachine // TypeDefIndex: 12643
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Stage_3DItem <>4__this; // 0x28
		public Item inItem; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F11B0-0x00000001801F11C0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <SetupWithDef>d__33 : IAsyncStateMachine // TypeDefIndex: 12644
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Stage_3DItem <>4__this; // 0x28
		public BaseDef inDef; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F11D0-0x00000001801F12B0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <SetItem>d__35 : IAsyncStateMachine // TypeDefIndex: 12645
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public UI_Stage_3DItem <>4__this; // 0x20
		public Item inItem; // 0x28
		private TaskAwaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F1190-0x00000001801F11A0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <SetItemWithDef>d__36 : IAsyncStateMachine // TypeDefIndex: 12646
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public BaseDef inDef; // 0x20
		public UI_Stage_3DItem <>4__this; // 0x28
		private TaskAwaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F11A0-0x00000001801F11B0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass39_0 // TypeDefIndex: 12647
	{
		// Fields
		public QRoutine routine; // 0x10

		// Constructors
		public <>c__DisplayClass39_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <SpawnItem>b__1(); // 0x0000000180EE1900-0x0000000180EE1950
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass39_1 // TypeDefIndex: 12648
	{
		// Fields
		public QRoutine routine; // 0x10

		// Constructors
		public <>c__DisplayClass39_1(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <SpawnItem>b__3(); // 0x0000000180EE1950-0x0000000180EE1980
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <SpawnItem>d__39 : IAsyncStateMachine // TypeDefIndex: 12649
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public UI_Stage_3DItem <>4__this; // 0x20
		private TaskAwaiter <>u__1; // 0x28
		private UniTask.Awaiter <>u__2; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F1950-0x00000001801F1960
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <SpawnAvatar>d__40 : IAsyncStateMachine // TypeDefIndex: 12650
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
		public UI_Stage_3DItem <>4__this; // 0x18
		private UniTask.Awaiter <>u__1; // 0x20

		// Methods
		private void MoveNext(); // 0x00000001801F1930-0x00000001801F1940
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0500-0x00000001801F0510
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <DespawnAvatar>d__41 : IAsyncStateMachine // TypeDefIndex: 12651
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
		public UI_Stage_3DItem <>4__this; // 0x18
		private TaskAwaiter <>u__1; // 0x20

		// Methods
		private void MoveNext(); // 0x00000001801F10A0-0x00000001801F10B0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0500-0x00000001801F0510
	}

	// Constructors
	public UI_Stage_3DItem(); // 0x0000000180EFAD70-0x0000000180EFAE20

	// Methods
	protected override void Start(); // 0x0000000180EF9B00-0x0000000180EF9BB0
	protected virtual void SendLoadedMessage(); // 0x0000000180EF90E0-0x0000000180EF9160
	protected override void OnDestroy(); // 0x0000000180EF8C10-0x0000000180EF8DA0
	[AsyncStateMachine] // 0x00000001800FEFC0-0x00000001800FF010
	public void Setup(Item inItem); // 0x0000000180EF98E0-0x0000000180EF99A0
	[AsyncStateMachine] // 0x00000001800FF2C0-0x00000001800FF310
	public void SetupWithDef(BaseDef inDef); // 0x0000000180EF9820-0x0000000180EF98E0
	protected virtual void SendInitializedMessage(); // 0x0000000180EF9060-0x0000000180EF90E0
	[AsyncStateMachine] // 0x00000001800FF5B0-0x00000001800FF600
	public Task SetItem(Item inItem); // 0x0000000180EF9740-0x0000000180EF9820
	[AsyncStateMachine] // 0x00000001800FF800-0x00000001800FF850
	public Task SetItemWithDef(BaseDef inDef); // 0x0000000180EF9660-0x0000000180EF9740
	public override void RemoveScene(); // 0x0000000180EF8F80-0x0000000180EF9060
	public void SetColors(List<HSVColor> inTargetColors); // 0x0000000180EF9160-0x0000000180EF9660
	[AsyncStateMachine] // 0x00000001800FF990-0x00000001800FF9E0
	private Task SpawnItem(); // 0x0000000180EF9A30-0x0000000180EF9B00
	[AsyncStateMachine] // 0x00000001800FFC40-0x00000001800FFCC0
	[DeMethodButton] // 0x00000001800FFC40-0x00000001800FFCC0
	public UniTask SpawnAvatar(); // 0x0000000180EF99A0-0x0000000180EF9A30
	[AsyncStateMachine] // 0x00000001800FFE80-0x00000001800FFF00
	[DeMethodButton] // 0x00000001800FFE80-0x00000001800FFF00
	public UniTask DespawnAvatar(); // 0x0000000180EF8B80-0x0000000180EF8C10
	protected override void Update(); // 0x0000000180EFA900-0x0000000180EFAD70
	private void AddPreviewClothingItem(); // 0x0000000180EF8A20-0x0000000180EF8B80
	private void RemovePreviewClothingItem(); // 0x0000000180EF8DA0-0x0000000180EF8F80
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <SetColors>b__38_0(ActorInfoClothingItem cItem); // 0x0000000180EF9BB0-0x0000000180EF9BF0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <SpawnItem>b__39_0(GameObject spawnedModel); // 0x0000000180EF9E70-0x0000000180EFA680
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <SpawnItem>b__39_2(Sprite sprite); // 0x0000000180EFA680-0x0000000180EFA900
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <SpawnAvatar>b__40_0(GameObject inActorBase, ActorInfo _actorInfo); // 0x0000000180EF9BF0-0x0000000180EF9E00
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <SpawnAvatar>b__40_1(); // 0x0000000180EF9E00-0x0000000180EF9E70
}

