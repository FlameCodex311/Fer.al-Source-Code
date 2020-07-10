/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UniRx.Async;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Stage_Avatar : UI_Stage // TypeDefIndex: 12652
{
	// Fields
	public static UI_Stage_Avatar instance; // 0x00
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _backupCamera; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _avatarParent; // 0x40
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private StageCameraSetting _cameraSetting_Detached; // 0x48
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private StageCameraSetting _cameraSetting_Default; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private StageCameraSetting _cameraSetting_Head; // 0x58
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private StageCameraSetting _cameraSetting_Tail; // 0x60
	private CreatureCustomizationTarget _currentLook; // 0x68
	public Action<CreatureCustomizationTarget> OnCurrentLookChanged; // 0x70
	private UI_Stage_Avatar _previousInstance; // 0x78

	// Properties
	public override Transform SpinTarget { get; } // 0x0000000180369B30-0x0000000180369B40 
	public override StageCameraSetting ActiveCameraSetting { get; } // 0x0000000180F907B0-0x0000000180F908D0 
	public CreatureCustomizationTarget CurrentLook { get; } // 0x0000000180358970-0x0000000180358980 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass21_0 // TypeDefIndex: 12653
	{
		// Fields
		public UI_Stage_Avatar <>4__this; // 0x10
		public CreatureCustomizationTarget lookToSet; // 0x18
		public bool finishedSpawning; // 0x20

		// Constructors
		public <>c__DisplayClass21_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <SetCurrentLook>b__0(GameObject inActorBase, ActorInfo _actorInfo); // 0x0000000180F8EC40-0x0000000180F8EEA0
		internal bool <SetCurrentLook>b__1(); // 0x00000001803C19E0-0x00000001803C19F0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass21_1 // TypeDefIndex: 12654
	{
		// Fields
		public GameObject go; // 0x10

		// Constructors
		public <>c__DisplayClass21_1(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <SetCurrentLook>b__2(); // 0x0000000180F8EEA0-0x0000000180F8EF00
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <SetCurrentLook>d__21 : IAsyncStateMachine // TypeDefIndex: 12655
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<CreatureCustomizationTarget> <>t__builder; // 0x08
		public UI_Stage_Avatar <>4__this; // 0x20
		public AvatarLookItemComponent inLook; // 0x28
		private <>c__DisplayClass21_0 <>8__1; // 0x30
		private UniTask.Awaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F1880-0x00000001801F1890
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F1890-0x00000001801F18E0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <Setup>d__24 : IAsyncStateMachine // TypeDefIndex: 12656
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public ActorInfo inActorInfo; // 0x28
		public UI_Stage_Avatar <>4__this; // 0x30
		private TaskAwaiter<CreatureCustomizationTarget> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F1900-0x00000001801F1910
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public UI_Stage_Avatar(); // 0x0000000180F907A0-0x0000000180F907B0

	// Methods
	public void ViewHead(); // 0x0000000180F905E0-0x0000000180F906C0
	public void ViewTail(); // 0x0000000180F906C0-0x0000000180F907A0
	public void ViewGeneral(); // 0x0000000180F903F0-0x0000000180F905E0
	public void ViewDetached(); // 0x0000000180F90310-0x0000000180F903F0
	public override void RemoveScene(); // 0x0000000180F8FAA0-0x0000000180F8FB70
	[AsyncStateMachine] // 0x00000001801035E0-0x0000000180103630
	public Task<CreatureCustomizationTarget> SetCurrentLook(AvatarLookItemComponent inLook); // 0x0000000180F8FB70-0x0000000180F8FC60
	protected override void Start(); // 0x0000000180F8FD20-0x0000000180F90010
	protected override void Update(); // 0x0000000180F90010-0x0000000180F90310
	[AsyncStateMachine] // 0x0000000180103870-0x00000001801038C0
	public void Setup(ActorInfo inActorInfo = null); // 0x0000000180F8FC60-0x0000000180F8FD20
	private void RefreshLookAtTargets(ActorBase inTargetActor); // 0x0000000180F8F740-0x0000000180F8FAA0
	protected override void OnDestroy(); // 0x0000000180F8F6A0-0x0000000180F8F740
}

