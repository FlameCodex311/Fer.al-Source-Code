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

namespace NodeCanvas.DialogueTrees.UI.Examples
{
	public class DialogueUGUI : MonoBehaviour // TypeDefIndex: 14106
	{
		// Fields
		[Header] // 0x00000001800BFDF0-0x00000001800BFE20
		public bool skipOnInput; // 0x20
		public bool waitForInput; // 0x21
		[Header] // 0x00000001800BFEB0-0x00000001800BFEE0
		public RectTransform subtitlesGroup; // 0x28
		public UnityEngine.UI.Text actorSpeech; // 0x30
		public UnityEngine.UI.Text actorName; // 0x38
		public Image actorPortrait; // 0x40
		public RectTransform waitInputIndicator; // 0x48
		public SubtitleDelays subtitleDelays; // 0x50
		public List<AudioClip> typingSounds; // 0x58
		[Header] // 0x00000001800C00E0-0x00000001800C0110
		public RectTransform optionsGroup; // 0x60
		public Button optionButton; // 0x68
		private Dictionary<Button, int> cachedButtons; // 0x70
		private Vector2 originalSubsPosition; // 0x78
		private bool isWaitingChoice; // 0x80
		private AudioSource _localSource; // 0x88
	
		// Properties
		private AudioSource localSource { get; } // 0x0000000181567460-0x0000000181567510 
	
		// Nested types
		[Serializable]
		public class SubtitleDelays // TypeDefIndex: 14107
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
		private sealed class <>c__DisplayClass25_0 // TypeDefIndex: 14108
		{
			// Fields
			public bool inputDown; // 0x10
	
			// Constructors
			public <>c__DisplayClass25_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal void <Internal_OnSubtitlesRequestInfo>b__0(); // 0x0000000180976970-0x0000000180976980
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Internal_OnSubtitlesRequestInfo>d__25 : IEnumerator<object> // TypeDefIndex: 14109
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public SubtitlesRequestInfo info; // 0x20
			public DialogueUGUI <>4__this; // 0x28
			private <>c__DisplayClass25_0 <>8__1; // 0x30
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
			public <Internal_OnSubtitlesRequestInfo>d__25(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181575410-0x0000000181575ED0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181575ED0-0x0000000181575F20
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <CheckInput>d__27 : IEnumerator<object> // TypeDefIndex: 14110
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
			public <CheckInput>d__27(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000180EFB5A0-0x0000000180EFB600
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181574B20-0x0000000181574B70
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <DelayPrint>d__28 : IEnumerator<object> // TypeDefIndex: 14111
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
			public <DelayPrint>d__28(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000180EFB880-0x0000000180EFB900
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001815753C0-0x0000000181575410
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass29_0 // TypeDefIndex: 14112
		{
			// Fields
			public DialogueUGUI <>4__this; // 0x10
			public MultipleChoiceRequestInfo info; // 0x18
	
			// Constructors
			public <>c__DisplayClass29_0(); // 0x000000018036B6C0-0x000000018036B6D0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass29_1 // TypeDefIndex: 14113
		{
			// Fields
			public Button btn; // 0x10
			public <>c__DisplayClass29_0 CS$<>8__locals1; // 0x18
	
			// Constructors
			public <>c__DisplayClass29_1(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal void <OnMultipleChoiceRequest>b__0(); // 0x0000000181576250-0x00000001815762F0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <CountDown>d__30 : IEnumerator<object> // TypeDefIndex: 14114
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DialogueUGUI <>4__this; // 0x20
			public MultipleChoiceRequestInfo info; // 0x28
			private float <timer>5__2; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <CountDown>d__30(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001815751A0-0x0000000181575370
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181575370-0x00000001815753C0
		}
	
		// Constructors
		public DialogueUGUI(); // 0x00000001815673E0-0x0000000181567460
	
		// Methods
		private void OnEnable(); // 0x0000000181566500-0x00000001815668E0
		private void OnDisable(); // 0x0000000181566120-0x0000000181566500
		private void Start(); // 0x0000000181567230-0x00000001815673E0
		private void OnDialogueStarted(DialogueTree dlg); // 0x00000001803581E0-0x00000001803581F0
		private void OnDialoguePaused(DialogueTree dlg); // 0x00000001815660B0-0x0000000181566120
		private void OnDialogueFinished(DialogueTree dlg); // 0x0000000181565E70-0x00000001815660B0
		private void OnSubtitlesRequest(SubtitlesRequestInfo info); // 0x0000000181566FD0-0x0000000181567050
		[IteratorStateMachine] // 0x00000001800C0230-0x00000001800C0280
		private IEnumerator Internal_OnSubtitlesRequestInfo(SubtitlesRequestInfo info); // 0x0000000181565E00-0x0000000181565E70
		private void PlayTypeSound(); // 0x0000000181567050-0x0000000181567170
		[IteratorStateMachine] // 0x00000001800C0410-0x00000001800C0460
		private IEnumerator CheckInput(Action Do); // 0x0000000181565A00-0x0000000181565A60
		[IteratorStateMachine] // 0x00000001800C0620-0x00000001800C0670
		private IEnumerator DelayPrint(float time); // 0x0000000181565AD0-0x0000000181565B30
		private void OnMultipleChoiceRequest(MultipleChoiceRequestInfo info); // 0x00000001815668E0-0x0000000181566FD0
		[IteratorStateMachine] // 0x00000001800C0800-0x00000001800C0850
		private IEnumerator CountDown(MultipleChoiceRequestInfo info); // 0x0000000181565A60-0x0000000181565AD0
		private void Finalize(MultipleChoiceRequestInfo info, int index); // 0x0000000181565B30-0x0000000181565E00
		private void SetMassAlpha(RectTransform root, float alpha); // 0x0000000181567170-0x0000000181567230
	}
}
