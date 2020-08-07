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

namespace NodeCanvas.DialogueTrees.UI.Examples
{
	public class DialogueUGUI : ManagedBehaviour // TypeDefIndex: 15131
	{
		// Fields
		[Header] // 0x00000001801DA460-0x00000001801DA490
		public bool skipOnInput; // 0x50
		public bool waitForInput; // 0x51
		[Header] // 0x00000001801DA580-0x00000001801DA5B0
		public RectTransform subtitlesGroup; // 0x58
		public UnityEngine.UI.Text actorSpeech; // 0x60
		public UnityEngine.UI.Text actorName; // 0x68
		public Image actorPortrait; // 0x70
		public RectTransform waitInputIndicator; // 0x78
		public SubtitleDelays subtitleDelays; // 0x80
		public List<AudioClip> typingSounds; // 0x88
		[Header] // 0x00000001801DA990-0x00000001801DA9C0
		public RectTransform optionsGroup; // 0x90
		public Button optionButton; // 0x98
		private Dictionary<Button, int> cachedButtons; // 0xA0
		private Vector2 originalSubsPosition; // 0xA8
		private bool isWaitingChoice; // 0xB0
		private AudioSource _localSource; // 0xB8
	
		// Properties
		private AudioSource localSource { get; } // 0x00000001808A78E0-0x00000001808A7990 
	
		// Nested types
		[Serializable]
		public class SubtitleDelays // TypeDefIndex: 15132
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
		private sealed class <>c__DisplayClass25_0 // TypeDefIndex: 15133
		{
			// Fields
			public bool inputDown; // 0x10
	
			// Constructors
			public <>c__DisplayClass25_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void <Internal_OnSubtitlesRequestInfo>b__0(); // 0x00000001804059F0-0x0000000180405A00
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Internal_OnSubtitlesRequestInfo>d__25 : IEnumerator<object> // TypeDefIndex: 15134
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Internal_OnSubtitlesRequestInfo>d__25(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001808B6A20-0x00000001808B74B0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001808B74B0-0x00000001808B7500
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <CheckInput>d__27 : IEnumerator<object> // TypeDefIndex: 15135
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
			public <CheckInput>d__27(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x000000018047B4E0-0x000000018047B540
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001808B5F80-0x00000001808B5FD0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <DelayPrint>d__28 : IEnumerator<object> // TypeDefIndex: 15136
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
			public <DelayPrint>d__28(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x000000018047B7B0-0x000000018047B830
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001808B6810-0x00000001808B6860
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass29_0 // TypeDefIndex: 15137
		{
			// Fields
			public DialogueUGUI <>4__this; // 0x10
			public MultipleChoiceRequestInfo info; // 0x18
	
			// Constructors
			public <>c__DisplayClass29_0(); // 0x0000000180373240-0x0000000180373250
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass29_1 // TypeDefIndex: 15138
		{
			// Fields
			public Button btn; // 0x10
			public <>c__DisplayClass29_0 CS$<>8__locals1; // 0x18
	
			// Constructors
			public <>c__DisplayClass29_1(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void <OnMultipleChoiceRequest>b__0(); // 0x00000001808B7990-0x00000001808B7A30
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <CountDown>d__30 : IEnumerator<object> // TypeDefIndex: 15139
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DialogueUGUI <>4__this; // 0x20
			public MultipleChoiceRequestInfo info; // 0x28
			private float <timer>5__2; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <CountDown>d__30(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001808B65F0-0x00000001808B67C0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001808B67C0-0x00000001808B6810
		}
	
		// Constructors
		public DialogueUGUI(); // 0x00000001808A7840-0x00000001808A78E0
	
		// Methods
		public override void MOnEnable(); // 0x00000001808A66D0-0x00000001808A6AB0
		public override void MOnDisable(); // 0x00000001808A62F0-0x00000001808A66D0
		public override void MStart(); // 0x00000001808A6AB0-0x00000001808A6C70
		private void OnDialogueStarted(DialogueTree dlg); // 0x00000001803774A0-0x00000001803774B0
		private void OnDialoguePaused(DialogueTree dlg); // 0x00000001808A6EB0-0x00000001808A6F20
		private void OnDialogueFinished(DialogueTree dlg); // 0x00000001808A6C70-0x00000001808A6EB0
		private void OnSubtitlesRequest(SubtitlesRequestInfo info); // 0x00000001808A7600-0x00000001808A7680
		[IteratorStateMachine] // 0x0000000180208CC0-0x0000000180208D10
		private IEnumerator Internal_OnSubtitlesRequestInfo(SubtitlesRequestInfo info); // 0x00000001808A6280-0x00000001808A62F0
		private void PlayTypeSound(); // 0x00000001808A7680-0x00000001808A7790
		[IteratorStateMachine] // 0x0000000180208ED0-0x0000000180208F20
		private IEnumerator CheckInput(Action Do); // 0x00000001808A5E90-0x00000001808A5EF0
		[IteratorStateMachine] // 0x0000000180209130-0x0000000180209180
		private IEnumerator DelayPrint(float time); // 0x00000001808A5F60-0x00000001808A5FC0
		private void OnMultipleChoiceRequest(MultipleChoiceRequestInfo info); // 0x00000001808A6F20-0x00000001808A7600
		[IteratorStateMachine] // 0x0000000180209310-0x0000000180209360
		private IEnumerator CountDown(MultipleChoiceRequestInfo info); // 0x00000001808A5EF0-0x00000001808A5F60
		private void Finalize(MultipleChoiceRequestInfo info, int index); // 0x00000001808A5FC0-0x00000001808A6280
		private void SetMassAlpha(RectTransform root, float alpha); // 0x00000001808A7790-0x00000001808A7840
	}
}
