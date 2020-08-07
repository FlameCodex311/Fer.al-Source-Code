/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.DialogueTrees;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_DialogNode : UI_Window // TypeDefIndex: 11421
{
	// Fields
	[Header] // 0x00000001801DA460-0x00000001801DA490
	public bool skipOnInput; // 0x108
	public bool waitForInput; // 0x109
	[Header] // 0x00000001801DA580-0x00000001801DA5B0
	public RectTransform subtitlesGroup; // 0x110
	public UnityEngine.UI.Text actorSpeech; // 0x118
	public UnityEngine.UI.Text actorName; // 0x120
	public Image actorPortrait; // 0x128
	public RectTransform waitInputIndicator; // 0x130
	private SubtitleDelays subtitleDelays; // 0x138
	public List<AudioClip> typingSounds; // 0x140
	[Header] // 0x00000001801DA990-0x00000001801DA9C0
	public RectTransform optionsGroup; // 0x148
	public Button optionButton; // 0x150
	private Dictionary<Button, int> cachedButtons; // 0x158
	private Vector3 originalSubsPosition; // 0x160
	private bool isWaitingChoice; // 0x16C
	private AudioSource _localSource; // 0x170
	private bool _hideHud; // 0x178
	private bool _removeControl; // 0x179

	// Properties
	private AudioSource localSource { get; } // 0x000000018048B6F0-0x000000018048B7A0 

	// Nested types
	[Serializable]
	public class SubtitleDelays // TypeDefIndex: 11422
	{
		// Fields
		public float characterDelay; // 0x10
		public float sentenceDelay; // 0x14
		public float commaDelay; // 0x18
		public float finalDelay; // 0x1C

		// Constructors
		public SubtitleDelays(); // 0x000000018047B4B0-0x000000018047B4E0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass21_0 // TypeDefIndex: 11423
	{
		// Fields
		public UI_Window_DialogNode cWindow; // 0x10

		// Constructors
		public <>c__DisplayClass21_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenCoroutine>b__0(UI_Window_DialogNode window); // 0x0000000180379F20-0x0000000180379F30
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <OpenCoroutine>d__21 : IEnumerator<object> // TypeDefIndex: 11424
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		private <>c__DisplayClass21_0 <>8__1; // 0x20
		public bool inHideHud; // 0x28
		public bool inRemoveControl; // 0x29
		public SubtitleDelays inSubtitleDelays; // 0x30
		public Action<UI_Window_DialogNode> callback; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <OpenCoroutine>d__21(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018047D5B0-0x000000018047D7F0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018047D7F0-0x000000018047E090
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass32_0 // TypeDefIndex: 11425
	{
		// Fields
		public bool inputDown; // 0x10

		// Constructors
		public <>c__DisplayClass32_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <Internal_OnSubtitlesRequestInfo>b__0(); // 0x00000001804059F0-0x0000000180405A00
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <Internal_OnSubtitlesRequestInfo>d__32 : IEnumerator<object> // TypeDefIndex: 11426
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SubtitlesRequestInfo info; // 0x20
		public UI_Window_DialogNode <>4__this; // 0x28
		private <>c__DisplayClass32_0 <>8__1; // 0x30
		private string <text>5__2; // 0x38
		private AudioClip <audio>5__3; // 0x40
		private AudioSource <playSource>5__4; // 0x48
		private float <timer>5__5; // 0x50
		private string <tempText>5__6; // 0x58
		private int <i>5__7; // 0x60
		private char <c>5__8; // 0x64

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <Internal_OnSubtitlesRequestInfo>d__32(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018047BBB0-0x000000018047C610
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018047C610-0x000000018047C660
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <CheckInput>d__34 : IEnumerator<object> // TypeDefIndex: 11427
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Action Do; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <CheckInput>d__34(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018047B4E0-0x000000018047B540
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018047B540-0x000000018047B590
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <DelayPrint>d__35 : IEnumerator<object> // TypeDefIndex: 11428
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public float time; // 0x20
		private float <timer>5__2; // 0x24

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <DelayPrint>d__35(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018047B7B0-0x000000018047B830
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018047B830-0x000000018047BBB0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass36_0 // TypeDefIndex: 11429
	{
		// Fields
		public UI_Window_DialogNode <>4__this; // 0x10
		public MultipleChoiceRequestInfo info; // 0x18

		// Constructors
		public <>c__DisplayClass36_0(); // 0x0000000180373240-0x0000000180373250
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass36_1 // TypeDefIndex: 11430
	{
		// Fields
		public Button btn; // 0x10
		public <>c__DisplayClass36_0 CS$<>8__locals1; // 0x18

		// Constructors
		public <>c__DisplayClass36_1(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OnMultipleChoiceRequest>b__0(); // 0x000000018047F180-0x000000018047F220
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <CountDown>d__37 : IEnumerator<object> // TypeDefIndex: 11431
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public UI_Window_DialogNode <>4__this; // 0x20
		public MultipleChoiceRequestInfo info; // 0x28
		private float <timer>5__2; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <CountDown>d__37(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018047B590-0x000000018047B760
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018047B760-0x000000018047B7B0
	}

	// Constructors
	public UI_Window_DialogNode(); // 0x000000018048B670-0x000000018048B6F0

	// Methods
	public static void Open(bool inHideHud, bool inRemoveControl, SubtitleDelays inSubtitleDelays, Action<UI_Window_DialogNode> callback); // 0x000000018048B040-0x000000018048B0F0
	[IteratorStateMachine] // 0x00000001801DABD0-0x00000001801DAC20
	private static IEnumerator OpenCoroutine(bool inHideHud, bool inRemoveControl, SubtitleDelays inSubtitleDelays, Action<UI_Window_DialogNode> callback); // 0x000000018048AFB0-0x000000018048B040
	public static new void Close(bool inAnimate = false /* Metadata: 0x0077CAE2 */); // 0x0000000180489BC0-0x0000000180489C20
	public void Init(bool inHideHud, bool inRemoveControl, SubtitleDelays inSubtitleDelays); // 0x0000000180489FB0-0x000000018048A210
	private void Subscribe(); // 0x000000018048B2B0-0x000000018048B490
	private void Unsubscribe(); // 0x000000018048B490-0x000000018048B670
	public override void MOnDestroy(); // 0x000000018048A280-0x000000018048A460
	public override void MStart(); // 0x000000018048A460-0x000000018048A5A0
	private void OnDialogueStarted(DialogueTree dlg); // 0x00000001803774A0-0x00000001803774B0
	private void OnDialoguePaused(DialogueTree dlg); // 0x000000018048A7E0-0x000000018048A850
	private void OnDialogueFinished(DialogueTree dlg); // 0x000000018048A5A0-0x000000018048A7E0
	private void OnSubtitlesRequest(SubtitlesRequestInfo info); // 0x000000018048AF30-0x000000018048AFB0
	[IteratorStateMachine] // 0x00000001801DAE10-0x00000001801DAE60
	private IEnumerator Internal_OnSubtitlesRequestInfo(SubtitlesRequestInfo info); // 0x000000018048A210-0x000000018048A280
	private void PlayTypeSound(); // 0x000000018048B0F0-0x000000018048B200
	[IteratorStateMachine] // 0x00000001801DB0E0-0x00000001801DB130
	private IEnumerator CheckInput(Action Do); // 0x0000000180489B60-0x0000000180489BC0
	[IteratorStateMachine] // 0x00000001801DB4F0-0x00000001801DB540
	private IEnumerator DelayPrint(float time); // 0x0000000180489C90-0x0000000180489CF0
	private void OnMultipleChoiceRequest(MultipleChoiceRequestInfo info); // 0x000000018048A850-0x000000018048AF30
	[IteratorStateMachine] // 0x00000001801DB6B0-0x00000001801DB700
	private IEnumerator CountDown(MultipleChoiceRequestInfo info); // 0x0000000180489C20-0x0000000180489C90
	private void Finalize(MultipleChoiceRequestInfo info, int index); // 0x0000000180489CF0-0x0000000180489FB0
	private void SetMassAlpha(RectTransform root, float alpha); // 0x000000018048B200-0x000000018048B2B0
}

