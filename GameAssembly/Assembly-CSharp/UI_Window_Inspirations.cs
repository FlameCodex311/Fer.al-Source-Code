/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;
using UnityEngine;
using UnityEngine.UI;
using WW.Debug;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_Inspirations : UI_Window // TypeDefIndex: 12505
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_InspirationThoughtBubble _thoughtBubble; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _combineButton; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioInfo _successAudioInfo; // 0x118
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioInfo _failureAudioInfo; // 0x120
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioInfo[] _addInspirationSounds; // 0x128
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioInfo _removeInspirationSound; // 0x130
	public Action<InspirationItemComponent> OnInspirationAdded; // 0x138
	public Action<InspirationItemComponent> OnInspirationRemoved; // 0x140
	private List<InspirationItemComponent> _inspirations; // 0x148
	private List<EnigmaDefComponent> _enigmasInInventory; // 0x150
	private EnigmaDefComponent _currentEnigmaResult; // 0x158

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12506
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_Inspirations> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10

		// Constructors
		static <>c(); // 0x0000000180ECF690-0x0000000180ECF6F0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_Inspirations window); // 0x0000000180E9D080-0x0000000180E9D0A0
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x0000000180ECDE50-0x0000000180ECDED0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <BtnClicked_Combine>d__21 : IAsyncStateMachine // TypeDefIndex: 12507
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_Inspirations <>4__this; // 0x28
		private bool <success>5__2; // 0x30
		private UniTask<InspirationCombineResponse> <>u__1; // 0x38
		private TaskAwaiter <>u__2; // 0x48

		// Methods
		private void MoveNext(); // 0x00000001801F0F80-0x00000001801F0F90
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public UI_Window_Inspirations(); // 0x0000000180ED7260-0x0000000180ED7300

	// Methods
	[DebugButton] // 0x00000001800CAF70-0x00000001800CAFD0
	public static void OpenWindow(); // 0x0000000180ED6B30-0x0000000180ED6C30
	public static void QueueWindow(); // 0x0000000180ED6C30-0x0000000180ED6D30
	[DebugButton] // 0x00000001800CB2F0-0x00000001800CB350
	public static void CloseWindow(); // 0x0000000180ED6460-0x0000000180ED64B0
	private void Setup(); // 0x00000001803581E0-0x00000001803581F0
	protected override void OnOpen(); // 0x0000000180ED69A0-0x0000000180ED6B30
	protected override void OnClose(bool inAnimate); // 0x0000000180ED6810-0x0000000180ED69A0
	private void OnBack(); // 0x0000000180EA0020-0x0000000180EA0030
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
	public bool InspirationIsAdded(InspirationItemComponent inInspiration); // 0x0000000180ED67B0-0x0000000180ED6810
	public void AddInspiration(InspirationItemComponent inInspiration); // 0x0000000180ED6210-0x0000000180ED63B0
	[AsyncStateMachine] // 0x00000001800CB4B0-0x00000001800CB500
	public void BtnClicked_Combine(); // 0x0000000180ED63B0-0x0000000180ED6460
	public void RemoveInspiration(InspirationItemComponent inInspiration, bool inPlaySound); // 0x0000000180ED6E10-0x0000000180ED6F10
	private void SetupEnigmaList(); // 0x0000000180ED6F10-0x0000000180ED7260
	private EnigmaDefComponent GetCombinationResultFromInventory(); // 0x0000000180ED64B0-0x0000000180ED67B0
	private void RefreshCombinationResult(); // 0x0000000180ED6D30-0x0000000180ED6E10
}

