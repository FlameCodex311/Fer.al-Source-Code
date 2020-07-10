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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_DialogNode : UI_Window // TypeDefIndex: 13748
{
	// Fields
	[Header] // 0x00000001800BFDF0-0x00000001800BFE20
	public bool skipOnInput; // 0x108
	public bool waitForInput; // 0x109
	[Header] // 0x00000001800BFEB0-0x00000001800BFEE0
	public RectTransform subtitlesGroup; // 0x110
	public UnityEngine.UI.Text actorSpeech; // 0x118
	public UnityEngine.UI.Text actorName; // 0x120
	public Image actorPortrait; // 0x128
	public RectTransform waitInputIndicator; // 0x130
	private SubtitleDelays subtitleDelays; // 0x138
	public List<AudioClip> typingSounds; // 0x140
	[Header] // 0x00000001800C00E0-0x00000001800C0110
	public RectTransform optionsGroup; // 0x148
	public Button optionButton; // 0x150
	private Dictionary<Button, int> cachedButtons; // 0x158
	private Vector3 originalSubsPosition; // 0x160
	private bool isWaitingChoice; // 0x16C
	private AudioSource _localSource; // 0x170
	private bool _hideHud; // 0x178
	private bool _removeControl; // 0x179

	// Properties
	private AudioSource localSource { get; } // 0x0000000180F0D590-0x0000000180F0D640 

	// Nested types
	[Serializable]
	public class SubtitleDelays // TypeDefIndex: 13749
	{
		// Fields
		public float characterDelay; // 0x10
		public float sentenceDelay; // 0x14
		public float commaDelay; // 0x18
		public float finalDelay; // 0x1C

		// Constructors
		public SubtitleDelays(); // 0x0000000180EFB570-0x0000000180EFB5A0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass21_0 // TypeDefIndex: 13750
	{
		// Fields
		public UI_Window_DialogNode cWindow; // 0x10

		// Constructors
		public <>c__DisplayClass21_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenCoroutine>b__0(UI_Window_DialogNode window); // 0x000000018036B1E0-0x000000018036B1F0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <OpenCoroutine>d__21 : IEnumerator<object> // TypeDefIndex: 13751
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <OpenCoroutine>d__21(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180EFD960-0x0000000180EFDBB0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180EFDBB0-0x0000000180EFE600
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass32_0 // TypeDefIndex: 13752
	{
		// Fields
		public bool inputDown; // 0x10

		// Constructors
		public <>c__DisplayClass32_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <Internal_OnSubtitlesRequestInfo>b__0(); // 0x0000000180976970-0x0000000180976980
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <Internal_OnSubtitlesRequestInfo>d__32 : IEnumerator<object> // TypeDefIndex: 13753
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <Internal_OnSubtitlesRequestInfo>d__32(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180EFBCC0-0x0000000180EFC760
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180EFC760-0x0000000180EFC7B0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <CheckInput>d__34 : IEnumerator<object> // TypeDefIndex: 13754
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Action Do; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <CheckInput>d__34(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180EFB5A0-0x0000000180EFB600
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180EFB600-0x0000000180EFB650
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <DelayPrint>d__35 : IEnumerator<object> // TypeDefIndex: 13755
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public float time; // 0x20
		private float <timer>5__2; // 0x24

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <DelayPrint>d__35(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180EFB880-0x0000000180EFB900
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180EFB900-0x0000000180EFBCC0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass36_0 // TypeDefIndex: 13756
	{
		// Fields
		public UI_Window_DialogNode <>4__this; // 0x10
		public MultipleChoiceRequestInfo info; // 0x18

		// Constructors
		public <>c__DisplayClass36_0(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass36_1 // TypeDefIndex: 13757
	{
		// Fields
		public Button btn; // 0x10
		public <>c__DisplayClass36_0 CS$<>8__locals1; // 0x18

		// Constructors
		public <>c__DisplayClass36_1(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OnMultipleChoiceRequest>b__0(); // 0x0000000180EFF9D0-0x0000000180EFFA80
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <CountDown>d__37 : IEnumerator<object> // TypeDefIndex: 13758
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public UI_Window_DialogNode <>4__this; // 0x20
		public MultipleChoiceRequestInfo info; // 0x28
		private float <timer>5__2; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <CountDown>d__37(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180EFB650-0x0000000180EFB830
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180EFB830-0x0000000180EFB880
	}

	// Constructors
	public UI_Window_DialogNode(); // 0x0000000180F0D510-0x0000000180F0D590

	// Methods
	public static void Open(bool inHideHud, bool inRemoveControl, SubtitleDelays inSubtitleDelays, Action<UI_Window_DialogNode> callback); // 0x0000000180F0CEC0-0x0000000180F0CF70
	[IteratorStateMachine] // 0x0000000180103B90-0x0000000180103BE0
	private static IEnumerator OpenCoroutine(bool inHideHud, bool inRemoveControl, SubtitleDelays inSubtitleDelays, Action<UI_Window_DialogNode> callback); // 0x0000000180F0CE30-0x0000000180F0CEC0
	public static new void Close(bool inAnimate = false /* Metadata: 0x00784023 */); // 0x0000000180F0B9E0-0x0000000180F0BA40
	public void Init(bool inHideHud, bool inRemoveControl, SubtitleDelays inSubtitleDelays); // 0x0000000180F0BDE0-0x0000000180F0C040
	private void Subscribe(); // 0x0000000180F0D150-0x0000000180F0D330
	private void Unsubscribe(); // 0x0000000180F0D330-0x0000000180F0D510
	public override void MOnDestroy(); // 0x0000000180F0C0B0-0x0000000180F0C290
	public override void MStart(); // 0x0000000180F0C290-0x0000000180F0C3E0
	private void OnDialogueStarted(DialogueTree dlg); // 0x00000001803581E0-0x00000001803581F0
	private void OnDialoguePaused(DialogueTree dlg); // 0x0000000180F0C620-0x0000000180F0C6A0
	private void OnDialogueFinished(DialogueTree dlg); // 0x0000000180F0C3E0-0x0000000180F0C620
	private void OnSubtitlesRequest(SubtitlesRequestInfo info); // 0x0000000180F0CDB0-0x0000000180F0CE30
	[IteratorStateMachine] // 0x0000000180103FE0-0x0000000180104030
	private IEnumerator Internal_OnSubtitlesRequestInfo(SubtitlesRequestInfo info); // 0x0000000180F0C040-0x0000000180F0C0B0
	private void PlayTypeSound(); // 0x0000000180F0CF70-0x0000000180F0D090
	[IteratorStateMachine] // 0x00000001801043B0-0x0000000180104400
	private IEnumerator CheckInput(Action Do); // 0x0000000180F0B980-0x0000000180F0B9E0
	[IteratorStateMachine] // 0x0000000180104540-0x0000000180104590
	private IEnumerator DelayPrint(float time); // 0x0000000180F0BAB0-0x0000000180F0BB10
	private void OnMultipleChoiceRequest(MultipleChoiceRequestInfo info); // 0x0000000180F0C6A0-0x0000000180F0CDB0
	[IteratorStateMachine] // 0x0000000180104770-0x00000001801047C0
	private IEnumerator CountDown(MultipleChoiceRequestInfo info); // 0x0000000180F0BA40-0x0000000180F0BAB0
	private void Finalize(MultipleChoiceRequestInfo info, int index); // 0x0000000180F0BB10-0x0000000180F0BDE0
	private void SetMassAlpha(RectTransform root, float alpha); // 0x0000000180F0D090-0x0000000180F0D150
}

