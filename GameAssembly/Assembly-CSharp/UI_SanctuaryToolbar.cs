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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_SanctuaryToolbar : MonoBehaviour // TypeDefIndex: 13929
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
	private enum UpgradeState // TypeDefIndex: 13930
	{
		None = 0,
		UpgradeAvailable = 1,
		UpgradeInProgress = 2,
		UpgradeInProgressDifferentSanctuary = 3,
		UpgradeFinished = 4,
		UpgradeFinishedDifferentSanctuary = 5
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 13931
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__15_0; // 0x08

		// Constructors
		static <>c(); // 0x00000001804C34A0-0x00000001804C3500
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <PlayUpgradeTimerCompleteSfxAsync>b__15_0(); // 0x00000001804C2A00-0x00000001804C2A10
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <PlayUpgradeTimerCompleteSfxAsync>d__15 : IAsyncStateMachine // TypeDefIndex: 13932
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
		public UI_SanctuaryToolbar <>4__this; // 0x18
		private UniTask.Awaiter <>u__1; // 0x20

		// Methods
		private void MoveNext(); // 0x0000000180005920-0x0000000180005930
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002020-0x0000000180002030
	}

	// Constructors
	public UI_SanctuaryToolbar(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Start(); // 0x00000001804C3C20-0x00000001804C3DA0
	private void Update(); // 0x00000001804C45D0-0x00000001804C4600
	private void SetUpgradeState(UpgradeState inState); // 0x00000001804C38B0-0x00000001804C3BD0
	private void UpdateUpgradeState(); // 0x00000001804C3DA0-0x00000001804C4100
	private void SetButtonEnabled(FeralButton inButton, bool inEnabled); // 0x00000001804C3830-0x00000001804C38B0
	private void SetUpgradeTimerVisible(bool inVisible); // 0x00000001804C3BD0-0x00000001804C3C20
	private void UpdateUpgradeTimer(); // 0x00000001804C4100-0x00000001804C45D0
	[AsyncStateMachine] // 0x0000000180242600-0x0000000180242650
	private UniTask PlayUpgradeTimerCompleteSfxAsync(); // 0x00000001804C37A0-0x00000001804C3830
}

