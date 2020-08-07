/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UniRx.Async;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Stage_Avatar : UI_Stage // TypeDefIndex: 13842
{
	// Fields
	public static UI_Stage_Avatar instance; // 0x00
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _backupCamera; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _avatarParent; // 0x40
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private StageCameraSetting _cameraSetting_Detached; // 0x48
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private StageCameraSetting _cameraSetting_Default; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private StageCameraSetting _cameraSetting_Head; // 0x58
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private StageCameraSetting _cameraSetting_Tail; // 0x60
	private CreatureCustomizationTarget _currentLook; // 0x68
	public Action<CreatureCustomizationTarget> OnCurrentLookChanged; // 0x70
	private UI_Stage_Avatar _previousInstance; // 0x78

	// Properties
	public override Transform SpinTarget { get; } // 0x00000001803C7290-0x00000001803C72A0 
	public override StageCameraSetting ActiveCameraSetting { get; } // 0x00000001804D0D50-0x00000001804D0E50 
	public CreatureCustomizationTarget CurrentLook { get; } // 0x00000001803765E0-0x00000001803765F0 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass21_0 // TypeDefIndex: 13843
	{
		// Fields
		public UI_Stage_Avatar <>4__this; // 0x10
		public CreatureCustomizationTarget lookToSet; // 0x18
		public bool finishedSpawning; // 0x20

		// Constructors
		public <>c__DisplayClass21_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <SetCurrentLook>b__0(GameObject inActorBase, ActorInfo _actorInfo); // 0x00000001804C2CA0-0x00000001804C2EF0
		internal bool <SetCurrentLook>b__1(); // 0x00000001803FA090-0x00000001803FA0A0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass21_1 // TypeDefIndex: 13844
	{
		// Fields
		public GameObject go; // 0x10

		// Constructors
		public <>c__DisplayClass21_1(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <SetCurrentLook>b__2(); // 0x00000001804C2EF0-0x00000001804C2F50
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <SetCurrentLook>d__21 : IAsyncStateMachine // TypeDefIndex: 13845
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<CreatureCustomizationTarget> <>t__builder; // 0x08
		public UI_Stage_Avatar <>4__this; // 0x20
		public AvatarLookItemComponent inLook; // 0x28
		private <>c__DisplayClass21_0 <>8__1; // 0x30
		private UniTask.Awaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x0000000180005930-0x0000000180005940
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180005940-0x0000000180005990
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <Setup>d__24 : IAsyncStateMachine // TypeDefIndex: 13846
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public ActorInfo inActorInfo; // 0x28
		public UI_Stage_Avatar <>4__this; // 0x30
		private TaskAwaiter<CreatureCustomizationTarget> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001800059D0-0x00000001800059E0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UI_Stage_Avatar(); // 0x00000001804D0D40-0x00000001804D0D50

	// Methods
	public void ViewHead(); // 0x00000001804D0B80-0x00000001804D0C60
	public void ViewTail(); // 0x00000001804D0C60-0x00000001804D0D40
	public void ViewGeneral(); // 0x00000001804D09A0-0x00000001804D0B80
	public void ViewDetached(); // 0x00000001804D08C0-0x00000001804D09A0
	public override void RemoveScene(); // 0x00000001804D0070-0x00000001804D0140
	[AsyncStateMachine] // 0x0000000180216780-0x00000001802167D0
	public Task<CreatureCustomizationTarget> SetCurrentLook(AvatarLookItemComponent inLook); // 0x00000001804D0140-0x00000001804D0230
	protected override void Start(); // 0x00000001804D02F0-0x00000001804D05D0
	protected override void Update(); // 0x00000001804D05D0-0x00000001804D08C0
	[AsyncStateMachine] // 0x0000000180216AA0-0x0000000180216AF0
	public void Setup(ActorInfo inActorInfo = null); // 0x00000001804D0230-0x00000001804D02F0
	private void RefreshLookAtTargets(ActorBase inTargetActor); // 0x00000001804CFD30-0x00000001804D0070
	protected override void OnDestroy(); // 0x00000001804CFC90-0x00000001804CFD30
}

