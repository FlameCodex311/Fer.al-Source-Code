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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_QuestCompleteSummary : UI_Window // TypeDefIndex: 14141
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _questIconImage; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _questTitleText; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _questLocationText; // 0x118
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_QuestSummary _questSummary; // 0x120
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<FeralButton> _buttons; // 0x128
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _chestClosedDisabledGroup; // 0x130
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _chestClosedImage; // 0x138
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _chestOpenGroup; // 0x140
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _chestClosedActiveGroup; // 0x148
	private Action<bool> _resultCallback; // 0x150
	private Quest _quest; // 0x158

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 14142
	{
		// Fields
		public Action<bool> inResultCallback; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_QuestCompleteSummary window); // 0x00000001803B2CF0-0x00000001803B2D20
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 14143
	{
		// Fields
		public Action<bool> inResultCallback; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x00000001803B3880-0x00000001803B3950
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass20_0 // TypeDefIndex: 14144
	{
		// Fields
		public float progress; // 0x10
		public UI_Window_QuestCompleteSummary <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass20_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal float <SetupRewardState>b__0(); // 0x0000000180373AA0-0x0000000180373AB0
		internal void <SetupRewardState>b__1(float x); // 0x0000000180373AB0-0x0000000180373AC0
		internal void <SetupRewardState>b__2(); // 0x00000001803B3B00-0x00000001803B3C00
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <SetupRewardState>d__20 : IAsyncStateMachine // TypeDefIndex: 14145
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public string inRewardDefId; // 0x28
		public UI_Window_QuestCompleteSummary <>4__this; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001800023D0-0x00000001800023E0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UI_Window_QuestCompleteSummary(); // 0x00000001803B4DD0-0x00000001803B4E40

	// Methods
	public static void OpenWindow(Action<bool> inResultCallback = null); // 0x00000001803B4580-0x00000001803B4640
	public static void QueueWindow(Action<bool> inResultCallback = null); // 0x00000001803B4640-0x00000001803B4700
	public static void CloseWindow(); // 0x00000001803B4500-0x00000001803B4550
	private void Setup(Action<bool> inResultCallback = null); // 0x00000001803B47C0-0x00000001803B4B60
	protected override void OnOpen(); // 0x00000001803B4570-0x00000001803B4580
	protected override void OnClose(bool inAnimate); // 0x00000001803B4560-0x00000001803B4570
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	public void BtnClicked_Leave(); // 0x00000001803B44A0-0x00000001803B4500
	public void BtnClicked_Cancel(); // 0x00000001803B4440-0x00000001803B44A0
	[AsyncStateMachine] // 0x00000001801CE160-0x00000001801CE1B0
	private void SetupRewardState(bool inFullCompletion, string inRewardDefId); // 0x00000001803B4700-0x00000001803B47C0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Setup>b__14_0(Sprite inSprite); // 0x00000001803B4D80-0x00000001803B4DB0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <Setup>b__14_1(); // 0x00000001803B4DB0-0x00000001803B4DD0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <SetupRewardState>b__20_3(); // 0x00000001803B4B60-0x00000001803B4BB0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <SetupRewardState>b__20_4(); // 0x00000001803B4BB0-0x00000001803B4D80
}

