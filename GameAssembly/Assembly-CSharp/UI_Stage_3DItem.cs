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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Stage_3DItem : UI_Stage // TypeDefIndex: 13832
{
	// Fields
	public static UI_Stage_3DItem instance; // 0x00
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private StageCameraSetting _cameraSetting_Default; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _spinTarget; // 0x40
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _itemParent; // 0x48
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _targetSpriteSize; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private SpriteRenderer _iconSprite; // 0x58
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _targetObjectDiameterMin; // 0x60
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _targetObjectDiameterMax; // 0x64
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
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
	public override StageCameraSetting ActiveCameraSetting { get; } // 0x00000001803743D0-0x00000001803743E0 
	public override Transform SpinTarget { get; } // 0x00000001803C7290-0x00000001803C72A0 
	public Item Item { get; } // 0x0000000180418980-0x0000000180418990 
	public List<Renderer> SpawnedItemRenderers { get; } // 0x0000000180476CE0-0x0000000180476CF0 
	public bool IsShowingAvatar { get; } // 0x00000001804CFC00-0x00000001804CFC90 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <Setup>d__32 : IAsyncStateMachine // TypeDefIndex: 13833
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Stage_3DItem <>4__this; // 0x28
		public Item inItem; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001800059F0-0x0000000180005A00
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <SetupWithDef>d__33 : IAsyncStateMachine // TypeDefIndex: 13834
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Stage_3DItem <>4__this; // 0x28
		public BaseDef inDef; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x0000000180005A20-0x0000000180005A30
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <SetItem>d__35 : IAsyncStateMachine // TypeDefIndex: 13835
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public UI_Stage_3DItem <>4__this; // 0x20
		public Item inItem; // 0x28
		private TaskAwaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001800059A0-0x00000001800059B0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <SetItemWithDef>d__36 : IAsyncStateMachine // TypeDefIndex: 13836
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public BaseDef inDef; // 0x20
		public UI_Stage_3DItem <>4__this; // 0x28
		private TaskAwaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001800059C0-0x00000001800059D0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass39_0 // TypeDefIndex: 13837
	{
		// Fields
		public QRoutine routine; // 0x10

		// Constructors
		public <>c__DisplayClass39_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <SpawnItem>b__1(); // 0x00000001804C3130-0x00000001804C3180
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass39_1 // TypeDefIndex: 13838
	{
		// Fields
		public QRoutine routine; // 0x10

		// Constructors
		public <>c__DisplayClass39_1(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <SpawnItem>b__3(); // 0x00000001804C3180-0x00000001804C31B0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <SpawnItem>d__39 : IAsyncStateMachine // TypeDefIndex: 13839
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public UI_Stage_3DItem <>4__this; // 0x20
		private TaskAwaiter <>u__1; // 0x28
		private UniTask.Awaiter <>u__2; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180005A50-0x0000000180005A60
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <SpawnAvatar>d__40 : IAsyncStateMachine // TypeDefIndex: 13840
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
		public UI_Stage_3DItem <>4__this; // 0x18
		private UniTask.Awaiter <>u__1; // 0x20

		// Methods
		private void MoveNext(); // 0x0000000180005A30-0x0000000180005A40
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002020-0x0000000180002030
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <DespawnAvatar>d__41 : IAsyncStateMachine // TypeDefIndex: 13841
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
		public UI_Stage_3DItem <>4__this; // 0x18
		private TaskAwaiter <>u__1; // 0x20

		// Methods
		private void MoveNext(); // 0x0000000180005850-0x0000000180005860
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002020-0x0000000180002030
	}

	// Constructors
	public UI_Stage_3DItem(); // 0x00000001804CFB50-0x00000001804CFC00

	// Methods
	protected override void Start(); // 0x00000001804CEA60-0x00000001804CEB10
	protected virtual void SendLoadedMessage(); // 0x00000001804CE050-0x00000001804CE0D0
	protected override void OnDestroy(); // 0x00000001804CDD10-0x00000001804CDDB0
	[AsyncStateMachine] // 0x00000001802112F0-0x0000000180211340
	public void Setup(Item inItem); // 0x00000001804CE840-0x00000001804CE900
	[AsyncStateMachine] // 0x0000000180211550-0x00000001802115A0
	public void SetupWithDef(BaseDef inDef); // 0x00000001804CE780-0x00000001804CE840
	protected virtual void SendInitializedMessage(); // 0x00000001804CDFD0-0x00000001804CE050
	[AsyncStateMachine] // 0x0000000180211780-0x00000001802117D0
	public Task SetItem(Item inItem); // 0x00000001804CE6A0-0x00000001804CE780
	[AsyncStateMachine] // 0x0000000180211940-0x0000000180211990
	public Task SetItemWithDef(BaseDef inDef); // 0x00000001804CE5C0-0x00000001804CE6A0
	public override void RemoveScene(); // 0x00000001804CDF80-0x00000001804CDFD0
	public void SetColors(List<HSVColor> inTargetColors); // 0x00000001804CE0D0-0x00000001804CE5C0
	[AsyncStateMachine] // 0x0000000180212DD0-0x0000000180212E20
	private Task SpawnItem(); // 0x00000001804CE990-0x00000001804CEA60
	[AsyncStateMachine] // 0x0000000180213050-0x00000001802130D0
	[DeMethodButton] // 0x0000000180213050-0x00000001802130D0
	public UniTask SpawnAvatar(); // 0x00000001804CE900-0x00000001804CE990
	[AsyncStateMachine] // 0x0000000180213550-0x00000001802135D0
	[DeMethodButton] // 0x0000000180213550-0x00000001802135D0
	public UniTask DespawnAvatar(); // 0x00000001804CDC80-0x00000001804CDD10
	protected override void Update(); // 0x00000001804CF830-0x00000001804CFB50
	private void AddPreviewClothingItem(); // 0x00000001804CDB20-0x00000001804CDC80
	private void RemovePreviewClothingItem(); // 0x00000001804CDDB0-0x00000001804CDF80
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <SetColors>b__38_0(ActorInfoClothingItem cItem); // 0x00000001804CEB10-0x00000001804CEB50
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <SpawnItem>b__39_0(GameObject spawnedModel); // 0x00000001804CEDC0-0x00000001804CF5B0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <SpawnItem>b__39_2(Sprite sprite); // 0x00000001804CF5B0-0x00000001804CF830
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <SpawnAvatar>b__40_0(GameObject inActorBase, ActorInfo _actorInfo); // 0x00000001804CEB50-0x00000001804CED50
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <SpawnAvatar>b__40_1(); // 0x00000001804CED50-0x00000001804CEDC0
}

