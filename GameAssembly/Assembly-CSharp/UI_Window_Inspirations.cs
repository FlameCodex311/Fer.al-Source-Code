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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_Inspirations : UI_Window // TypeDefIndex: 14104
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_InspirationThoughtBubble _thoughtBubble; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _combineButton; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioInfo _successAudioInfo; // 0x118
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioInfo _failureAudioInfo; // 0x120
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioInfo[] _addInspirationSounds; // 0x128
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioInfo _removeInspirationSound; // 0x130
	public Action<InspirationItemComponent> OnInspirationAdded; // 0x138
	public Action<InspirationItemComponent> OnInspirationRemoved; // 0x140
	private List<InspirationItemComponent> _inspirations; // 0x148
	private List<EnigmaDefComponent> _enigmasInInventory; // 0x150
	private EnigmaDefComponent _currentEnigmaResult; // 0x158

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 14105
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_Inspirations> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10

		// Constructors
		static <>c(); // 0x00000001803E29D0-0x00000001803E2A30
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_Inspirations window); // 0x00000001803B24A0-0x00000001803B24C0
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x00000001803E1450-0x00000001803E14D0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <BtnClicked_Combine>d__21 : IAsyncStateMachine // TypeDefIndex: 14106
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_Inspirations <>4__this; // 0x28
		private bool <success>5__2; // 0x30
		private UniTask<InspirationCombineResponse> <>u__1; // 0x38
		private TaskAwaiter <>u__2; // 0x48

		// Methods
		private void MoveNext(); // 0x0000000180002630-0x0000000180002640
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UI_Window_Inspirations(); // 0x00000001803EA490-0x00000001803EA530

	// Methods
	[DebugButton] // 0x00000001802830E0-0x0000000180283140
	public static void OpenWindow(); // 0x00000001803E9D70-0x00000001803E9E70
	public static void QueueWindow(); // 0x00000001803E9E70-0x00000001803E9F70
	[DebugButton] // 0x00000001802833C0-0x0000000180283420
	public static void CloseWindow(); // 0x00000001803E9690-0x00000001803E96E0
	private void Setup(); // 0x00000001803774A0-0x00000001803774B0
	protected override void OnOpen(); // 0x00000001803E9BE0-0x00000001803E9D70
	protected override void OnClose(bool inAnimate); // 0x00000001803E9A50-0x00000001803E9BE0
	private void OnBack(); // 0x00000001803B58D0-0x00000001803B58E0
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	public bool InspirationIsAdded(InspirationItemComponent inInspiration); // 0x00000001803E99F0-0x00000001803E9A50
	public void AddInspiration(InspirationItemComponent inInspiration); // 0x00000001803E9450-0x00000001803E95E0
	[AsyncStateMachine] // 0x00000001802835D0-0x0000000180283620
	public void BtnClicked_Combine(); // 0x00000001803E95E0-0x00000001803E9690
	public void RemoveInspiration(InspirationItemComponent inInspiration, bool inPlaySound); // 0x00000001803EA050-0x00000001803EA150
	private void SetupEnigmaList(); // 0x00000001803EA150-0x00000001803EA490
	private EnigmaDefComponent GetCombinationResultFromInventory(); // 0x00000001803E96E0-0x00000001803E99F0
	private void RefreshCombinationResult(); // 0x00000001803E9F70-0x00000001803EA050
}

