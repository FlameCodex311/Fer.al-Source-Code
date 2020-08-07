/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ManagedBehaviourManager] // 0x000000018023B950-0x000000018023B980
public class UI_QuestStepTrackerMain : ManagedBehaviour // TypeDefIndex: 13921
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _bgImage; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_ObjectiveItem _objectiveItem; // 0x58
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioInfo _questAddedSound; // 0x60
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioInfo _questUpdatedSound; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioInfo _questCompletedSound; // 0x70
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _completeSoundDelay; // 0x78
	private Quest _primaryQuest; // 0x80
	private QuestObjective _currentlyRenderedObjective; // 0x88
	private bool _isSlidOut; // 0x90

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <OnPrimaryQuestUpdated>d__14 : IAsyncStateMachine // TypeDefIndex: 13922
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_QuestStepTrackerMain <>4__this; // 0x28
		public PrimaryQuestUpdatedMessage inMessage; // 0x30
		private UniTask.Awaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x0000000180002510-0x0000000180002520
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UI_QuestStepTrackerMain(); // 0x00000001803D47C0-0x00000001803D4820

	// Methods
	public override void MStart(); // 0x00000001803D4360-0x00000001803D44A0
	public override void MOnDestroy(); // 0x00000001803D4240-0x00000001803D4360
	public void BtnClicked_SlideOutTab(); // 0x00000001803D4120-0x00000001803D4240
	private void RemovePrimaryQuestItem(); // 0x00000001803D46A0-0x00000001803D4700
	private void OnPrimaryQuestAdded(PrimaryQuestAddedMessage inMessage); // 0x00000001803D44A0-0x00000001803D46A0
	[AsyncStateMachine] // 0x000000018023D3C0-0x000000018023D410
	private void OnPrimaryQuestUpdated(PrimaryQuestUpdatedMessage inMessage); // 0x00000001803D4700-0x00000001803D47C0
	private void OnPrimaryQuestRemoved(PrimaryQuestRemovedMessage inMessage); // 0x00000001803D46A0-0x00000001803D4700
}

