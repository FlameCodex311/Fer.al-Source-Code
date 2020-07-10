/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ManagedBehaviourManager] // 0x0000000180141270-0x00000001801412A0
public class UI_QuestStepTrackerMain : ManagedBehaviour // TypeDefIndex: 12337
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _bgImage; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_ObjectiveItem _objectiveItem; // 0x58
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioInfo _questAddedSound; // 0x60
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioInfo _questUpdatedSound; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioInfo _questCompletedSound; // 0x70
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _completeSoundDelay; // 0x78
	private Quest _primaryQuest; // 0x80
	private QuestObjective _currentlyRenderedObjective; // 0x88
	private bool _isSlidOut; // 0x90

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <OnPrimaryQuestUpdated>d__14 : IAsyncStateMachine // TypeDefIndex: 12338
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_QuestStepTrackerMain <>4__this; // 0x28
		public PrimaryQuestUpdatedMessage inMessage; // 0x30
		private UniTask.Awaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F1170-0x00000001801F1180
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public UI_QuestStepTrackerMain(); // 0x0000000180EE5460-0x0000000180EE54C0

	// Methods
	public override void MStart(); // 0x0000000180EE4FF0-0x0000000180EE5140
	public override void MOnDestroy(); // 0x0000000180EE4ED0-0x0000000180EE4FF0
	public void BtnClicked_SlideOutTab(); // 0x0000000180EE4DB0-0x0000000180EE4ED0
	private void RemovePrimaryQuestItem(); // 0x0000000180EE5340-0x0000000180EE53A0
	private void OnPrimaryQuestAdded(PrimaryQuestAddedMessage inMessage); // 0x0000000180EE5140-0x0000000180EE5340
	[AsyncStateMachine] // 0x0000000180143180-0x00000001801431D0
	private void OnPrimaryQuestUpdated(PrimaryQuestUpdatedMessage inMessage); // 0x0000000180EE53A0-0x0000000180EE5460
	private void OnPrimaryQuestRemoved(PrimaryQuestRemovedMessage inMessage); // 0x0000000180EE5340-0x0000000180EE53A0
}

