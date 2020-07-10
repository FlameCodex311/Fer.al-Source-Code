/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_QuestCompleteSummary : UI_Window // TypeDefIndex: 12539
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _questIconImage; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _questTitleText; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _questLocationText; // 0x118
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_QuestSummary _questSummary; // 0x120
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<FeralButton> _buttons; // 0x128
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _chestClosedDisabledGroup; // 0x130
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _chestClosedImage; // 0x138
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _chestOpenGroup; // 0x140
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _chestClosedActiveGroup; // 0x148
	private Action<bool> _resultCallback; // 0x150
	private Quest _quest; // 0x158

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 12540
	{
		// Fields
		public Action<bool> inResultCallback; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_QuestCompleteSummary window); // 0x0000000180ECE240-0x0000000180ECE270
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12541
	{
		// Fields
		public Action<bool> inResultCallback; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180ECEBD0-0x0000000180ECECA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass20_0 // TypeDefIndex: 12542
	{
		// Fields
		public float progress; // 0x10
		public UI_Window_QuestCompleteSummary <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass20_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal float <SetupRewardState>b__0(); // 0x0000000180493360-0x0000000180493370
		internal void <SetupRewardState>b__1(float x); // 0x0000000180BD7F10-0x0000000180BD7F20
		internal void <SetupRewardState>b__2(); // 0x0000000180ECED70-0x0000000180ECEE80
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <SetupRewardState>d__20 : IAsyncStateMachine // TypeDefIndex: 12543
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public string inRewardDefId; // 0x28
		public UI_Window_QuestCompleteSummary <>4__this; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F1020-0x00000001801F1030
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public UI_Window_QuestCompleteSummary(); // 0x0000000180EDF9D0-0x0000000180EDFA40

	// Methods
	public static void OpenWindow(Action<bool> inResultCallback = null); // 0x0000000180EDF170-0x0000000180EDF230
	public static void QueueWindow(Action<bool> inResultCallback = null); // 0x0000000180EDF230-0x0000000180EDF2F0
	public static void CloseWindow(); // 0x0000000180EDF120-0x0000000180EDF170
	private void Setup(Action<bool> inResultCallback = null); // 0x0000000180EDF3B0-0x0000000180EDF760
	protected override void OnOpen(); // 0x0000000180E9F6A0-0x0000000180E9F6B0
	protected override void OnClose(bool inAnimate); // 0x0000000180E9F690-0x0000000180E9F6A0
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
	public void BtnClicked_Leave(); // 0x0000000180EDF0C0-0x0000000180EDF120
	public void BtnClicked_Cancel(); // 0x0000000180EDF060-0x0000000180EDF0C0
	[AsyncStateMachine] // 0x00000001800DF2C0-0x00000001800DF310
	private void SetupRewardState(bool inFullCompletion, string inRewardDefId); // 0x0000000180EDF2F0-0x0000000180EDF3B0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Setup>b__14_0(Sprite inSprite); // 0x0000000180EDF980-0x0000000180EDF9B0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <Setup>b__14_1(); // 0x0000000180EDF9B0-0x0000000180EDF9D0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <SetupRewardState>b__20_3(); // 0x0000000180EDF760-0x0000000180EDF7B0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <SetupRewardState>b__20_4(); // 0x0000000180EDF7B0-0x0000000180EDF980
}

