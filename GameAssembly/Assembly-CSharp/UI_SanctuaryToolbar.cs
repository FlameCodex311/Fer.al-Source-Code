/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UniRx.Async;
using UniRx.Async.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_SanctuaryToolbar : MonoBehaviour // TypeDefIndex: 12345
{
	// Fields
	public FeralButton decorateButton; // 0x20
	public FeralButton upgradeButton; // 0x28
	public FeralButton switchButton; // 0x30
	public GameObject upgradeTimerContainer; // 0x38
	public WWTextMeshProUGUI upgradeTimerText; // 0x40
	public FeralAudioInfo upgradeTimerCompleteSfx; // 0x48
	private UpgradeState _upgradeState; // 0x50

	// Nested types
	private enum UpgradeState // TypeDefIndex: 12346
	{
		None = 0,
		UpgradeAvailable = 1,
		UpgradeInProgress = 2,
		UpgradeInProgressDifferentSanctuary = 3,
		UpgradeFinished = 4,
		UpgradeFinishedDifferentSanctuary = 5
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12347
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__15_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180EE1C90-0x0000000180EE1CF0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <PlayUpgradeTimerCompleteSfxAsync>b__15_0(); // 0x0000000180EE1840-0x0000000180EE1850
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <PlayUpgradeTimerCompleteSfxAsync>d__15 : IAsyncStateMachine // TypeDefIndex: 12348
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
		public UI_SanctuaryToolbar <>4__this; // 0x18
		private UniTask.Awaiter <>u__1; // 0x20

		// Methods
		private void MoveNext(); // 0x00000001801F1180-0x00000001801F1190
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0500-0x00000001801F0510
	}

	// Constructors
	public UI_SanctuaryToolbar(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Start(); // 0x0000000180EEF230-0x0000000180EEF3B0
	private void Update(); // 0x0000000180EEFC20-0x0000000180EEFC50
	private void SetUpgradeState(UpgradeState inState); // 0x0000000180EEEEC0-0x0000000180EEF1E0
	private void UpdateUpgradeState(); // 0x0000000180EEF3B0-0x0000000180EEF720
	private void SetButtonEnabled(FeralButton inButton, bool inEnabled); // 0x0000000180EEEE30-0x0000000180EEEEC0
	private void SetUpgradeTimerVisible(bool inVisible); // 0x0000000180EEF1E0-0x0000000180EEF230
	private void UpdateUpgradeTimer(); // 0x0000000180EEF720-0x0000000180EEFC20
	[AsyncStateMachine] // 0x0000000180149D90-0x0000000180149DE0
	private UniTask PlayUpgradeTimerCompleteSfxAsync(); // 0x0000000180EEEDA0-0x0000000180EEEE30
}

